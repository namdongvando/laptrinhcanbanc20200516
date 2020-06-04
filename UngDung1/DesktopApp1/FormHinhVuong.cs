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
    public partial class FormHinhVuong : Form
    {
        public FormHinhVuong()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double canhA = double.Parse(txtCanhA.Text);
                HinhVuong hv = new HinhVuong();
                hv.CanhA = canhA;
                lblChuVi.Text =
                    String.Format("Chu Vi: {0}", hv.ChuVi());
                lblDienTich.Text =
                    String.Format("Diện Tích: {0}", hv.DienTich());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
