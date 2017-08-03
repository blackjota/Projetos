using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public void verificatriangulo()
        {
            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))
            {
                Console.WriteLine("Os numeros formam um triangulo!!!!");
            }
            else
            {
                Console.WriteLine("Os numeros informados não formam um triangulo !!!!");
            }
        }
        
            
    }
}
