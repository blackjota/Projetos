using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados;

            Console.WriteLine("-----ESTE PROGRAMA VERIFICA SE OS NUMEROS INFORMADOS FORMAM UM TRIANGULO-----");
            Console.WriteLine("Informe o lado A: ");
            dados = Console.ReadLine();
            var objeto = new Triangulo();
            objeto.ladoA = Convert.ToInt32(dados);

            Console.WriteLine("Informe o lado B: ");
            dados = Console.ReadLine();
            objeto.ladoB = Convert.ToInt32(dados);

            Console.WriteLine("Informe o lado C: ");
            dados = Console.ReadLine();
            objeto.ladoC = Convert.ToInt32(dados);

            objeto.verificatriangulo();

            Console.ReadKey();

        }             
    }
}
