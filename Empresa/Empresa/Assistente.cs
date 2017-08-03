using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Assistente : Funcionario
    {
        public int NumMatricula;

        // base = classe mãe no caso Funcionario. 
        public Assistente(string nome, int idade, string rg, double salario, int numMatricula) : base(nome, idade, rg, salario)
        { 
            NumMatricula = numMatricula;
        }
    }
}
