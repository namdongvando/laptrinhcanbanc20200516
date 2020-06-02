using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungClass
{
    class PhuongTrinhBac2
    {
        public double SoA { get; set; }
        public double SoB { get; set; }
        public double SoC { get; set; }
        public double NghiemX1 { get; set; }
        public double NghiemX2 { get; set; }

        public PhuongTrinhBac2(double soA, double soB, double soC)
        {
            SoA = soA;
            SoB = soB;
            SoC = soC;
            GiaiPhuongTrinhBac2();
        }

        private void GiaiPhuongTrinhBac2()
        {
            if (SoA==0)
            {
                throw new Exception("không phai phuong trinh bac 2");
            }
            double d = Math.Pow(SoB, 2) - 4 * SoA * SoC;
            if (d<0)
            {
                throw new Exception("Phuong trinh vo nghiem");
            }
            NghiemX1 = (-SoB + Math.Sqrt(d)) / (2 * SoA);
            NghiemX2 = (-SoB - Math.Sqrt(d)) / (2 * SoA);

        }
    }
}
