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
            timer2.Start();
            pbxMario.Location = new Point(40, 100);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // DiChuyenMario();
            DiChuyenMario1();
            DiChuyenMario2();
            EVaChanHaiDoiTuong(pbxMario, pbxMario1);
            EVaChanHaiDoiTuong(pbxMario, pbxMario2);

        }

        private void EVaChanHaiDoiTuong(PictureBox pbx1, PictureBox pbx2)
        {
            // doi tuong 1
            int By = pbx1.Location.Y;
            int Cy =By+ pbx1.Height;
            // doi tuong 2
            int A2y = pbx2.Location.Y;
            int D2y = A2y + pbx2.Height;
            if (pbx1.Location.X + pbx1.Width >= pbx2.Location.X) {
                if ((A2y <= Cy) && (A2y >= By) || (D2y <= Cy) && (D2y >= By))  {
                        timer1.Stop();
                   DialogResult kt = MessageBox.Show("bạn có muôn chơi lại không?"
                       , "Thông báo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (kt == DialogResult.Yes) {
                        ResetGame();
                    }

                }
            }
        }

        private void ResetGame()
        {
            int Y1 = new Random().Next(0,200);
            int Y2 = new Random().Next(201, 400);
            pbxMario1.Location = new Point((this.Width - 80),Y1);
            pbxMario2.Location = new Point((this.Width - 80), Y2);
            timer1.Start();
        }

        private void DiChuyenMario2()
        {
            Point viTriHienTaiCuaHinh = pbxMario2.Location;
            viTriHienTaiCuaHinh.X -= 5;
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

        private int PTChuyenDongBienDoiDeu(int x0, int Huong)
        {
            return 0;
        }

        private void DiChuyenMario(int LaDiLen = -1)
        {
            Point viTriHienTaiCuaHinh = pbxMario.Location;
            if (viTriHienTaiCuaHinh.Y <= 0)
            {
                viTriHienTaiCuaHinh.Y = 0;
            }
            if (viTriHienTaiCuaHinh.Y >= this.Height - pbxMario.Height)
            {
                viTriHienTaiCuaHinh.Y = this.Height - pbxMario.Height;
            }
            if (LaDiLen == 1)
            {
                viTriHienTaiCuaHinh.Y += (10);
            }
            else
            {
                viTriHienTaiCuaHinh.Y -= (10);
            }
            pbxMario.Location = viTriHienTaiCuaHinh;
        }

        private void FormTimer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                DiChuyenMario(-1);

                //MessageBox.Show(e.KeyCode.ToString());
            }
            if (e.KeyCode == Keys.Down)
            {
                DiChuyenMario(1);
                //MessageBox.Show(e.KeyCode.ToString());

            }




        }

        private void FormTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Up)
            {
                MessageBox.Show(e.KeyChar.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblThoiGianHienTai.Text = DateTime.Now.ToLocalTime().ToString();
        }
    }
}
