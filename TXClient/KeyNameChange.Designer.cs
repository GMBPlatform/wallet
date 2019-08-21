namespace TXClient
{
    partial class KeyNameChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyNameChange));
            this.Txt_change = new System.Windows.Forms.TextBox();
            this.Btn_Change = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_change
            // 
            this.Txt_change.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_change.Location = new System.Drawing.Point(12, 10);
            this.Txt_change.MaxLength = 10;
            this.Txt_change.Name = "Txt_change";
            this.Txt_change.Size = new System.Drawing.Size(156, 21);
            this.Txt_change.TabIndex = 0;
            this.Txt_change.TextChanged += new System.EventHandler(this.Txt_change_TextChanged);
            // 
            // Btn_Change
            // 
            this.Btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Change.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_Change.ImageKey = "1";
            this.Btn_Change.ImageList = this.imageList1;
            this.Btn_Change.Location = new System.Drawing.Point(12, 37);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(75, 23);
            this.Btn_Change.TabIndex = 1;
            this.Btn_Change.Text = "Change";
            this.Btn_Change.UseVisualStyleBackColor = true;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Change_Click);
            this.Btn_Change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Change_MouseDown);
            this.Btn_Change.MouseLeave += new System.EventHandler(this.Btn_Change_MouseLeave);
            this.Btn_Change.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Change_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1");
            this.imageList1.Images.SetKeyName(1, "2");
            this.imageList1.Images.SetKeyName(2, "3");
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_Cancel.ImageKey = "1";
            this.Btn_Cancel.ImageList = this.imageList1;
            this.Btn_Cancel.Location = new System.Drawing.Point(90, 37);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            this.Btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Cancel_MouseDown);
            this.Btn_Cancel.MouseLeave += new System.EventHandler(this.Btn_Cancel_MouseLeave);
            this.Btn_Cancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Cancel_MouseMove);
            // 
            // KeyNameChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(177, 63);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Change);
            this.Controls.Add(this.Txt_change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyNameChange";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyNameChange";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyNameChange_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Change;
        private System.Windows.Forms.Button Btn_Cancel;
        public System.Windows.Forms.TextBox Txt_change;
        private System.Windows.Forms.ImageList imageList1;
    }
}