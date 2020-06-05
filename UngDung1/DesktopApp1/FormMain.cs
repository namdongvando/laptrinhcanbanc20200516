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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void hinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formHinhTamGiac = new FormHinhTamGiac();
            formHinhTamGiac.MdiParent = this;
            formHinhTamGiac.Show();
        }

        private void hìnhVuôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formHinhVuong = new FormHinhVuong();
            formHinhVuong.MdiParent = this;
            formHinhVuong.Show();

        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formHinhVuong = new FormHinhTron();
            formHinhVuong.MdiParent = this;
            formHinhVuong.Show();
        }

        private void formTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formHinhVuong = new FormTimer();
            formHinhVuong.MdiParent = this;
            formHinhVuong.Show();
        }
    }
}
