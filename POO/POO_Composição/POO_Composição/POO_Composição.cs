using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Composição
{
    public class POO_Composição
    {
        static void Main(string[] args)
        {
            // Composição é quando um objeto é formado por outro objeto

            Roda r1 = new Roda();
            r1.cor = "Branco";
            r1.aro = 22;

            Roda r2 = new Roda();
            r2.cor = "Azul";
            r2.aro = 22;

            Moto minhaMoto = new Moto("Preto",r1,r2);

            //minhaMoto.aMoto();
            Console.ReadKey();
        }
    }
}
