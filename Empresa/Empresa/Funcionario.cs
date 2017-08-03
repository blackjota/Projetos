using Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Funcionario
    {
        //Construtor ( Construtor em cima das propriedades)
        public Funcionario(string nome, int idade, string rg, double salario)
        {
            Nome = nome;
            Idade = idade;
            Rg = rg;
            Salario = salario;
        }

        public virtual void ExibeDados()
        {
            Console.WriteLine($"{Nome} Idade: {Idade} RG: {Rg} Salario: {Salario}");

        }
        public string Nome;
        public int Idade;
        public string Rg;
        public double Salario;

        

        
    }
}
