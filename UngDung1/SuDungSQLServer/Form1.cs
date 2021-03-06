﻿using System;
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

namespace SuDungSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void danhSáchNhàCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fNCC = new FormNhaCungCap();
            fNCC.Show();
        }

        private void danhSáchLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fNCC = new FormLoai();
            fNCC.Show();
        }

        private void thêmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemhanghoa = new FormThemHangHoa();
            fThemhanghoa.Show();
        }

        private void danhSáchHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemhanghoa = new FormDanhSachHangHoa();
            fThemhanghoa.Show();
        }
    }
}
