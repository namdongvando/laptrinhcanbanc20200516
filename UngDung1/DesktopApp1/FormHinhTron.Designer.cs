namespace DesktopApp1
{
    partial class FormHinhTron
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
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(517, 141);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(55, 13);
            this.lblDienTich.TabIndex = 24;
            this.lblDienTich.Text = "Diện Tích";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(517, 119);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(38, 13);
            this.lblChuVi.TabIndex = 23;
            this.lblChuVi.Text = "Chu Vi";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(291, 112);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(188, 20);
            this.txtBanKinh.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bán Kinh";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(271, 315);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 20;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // FormHinhTron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinh);
            this.Name = "FormHinhTron";
            this.Text = "FormHinhTron";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinh;
    }
}