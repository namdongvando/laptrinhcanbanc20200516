using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungSQLServer
{
    public partial class FormDanhSachHangHoa : Form
    {
        public FormDanhSachHangHoa()
        {
            InitializeComponent();
        }

        private void FormDanhSachHangHoa_Load(object sender, EventArgs e)
        {
            LoadCbbLoaiHangHoa();
        }

        private void LoadCbbLoaiHangHoa()
        {
            LoaiService loaiService = new LoaiService();
            List<Loai> lLoai = loaiService.GetAll();
            lLoai.Add(new Loai()
            {
                MaLoai = 0,
                TenLoai = "Chọn Loại Hàng Hóa"
            });
            cbbLoaiHangHoa.DataSource = lLoai;
            cbbLoaiHangHoa.DisplayMember = "TenLoai";
            cbbLoaiHangHoa.ValueMember = "MaLoai";
            cbbLoaiHangHoa.SelectedValue = 0;
        }

        private void cbbLoaiHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int loaiHH = int.Parse( cbbLoaiHangHoa.SelectedValue.ToString());
            //HangHoaService hangHoaService = new HangHoaService();
            //List<HangHoa> lHangHoa = hangHoaService.GetHangHoaByMaLoai(loaiHH);
            //dgvHangHoa.DataSource = lHangHoa;
        }

        private void cbbLoaiHangHoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int loaiHH = int.Parse(cbbLoaiHangHoa.SelectedValue.ToString());
            HangHoaService hangHoaService = new HangHoaService();
            List<HangHoa> lHangHoa = hangHoaService.GetHangHoaByMaLoai(loaiHH);
            dgvHangHoa.DataSource = lHangHoa;
        }
    }
}
