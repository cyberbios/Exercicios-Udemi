using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioCINCO
{
    class Program
    {
        static void Main(string[] args)
        {
            //No arremesso de dardo, o atleta tem três chances para lançar o dardo à maior distância que conseguir. Você deve criar             um programa para, dadas as medidas das três tentativas de lançamento, informar qual foi a maior.
            //Entrada
            //A entrada contém os valores das medidas em metros das três distâncias às quais o dardo foi arremessado, com duas casas decimais.
            //Saída
            //A saída contém a maior das distâncias, com duas casas decimais.
            double arremesso1, arremesso2, arremesso3;

            string[] vet = Console.ReadLine().Split(' ');
            arremesso1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            arremesso2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            arremesso3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if(arremesso1 > arremesso2 && arremesso1 > arremesso3)
            {
                Console.WriteLine(arremesso1.ToString("F2", CultureInfo.InvariantCulture) + " O Primeiro arremesso foi o melhor!");
            }
            else if(arremesso2 > arremesso3)
            {
                Console.WriteLine(arremesso2.ToString("F2", CultureInfo.InvariantCulture) + " O Segundo arremesso foi o melhor!");
            }
            else
            {
                Console.WriteLine(arremesso3.ToString("F2", CultureInfo.InvariantCulture) + " O Terceiro arremesso foi o melhor!");
            }
            Console.ReadLine();
        }
    }
}
