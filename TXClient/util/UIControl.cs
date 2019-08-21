using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace TXClient.util
{
    public class UIControl
    {
        MainForms MainForm = null;
        public UIControl(MainForms m)
        {
            MainForm = m;
        }



        // not enter text
        public void RichTextBoxInputBan(RichTextBox ControlName)
        {
            ControlName.BackgroundImageLayout = ImageLayout.Stretch;
            ControlName.BorderStyle = BorderStyle.None;
            ControlName.GotFocus += new System.EventHandler(RTBGotFocus);
            ControlName.Cursor = Cursors.Default;
        }

        private void RTBGotFocus(object sender, EventArgs e)
        {
            SendKeys.Send("{tab}");
        }

        /* Delete text focus when scrolling */
        public void ControlsBox_Scroll(object sender, ScrollEventArgs e)
        {
            // MainForm.ActiveControl = null;
        }
        /*  Delete text focus when wheel is working */
        public void ControlsBox_MouseWheel(object sender, MouseEventArgs e)
        {
            // this.ActiveControl = null;
        }
        
        Form forms = null;
        public void FormHide(Form form)
        {
            forms = form;
            forms.FormClosing += new FormClosingEventHandler(FormHides);
        }
        private void FormHides(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                forms.Hide();
            }
        }
    
        string TextBoxSpecialStringBanStr = null;
        TextBox TextBoxSpecialStringBanStrControlName = null;
        public void TextBoxSpecialStringBan(TextBox ControlName, string str)
        {
            ControlName.TextChanged += new System.EventHandler(TextBoxSpecialStringBans);
            TextBoxSpecialStringBanStr = str;
            TextBoxSpecialStringBanStrControlName = ControlName;
        }
        private void TextBoxSpecialStringBans(object sender, EventArgs e)
        {
            TextBoxSpecialStringBanStrControlName.Text = Regex.Replace(TextBoxSpecialStringBanStrControlName.Text, TextBoxSpecialStringBanStr, "");
            TextBoxSpecialStringBanStrControlName.Focus();
            TextBoxSpecialStringBanStrControlName.Select(TextBoxSpecialStringBanStrControlName.Text.Length, 0);
        }
    }
}