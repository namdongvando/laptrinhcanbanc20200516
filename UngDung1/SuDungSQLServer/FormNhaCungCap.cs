using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungSQLServer
{
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myeStoreDataSet.NhaCungCap' table. You can move, or remove it, as needed.

            //this.nhaCungCapTableAdapter.Fill(this.myeStoreDataSet.NhaCungCap);
            LoadDgvNCC();
        }

        private void LoadDgvNCC()
        {
            NhaCungCapService nCCS = new NhaCungCapService();
            dgvNCC.DataSource = nCCS.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nCC = GetInputForm();
                NhaCungCapService nccs = new NhaCungCapService();
                nccs.Add(nCC);
                LoadDgvNCC();
                SetInputForm(new NhaCungCap());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void SetInputForm(NhaCungCap nhaCungCap)
        {
            txtMaNCC.Text = nhaCungCap.MaNCC;
            txtTenCongTy.Text = nhaCungCap.TenCongTy;
            txtDiaChi.Text = nhaCungCap.DiaChi;
            txtEmail.Text = nhaCungCap.Email;
            txtSDT.Text = nhaCungCap.DienThoai;
            txtNguoiLienLac.Text = nhaCungCap.NguoiLienLac;
            txtMoTa.Text = nhaCungCap.MoTa;
            txtLogo.Text = nhaCungCap.Logo;
        }

        private NhaCungCap GetInputForm()
        {
            if (txtMaNCC.Text == "")
                throw new Exception("Chưa có mã nhà cung cấp");
            if (txtTenCongTy.Text == "")
                throw new Exception("Chưa có tên công ty");
            if (txtLogo.Text == "")
                throw new Exception("Chưa có Logo");

            if (txtEmail.Text == "")
                throw new Exception("Chưa có Email");

            return new NhaCungCap() {
                MaNCC = txtMaNCC.Text,
                TenCongTy = txtTenCongTy.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtSDT.Text,
                Email = txtEmail.Text,
                Logo = txtLogo.Text,
                MoTa = txtMoTa.Text,
                NguoiLienLac = txtNguoiLienLac.Text,
                 
            };
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          NhaCungCap nhaCungCap =  new NhaCungCap()
            {
                MaNCC = dgvNCC.Rows[e.RowIndex].Cells[0].Value.ToString().Trim(),
                TenCongTy = dgvNCC.Rows[e.RowIndex].Cells[1].Value.ToString().Trim(),
                Logo = dgvNCC.Rows[e.RowIndex].Cells[2].Value.ToString().Trim(),
                NguoiLienLac = dgvNCC.Rows[e.RowIndex].Cells[3].Value.ToString().Trim(),
                Email = dgvNCC.Rows[e.RowIndex].Cells[4].Value.ToString().Trim(),
                DienThoai = dgvNCC.Rows[e.RowIndex].Cells[5].Value.ToString().Trim(),
                DiaChi = dgvNCC.Rows[e.RowIndex].Cells[6].Value.ToString().Trim(),
                MoTa = dgvNCC.Rows[e.RowIndex].Cells[7].Value.ToString().Trim(),

            };
            SetInputForm(nhaCungCap);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nCC = GetInputForm();
                NhaCungCapService nccs = new NhaCungCapService();
                nccs.Edit(nCC);
                LoadDgvNCC();
                SetInputForm(new NhaCungCap());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kt = MessageBox.Show("Bạn có muốn xóa NCC này không?",
                "Thông Báo",
                MessageBoxButtons.YesNoCancel
                ,MessageBoxIcon.Warning
                );
            if (kt == DialogResult.Yes) {
                try
                {
                    NhaCungCap nCC = GetInputForm();
                    NhaCungCapService nccs = new NhaCungCapService();
                    nccs.Delete(nCC);
                    LoadDgvNCC();
                    SetInputForm(new NhaCungCap());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
