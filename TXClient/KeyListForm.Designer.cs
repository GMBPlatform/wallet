namespace TXClient
{
    partial class KeyListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyListForm));
            this.listBox_KeyList = new System.Windows.Forms.ListBox();
            this.btn_KeyAdd = new System.Windows.Forms.Button();
            this.imglst_btn = new System.Windows.Forms.ImageList(this.components);
            this.btn_KeySub = new System.Windows.Forms.Button();
            this.Btn_KeyNameChange = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btx_exit = new System.Windows.Forms.Button();
            this.imglst_util = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listBox_KeyList
            // 
            this.listBox_KeyList.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox_KeyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_KeyList.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_KeyList.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_KeyList.FormattingEnabled = true;
            this.listBox_KeyList.ItemHeight = 12;
            this.listBox_KeyList.Location = new System.Drawing.Point(2, 26);
            this.listBox_KeyList.Name = "listBox_KeyList";
            this.listBox_KeyList.Size = new System.Drawing.Size(405, 384);
            this.listBox_KeyList.TabIndex = 0;
            this.listBox_KeyList.SelectedIndexChanged += new System.EventHandler(this.listBox_KeyList_SelectedIndexChanged);
            // 
            // btn_KeyAdd
            // 
            this.btn_KeyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_KeyAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_KeyAdd.ImageKey = "1";
            this.btn_KeyAdd.ImageList = this.imglst_btn;
            this.btn_KeyAdd.Location = new System.Drawing.Point(4, 421);
            this.btn_KeyAdd.Name = "btn_KeyAdd";
            this.btn_KeyAdd.Size = new System.Drawing.Size(130, 31);
            this.btn_KeyAdd.TabIndex = 1;
            this.btn_KeyAdd.Text = "Add Key";
            this.btn_KeyAdd.UseVisualStyleBackColor = true;
            this.btn_KeyAdd.Click += new System.EventHandler(this.btn_KeyAdd_Click);
            // 
            // imglst_btn
            // 
            this.imglst_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_btn.ImageStream")));
            this.imglst_btn.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_btn.Images.SetKeyName(0, "1");
            this.imglst_btn.Images.SetKeyName(1, "2");
            this.imglst_btn.Images.SetKeyName(2, "3");
            // 
            // btn_KeySub
            // 
            this.btn_KeySub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_KeySub.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_KeySub.ImageKey = "1";
            this.btn_KeySub.ImageList = this.imglst_btn;
            this.btn_KeySub.Location = new System.Drawing.Point(139, 421);
            this.btn_KeySub.Name = "btn_KeySub";
            this.btn_KeySub.Size = new System.Drawing.Size(130, 31);
            this.btn_KeySub.TabIndex = 2;
            this.btn_KeySub.Text = "Delete Key";
            this.btn_KeySub.UseVisualStyleBackColor = true;
            this.btn_KeySub.Click += new System.EventHandler(this.btn_KeySub_Click);
            // 
            // Btn_KeyNameChange
            // 
            this.Btn_KeyNameChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KeyNameChange.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_KeyNameChange.ImageKey = "1";
            this.Btn_KeyNameChange.ImageList = this.imglst_btn;
            this.Btn_KeyNameChange.Location = new System.Drawing.Point(274, 421);
            this.Btn_KeyNameChange.Name = "Btn_KeyNameChange";
            this.Btn_KeyNameChange.Size = new System.Drawing.Size(130, 31);
            this.Btn_KeyNameChange.TabIndex = 3;
            this.Btn_KeyNameChange.Text = "Change Key Name";
            this.Btn_KeyNameChange.UseVisualStyleBackColor = true;
            this.Btn_KeyNameChange.Click += new System.EventHandler(this.Btn_KeyNameChange_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // btx_exit
            // 
            this.btx_exit.BackColor = System.Drawing.Color.Transparent;
            this.btx_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btx_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btx_exit.ImageKey = "1";
            this.btx_exit.ImageList = this.imglst_util;
            this.btx_exit.Location = new System.Drawing.Point(385, 0);
            this.btx_exit.Name = "btx_exit";
            this.btx_exit.Size = new System.Drawing.Size(24, 24);
            this.btx_exit.TabIndex = 18;
            this.btx_exit.UseVisualStyleBackColor = false;
            this.btx_exit.Click += new System.EventHandler(this.btx_exit_Click);
            this.btx_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btx_exit_MouseDown);
            this.btx_exit.MouseLeave += new System.EventHandler(this.btx_exit_MouseLeave);
            this.btx_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btx_exit_MouseMove);
            // 
            // imglst_util
            // 
            this.imglst_util.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_util.ImageStream")));
            this.imglst_util.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_util.Images.SetKeyName(0, "3");
            this.imglst_util.Images.SetKeyName(1, "1");
            this.imglst_util.Images.SetKeyName(2, "2");
            // 
            // KeyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(409, 461);
            this.Controls.Add(this.btx_exit);
            this.Controls.Add(this.Btn_KeyNameChange);
            this.Controls.Add(this.btn_KeySub);
            this.Controls.Add(this.btn_KeyAdd);
            this.Controls.Add(this.listBox_KeyList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KeyListForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyListForm_FormClosing);
            this.Load += new System.EventHandler(this.KeyListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_KeyAdd;
        private System.Windows.Forms.Button btn_KeySub;
        public System.Windows.Forms.ListBox listBox_KeyList;
        private System.Windows.Forms.Button Btn_KeyNameChange;
        private System.Windows.Forms.ImageList imglst_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btx_exit;
        private System.Windows.Forms.ImageList imglst_util;
    }
}