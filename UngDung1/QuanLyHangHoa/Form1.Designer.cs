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
            this.h�ngHo�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.th�mH�ngH�aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhS�chH�ngH�aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tho�tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.h�ngHo�ToolStripMenuItem,
            this.tho�tToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // h�ngHo�ToolStripMenuItem
            // 
            this.h�ngHo�ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.th�mH�ngH�aToolStripMenuItem,
            this.danhS�chH�ngH�aToolStripMenuItem});
            this.h�ngHo�ToolStripMenuItem.Name = "h�ngHo�ToolStripMenuItem";
            this.h�ngHo�ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.h�ngHo�ToolStripMenuItem.Text = "H�ng Ho�";
            // 
            // th�mH�ngH�aToolStripMenuItem
            // 
            this.th�mH�ngH�aToolStripMenuItem.Name = "th�mH�ngH�aToolStripMenuItem";
            this.th�mH�ngH�aToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.th�mH�ngH�aToolStripMenuItem.Text = "Th�m H�ng H�a";
            // 
            // danhS�chH�ngH�aToolStripMenuItem
            // 
            this.danhS�chH�ngH�aToolStripMenuItem.Name = "danhS�chH�ngH�aToolStripMenuItem";
            this.danhS�chH�ngH�aToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.danhS�chH�ngH�aToolStripMenuItem.Text = "Danh S�ch H�ng H�a";
            // 
            // tho�tToolStripMenuItem
            // 
            this.tho�tToolStripMenuItem.Name = "tho�tToolStripMenuItem";
            this.tho�tToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.tho�tToolStripMenuItem.Text = "Tho�t";
            this.tho�tToolStripMenuItem.Click += new System.EventHandler(this.tho�tToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem h�ngHo�ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem th�mH�ngH�aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhS�chH�ngH�aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tho�tToolStripMenuItem;
    }
}

