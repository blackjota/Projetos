using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Obj_mediaaluno
{
    public class Aluno
    {
        private string _nome;

        public void Nome(string nome)
        {

            _nome = nome;
        }
                  

        private double _nota1;
        public void Nota1(double nota1)
        {
            _nota1 = nota1;
        }

        private double _nota2;

        public void Nota2(double nota2)
        {
            _nota2 = nota2;
        }

        private double _nota3;
        public void Nota3(double nota3)
        {
            _nota3 = nota3;
        }

        private double _nota4;
        public void Nota4 (double nota4)
        {
            _nota4 = nota4;
        }

        public double media()
        {
            return Nota1, _nota2, Nota3 , Nota4) / 4;
        }

        public void exibeMedia()
        {
            Console.Clear();
            Console.WriteLine($"Aluno: {this._nome} ");
            Console.WriteLine($"Média: {this.media()}");  
        }

    }
 }
    