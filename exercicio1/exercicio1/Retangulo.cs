using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Retangulo
    {
        public double h, b;

        public double Area()
        {
            double a = b * h;
            return a;
        }
        public double Perimetro()
        {
           double p = 2 * (b + h);
            return p;
        }
        public double Diagonal()
        {
            double d = (Math.Sqrt(b * b + h * h));
            return d;
        }
    }
}
