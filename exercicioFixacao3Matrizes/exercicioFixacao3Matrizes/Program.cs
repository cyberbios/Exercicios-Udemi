using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao3Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            string[] matriz = Console.ReadLine().Split(' ');
            M = int.Parse(matriz[0]);
            N = int.Parse(matriz[1]);

            int[,] mat = new int[M, N];
            for(int i = 0; i < M; i++)
            {
                matriz = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(matriz[j]);
                }
            }
            int X = int.Parse(Console.ReadLine());
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(mat[i, j] == X)
                    {
                        if(j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if(j < N - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if(i < M - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                        j = N;
                        i = M;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
