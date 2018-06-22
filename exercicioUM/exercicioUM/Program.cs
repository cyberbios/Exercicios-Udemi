using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioUM
{
    class Program
    {
        static void Main(string[] args)
        {//Um agricultor precisa aplicar veneno em suas plantações. Para isso ele precisa escolher um frasco e uma bomba para aplicação.O frasco de veneno possui um volume de veneno líquido medido em ml(mililitro).Já a bomba de aplicação possui uma vazão* medida em ml/ s(mililitro por segundo).O agricultor deseja saber: dado o volume inicial de um frasco de veneno(em ml), a vazão da bomba(em ml/ s), e um tempo(em s), qual volume de veneno restará no frasco após o uso da bomba durante este tempo? * Vazão, neste contexto, significa o quanto a bomba consegue bombear em um certo intervalo de tempo.
         //A entrada possui três números inteiros representando  respectivamente: o volume inicial de um frasco de veneno (em ml), a vazão da bomba(em ml/ s), e um tempo(em s).
         //A saída contém um número inteiro representando o volume de veneno (em ml) restante no frasco depois o uso da bomba durante o tempo informado. Se o volume do frasco não for suficiente, mostre a mensagem "nao eh possivel".

            int volumeInicial, vazao, tempo, volumeFinal;

            volumeInicial = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            if(vazao * tempo > volumeInicial)
            {
                Console.WriteLine("NÃO É POSSÍVEL, VENENO INSUFICIENTE!");
            }
            else
            {
                volumeFinal = volumeInicial - (vazao * tempo);
                Console.WriteLine("APÓS O USO SOBRARÁ " + volumeFinal + "ml DE VENENO NO FRASCO!");
            }
            Console.ReadLine();
        }
    }
}
