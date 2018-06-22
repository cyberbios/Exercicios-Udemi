using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia números inteiros até que um 0 (zero) seja lido. Para cada valor lido, o programa deve mostrar o quadrado do valor.
            //Lembrete: você não precisa ler todos dados para só depois começar a mostrar a saída. Você pode ir lendo um número e mostrando a saída referente a ele, um de cada vez.
            //Entrada:
            //Cada linha contém um número inteiro.
            //Saída:
            //Cada linha contém um número inteiro correspondente ao quadrado do número lido. Não se deve mostrar o quadrado para o número 0.
            int valorLido, quadradoValor;

            valorLido = int.Parse(Console.ReadLine());

            while(valorLido != 0)
            {
                quadradoValor = valorLido * valorLido;
                Console.WriteLine(quadradoValor);
                valorLido = int.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
