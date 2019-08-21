using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace TXClient
{
    public partial class KeyListForm : Form
    {
        MainForms MainForm = null;
        public KeyListForm()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                        , int nTopRect
                                        , int nRightRect
                                        , int nBottomRect
                                        , int nWidthEllipse
                                        , int nHeightEllipse);
        private void KeyListForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            new util.UIControl(MainForm).FormHide(this);
        }
        public void Init(MainForms m)
        {
            MainForm = m;
            btx_exit.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(3, 4, btx_exit.Width - 2, btx_exit.Height - 2, 22, 22));
        }
        private void btn_KeyAdd_Click(object sender, EventArgs e)
        {
            MainForm.AddToolStripMenuItem.PerformClick();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btn_KeySub_Click(object sender, EventArgs e)
        {
            if (listBox_KeyList.SelectedIndices.Count > 0)
            {
                MainForm.C_KEY.KeySub(listBox_KeyList.SelectedIndex, MainForm.C_DEFINE.KeyFilePath);
            }
            else
            {
                MessageBox.Show("Key not selected");
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void listBox_KeyList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Btn_KeyNameChange_Click(object sender, EventArgs e)
        {
            if (listBox_KeyList.SelectedIndices.Count > 0)
            {
                MainForm.F_KEYNAMECHANGE.ShowDialog();
            }
            else
            {
                MessageBox.Show("Key not selected");
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void KeyListForm_Load(object sender, EventArgs e)
        {
        }
        private System.Drawing.Point mousePoint;
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

        private void btx_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
