using SuDungClass;
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
    public partial class FormHinhTron : Form
    {
        public FormHinhTron()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double banKinh = double.Parse(txtBanKinh.Text);
                HinhTron ht = new HinhTron();
                ht.BanKinh = banKinh;
                lblChuVi.Text =
                  String.Format("Chu Vi: {0}", ht.ChuVi());
                lblDienTich.Text =
                    String.Format("Diện Tích: {0}", ht.DienTich());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
