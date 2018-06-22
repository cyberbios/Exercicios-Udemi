using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioONZE
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume, comando;

            volume = int.Parse(Console.ReadLine());
            comando = int.Parse(Console.ReadLine());

            while (comando != 0)
            {
                volume = volume + comando;
                if (volume < 0)
                {
                    volume = 0;
                }
                if(volume > 100)
                {
                    volume = 100;
                }
                Console.WriteLine(volume);
                comando = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
//Você foi contratado para fazer um programa que controla o volume de um equipamento de som. O volume do equipamento obedece a uma escala de 0 a 100. O equipamento inicialmente está em um certo volume.Em seguida, podem ser dados comandos de alteração de volume, representados por números inteiros (positivo = aumenta o volume; negativo = diminui o volume). A cada comando, o volume do equipamento deve ser ajustado.Se a medida de alteração do volume ultrapassar algum limite (0 ou 100), então o volume não deve passar do limite.
//Entrada:
//A entrada contem o volume inicial(V) do equipamento(0 ≤ 􀀃 ≤ 100), seguido de vários comandos de alteração(CA) de volume(−100 ≤ 􀀇􀀈 ≤ 100). A entrada termina quando for entrado o valor 0 (zero) para o comando de alteração de volume.Os dados são números inteiros.
//Saída:
//A saída contém os volumes(números inteiros) do equipamento após cada comando de alteração de volume.