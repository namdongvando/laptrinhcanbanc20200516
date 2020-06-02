using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungClass
{
    class HinhTron : HinhHoc
    {
        public double BanKinh { get; set; }
        public override double ChuVi()
        {
            return BanKinh * 2 * Math.PI;
        }

        public override double DienTich()
        {
            return BanKinh * BanKinh * Math.PI;
        }
    }
}
