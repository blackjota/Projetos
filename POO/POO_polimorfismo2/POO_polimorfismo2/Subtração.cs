using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_polimorfismo2
{
    class Subtração : Operação
    {
        public override double calcular(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
