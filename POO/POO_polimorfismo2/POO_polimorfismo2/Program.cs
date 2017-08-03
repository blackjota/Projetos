using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_polimorfismo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operação op = new Subtração();
            double n1 = 20, n2 = 10;

            new Calcular().mostraResult(op,n1,n2);

            Console.ReadKey();
        }
    }
}
