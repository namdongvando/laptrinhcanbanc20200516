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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MyEStoreDataContext _Database = new MyEStoreDataContext()) {
                _Database.DeferredLoadingEnabled = false;
                //Load datagreaView
                dgvHangHoa.DataSource = _Database.HangHoas.ToList();
                //Load cbbLoai
                List<Loai> danhSachLoai = _Database.Loais.ToList();
                danhSachLoai.Insert(0,new Loai()
                {
                    MaLoai = 0,
                    TenLoai = "Chọn Loại Sản Phẩm"
                }) ;
                cbbLoai.DataSource = danhSachLoai; 
                
                cbbLoai.SelectedIndex = 0;
                cbbLoai.ValueMember = "MaLoai";
                cbbLoai.DisplayMember = "TenLoai";
            }


        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text;
            using (MyEStoreDataContext _Database = new MyEStoreDataContext()) {
                _Database.DeferredLoadingEnabled = false;
               var danhSachHHTimKiem =  
                    _Database.HangHoas.Where(
                        hh => hh.TenHH.Contains(tuKhoa)
                        || hh.MaHH.ToString().Contains(tuKhoa)
                        ).ToList();
                dgvHangHoa.DataSource = danhSachHHTimKiem;
            } 


        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void cbbLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var MaLoai = cbbLoai.SelectedValue.ToString();
            using (MyEStoreDataContext _Database = new MyEStoreDataContext()) {
                _Database.DeferredLoadingEnabled = false;
                var danhSachHangHoaTheoLoai =
                    _Database.HangHoas.Where(hh => hh.MaLoai.Equals(MaLoai)).ToList();

                dgvHangHoa.DataSource = danhSachHangHoaTheoLoai;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fThemHangHoa = new FormThemHangHoa();
            DialogResult formThem = fThemHangHoa.ShowDialog();
            if (formThem == DialogResult.OK) {
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.DeferredLoadingEnabled = false;
                    dgvHangHoa.DataSource = _Database.HangHoas.ToList();
                }
            }
            
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var MaHH = dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();

            Form formSuaHangHoa = new FormSuaHangHoa(MaHH);
            DialogResult kt = formSuaHangHoa.ShowDialog();
            if (kt == DialogResult.OK) {
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.DeferredLoadingEnabled = false;
                    dgvHangHoa.DataSource = _Database.HangHoas.ToList();
                }
            }
        }
    }
}
