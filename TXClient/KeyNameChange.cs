using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace TXClient
{
    public partial class KeyNameChange : Form
    {
        MainForms MainForm=null;
        public KeyNameChange()
        {
            InitializeComponent();
        }
        public void Init(MainForms m)
        {
            MainForm = m;
        }
        private void KeyNameChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            new util.UIControl(MainForm).FormHide(this);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Txt_change.Text = "";
            Hide();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            if (Txt_change.Text == "")
            {
                MessageBox.Show("Not entered.");
                return;
            }
            else
            {
                MainForm.C_KEY.KeyNameChange(MainForm.F_KEYLISTFORM.listBox_KeyList.SelectedIndex, MainForm.C_DEFINE.KeyFilePath);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void Txt_change_TextChanged(object sender, EventArgs e)
        {
            new util.UIControl(MainForm).TextBoxSpecialStringBan(Txt_change, @"[~`!@#$%^&*_\-={}[\]|\\;:'""<>,.?/]");
        }

        private void Btn_Change_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_Change.ImageKey = "2";
        }

        private void Btn_Change_MouseLeave(object sender, EventArgs e)
        {
            Btn_Change.ImageKey = "1";
        }

        private void Btn_Change_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Change.ImageKey = "3";
        }

        private void Btn_Cancel_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_Cancel.ImageKey = "2";
        }

        private void Btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            Btn_Cancel.ImageKey = "1";
        }

        private void Btn_Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Cancel.ImageKey = "3";
        }
    }
}
