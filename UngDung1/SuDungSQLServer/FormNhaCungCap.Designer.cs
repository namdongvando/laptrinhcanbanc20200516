namespace SuDungSQLServer
{
    partial class FormNhaCungCap
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
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCongTyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiLienLacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myeStoreDataSet = new SuDungSQLServer.MyeStoreDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiLienLac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.nhaCungCapTableAdapter = new SuDungSQLServer.MyeStoreDataSetTableAdapters.NhaCungCapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myeStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoGenerateColumns = false;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNCCDataGridViewTextBoxColumn,
            this.tenCongTyDataGridViewTextBoxColumn,
            this.logoDataGridViewTextBoxColumn,
            this.nguoiLienLacDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dgvNCC.DataSource = this.nhaCungCapBindingSource;
            this.dgvNCC.Location = new System.Drawing.Point(338, 12);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.Size = new System.Drawing.Size(544, 511);
            this.dgvNCC.TabIndex = 0;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            // 
            // tenCongTyDataGridViewTextBoxColumn
            // 
            this.tenCongTyDataGridViewTextBoxColumn.DataPropertyName = "TenCongTy";
            this.tenCongTyDataGridViewTextBoxColumn.HeaderText = "TenCongTy";
            this.tenCongTyDataGridViewTextBoxColumn.Name = "tenCongTyDataGridViewTextBoxColumn";
            // 
            // logoDataGridViewTextBoxColumn
            // 
            this.logoDataGridViewTextBoxColumn.DataPropertyName = "Logo";
            this.logoDataGridViewTextBoxColumn.HeaderText = "Logo";
            this.logoDataGridViewTextBoxColumn.Name = "logoDataGridViewTextBoxColumn";
            // 
            // nguoiLienLacDataGridViewTextBoxColumn
            // 
            this.nguoiLienLacDataGridViewTextBoxColumn.DataPropertyName = "NguoiLienLac";
            this.nguoiLienLacDataGridViewTextBoxColumn.HeaderText = "NguoiLienLac";
            this.nguoiLienLacDataGridViewTextBoxColumn.Name = "nguoiLienLacDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.myeStoreDataSet;
            // 
            // myeStoreDataSet
            // 
            this.myeStoreDataSet.DataSetName = "MyeStoreDataSet";
            this.myeStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(12, 50);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(299, 20);
            this.txtMaNCC.TabIndex = 2;
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(12, 99);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(299, 20);
            this.txtTenCongTy.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Công Ty";
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(12, 149);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(299, 20);
            this.txtLogo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logo";
            // 
            // txtNguoiLienLac
            // 
            this.txtNguoiLienLac.Location = new System.Drawing.Point(12, 199);
            this.txtNguoiLienLac.Name = "txtNguoiLienLac";
            this.txtNguoiLienLac.Size = new System.Drawing.Size(299, 20);
            this.txtNguoiLienLac.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Người Liên Lac";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(12, 288);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(299, 20);
            this.txtSDT.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điện Thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(12, 335);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(299, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(12, 377);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(299, 47);
            this.txtMoTa.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mô Tả";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 451);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 451);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(236, 451);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 550);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNguoiLienLac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenCongTy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNCC);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myeStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiLienLac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private MyeStoreDataSet myeStoreDataSet;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private MyeStoreDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCongTyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiLienLacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
    }
}