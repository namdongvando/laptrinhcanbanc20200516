using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungSQLServer
{
    public partial class FormLoai : Form
    {
        public FormLoai()
        {
            InitializeComponent();
        }

        private void FormLoai_Load(object sender, EventArgs e)
        {
            LoadDGVLoaiHangHoa();
        }

        private void LoadDGVLoaiHangHoa()
        {
            LoaiService loaiService = new LoaiService();
            dgvLoaiHangHoa.DataSource = loaiService.GetAll();
        }
        private Loai GetInputForm()
        {
            if (txtMaLoai.Text == "")
                txtMaLoai.Text = "0";

            return new Loai()
            {
                MaLoai = int.Parse(txtMaLoai.Text)
                , TenLoai = txtTenLoai.Text
                , MoTa = txtMoTa.Text
                ,Hinh = txtHinh.Text

            };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Loai nCC = GetInputForm();
                LoaiService nccs = new LoaiService();
                nccs.Add(nCC);
                LoadDGVLoaiHangHoa();
                SetInputForm(new Loai());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInputForm(Loai loai)
        {
            txtMaLoai.Text = loai.MaLoai.ToString();
            txtTenLoai.Text = loai.TenLoai;
            txtMoTa.Text = loai.MoTa;
            txtHinh.Text = loai.Hinh;

        }
    }
}
