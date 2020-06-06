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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (taiKhoan == "admin" && matKhau == "123456")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng",
                    "Thông Báo", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

        }
    }
}
