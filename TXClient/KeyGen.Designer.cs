namespace TXClient
{
    partial class KeyGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyGen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_KetGen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_mnemonic = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btx_exit = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "User-defined characters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btn_KetGen
            // 
            this.btn_KetGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_KetGen.ImageKey = "1";
            this.btn_KetGen.ImageList = this.imageList1;
            this.btn_KetGen.Location = new System.Drawing.Point(14, 113);
            this.btn_KetGen.Name = "btn_KetGen";
            this.btn_KetGen.Size = new System.Drawing.Size(175, 23);
            this.btn_KetGen.TabIndex = 2;
            this.btn_KetGen.Text = "KeyGenerator";
            this.btn_KetGen.UseVisualStyleBackColor = true;
            this.btn_KetGen.Click += new System.EventHandler(this.btn_KetGen_Click);
            this.btn_KetGen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_KetGen_MouseDown);
            this.btn_KetGen.MouseLeave += new System.EventHandler(this.btn_KetGen_MouseLeave);
            this.btn_KetGen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_KetGen_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1");
            this.imageList1.Images.SetKeyName(1, "2");
            this.imageList1.Images.SetKeyName(2, "3");
            // 
            // txt_mnemonic
            // 
            this.txt_mnemonic.Location = new System.Drawing.Point(14, 47);
            this.txt_mnemonic.Name = "txt_mnemonic";
            this.txt_mnemonic.Size = new System.Drawing.Size(175, 21);
            this.txt_mnemonic.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(14, 86);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(175, 21);
            this.txt_password.TabIndex = 6;
            // 
            // btx_exit
            // 
            this.btx_exit.BackColor = System.Drawing.Color.Transparent;
            this.btx_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btx_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btx_exit.ImageKey = "1";
            this.btx_exit.ImageList = this.imageList2;
            this.btx_exit.Location = new System.Drawing.Point(176, 0);
            this.btx_exit.Name = "btx_exit";
            this.btx_exit.Size = new System.Drawing.Size(24, 24);
            this.btx_exit.TabIndex = 19;
            this.btx_exit.UseVisualStyleBackColor = false;
            this.btx_exit.Click += new System.EventHandler(this.btx_exit_Click);
            this.btx_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btx_exit_MouseDown);
            this.btx_exit.MouseLeave += new System.EventHandler(this.btx_exit_MouseLeave);
            this.btx_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btx_exit_MouseMove);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "3");
            this.imageList2.Images.SetKeyName(1, "1");
            this.imageList2.Images.SetKeyName(2, "2");
            // 
            // KeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(200, 148);
            this.Controls.Add(this.btx_exit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_mnemonic);
            this.Controls.Add(this.btn_KetGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyGen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KeyGen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeyGen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyGen_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_KetGen;
        private System.Windows.Forms.TextBox txt_mnemonic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btx_exit;
        private System.Windows.Forms.ImageList imageList2;
    }
}