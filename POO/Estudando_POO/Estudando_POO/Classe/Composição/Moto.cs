using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando_POO.Classe.Composição
{
    public class Moto
    {
        private string cor;
        Roda roda1;
        Roda roda2;

        //Criando construtor da classe moro
        public Moto(string _cor,Roda _roda1 ,Roda _roda2)
        {
            cor = _cor;
            roda1 = _roda1;
            roda2 = _roda2;

        }


    }
}
