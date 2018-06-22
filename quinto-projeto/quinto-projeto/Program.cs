using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace quinto_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler uma quantidade indeterminada de números, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém Um valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos com duas casas decimais. Se for lido um valor negativo já na primeira vez, mostrar a mensagem "IMPOSSÍVEL CALCULAR".
            //Entrada: 31, 27, 46, -5   Saída: 34.67
            //Entrada: -8   Saída: IMPOSSÍVEL CALCULAR

            int idade, soma, cont;
            double media;

            soma = 0;
            cont = 0;

            idade = int.Parse(Console.ReadLine());

            while(idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }

            if(cont == 0)
            {
                Console.WriteLine("IMPOSSÍVEL CALCULAR!");
            }
            media = (double) soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
