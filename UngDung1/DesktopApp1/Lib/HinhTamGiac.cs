using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungClass
{
    class HinhTamGiac : HinhHoc
    {
        public double CanhA { get; set; }
        public double CanhB { get; set; }
        public double CanhC { get; set; }

        public override double ChuVi()
        {
            if (LaTamGiac()==true)
                return CanhA + CanhB + CanhC;
            throw new Exception("không Phai la tam giac");
        }

        public override double DienTich()
        {
            bool kt = LaTamGiac();
            if (kt == false)
                throw new Exception("không Phai tam giac");
            double p = ChuVi() / 2;
            double s = Math.Sqrt(p *
                (p - CanhA)
                * (p - CanhB)
                * (p - CanhC));
            return s;
        }

        private bool LaTamGiac()
        {
            //return CanhA + CanhB > CanhC
            //     && CanhA + CanhC > CanhB
            //     && CanhC + CanhB > CanhA;

            if (CanhA + CanhB > CanhC
                 && CanhA + CanhC > CanhB
                 && CanhC + CanhB > CanhA
                 )
            {
                return true;
            }
            return false;
        }
    }
}
