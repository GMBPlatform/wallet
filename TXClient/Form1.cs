using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TXClient
{
    public partial class MainForms : Form
    {
        public Sockets.SCN C_SOCKET_SCN = new Sockets.SCN();

        public Inteface C_INTEFACE = null;

        public structs.SaveKeyList[] C_SAVEKEYLIST;
        public structs.Keys C_KEYS;

        public util.To C_TO = new util.To();
        public util.TypeCast C_TYPECAST = new util.TypeCast();
        public util.key C_KEYUTIL = new util.key();
        public config.Define C_DEFINE = new config.Define();
        public util.AES128 C_AES128 = new util.AES128();



        public func.Key C_KEY = new func.Key();

        public KeyListForm F_KEYLISTFORM = new KeyListForm();
        public KeyNameChange F_KEYNAMECHANGE = new KeyNameChange();
        public ContentsForm F_CONTENTSFORM = new ContentsForm();


        public MainForms()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loading l = new loading();
            l.Show();

            l.lbl_loadings("Gps Loading ...");
            new util.AsyncSleep(1000);
            JObject GpsObj = new util.Gps().GetJsonObj();
            JObject GpsHexObj = new util.Gps().GetHexJsonObj(GpsObj);
            btn_location_ico.ImageKey = new util.Gps().GetCountryCodeString(GpsObj) + ".gif";
            lbl_location.Text += new util.Gps().GetCountryString(GpsObj);
            lbl_location.Text += "/" + new util.Gps().GetCityString(GpsObj);
            lbl_location.Left = lbl_location.Left - (lbl_location.Width);

            for (int i = 0; i < 3; i++)
            {
                l.lbl_loadings("IndexServer Connect ..." + " " + (i + 1) + "/3");
                new util.AsyncSleep(1000);

                if (new Sockets.IDX(GpsHexObj, C_SOCKET_SCN).res == true)
                {
                    break;
                }
                else if (i == 2)
                {
                    MessageBox.Show("IndexServer Connect Failed");
#if !DEBUG
                    Application.Exit();
#endif

                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            /*To hand over Mainform~*/
            l.lbl_loadings("Main Loading ...");
            F_KEYLISTFORM.Init(this);
            C_KEY.Init(this);
            F_KEYNAMECHANGE.Init(this);
            C_KEYUTIL.Init(this);
            C_TO.Init(this);
            F_CONTENTSFORM.Init(this);
            new util.AsyncSleep(1000);

            l.lbl_loadings("UI Loading ...");
            C_INTEFACE = new Inteface(this);
            new util.AsyncSleep(1000);

            l.lbl_loadings("key Loading ...");
            C_KEY.KeyUtil();
            new util.AsyncSleep(1000);

            C_TO.Add();
            new util.AsyncSleep(1000);

            l.Hide();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /* Show lower right time */
        private void Tim_Time_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = new util.Timestamp("yyyyMMddHHmmss").ResStr;
        }
        /* to add */
        private void Btn_ToAdd_Click(object sender, EventArgs e)
        {
            C_TO.Add();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        /* to delete */
        private void Btn_ToSub_Click(object sender, EventArgs e)
        {
            C_TO.Sub();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Bring the File name and extension. SafeFileName;
            //// Bring both the File path and the File name. FileName;
            //// I only bring it to Sir File. fileFullName.Replace(fileName, "");

            openFileDialog_prikey.Title = "prikey";
            openFileDialog_prikey.FileName = "";
            openFileDialog_prikey.Filter = "*.pem|";
            openFileDialog_prikey.InitialDirectory = Application.StartupPath;

            DialogResult pridr = openFileDialog_prikey.ShowDialog();

            if (pridr == DialogResult.OK)
            {
                C_KEY.KeyAdd(openFileDialog_prikey.FileName, C_DEFINE.SigAlgorithm, C_DEFINE.KeyFilePath);
            }
            else if (pridr == DialogResult.Cancel)
            {
                // If you do not select PriKey
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_KEY.KeyListForm();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_KEY.KeyListForm();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Btn_Send_String_Click(object sender, EventArgs e)
        {
            new func.Transaction(this).tx();
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private System.Drawing.Point mousePoint;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new System.Drawing.Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void btx_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btx_exit_MouseMove(object sender, MouseEventArgs e)
        {
            btx_exit.ImageKey = "2";
        }

        private void btx_exit_MouseLeave(object sender, EventArgs e)
        {
            btx_exit.ImageKey = "1";
        }

        private void btx_exit_MouseDown(object sender, MouseEventArgs e)
        {
            btx_exit.ImageKey = "3";
        }
        private void btn___MouseMove(object sender, MouseEventArgs e)
        {
            btn__.ImageKey = "22";
        }
        private void btn___MouseLeave(object sender, EventArgs e)
        {
            btn__.ImageKey = "11";
        }
        private void btn___MouseDown(object sender, MouseEventArgs e)
        {
            btn__.ImageKey = "33";
        }

        private void btn___Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Send_String_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_Send_String.ImageKey = "send2";
        }

        private void Btn_Send_String_MouseLeave(object sender, EventArgs e)
        {
            Btn_Send_String.ImageKey = "send1";
        }

        private void Btn_Send_String_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Send_String.ImageKey = "send3";
        }

        private void ControlsBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Send_Byte_Click(object sender, EventArgs e)
        {


        }

        private void com_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            string amount = "";
            //BigInteger ResBalance = new BigInteger();
            try
            {
                C_INTEFACE.RTxt_balance.Text = "Balance";


                if (com_from.SelectedItem != null)
                {
                    for (int i = 0; i < C_SAVEKEYLIST.Length; i++)
                    {
                        if (com_from.SelectedItem.ToString() == C_SAVEKEYLIST[i].Name)
                        {

                            amount = new util.WebApi(null, null, "Function").GetBalance(new util.TypeCast().ToByteArray(C_SAVEKEYLIST[i].PublicKey)).ToString();
                            break;
                        }
                    }
                }

                C_INTEFACE.RTxt_balance.Text += "\n";
                C_INTEFACE.RTxt_balance.Text += amount.ToString();

                string strChangeTarget = "Balance";
                Regex regex = new Regex(strChangeTarget);
                MatchCollection mc = regex.Matches(C_INTEFACE.RTxt_balance.Text);
                int iCursorPosition = C_INTEFACE.RTxt_balance.SelectionStart;
                foreach (Match m in mc)
                {
                    int iStartIdx = m.Index;
                    int iStopIdx = m.Length;

                    C_INTEFACE.RTxt_balance.Select(iStartIdx, iStopIdx);
                    C_INTEFACE.RTxt_balance.SelectionColor = Color.DodgerBlue;
                    C_INTEFACE.RTxt_balance.SelectionStart = iCursorPosition;
                }
            }
            catch
            {
            }
        }

        private void btn_FormExtend_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("TXClient.Properties.Resources.main_bac_ex");
            for (int i = 0; i < 20; i++)
            {
                this.Width += 20;
            }

        }

        private void com_from_MouseHover(object sender, EventArgs e)
        {

            if (com_from.SelectedItem != null)
            {
                for (int i = 0; i < C_SAVEKEYLIST.Length; i++)
                {
                    if (com_from.SelectedItem.ToString() == C_SAVEKEYLIST[i].Name)
                    {
                        toolTip1.ToolTipTitle = "PublicKey";
                        toolTip1.IsBalloon = true;
                        toolTip1.SetToolTip(com_from, C_SAVEKEYLIST[i].PublicKey);
                        break;
                    }
                }
            }


        }
        public string RsaEncryptWithPrivate(string clearText, string privateKey)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(clearText);

            var encryptEngine = new Pkcs1Encoding(new RsaEngine());

            using (var txtreader = new StringReader(privateKey))
            {
                var keyPair = (AsymmetricCipherKeyPair)new PemReader(txtreader).ReadObject();

                encryptEngine.Init(true, keyPair.Private);
            }

            var encrypted = Convert.ToBase64String(encryptEngine.ProcessBlock(bytesToEncrypt, 0, bytesToEncrypt.Length));
            return encrypted;
        }
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KeyGen().ShowDialog();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void keyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
