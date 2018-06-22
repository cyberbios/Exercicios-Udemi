using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo H, B;
                                  
            H = new Retangulo();
            

            H.h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            H.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area  = " + H.Area().ToString("F2", CultureInfo.InvariantCulture));
            
           Console.WriteLine("Perimetro  = " + H.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Diagonal = " + H.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
