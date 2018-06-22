using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace quarto_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os coeficientes a, b, c de uma equação do segundo grau (ax2+bx+c=0) e depois mostrar as raízes da equação, com quatro casas decimais, conforme exemplo. Se não for possível calcular as raízes, exibir uma mensagem.
            //Exemplos: Entrada: 1.00   -4.00   3.00 Saída: X1 = 3.0000   X2 = 1.0000
            // Entrada: 2.00   3.52   8.00   Saída: Impossível Calcular
            //Entrada: 0.00   4.00   2.00   Saída: Impossível Calcular

            double a, b, c, delta, x1, x2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = b * b - 4 * a * c;

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
