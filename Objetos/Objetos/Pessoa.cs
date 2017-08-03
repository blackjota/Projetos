using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Pessoa
    {
        public string nome;
        public double altura;
        public void faleSobreVoce()
        {
            Console.WriteLine($"Olá! Meu nome é {nome} ");
            Console.Write($"Eu tenho {altura} metros de altura ");
        }
    }
}
