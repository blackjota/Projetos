using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, string rg, double salario, string autoridade) : base(nome, idade, rg,
            salario)
        {
            Autoridade = autoridade;
        }
        public string Autoridade;
    }
}


