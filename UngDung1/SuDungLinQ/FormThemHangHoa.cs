using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
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
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.HangHoas.InsertOnSubmit(hh);
                    _Database.SubmitChanges();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private HangHoa GetInputForm()
        {
            if (txtMaHangHoa.Text == "")
            {
                txtMaHangHoa.Text = "0";
            }
            if (txtTenHangHoa.Text == "")
                throw new Exception("Chưa có tên hàng hóa");
            if (cbbLoaiHangHoa.SelectedValue.ToString() == "")
            {
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
            float donGia;
            if (float.TryParse(txtDonGia.Text,out donGia)==false)
            {
                throw new Exception("Đơn Giá Không Hợp Lệ");
            }
            float giamGia;
            if (float.TryParse(txtGiamGia.Text, out giamGia)==false)
            {
                throw new Exception("Giảm Giá Không Hợp Lệ");
            }
            HangHoa hh = new HangHoa();
            hh.TenHH = txtTenHangHoa.Text;
            hh.MaLoai = int.Parse(cbbLoaiHangHoa.SelectedValue.ToString());
            hh.MaNCC = cbbNhaCungCap.SelectedValue.ToString();
            hh.NgaySX = dtpNgaySanXuat.Value;
            hh.SoLanXem = 0;
            hh.MoTa = txtMoTa.Text;
            hh.MoTaDonVi = txtMoTaDonVi.Text;
            hh.Hinh = txtHinh.Text;
            hh.DonGia = donGia;
            hh.GiamGia = giamGia;

            return hh;
        }

        private void FormThemHangHoa_Load(object sender, EventArgs e)
        {
            using (MyEStoreDataContext _Database = new MyEStoreDataContext()) {

                cbbLoaiHangHoa.DataSource = _Database.Loais.ToList();
                cbbLoaiHangHoa.DisplayMember = "TenLoai";
                cbbLoaiHangHoa.ValueMember = "MaLoai";
                
                cbbNhaCungCap.DataSource = _Database.NhaCungCaps.ToList();
                cbbNhaCungCap.DisplayMember = "TenCongTy";
                cbbNhaCungCap.ValueMember = "MaNCC";
            }


        }
    }
}
