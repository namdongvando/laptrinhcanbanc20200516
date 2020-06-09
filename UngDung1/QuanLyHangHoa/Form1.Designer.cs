namespace QuanLyHangHoa
{
    partial class Form1
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
            this.hàngHoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLoạiHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLoạiHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngHoáToolStripMenuItem,
            this.loạiHàngHóaToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hàngHoáToolStripMenuItem
            // 
            this.hàngHoáToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHàngHóaToolStripMenuItem,
            this.danhSáchHàngHóaToolStripMenuItem});
            this.hàngHoáToolStripMenuItem.Name = "hàngHoáToolStripMenuItem";
            this.hàngHoáToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hàngHoáToolStripMenuItem.Text = "Hàng Hoá";
            // 
            // thêmHàngHóaToolStripMenuItem
            // 
            this.thêmHàngHóaToolStripMenuItem.Name = "thêmHàngHóaToolStripMenuItem";
            this.thêmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thêmHàngHóaToolStripMenuItem.Text = "Thêm Hàng Hóa";
            // 
            // danhSáchHàngHóaToolStripMenuItem
            // 
            this.danhSáchHàngHóaToolStripMenuItem.Name = "danhSáchHàngHóaToolStripMenuItem";
            this.danhSáchHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.danhSáchHàngHóaToolStripMenuItem.Text = "Danh Sách Hàng Hóa";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // loạiHàngHóaToolStripMenuItem
            // 
            this.loạiHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLoạiHàngHóaToolStripMenuItem,
            this.danhSáchLoạiHàngHóaToolStripMenuItem});
            this.loạiHàngHóaToolStripMenuItem.Name = "loạiHàngHóaToolStripMenuItem";
            this.loạiHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.loạiHàngHóaToolStripMenuItem.Text = "Loại Hàng Hóa";
            // 
            // thêmLoạiHàngHóaToolStripMenuItem
            // 
            this.thêmLoạiHàngHóaToolStripMenuItem.Name = "thêmLoạiHàngHóaToolStripMenuItem";
            this.thêmLoạiHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.thêmLoạiHàngHóaToolStripMenuItem.Text = "Thêm Loại Hàng Hóa";
            this.thêmLoạiHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.thêmLoạiHàngHóaToolStripMenuItem_Click);
            // 
            // danhSáchLoạiHàngHóaToolStripMenuItem
            // 
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Name = "danhSáchLoạiHàngHóaToolStripMenuItem";
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Text = "Danh Sách Loại Hàng Hóa";
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLoạiHàngHóaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hàngHoáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLoạiHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLoạiHàngHóaToolStripMenuItem;
    }
}

