using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace sexto_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler um número inteiro N e depois ler N pares de números com ponto flutuante com uma casa decimal. Para cada par de números lido, mostrar o resultado da divisão do primero pelo segundo, com três casas decimais. Se a divisão não for possível, exibir uma mensagem "NÃO EXISTE."
            //Lembrete: você não precisa ler todos os dados para só depois começar a mostrar a saída. Você pode ir lendo cada par de números e ir mostrando a saída referente a ele, uma de cada vez.
            //Exemplos: 
            // Entradas: 3 ----- 6.0 e 3.0 ----- 14.3 e 0.0 -----3.2 e 2.5
            // Saídas: 2.000 ----- não existe ------ 1.280

            int N;
            double x, y, resultado;

            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if (y == 0.0)
                {
                    Console.WriteLine("NÃO EXISTE!");
                }
                else
                {
                    resultado = x / y;
                    Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
