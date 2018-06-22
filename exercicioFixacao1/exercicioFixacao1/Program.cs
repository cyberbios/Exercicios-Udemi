using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta X;
            Console.Write("Digite o Número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Titular da Conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá Depósito Inicial (s/n)? ");
            char ch = char.Parse(Console.ReadLine());
            if(ch == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double valorInicial = valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                X = new Conta(numero, nome, valorInicial);
            }
            else
            {
                X = new Conta(numero, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Conta Criada: \n");
            Console.WriteLine(X);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.depositar(dep);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada: \n");
            Console.WriteLine(X);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.sacar(saq);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada: \n");
            Console.WriteLine(X);
            
            
            Console.ReadLine();
        }
    }
}
