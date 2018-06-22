using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioFixacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Quantos funcionários serão cadastrados? ");
            N = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();
            for (int i = 1; i <=N; i++)
            {
                Console.WriteLine("Dados do " + i + "º funcionário: ");
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario f = new Funcionario(cpf, nome, salario);
                lista.Add(f);
            }
            Console.WriteLine();
            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            string cpfBuscado = Console.ReadLine();

            int pos = lista.FindIndex(x => x._cpf == cpfBuscado);
            if (pos == -1)
            {
                Console.WriteLine("CPF INEXISTENTE!");
            }
            else
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista[pos].aumentarSalario(porc);
            }
            Console.WriteLine();
            Console.WriteLine("Listagem atualizada de funcionários: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
