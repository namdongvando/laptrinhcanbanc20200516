using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace QuanLyHangHoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form fDangNhap = new FormDangNhap();
            var ktDangNhap = fDangNhap.ShowDialog(this);
            if (ktDangNhap == DialogResult.OK)
            {
                InitializeComponent();
            }
            else {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var kt = MessageBox.Show("Bạn có muốn thoát không?",
                "Thông Báo", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);
            if (kt != DialogResult.Yes) {
                e.Cancel = true;
            }
        }

        private void thêmLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fDanhSachHangHoa = new FormDanhSachHangHoa();
            //fDanhSachHangHoa.MdiParent = this;
            fDanhSachHangHoa.Show();
        }
    }
}
