namespace TXClient
{
    partial class ContentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentsForm));
            this.Btn_ok = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Txt_Contents = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // Btn_ok
            // 
            this.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ok.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_ok.ImageKey = "1";
            this.Btn_ok.ImageList = this.imageList1;
            this.Btn_ok.Location = new System.Drawing.Point(62, 415);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(256, 23);
            this.Btn_ok.TabIndex = 0;
            this.Btn_ok.Text = "Completion";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            this.Btn_ok.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_ok_MouseDown);
            this.Btn_ok.MouseLeave += new System.EventHandler(this.Btn_ok_MouseLeave);
            this.Btn_ok.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_ok_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1");
            this.imageList1.Images.SetKeyName(1, "2");
            this.imageList1.Images.SetKeyName(2, "3");
            // 
            // Txt_Contents
            // 
            this.Txt_Contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Contents.Location = new System.Drawing.Point(12, 33);
            this.Txt_Contents.Name = "Txt_Contents";
            this.Txt_Contents.Size = new System.Drawing.Size(357, 376);
            this.Txt_Contents.TabIndex = 1;
            this.Txt_Contents.Text = "";
            this.Txt_Contents.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // ContentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Txt_Contents);
            this.Controls.Add(this.Btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContentsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContentsForm";
            this.Load += new System.EventHandler(this.ContentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ok;
        public System.Windows.Forms.RichTextBox Txt_Contents;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}