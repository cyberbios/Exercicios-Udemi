using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao2
{
    class Aluguel
    {
        public string nome { get; set; }
        public string email { get; set; }

        public Aluguel(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
        public override string ToString()
        {
            return nome + ", " + email;
        }
    }
}
