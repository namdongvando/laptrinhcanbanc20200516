using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungSQLServer
{
    public partial class FormThemHangHoa : Form
    {
        public FormThemHangHoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInputForm();
                HangHoaService hangHoaService = new HangHoaService();
                hangHoaService.Add(hh);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }




        }

        private HangHoa GetInputForm()
        {
            if (txtMaHangHoa.Text == "") {
                txtMaHangHoa.Text = "0";
            }
            if (txtTenHangHoa.Text == "")
                throw new Exception("Chưa có tên hàng hóa");
            if (cbbLoaiHangHoa.SelectedValue.ToString() =="") {
                throw new Exception("Chưa có loại hàng hóa");
            }
            if (txtGiamGia.Text == "")
            {
                txtGiamGia.Text = "0";
            }
            if (cbbNhaCungCap.SelectedValue.ToString() == "")
            {
                throw new Exception("Chưa có nhà cung cấp");
            }

            HangHoa hh = new HangHoa();
            hh.MaHH = int.Parse(txtMaHangHoa.Text);
            hh.TenHH = txtTenHangHoa.Text;
            hh.MaLoai= int.Parse(cbbLoaiHangHoa.SelectedValue.ToString());
            hh.MaNCC = cbbNhaCungCap.SelectedValue.ToString();
            hh.NgaySX = dtpNgaySanXuat.Value;
            hh.SoLanXem = 0;
            hh.MoTa = txtMoTa.Text;
            hh.MoTaDonVi = txtMoTaDonVi.Text;
            hh.Hinh = txtHinh.Text;
            hh.DonGia = float.Parse(txtDonGia.Text);
            hh.GiamGia = float.Parse(txtMaHangHoa.Text);

            return hh;
        }

        private void FormThemHangHoa_Load(object sender, EventArgs e)
        {
            LoadCBBLoaiHangHoa();
            LoadCBBNhaCungCap();
        }

        private void LoadCBBNhaCungCap()
        {
            NhaCungCapService nhaCungCapService = new NhaCungCapService();
            cbbNhaCungCap.DataSource = nhaCungCapService.GetAll();
            cbbNhaCungCap.ValueMember = "MaNCC";
            cbbNhaCungCap.DisplayMember = "TenCongTy";
        }

        private void LoadCBBLoaiHangHoa()
        {
            LoaiService loaiService = new LoaiService();
            cbbLoaiHangHoa.DataSource = loaiService.GetAll();
            cbbLoaiHangHoa.DisplayMember = "TenLoai";
            cbbLoaiHangHoa.ValueMember = "MaLoai";
        }
    }
}
