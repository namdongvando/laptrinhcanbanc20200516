using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungClass
{
    class HinhVuong : HinhHoc
    {
        public double CanhA { get; set; }
        public override double ChuVi()
        {
            return 4 * CanhA;
        }
        
        public override double DienTich()
        {
            return CanhA * CanhA;
        }
    }
}
