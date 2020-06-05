namespace DesktopApp1
{
    partial class FormMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hinhHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhVuôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhTrònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmViệcVớiThoiGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinhHocToolStripMenuItem,
            this.làmViệcVớiThoiGianToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hinhHocToolStripMenuItem
            // 
            this.hinhHocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinhToolStripMenuItem,
            this.hìnhVuôngToolStripMenuItem,
            this.hìnhTrònToolStripMenuItem});
            this.hinhHocToolStripMenuItem.Name = "hinhHocToolStripMenuItem";
            this.hinhHocToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.hinhHocToolStripMenuItem.Text = "Hinh Hoc";
            // 
            // hinhToolStripMenuItem
            // 
            this.hinhToolStripMenuItem.Name = "hinhToolStripMenuItem";
            this.hinhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hinhToolStripMenuItem.Text = "Hình Tam Giác";
            this.hinhToolStripMenuItem.Click += new System.EventHandler(this.hinhToolStripMenuItem_Click);
            // 
            // hìnhVuôngToolStripMenuItem
            // 
            this.hìnhVuôngToolStripMenuItem.Name = "hìnhVuôngToolStripMenuItem";
            this.hìnhVuôngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hìnhVuôngToolStripMenuItem.Text = "Hình vuông";
            this.hìnhVuôngToolStripMenuItem.Click += new System.EventHandler(this.hìnhVuôngToolStripMenuItem_Click);
            // 
            // hìnhTrònToolStripMenuItem
            // 
            this.hìnhTrònToolStripMenuItem.Name = "hìnhTrònToolStripMenuItem";
            this.hìnhTrònToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hìnhTrònToolStripMenuItem.Text = "Hình Tròn";
            this.hìnhTrònToolStripMenuItem.Click += new System.EventHandler(this.hìnhTrònToolStripMenuItem_Click);
            // 
            // làmViệcVớiThoiGianToolStripMenuItem
            // 
            this.làmViệcVớiThoiGianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formTimerToolStripMenuItem});
            this.làmViệcVớiThoiGianToolStripMenuItem.Name = "làmViệcVớiThoiGianToolStripMenuItem";
            this.làmViệcVớiThoiGianToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.làmViệcVớiThoiGianToolStripMenuItem.Text = "Làm Việc Với Thoi Gian";
            // 
            // formTimerToolStripMenuItem
            // 
            this.formTimerToolStripMenuItem.Name = "formTimerToolStripMenuItem";
            this.formTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formTimerToolStripMenuItem.Text = "FormTimer";
            this.formTimerToolStripMenuItem.Click += new System.EventHandler(this.formTimerToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hinhHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhVuôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhTrònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmViệcVớiThoiGianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formTimerToolStripMenuItem;
    }
}