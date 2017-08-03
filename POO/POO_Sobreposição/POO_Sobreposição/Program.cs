using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Sobreposição
{
    class Program
    {
        static void Main(string[] args)
        {
            Poupanca p1 = new Poupanca();
            p1.Saque("44444-1","2525-2",200);

           Ccorrente c1 = new Ccorrente();
            c1.Saque("88888-1", "3030-5", 200);

            Console.ReadKey();
        }
    }
}
