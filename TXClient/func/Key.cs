using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace TXClient.func
{

    public class Key
    {
        MainForms MainForm = null;
        public void Init(MainForms m)
        {
            MainForm = m;
        }
        /* Add key */
        public void KeyAdd(string KeyFile, string SigAlgorithm, string KeyListFile)
        {
            structs.Keys key = new structs.Keys();
            /* Setting key */
            key = MainForm.C_KEYUTIL.ReadPrivatePemFile(KeyFile, SigAlgorithm);
            if (key.PrivateKeyStr == null)
            {
                MessageBox.Show("Key file does not exist.");
                return;
            }
            /* Check key */
            if (MainForm.C_KEYUTIL.PublicKeyCheckDuplication(key.PublicKeyStr) == false)
            {
                MessageBox.Show("Key already added");
                return;
            }
            /* Save Key */
            MainForm.C_KEYUTIL.KeySave(key, KeyFile, KeyListFile);

            KeyUtil();
            MessageBox.Show("Add Key Completed");
        }
        /* Delete key */
        public void KeySub(int DelIdx, string KeyListFile)
        {
            if (MainForm.C_KEYUTIL.KeyDel(DelIdx, KeyListFile) == false)
            {
                MessageBox.Show("Deletable key does not exist.");
                return;
            }

            KeyUtil();
            MessageBox.Show("Delete Key Complete");
        }
        /* Change key name */
        public void KeyNameChange(int KeyIdx, string KeyListFile)
        {

            MainForm.C_KEYUTIL.KeyFileNameChange(KeyIdx, KeyListFile);

            KeyUtil();
            MessageBox.Show("Key Name Change Complete");

            MainForm.F_KEYNAMECHANGE.Hide();
            MainForm.F_KEYNAMECHANGE.Txt_change.Text = "";
        }
        /* util */
        public void KeyUtil()
        {
            KeyListInit();
            KeyListFormRefresh();
            KeyNoteComRefresh();
        }
        // SaveKeyList Init
        public void KeyListInit()
        {
            MainForm.C_SAVEKEYLIST = null;
            MainForm.C_SAVEKEYLIST = MainForm.C_KEYUTIL.KeyListUpdate(MainForm.C_DEFINE.KeyFilePath);
        }
        //  Refresh Form 
        public void KeyListFormRefresh()
        {
            MainForm.F_KEYLISTFORM.listBox_KeyList.Items.Clear();
            for (int i = 0; i < MainForm.C_SAVEKEYLIST.Length; i++)
            {
                MainForm.F_KEYLISTFORM.listBox_KeyList.Items.Add(MainForm.C_SAVEKEYLIST[i].Name);
            }
        }
        // refresh combobox 
        public void KeyNoteComRefresh()
        {
            MainForm.com_from.SelectedIndex = -1;
            MainForm.com_from.Items.Clear();
            MainForm.com_from.ResetText();

            for (int j = 0; j < MainForm.C_SAVEKEYLIST.Length; j++)
            {
                MainForm.com_from.Items.Add(MainForm.C_SAVEKEYLIST[j].Name);
                MainForm.com_from.SelectedIndex = 0;
            }
        }
        // keylist form show event
        public void KeyListForm()
        {
            MainForm.F_KEYLISTFORM.ShowDialog();
        }

    }
}