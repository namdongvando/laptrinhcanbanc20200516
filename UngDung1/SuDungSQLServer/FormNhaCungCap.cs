using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungSQLServer
{
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myeStoreDataSet.NhaCungCap' table. You can move, or remove it, as needed.

            //this.nhaCungCapTableAdapter.Fill(this.myeStoreDataSet.NhaCungCap);
            NhaCungCapService nCCS = new NhaCungCapService();
            dgvNCC.DataSource = nCCS.GetAll();
        }   

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

     


    }
}
