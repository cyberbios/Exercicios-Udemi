using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace oitavo_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int qte;
            Produto P;
            
            Console.WriteLine("===DIGITE OS DADOS DO PRODUTO===");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade em estoque: ");
            //int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            //P = new Produto(nome, preco, quantidadeEmEstoque);
            P = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizaEntrada(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que sairam do estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizaSaida(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + P);

            Console.ReadLine();
        }
    }
}
