using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class FormDanhSachHangHoa : Form
    {
        public FormDanhSachHangHoa()
        {
            InitializeComponent();
        }

        private void FormDanhSachHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyHangHoaDataSet.LoaiHangHoa' table. You can move, or remove it, as needed.
            this.loaiHangHoaTableAdapter.Fill(this.dBQuanLyHangHoaDataSet.LoaiHangHoa);
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

    
        }
    }
}
