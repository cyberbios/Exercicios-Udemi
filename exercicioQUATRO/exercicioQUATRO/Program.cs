using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioQUATRO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler a quantidade de glicose no sangue de uma pessoa e depois mostrar na tela a classificação desta        glicose de acordo com a tabela de referência ao lado.
            //Entrada: A entrada contém o valor de glicose com uma casa decimal.
            //Saída: A saída contém a classificação da glicose.

            double glicose;
            Console.WriteLine("===== TABELA DE CLASSIFICAÇÃO DE GLICOSE =====\n");
            Console.WriteLine("===== CLASSIFICAÇÃO              GLICOSE =====\n");
            Console.WriteLine("         Normal                Até 100mg/dl");
            Console.WriteLine("        Elevado          Maior que 100 até 140mg/dl");
            Console.WriteLine("       Diabetes              Maior de 140mg/dl");

            glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(glicose <= 100.0)
            {
                Console.WriteLine("Resultado do exame NORMAL");
            }
            else if(glicose <= 140.0){
                Console.WriteLine("Cuidado, índice de glicose ELEVADO");
            }
            else {
                Console.WriteLine("DIABETES");
            }
            Console.ReadLine();
        }
    }
}
