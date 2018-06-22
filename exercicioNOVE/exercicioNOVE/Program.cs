using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioNOVE
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double tempoTotal, tempoJogado, tempoRestante;

            tempoTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N = int.Parse(Console.ReadLine());

            tempoRestante = tempoTotal;
            for (int i = 0; i < N; i++)
            {
                tempoJogado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                tempoRestante = tempoRestante - tempoJogado;
                if(tempoRestante < 0.0)
                {
                    Console.WriteLine("RECARREGAR!");
                }
                else
                {
                    Console.WriteLine(tempoRestante);
                }
            }
            Console.ReadLine();
        }
    }
}
//Alexandre está se mordendo de vontade de jogar muito vídeo game depois das provas finais do primeiro trimestre. Entretanto, ele quer se prevenir de ficar sem bateria para o controle do vídeo game.Para isso, ele deseja se planejar, recarregando completamente a bateria do controle do vídeo game, e fazendo um acompanhamento de tempo a cada vez que for jogar. Assim, ele deseja informar quantas vezes pretende jogar, e quanto tempo vai jogar em cada vez. Você deve construir um programa que informa o tempo restante de cada vez que ele for jogar.
//Entrada:
//A entrada consiste do tempo total de duração da bateria completamente recarregada(em horas - ponto flutuante com uma casa decimal), seguido de um número inteiro N indicando quantas vezes Alexandre pretende jogar, seguido dos tempos que ele vai jogar em cada vez(em horas - ponto flutuante com uma casa decimal).
//Saída:
//A saída é composta do tempo restante de duração da bateria a cada vez que Alexandre for jogar(em horas - ponto flutuante com uma casa decimal). Se o tempo restante da bateria não for suficiente para uma determinada vez que Alexandre for jogar, mostrar a palavra "recarregar".