using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Aluno
    {
        public string nome;
        public double trimestre1, trimestre2, trimestre3;

        public double notaFinal()
        {
            return trimestre1 + trimestre2 + trimestre3;
        }

        public bool aprovado()
        {
            if(notaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double quantoFaltaParaAprovacao()
        {
            if (aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - notaFinal();
            }
        }
    }
}
