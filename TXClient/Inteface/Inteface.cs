using System;
using System.Drawing;
using System.Windows.Forms;
namespace TXClient
{
    public class Inteface
    {

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                            , int nTopRect
                                            , int nRightRect
                                            , int nBottomRect
                                            , int nWidthEllipse
                                            , int nHeightEllipse);


        public TransparentLabel RTxt_FEE = new TransparentLabel();
        public TransparentLabel RTxt_TotalGmb = new TransparentLabel();
        public TransparentLabel RTxt_Contents = new TransparentLabel();
        public TransparentLabel RTxt_balance = new TransparentLabel();
        public Inteface(MainForms main)
        {
            MainFormInit(main);
        }
        void MainFormInit(MainForms main)
        {
            main.Num3_group.Controls.Add(RTxt_FEE);
            RTxt_FEE.Size = new Size(124, 32);
            RTxt_FEE.Location = new Point(6, 22);
            RTxt_FEE.BorderStyle = BorderStyle.None;
            RTxt_FEE.ReadOnly = true;
            RTxt_FEE.ScrollBars = RichTextBoxScrollBars.None;
            RTxt_FEE.ForeColor = Color.White;

            main.Num3_group.Controls.Add(RTxt_TotalGmb);
            RTxt_TotalGmb.Size = new Size(124, 32);
            RTxt_TotalGmb.Location = new Point(6, 70);
            RTxt_TotalGmb.BorderStyle = BorderStyle.None;
            RTxt_TotalGmb.ReadOnly = true;
            RTxt_TotalGmb.ScrollBars = RichTextBoxScrollBars.None;
            RTxt_TotalGmb.ForeColor = Color.White;

            main.Num1_group.Controls.Add(RTxt_balance);
            RTxt_balance.Size = new Size(124, 32);
            RTxt_balance.Location = new Point(9, 41);
            RTxt_balance.BorderStyle = BorderStyle.None;
            RTxt_balance.ReadOnly = true;
            RTxt_balance.ScrollBars = RichTextBoxScrollBars.None;
            RTxt_balance.ForeColor = Color.White;

            new util.UIControl(main).RichTextBoxInputBan(RTxt_FEE);
            new util.UIControl(main).RichTextBoxInputBan(RTxt_TotalGmb);
            new util.UIControl(main).RichTextBoxInputBan(RTxt_balance);

            main.ControlsBox.MouseWheel += new MouseEventHandler(new util.UIControl(main).ControlsBox_MouseWheel);
            main.ControlsBox.Scroll += new ScrollEventHandler(new util.UIControl(main).ControlsBox_Scroll);

            main.btx_exit.Region = Region.FromHrgn(CreateRoundRectRgn(3, 4, main.btx_exit.Width - 2, main.btx_exit.Height - 2, 22, 22));
            main.btn__.Region = Region.FromHrgn(CreateRoundRectRgn(3, 4, main.btn__.Width - 2, main.btn__.Height - 2, 22, 22));

            main.menuStrip1.ForeColor = Color.White;
            main.Num1_group.ForeColor = Color.White;
            main.Num2_group.ForeColor = Color.White;
            main.Num3_group.ForeColor = Color.White;
        }
    }

    // Transparent RichTextBox
    public class TransparentLabel : RichTextBox
    {
        public TransparentLabel()
        {
            this.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            this.TextChanged += TransparentLabel_TextChanged;
            this.VScroll += TransparentLabel_TextChanged;
            this.HScroll += TransparentLabel_TextChanged;
        }

        void TransparentLabel_TextChanged(object sender, System.EventArgs e)
        {
            this.ForceRefresh();
        }
        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams parms = base.CreateParams;
                parms.ExStyle |= 0x20;  // Turn on WS_EX_TRANSPARENT
                return parms;
            }
        }
        public void ForceRefresh()
        {
            this.UpdateStyles();
        }
    }
}
