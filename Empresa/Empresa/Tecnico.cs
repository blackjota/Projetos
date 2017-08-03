using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Tecnico : Assistente
    {
        public Tecnico(string nome, int idade, string rg, double salario, int numMatricula, double bonusS) : base(nome, idade, rg, salario, numMatricula)
        {
            
            BonusS = bonusS;
        }

        public override void ExibeDados()
        {
            base.ExibeDados();
             Console.WriteLine($"O Assistente Tecnico possui um bonus salarial de: {BonusS}");
        }

        public double BonusS;
        public string Turno;
    }
}
