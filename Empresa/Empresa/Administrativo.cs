using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Administrativo : Assistente
    {
        public Administrativo(string nome, int idade, string rg, double salario, int numMatricula, string turno) : base(nome, idade, rg, salario, numMatricula)
        {
            Turno = turno;
            
        }

        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine($"Assistente Administrativo turno: {Turno}");
        }

        public string Turno;
    }
    
}
