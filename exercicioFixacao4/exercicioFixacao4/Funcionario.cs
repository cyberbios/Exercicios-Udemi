using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioFixacao4
{
    class Funcionario
    {
        public string _cpf { get; private set; }
        public string _nome { get; private set; }
        public double _salario { get; private set; }

        public Funcionario(string cpf, string nome, double salario)
        {
            _cpf = cpf;
            _nome = nome;
            _salario = salario;
        }
        public void aumentarSalario(double porcentagem)
        {
            _salario = porcentagem * _salario / 100.0 + _salario;
        }
        public override string ToString()
        {
            return _cpf + ", " + _nome + ", " + _salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
