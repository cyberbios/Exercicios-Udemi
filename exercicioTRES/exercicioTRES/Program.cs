using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioTRES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dadas as dimensões de uma foto e de um porta retrato, você deve verificar se uma foto cabe em um porta retrato.Você pode girar a foto 90º para adequá-la à dimensão do porta retrato.
            //Entrada:
            //A primeira linha da entrada contém a largura e altura da foto, e a segunda linha contém a largura e altura do porta retrato.
            //Saída:
            //A saída contém a palavra "SIM" se a foto couber no porta retrato, ou a palavra "NAO" caso contrário.   

            int largPic, altPic, largPortRet, altPortRet;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            largPic = int.Parse(vet[0]);
            altPic = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            largPortRet = int.Parse(vet[0]);
            altPortRet = int.Parse(vet[1]);

            if((largPic <= largPortRet && altPic <= altPortRet) || (altPic <= largPortRet && largPic <= altPortRet))
            {
                Console.WriteLine("SIM, A FOTO CABE NO PORTA RETRATO!");
            }
            else
            {
                Console.WriteLine("NÃO, UTILIZE OUTRO PORTA RETRATO!");
            }
            Console.ReadLine();
        }
    }
}
