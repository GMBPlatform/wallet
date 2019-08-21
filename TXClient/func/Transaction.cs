using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace TXClient.func
{
    public class Transaction
    {
        MainForms MainForm = null;
        public Transaction(MainForms MainForm)
        {
            this.MainForm = MainForm;
        }
        public void tx()
        {
            structs.Transaction S_Contract = new structs.Transaction();
            structs.Transaction.Note[] S_Note = new structs.Transaction.Note[MainForm.C_TO.ToVal + 1];


            S_Contract.Revision = 0;
            S_Contract.PreviousKeyID = 0;
            S_Contract.ContractCreateTime = new util.Timestamp("NowInt").ResInt;

            for (int i = 0; i < MainForm.C_TO.ToVal + 1; i++)
            {
                S_Contract.Fintech = 0;
                if (MainForm.C_TO.Check_Amount[i].Checked == true)
                {
                    S_Contract.Fintech = 1;
                    break;
                }
            }

            for (int i = 0; i < MainForm.C_SAVEKEYLIST.Length; i++)
            {
                if (MainForm.com_from.SelectedItem.ToString() == MainForm.C_SAVEKEYLIST[i].Name)
                {
                    S_Contract.From = MainForm.C_TYPECAST.ToByteArray(MainForm.C_SAVEKEYLIST[i].PublicKey);
                    break;
                }
            }

            S_Contract.Balance = new util.WebApi(null, null, "Function").GetBalance((S_Contract.From));


            if (MainForm.radio_Private.Checked == true)
            {
                S_Contract.NotePrivacy = 0;
            }
            else
            {
                S_Contract.NotePrivacy = 1;
            }

            for (int i = 0; i < MainForm.C_TO.ToVal + 1; i++)
            {
                if (MainForm.C_TO.Txtbox_To[i].Text.Length != 66)
                {
                    MessageBox.Show("Invalid To");
                    return;
                }
                S_Note[i].To = MainForm.C_TYPECAST.ToByteArray(MainForm.C_TO.Txtbox_To[i].Text);
                S_Note[i].Fee = 0;
                if (MainForm.C_TO.Check_Amount[i].Checked == true)
                {
                    S_Note[i].Kind = 0;
                }
                else
                {
                    S_Note[i].Kind = 0;

                }

                S_Note[i].Contents = MainForm.C_TYPECAST.StringToByte(MainForm.C_TO.Txt_Contents[i].Text);
            }


            JObject jobj = new JObject();

            JArray Jarr = new JArray();
            jobj["Revision"] = S_Contract.Revision;
            jobj["PreviousKeyID"] = S_Contract.PreviousKeyID;
            jobj["ContractCreateTime"] = S_Contract.ContractCreateTime;
            jobj["Fintech"] = 0;
            jobj["From"] = MainForm.C_TYPECAST.ByteArrayToHexString(S_Contract.From);
            S_Contract.SigKeyData = MainForm.C_TYPECAST.ByteArrayToHexString(S_Contract.From);
            jobj["Balance"] = S_Contract.Balance.ToString();
            jobj["NotePrivacy"] = 0;
            S_Contract.SigKeyData = S_Contract.SigKeyData + "0";
            JObject NoteJobj = null;


            string GetTxInfoJsonStr = jobj.ToString(Formatting.None);

            jobj["Note"] = Jarr;
            string GetNoteJsonStr = null;


            for (int i = 0; i < MainForm.C_TO.ToVal + 1; i++)
            {
                NoteJobj = new JObject();
                NoteJobj.Add("To", MainForm.C_TYPECAST.ByteArrayToHexString(S_Note[i].To));
                S_Contract.SigKeyData = S_Contract.SigKeyData + MainForm.C_TYPECAST.ByteArrayToHexString(S_Note[i].To);
                NoteJobj.Add("Fee", S_Note[i].Fee);
                NoteJobj.Add("Kind", S_Note[i].Kind);
                //NoteJobj.Add("Contents", S_Note[i].Contents);
                NoteJobj.Add("Amount", MainForm.C_TO.Txt_Contents[i].Text);
                S_Contract.SigKeyData = S_Contract.SigKeyData + MainForm.C_TO.Txt_Contents[i].Text;
                Jarr.Add(NoteJobj);



                GetNoteJsonStr = NoteJobj.ToString(Formatting.None);
                S_Contract.NoteXOR = new util.TypeCast().XOR(S_Contract.NoteXOR, new util.TypeCast().StringToByte(GetNoteJsonStr));
            }
            S_Contract.Sha256Data = new byte[new util.TypeCast().StringToByte(GetTxInfoJsonStr).Length + S_Contract.NoteXOR.Length];
            Array.Copy(new util.TypeCast().StringToByte(GetTxInfoJsonStr), 0, S_Contract.Sha256Data, 0, new util.TypeCast().StringToByte(GetTxInfoJsonStr).Length);
            Array.Copy(S_Contract.NoteXOR, 0, S_Contract.Sha256Data, new util.TypeCast().StringToByte(GetTxInfoJsonStr).Length, S_Contract.NoteXOR.Length);
            S_Contract.Sha256Res = new util.TypeCast().ToByteArray(new util.Sha256(S_Contract.Sha256Data).res);

            jobj["Note"] = Jarr;

            structs.Keys k = new structs.Keys();



            for (int i = 0; i < MainForm.C_SAVEKEYLIST.Length; i++)
            {
                if (MainForm.com_from.SelectedItem.ToString() == MainForm.C_SAVEKEYLIST[i].Name)
                {
                    k = MainForm.C_KEYUTIL.ReadPrivatePemFile(MainForm.C_SAVEKEYLIST[i].Path, MainForm.C_DEFINE.SigAlgorithm);
                    if (k.PrivateKeyStr == null)
                    {
                        MessageBox.Show("Key file does not exist.");
                        return;
                    }
                    k = MainForm.C_KEYUTIL.signer(k.PrivateKey, S_Contract.Sha256Res);
                    if (k.SigR.Length == 32 && k.SigS.Length == 32)
                    {
                        break;
                    }
                    else
                    {
                        k = MainForm.C_KEYUTIL.signer(k.PrivateKey, S_Contract.Sha256Res);

                        if (k.SigR.Length == 32 && k.SigS.Length == 32)
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("SigKey creation failed.");
                            return;
                        }
                    }
                }
            }


            jobj["KeyR"] = MainForm.C_TYPECAST.ByteArrayToHexString(k.SigR);
            jobj["KeyS"] = MainForm.C_TYPECAST.ByteArrayToHexString(k.SigS);





            string json = jobj.ToString(Formatting.None);

            string strTmp = Regex.Replace(MainForm.C_INTEFACE.RTxt_TotalGmb.Text, @"\D", "");
            decimal nTmp = Convert.ToDecimal(strTmp);



            if (new util.WebApi(null, null, "Function").GetBalance((S_Contract.From)) < nTmp)
            {
                MessageBox.Show("I'm short of balance.");
                return;
            }
            bool res = MainForm.C_SOCKET_SCN.send(json);

            int tmp = MainForm.com_from.SelectedIndex;
            MainForm.com_from.SelectedIndex = -1;
            MainForm.com_from.SelectedIndex = tmp;
        }
    }
}
