using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioSEIS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler dois números inteiros e mostrar a soma de todos os números ímpares entre eles, inclusive eles próprios.
            //Entrada:
            //A entrada consiste de dois números inteiros, sendo o primeiro menor ou igual ao segundo(ou seja: não precisa se preocupar em verificar qual dos dois números é o menor ou o maior).
            //Saída:
            //A saída consiste de um número inteiro representando a soma.
            int a, b, soma;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            soma = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0){
                // testa se i é par
                soma = soma + i;
            }
        }
        Console.WriteLine(soma);

        Console.ReadLine();
        }
    }
}
