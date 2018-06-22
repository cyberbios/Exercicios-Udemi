using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            double porcentagem;

            Console.WriteLine("     DADOS DO FUNCIONÁRIO     \n");
            Console.Write(" Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write(" Salário bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(" Desconto: ");
            funcionario.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + funcionario);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");

            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.aumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + funcionario);

            Console.ReadLine();
        }
    }
}
