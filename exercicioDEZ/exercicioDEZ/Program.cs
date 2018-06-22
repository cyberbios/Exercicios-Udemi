using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioDEZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double nota1, nota2, nota3, notaFinal;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                notaFinal = nota1 + nota2 + nota3;
                Console.WriteLine(notaFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
//O curso de Computação Gráfica do IFTM é trimestral, sendo que as notas do ano são divididas em três partes: 30, 35 e 35, totalizando 100 pontos no ano.O professor de programação está querendo automatizar o processo de fechamento de notas, fazendo um programa para somar as notas dos três trimestres de todos alunos da turma.
//Entrada:
//A entrada é composta por um número inteiro N representando a quantidade de alunos da turma, seguida pelas três notas de cada aluno da turma.As notas de um aluno são representadas por três números de ponto flutuante com duas casas decimais.
//Saída:
//A saída mostra a nota final de cada aluno(duas casas decimais).