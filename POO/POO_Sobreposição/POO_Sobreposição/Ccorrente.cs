using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Sobreposição
{
    class Ccorrente : Conta
    {
        public override void Saque(string agencia, string conta, double valor)
        {
            valor = valor - (valor * 0.10);
            base.Saque(agencia, conta, valor);
        }
    }
}
