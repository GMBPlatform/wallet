using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace TXClient
{
    public partial class KeyGen : Form
    {
        public KeyGen()
        {
            InitializeComponent();
        }

        private void btn_KetGen_MouseMove(object sender, MouseEventArgs e)
        {
            btn_KetGen.ImageKey = "2";
        }

        private void btn_KetGen_MouseLeave(object sender, EventArgs e)
        {
            btn_KetGen.ImageKey = "1";
        }

        private void btn_KetGen_MouseDown(object sender, MouseEventArgs e)
        {
            btn_KetGen.ImageKey = "3";
        }

        private void btn_KetGen_Click(object sender, EventArgs e)
        {
            //string Base64Res = new util.TypeCast().Base64Encoding(txt_mnemonic.Text + txt_password.Text);
            //string Sha256Res = new util.Sha256(Base64Res).res;
            //int Sha256ResLen = Sha256Res.Length;


            structs.KeyGenerate m_key = new util.WebApi(null, null, "Function").KeyGenerate("{\"mnemonic\": \"" + txt_mnemonic.Text + "\",\"password\": \"" + txt_password.Text + "\"}");

            if (MessageBox.Show("PrivateKey : " + m_key.PrivateKeyStr + "\n" +
                            "PublicKey : " + m_key.PublicKeyStr + "\n" +
                            "Do you want to save the key information as a file(.Pem)?"
                            , "Key", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                SaveFileDialog savePanel = new SaveFileDialog();
                savePanel.InitialDirectory = @"C:\";
                savePanel.Filter = "pem (*.pem)|";
                savePanel.Title = "pem";

                m_key.BigPrivateKey = new BigInteger(new util.TypeCast().ToByteArray(m_key.PrivateKeyStr));

                X9ECParameters ec = SecNamedCurves.GetByName(new config.Define().SigAlgorithm);
                ECDomainParameters ecSpec = new ECDomainParameters(ec.Curve, ec.G, ec.N, ec.H);

                m_key.PrivateKey = new ECPrivateKeyParameters(m_key.BigPrivateKey, ecSpec);
                m_key.PublicKey = new util.key().GetPublicKey(m_key.PrivateKey);

                TextWriter textWriter = new StringWriter();
                PemWriter pemWriter = new PemWriter(textWriter);
                pemWriter.WriteObject(m_key.PrivateKey);
                pemWriter.Writer.Flush();

                if (savePanel.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(savePanel.FileName + "_pri" + ".pem"))
                        sw.WriteLine(pemWriter.Writer.ToString());
                }

                textWriter = new StringWriter();
                pemWriter = new PemWriter(textWriter);
                pemWriter.WriteObject(m_key.PublicKey);
                pemWriter.Writer.Flush();


                using (StreamWriter sw = new StreamWriter(savePanel.FileName + "_pub" + ".pem"))
                    sw.WriteLine(pemWriter.Writer.ToString());
            }
            else
            {

            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private System.Drawing.Point mousePoint;
        private void KeyGen_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void KeyGen_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new System.Drawing.Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void btx_exit_MouseDown(object sender, MouseEventArgs e)
        {
            btx_exit.ImageKey = "3";
        }

        private void btx_exit_MouseLeave(object sender, EventArgs e)
        {
            btx_exit.ImageKey = "1";
        }

        private void btx_exit_MouseMove(object sender, MouseEventArgs e)
        {
            btx_exit.ImageKey = "2";
        }

        private void btx_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                            , int nTopRect
                                            , int nRightRect
                                            , int nBottomRect
                                            , int nWidthEllipse
                                            , int nHeightEllipse);
        private void KeyGen_Load(object sender, EventArgs e)
        {
            btx_exit.Region = Region.FromHrgn(CreateRoundRectRgn(3, 4, btx_exit.Width - 2, btx_exit.Height - 2, 22, 22));
        }
    }
}
