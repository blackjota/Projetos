using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_polimorfismo2
{
    class Calcular
    {
        public void mostraResult(Operação operação, double n1, double n2)
        {
            double resultado = operação.calcular(n1, n2);
            Console.WriteLine($"Resultado da operação: {resultado}");
        }
    }
}
