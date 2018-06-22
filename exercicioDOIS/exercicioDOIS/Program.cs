using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioDOIS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deseja-se fazer um programa para calcular a nota final de um estudante, considerando as três notas que ele tirou nos três trimestres de seu curso.Caso a nota final do estudante seja menor que 60.00, deve - se mostrar uma mensagem "DEPENDENCIA" também.
            //Entrada: A entrada possui as três notas do estudante, com duas casas decimais.
            //Saída: A saída possui a nota final do estudante com duas casas decimais. Caso a nota seja menor que 60.00, a saída também possui a mensagem "DEPENDENCIA".
            double N1, N2, N3, NotaFinal;

            string[] vet = Console.ReadLine().Split(' ');
            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            NotaFinal = N1 + N2 + N3;

            Console.WriteLine(NotaFinal.ToString("F2", CultureInfo.InvariantCulture));
            
            if (NotaFinal < 60.00)
            {
                Console.WriteLine("DEPENDÊNCIA!");
            }
            else
            {
                Console.WriteLine("APROVADO!");
            }
            Console.ReadLine();
        } 
    }
}
