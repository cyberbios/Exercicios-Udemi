using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Juãn");
            lista.Add("Craudia");
            lista.Add("Prênia");
            lista.Add("Pilania");

            lista.Remove("Juãn");
            lista.RemoveAt(2);

            int pos = lista.FindIndex(x => x == "Craudia");
            Console.WriteLine("Posição da Craudia é " + pos);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
