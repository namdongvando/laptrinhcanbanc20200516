namespace SuDungSQLServer
{
    partial class FormDanhSachHangHoa
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
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.cbbLoaiHangHoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(4, 121);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(1157, 462);
            this.dgvHangHoa.TabIndex = 0;
            // 
            // cbbLoaiHangHoa
            // 
            this.cbbLoaiHangHoa.FormattingEnabled = true;
            this.cbbLoaiHangHoa.Location = new System.Drawing.Point(678, 85);
            this.cbbLoaiHangHoa.Name = "cbbLoaiHangHoa";
            this.cbbLoaiHangHoa.Size = new System.Drawing.Size(474, 21);
            this.cbbLoaiHangHoa.TabIndex = 1;
            this.cbbLoaiHangHoa.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiHangHoa_SelectedIndexChanged);
            this.cbbLoaiHangHoa.SelectionChangeCommitted += new System.EventHandler(this.cbbLoaiHangHoa_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loai Hàng Hóa";
            // 
            // FormDanhSachHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLoaiHangHoa);
            this.Controls.Add(this.dgvHangHoa);
            this.Name = "FormDanhSachHangHoa";
            this.Text = "FormDanhSachHangHoa";
            this.Load += new System.EventHandler(this.FormDanhSachHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.ComboBox cbbLoaiHangHoa;
        private System.Windows.Forms.Label label1;
    }
}