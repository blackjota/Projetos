using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Polimorfismo
{
   public class Gorila : Mamifero
   {
       public override void Andar()
       {
           Console.WriteLine("Anda com 2 patas");
       }
   }
}
