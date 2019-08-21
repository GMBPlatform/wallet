using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
namespace TXClient
{
    public partial class ContentsForm : Form
    {
        MainForms main = null;
        int S_NUM = 0;
        public ContentsForm()
        {
            InitializeComponent();
        }
        public void Init(MainForms m)
        {
            main = m;
            //Txt_Contents.TextChanged += new System.EventHandler(main.C_TO.AmountKeyInput);
        }
        private void Btn_ok_Click(object sender, EventArgs e)
        {
            BigInteger numChk = 0;
            bool isNum = BigInteger.TryParse(main.C_INTEFACE.RTxt_Contents.Text, out numChk);
            if (!isNum)
            {
                main.C_TO.Check_Amount[S_NUM].Checked = false;
            }
            else
            {
                main.C_TO.Check_Amount[S_NUM].Checked = true;
            }

            main.C_TO.Txt_Contents[S_NUM].Text = main.C_INTEFACE.RTxt_Contents.Text;
            this.Hide();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void ToNum(int num)
        {
            S_NUM = num;
        }

        private void ContentsForm_Load(object sender, EventArgs e)
        {
            main.C_INTEFACE.RTxt_Contents.Size = new System.Drawing.Size(357, 376);
            main.C_INTEFACE.RTxt_Contents.Location = new System.Drawing.Point(12, 33);
            main.C_INTEFACE.RTxt_Contents.BorderStyle = BorderStyle.None;
            main.C_INTEFACE.RTxt_Contents.ScrollBars = RichTextBoxScrollBars.None;
            main.C_INTEFACE.RTxt_Contents.ForeColor = Color.White;
            this.Controls.Add(main.C_INTEFACE.RTxt_Contents);
        }

        private void Btn_ok_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_ok.ImageKey = "3";
        }

        private void Btn_ok_MouseLeave(object sender, EventArgs e)
        {
            Btn_ok.ImageKey = "2";
        }

        private void Btn_ok_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_ok.ImageKey = "1";
        }
        private System.Drawing.Point mousePoint;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new System.Drawing.Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
