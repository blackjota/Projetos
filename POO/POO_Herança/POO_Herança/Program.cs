using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Homem hm = new Homem();
            hm.Idade = 21;
            hm.Nome = "João Guilherme";
            hm.tamanhoBarba = 1;

            Mulher ml = new Mulher();
            ml.Idade = 20;
            ml.Nome = "Maria";
            ml.tamBusto = 20;
        }
    }
}
