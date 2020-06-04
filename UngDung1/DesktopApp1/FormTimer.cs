using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class FormTimer : Form
    {
        private static int LaDiLen = 1;


        public FormTimer()
        {
            InitializeComponent();
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30;
            timer1.Start();
            pbxMario.Location = new Point(100, 100);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiChuyenMario();
            DiChuyenMario1();
            DiChuyenMario2();
        }

        private void DiChuyenMario2()
        {
            Point viTriHienTaiCuaHinh = pbxMario2.Location;
            viTriHienTaiCuaHinh.X-=5;
            if (viTriHienTaiCuaHinh.X <= 0)
                viTriHienTaiCuaHinh.X = this.Width;
            pbxMario2.Location = viTriHienTaiCuaHinh;
        }

        private void DiChuyenMario1()
        {
            Point viTriHienTaiCuaHinh = pbxMario1.Location;
            viTriHienTaiCuaHinh.X -= 5;
            if (viTriHienTaiCuaHinh.X <= 0)
                viTriHienTaiCuaHinh.X = this.Width;
            pbxMario1.Location = viTriHienTaiCuaHinh;
        }

        private void DiChuyenMario()
        {
            Point viTriHienTaiCuaHinh = pbxMario.Location;
            if (LaDiLen == 1)
            {
                viTriHienTaiCuaHinh.Y += 5;
            }
            else
            {
                viTriHienTaiCuaHinh.Y -= 5;
            }
            if (viTriHienTaiCuaHinh.Y <= 0)
            {
                LaDiLen = 1;
            }

            if (viTriHienTaiCuaHinh.Y >= 200)
            {
                LaDiLen = -1;
            }
            pbxMario.Location = viTriHienTaiCuaHinh;
        }

        private void FormTimer_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
            
        }

        private void FormTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Up) {
                MessageBox.Show(e.KeyChar.ToString());
            }  
        }
    }
}
