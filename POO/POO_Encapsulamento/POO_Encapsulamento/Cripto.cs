using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Encapsulamento
{
    public class Cripto
    {
        private string valor;    
        public void setValor(string txt)
        {
            valor = txt.Replace('a', '1');
        }

        public string getValor()
        {
            return valor;
        }

    }
}
