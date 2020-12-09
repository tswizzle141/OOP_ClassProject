using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator{
    public class Format{
        public static string ComplexNumber(Complex cplx){
            var re = cplx.Real;
            var im = cplx.Imaginary;
            if(im == 0)
                return re.ToString();
            if(re == 0)
                return im.ToString() + "i";
            if(im < 0)
                return re.ToString() + im + "i";
            else
                return re.ToString() + "+" + im + "i";
        }
    }
}
