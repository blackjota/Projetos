using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Polimorfismo
{
   public class Program
    {
        static void Main(string[] args)
        {
            Mamifero m1 = new Leão();
            m1.Andar();
            Mamifero m2 = new Gorila();
            m2.Andar();

            Console.ReadKey();
        }
    }
}
