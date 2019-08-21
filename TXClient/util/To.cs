//using Org.BouncyCastle.Math;
using System;
using System.Drawing;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace TXClient.util
{
    public class To
    {
        public Label[] Lab_To = new Label[10];
        public Label[] Lab_Contents = new Label[10];
        public TextBox[] Txtbox_To = new TextBox[10];
        public TextBox[] Txt_Contents = new TextBox[10];
        public CheckBox[] Check_Amount = new CheckBox[10];



        public int ToVal = -1;

        MainForms MainForm = null;

        public void Init(MainForms m)
        {
            MainForm = m;
        }

        private void Contents_Click(object sender, System.EventArgs e)
        {
            MainForm.F_CONTENTSFORM.ToNum(Int32.Parse(((TextBox)sender).Name.ToString().Substring(12, ((TextBox)sender).Name.ToString().Length - 12)));
            MainForm.C_INTEFACE.RTxt_Contents.Text = ((TextBox)sender).Text;
            MainForm.F_CONTENTSFORM.ShowDialog();
        }


        public void Add()
        {
            ToVal++;

            Lab_To[ToVal] = new Label();
            Lab_Contents[ToVal] = new Label();
            Txtbox_To[ToVal] = new TextBox();
            Txt_Contents[ToVal] = new TextBox();
            Check_Amount[ToVal] = new CheckBox();

            Lab_To[ToVal].Name = "Lab_To" + ToVal;
            Lab_To[ToVal].Width = 260;
            Lab_To[ToVal].Text = (ToVal + 1).ToString() + ". To";
            Lab_To[ToVal].BackColor = Color.Transparent;

            Lab_Contents[ToVal].Name = "ContentsLab" + ToVal;
            Lab_Contents[ToVal].Width = 120;
            Lab_Contents[ToVal].Text = "Amount / Contents";
            Lab_Contents[ToVal].BackColor = Color.Transparent;

            Txtbox_To[ToVal].Name = "Txtbox_To" + ToVal;
            Txtbox_To[ToVal].Width = 260;

            Txt_Contents[ToVal].Name = "Txt_Contents" + ToVal;
            Txt_Contents[ToVal].ReadOnly = true;
            Txt_Contents[ToVal].Width = 120;
            Txt_Contents[ToVal].TextChanged += new System.EventHandler(AmountKeyInput);
            Txt_Contents[ToVal].Click += new System.EventHandler(Contents_Click);

            Check_Amount[ToVal].Name = "Check_Amount" + ToVal;
            Check_Amount[ToVal].Text = "Amount";
            Check_Amount[ToVal].CheckedChanged += new System.EventHandler(AmountCheckChanged);
            Check_Amount[ToVal].Checked = true;
            Check_Amount[ToVal].BackColor = Color.Transparent;

            if (ToVal != 0)
            {
                MainForm.Btn_ToSub.Enabled = true;
            }
            else
            {
                MainForm.Btn_ToSub.Enabled = false;
            }


            MainForm.ControlsBox.Controls.Add(Lab_To[ToVal]);
            MainForm.ControlsBox.Controls.Add(Lab_Contents[ToVal]);
            MainForm.ControlsBox.SetFlowBreak(Lab_Contents[ToVal], true);
            MainForm.ControlsBox.Controls.Add(Txtbox_To[ToVal]);
            MainForm.ControlsBox.Controls.Add(Txt_Contents[ToVal]);
            MainForm.ControlsBox.Controls.Add(Check_Amount[ToVal]);
            MainForm.ControlsBox.SetFlowBreak(Check_Amount[ToVal], true);

            if (ToVal < 5)
            {
                MainForm.Btn_ToAdd.Enabled = true;

            }
            else
            {
                MainForm.Btn_ToAdd.Enabled = false;
            }
            FEE();
            Fasd();
        }
        public void Sub()
        {
            MainForm.ControlsBox.Controls.Remove(Lab_To[ToVal]);
            MainForm.ControlsBox.Controls.Remove(Lab_Contents[ToVal]);
            MainForm.ControlsBox.Controls.Remove(Check_Amount[ToVal]);
            MainForm.ControlsBox.Controls.Remove(Txtbox_To[ToVal]);
            MainForm.ControlsBox.Controls.Remove(Txt_Contents[ToVal]);

            if (ToVal > 1)
            {
                MainForm.Btn_ToSub.Enabled = true;
            }
            else
            {
                MainForm.Btn_ToSub.Enabled = false;
            }

            MainForm.Btn_ToAdd.Enabled = true;

            if (ToVal > 0)
            {
                ToVal--;
            }
            FEE();
            Fasd();

        }


        private void AmountCheckChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < ToVal + 1; i++)
            {
                Txt_Contents[i].KeyPress -= txtInterval_KeyPress;
                if (Check_Amount[i].Checked == true)
                {
                    Txt_Contents[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtInterval_KeyPress);
                    Txt_Contents[i].Text = Regex.Replace(Txt_Contents[i].Text, @"\D", "");

                }
            }
            FEE();
            Fasd();
        }
        public void AmountKeyInput(object sender, EventArgs e)
        {
            FEE();
            Fasd();
        }
        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public void Fasd()
        {
            BigInteger ResTotalFasd = new BigInteger();
            MainForm.C_INTEFACE.RTxt_TotalGmb.Text = "Total GMB";


            for (int i = 0; ToVal + 1 > i; i++)
            {
                if (Check_Amount[i].Checked == true && Txt_Contents[i].Text != "")
                {
                    ResTotalFasd = ResTotalFasd + BigInteger.Parse(Txt_Contents[i].Text);
                }
                else
                {
                    ResTotalFasd = ResTotalFasd + 0;
                }
            }
            MainForm.C_INTEFACE.RTxt_TotalGmb.Text += "\n";

            MainForm.C_INTEFACE.RTxt_TotalGmb.Text += MainForm.com_from.SelectedText;
            MainForm.C_INTEFACE.RTxt_TotalGmb.Text += ResTotalFasd + ResFee;
            MainForm.C_INTEFACE.RTxt_TotalGmb.Text += " GMB";

            string strChangeTarget = "Total GMB";
            Regex regex = new Regex(strChangeTarget);
            MatchCollection mc = regex.Matches(MainForm.C_INTEFACE.RTxt_TotalGmb.Text);
            int iCursorPosition = MainForm.C_INTEFACE.RTxt_TotalGmb.SelectionStart;
            foreach (Match m in mc)
            {
                int iStartIdx = m.Index;
                int iStopIdx = m.Length;

                MainForm.C_INTEFACE.RTxt_TotalGmb.Select(iStartIdx, iStopIdx);
                MainForm.C_INTEFACE.RTxt_TotalGmb.SelectionColor = Color.DodgerBlue;
                MainForm.C_INTEFACE.RTxt_TotalGmb.SelectionStart = iCursorPosition;
            }

        }
        int ResFee = 0;
        public void FEE()
        {
            ResFee = 0;
            int DefaultFee = 1;

            ResFee = (ToVal + 1) * DefaultFee;

            MainForm.C_INTEFACE.RTxt_FEE.Text = "FEE";
            MainForm.C_INTEFACE.RTxt_FEE.Text += "\n";
            MainForm.C_INTEFACE.RTxt_FEE.Text += ResFee;
            MainForm.C_INTEFACE.RTxt_FEE.Text += " Fee";


            string strChangeTarget = "FEE";
            Regex regex = new Regex(strChangeTarget);
            MatchCollection mc = regex.Matches(MainForm.C_INTEFACE.RTxt_FEE.Text);
            int iCursorPosition = MainForm.C_INTEFACE.RTxt_FEE.SelectionStart;
            foreach (Match m in mc)
            {
                int iStartIdx = m.Index;
                int iStopIdx = m.Length;

                MainForm.C_INTEFACE.RTxt_FEE.Select(iStartIdx, iStopIdx);
                MainForm.C_INTEFACE.RTxt_FEE.SelectionColor = Color.DodgerBlue;
                MainForm.C_INTEFACE.RTxt_FEE.SelectionStart = iCursorPosition;
            }
        }
    }

}