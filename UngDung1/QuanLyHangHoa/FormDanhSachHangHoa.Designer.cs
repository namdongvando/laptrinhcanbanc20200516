namespace QuanLyHangHoa
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
            this.components = new System.ComponentModel.Container();
            this.dgvLoaiHangHoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dBQuanLyHangHoaDataSet = new QuanLyHangHoa.DBQuanLyHangHoaDataSet();
            this.loaiHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangHoaTableAdapter = new QuanLyHangHoa.DBQuanLyHangHoaDataSetTableAdapters.LoaiHangHoaTableAdapter();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiChaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyHangHoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiHangHoa
            // 
            this.dgvLoaiHangHoa.AutoGenerateColumns = false;
            this.dgvLoaiHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.maLoaiChaDataGridViewTextBoxColumn});
            this.dgvLoaiHangHoa.DataSource = this.loaiHangHoaBindingSource;
            this.dgvLoaiHangHoa.Location = new System.Drawing.Point(12, 69);
            this.dgvLoaiHangHoa.Name = "dgvLoaiHangHoa";
            this.dgvLoaiHangHoa.Size = new System.Drawing.Size(542, 369);
            this.dgvLoaiHangHoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // dBQuanLyHangHoaDataSet
            // 
            this.dBQuanLyHangHoaDataSet.DataSetName = "DBQuanLyHangHoaDataSet";
            this.dBQuanLyHangHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangHoaBindingSource
            // 
            this.loaiHangHoaBindingSource.DataMember = "LoaiHangHoa";
            this.loaiHangHoaBindingSource.DataSource = this.dBQuanLyHangHoaDataSet;
            // 
            // loaiHangHoaTableAdapter
            // 
            this.loaiHangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // maLoaiChaDataGridViewTextBoxColumn
            // 
            this.maLoaiChaDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiCha";
            this.maLoaiChaDataGridViewTextBoxColumn.HeaderText = "MaLoaiCha";
            this.maLoaiChaDataGridViewTextBoxColumn.Name = "maLoaiChaDataGridViewTextBoxColumn";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(607, 69);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormDanhSachHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoaiHangHoa);
            this.Name = "FormDanhSachHangHoa";
            this.Text = "FormDanhSachHangHoa";
            this.Load += new System.EventHandler(this.FormDanhSachHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyHangHoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiHangHoa;
        private System.Windows.Forms.Label label1;
        private DBQuanLyHangHoaDataSet dBQuanLyHangHoaDataSet;
        private System.Windows.Forms.BindingSource loaiHangHoaBindingSource;
        private DBQuanLyHangHoaDataSetTableAdapters.LoaiHangHoaTableAdapter loaiHangHoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiChaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThem;
    }
}