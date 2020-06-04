namespace DesktopApp1
{
    partial class FormHinhTamGiac
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
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtCanhA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCanhB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCanhC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(83, 223);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtCanhA
            // 
            this.txtCanhA.Location = new System.Drawing.Point(103, 20);
            this.txtCanhA.Name = "txtCanhA";
            this.txtCanhA.Size = new System.Drawing.Size(188, 20);
            this.txtCanhA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Canh A";
            // 
            // txtCanhB
            // 
            this.txtCanhB.Location = new System.Drawing.Point(103, 46);
            this.txtCanhB.Name = "txtCanhB";
            this.txtCanhB.Size = new System.Drawing.Size(188, 20);
            this.txtCanhB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Canh B";
            // 
            // txtCanhC
            // 
            this.txtCanhC.Location = new System.Drawing.Point(103, 72);
            this.txtCanhC.Name = "txtCanhC";
            this.txtCanhC.Size = new System.Drawing.Size(188, 20);
            this.txtCanhC.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Canh C";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(329, 27);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(38, 13);
            this.lblChuVi.TabIndex = 9;
            this.lblChuVi.Text = "Chu Vi";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(329, 49);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(55, 13);
            this.lblDienTich.TabIndex = 10;
            this.lblDienTich.Text = "Diện Tích";
            // 
            // FormHinhTamGiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.txtCanhC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCanhB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCanhA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinh);
            this.Name = "FormHinhTamGiac";
            this.Text = "FormHinhTamGiac";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtCanhA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCanhB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCanhC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
    }
}