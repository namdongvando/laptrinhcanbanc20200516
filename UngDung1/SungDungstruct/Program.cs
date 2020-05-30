using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungDungstruct
{
    struct SinhVien {

        public static List<SinhVien> DanhSachSinhVien; 

        public string MaSV { get; set; }
        public String Ten { get; set; }
      
        public String SDT { get; set; }
        public String DiaChi { get; set; }
        public String Lop { get; set; }
        public String Khoa { get; set; }
        public DateTime NgaySinh { get; set; }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", this.MaSV,
                this.Ten,this.SDT,this.DiaChi,this.Lop,this.Khoa,this.NgaySinh);
        }

        public SinhVien(string maSV, string ten
            , string sDT, string diaChi
            , string lop, string khoa
            , DateTime ngaySinh)  
        {
            this.MaSV = maSV;
            this.Ten = ten;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Lop = lop;
            this.Khoa = khoa;
            this.NgaySinh = ngaySinh;
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<SinhVien>();

        }

        public void ThemSinhVien(SinhVien teo)
        {

            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<SinhVien>();
            DanhSachSinhVien.Add(teo);
            
        }

        public void XoaSinhVien(string v)
        {
            int index = TimViTriSVTrongDanhSach(v); 
            if (index>=0)
            DanhSachSinhVien.RemoveAt(index);  
        }

        private int TimViTriSVTrongDanhSach(string v)
        {
            int dem = -1;
            int i = 0;
            foreach (SinhVien item in DanhSachSinhVien)
            {
                if (item.MaSV == v) {
                    dem = i;
                    break;
                }
                i++;


            }
            return dem;

        }

        public void SuaThongTinSinhVien(SinhVien teo)
        {
            XoaSinhVien(teo.MaSV);
            ThemSinhVien(teo);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //KhoiTaoSV();
           SinhVien teo =  NhapTTSV();
            SinhVien ti = NhapTTSV();
            teo.ThemSinhVien(teo);
            teo.ThemSinhVien(ti);
            teo.Ten = "Teo nguyen";
            teo.SuaThongTinSinhVien(teo);

            teo.XoaSinhVien("001");
            XDSSV();


            

        }
        /// <summary>
        /// XuatDanhSachSinhVien
        /// </summary>
        private static void XDSSV()
        {
            foreach (SinhVien sv in SinhVien.DanhSachSinhVien)
            {
                Console.WriteLine(sv.ToString());
            }
        }

        private static SinhVien NhapTTSV()
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("NhaptenSV");
            sv.Ten=Console.ReadLine();
            Console.WriteLine("nhap ma");
            sv.MaSV = Console.ReadLine();
            Console.WriteLine("nhap sdt");
            sv.SDT = Console.ReadLine();
            Console.WriteLine("dia chi ");
            sv.DiaChi = Console.ReadLine();
            Console.WriteLine("khoa");
            sv.Khoa = Console.ReadLine();
            Console.WriteLine("lop");
            sv.Lop = Console.ReadLine();
            Console.WriteLine(sv.ToString());
            return sv;
        }

        private static void KhoiTaoSV()
        {
            SinhVien Teo = new SinhVien();
            Teo.MaSV = "123456";
            Teo.Ten = "Nguyen van Teo";
            Teo.SDT = "0123456789";
            Teo.DiaChi = "hcm";
            Teo.Lop = "Cn001";
            Teo.Khoa = "Cong nghe thong tin";
            Teo.NgaySinh = new DateTime(2000, 1, 1);

            SinhVien Ti = new SinhVien();
            Ti.MaSV = "123456";
            Ti.Ten = "Nguyen van Ti";
            Ti.SDT = "0123456789";
            Ti.DiaChi = "hcm";
            Ti.Lop = "Cn001";
            Ti.Khoa = "Cong nghe thong tin";
            Ti.NgaySinh = new DateTime(2000, 1, 1);
            Console.WriteLine(Teo.Ten);

            SinhVien Lan = new SinhVien("00001", "Nguyen thi Lan",
                "12312312321", "hcm"
                , "cn10", "ke toan", new DateTime(2000, 2, 2));
            SinhVien Toan = new SinhVien
            {
                MaSV = "8491"
                ,
                Ten = "phan chi toan"
                ,
                SDT = "13154548656"
                ,
                DiaChi = "1232241"
                ,
                Lop = "7/9"
                ,
                Khoa = "ffafae"
                ,
                NgaySinh = new DateTime(2007, 9, 12)

            };
            string tt = Toan.ToString();

            Console.WriteLine(Toan.ToString());
        }
    }
}
