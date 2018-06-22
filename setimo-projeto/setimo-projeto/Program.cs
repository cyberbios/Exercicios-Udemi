using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace setimo_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            double areaX, areaY;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.area();
            areaY = Y.area();

            Console.WriteLine("AREA DO TRIÂNGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIÂNGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("TRIÂNGULO DE MAIOR ÁREA: X");
            }
            else if(areaX < areaY)
            {
                Console.WriteLine("TRIÂNGULO DE MAIOR ÁREA: Y");
            }
            else
            {
                Console.WriteLine("ÁREAS IGUAIS");
            }
            Console.ReadLine();
        }
    }
}
