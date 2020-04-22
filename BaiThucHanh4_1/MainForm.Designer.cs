namespace BaiThucHanh4_1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuVanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVanhZn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTruong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTruongQp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVanh,
            this.mnuTruong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuVanh
            // 
            this.mnuVanh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVanhZn});
            this.mnuVanh.Name = "mnuVanh";
            this.mnuVanh.Size = new System.Drawing.Size(55, 24);
            this.mnuVanh.Text = "Vành";
            // 
            // mnuVanhZn
            // 
            this.mnuVanhZn.Name = "mnuVanhZn";
            this.mnuVanhZn.Size = new System.Drawing.Size(224, 26);
            this.mnuVanhZn.Text = "Vành Zn";
            this.mnuVanhZn.Click += new System.EventHandler(this.mnuVanhZn_Click);
            // 
            // mnuTruong
            // 
            this.mnuTruong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTruongQp});
            this.mnuTruong.Name = "mnuTruong";
            this.mnuTruong.Size = new System.Drawing.Size(70, 24);
            this.mnuTruong.Text = "Trường";
            // 
            // mnuTruongQp
            // 
            this.mnuTruongQp.Name = "mnuTruongQp";
            this.mnuTruongQp.Size = new System.Drawing.Size(224, 26);
            this.mnuTruongQp.Text = "Trường Qp";
            this.mnuTruongQp.Click += new System.EventHandler(this.mnuTruongQp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Đại số hữu hạn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuVanh;
        private System.Windows.Forms.ToolStripMenuItem mnuVanhZn;
        private System.Windows.Forms.ToolStripMenuItem mnuTruong;
        private System.Windows.Forms.ToolStripMenuItem mnuTruongQp;
    }
}

