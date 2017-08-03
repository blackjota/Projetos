using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Composição
{
    public class Moto
    {
        private string cor;
        private Roda roda1;
        private Roda roda2;


        public Moto(string _cor, Roda _roda1, Roda _roda2)
        {
            cor = _cor;
            roda1 = _roda1;
            roda2 = _roda2;
        }
        //public void aMoto()
        //{
        //    Console.WriteLine($"A sua moto é da cor {cor} e rodas {roda1} {roda1}");
        //}
    }

}
