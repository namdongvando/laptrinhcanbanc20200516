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
    public partial class FormHinhTamGiac : Form
    {
        public FormHinhTamGiac()
        {
            InitializeComponent();
        }
        
        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double canhA = double.Parse(txtCanhA.Text);
                double canhB = double.Parse(txtCanhB.Text);
                double canhC = double.Parse(txtCanhC.Text);
                HinhTamGiac htg = new HinhTamGiac();
                htg.CanhA = canhA;
                htg.CanhB = canhB;
                htg.CanhC = canhC;
                lblChuVi.Text = 
                    String.Format("Chu Vi: {0}", htg.ChuVi());
                lblDienTich.Text =
                    String.Format("Diện Tích: {0}", htg.DienTich());
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
