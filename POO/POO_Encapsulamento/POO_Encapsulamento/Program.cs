using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Encapsulamento
{
   public class POO_Encapsulamento
    {
        static void Main(string[] args)
        {
            Cripto cp = new Cripto();

            cp.setValor("aeiou");

            Console.WriteLine(cp.getValor());

            Console.ReadKey();
        }
    }
}
