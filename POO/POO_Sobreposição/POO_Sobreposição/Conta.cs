using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Sobreposição
{
   public class Conta
    {
        public virtual void Saque(string agencia, string conta, double valor)
        {
            Console.WriteLine($"Saque-- Agencia: {agencia} Conta: {conta} Valor: {valor}");
        }
    }
}
