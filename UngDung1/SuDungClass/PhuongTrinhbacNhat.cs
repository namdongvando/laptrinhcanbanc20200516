using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungClass
{
    class PhuongTrinhbacNhat
    {
        public PhuongTrinhbacNhat()
        {
        }

        public PhuongTrinhbacNhat(double soA, double soB)
        {
            SoA = soA;
            SoB = soB;
            GiaiPhuongTrinh();
        }

        public double SoA { get; set; }
        public double SoB { get; set; }
        public double NghiemX { get; set; }
        public void GiaiPhuongTrinh()
        {
            if (SoA == 0)
            {
                if (SoB == 0)
                    throw new Exception("PTVSN");
                else
                    throw new Exception("PTVN");
            }
            NghiemX = -SoB / SoA;

        }
    }
}
