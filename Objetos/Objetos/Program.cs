using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = "";
            
            
            //Criando o obj pessoa
            var pessoa1 = new Pessoa();
            Console.WriteLine("Informe os dados de 3 pessoas");
            Console.WriteLine("Informe o nome da pessoa 1: ");
            dados = Console.ReadLine();
            // Busca a propriedade nome do obj pessoa e atribui o valor de dados pra ele
            pessoa1.nome = dados;
            Console.WriteLine("Informe a altura da pessoa 2: ");
            dados = Console.ReadLine();
            pessoa1.altura = Convert.ToDouble(dados);
            pessoa1.faleSobreVoce();

           var pessoa2 = new Pessoa();
           
            Console.WriteLine("Informe o nome da pessoa 2: ");
            dados = Console.ReadLine();
            pessoa2.nome = dados;
            Console.WriteLine("Informe a altura da pessoa 2: ");
            dados = Console.ReadLine();
            pessoa2.altura = Convert.ToDouble(dados);
            pessoa2.faleSobreVoce();


            Console.ReadKey();
        }
       
    }
}
