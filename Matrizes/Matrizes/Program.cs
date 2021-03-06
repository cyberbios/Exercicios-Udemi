﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int N, cont;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

            for (int j = 0; j< N; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
                Console.WriteLine(mat[i, i] + " ");
            {
                Console.WriteLine();

                cont = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if(mat[i, j] < 0)
                        {
                            cont = cont + 1;
                        }
                    }
                }
                Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
                Console.ReadLine();
            }
        }
    }
}
