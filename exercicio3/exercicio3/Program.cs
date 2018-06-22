using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            aluno.trimestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.trimestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.trimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.notaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTAM " + aluno.quantoFaltaParaAprovacao().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
            Console.ReadLine();
        }
    }
}
