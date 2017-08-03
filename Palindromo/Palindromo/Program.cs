using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string invertido = "";

            Console.WriteLine("Digite uma palavra: ");
            var palavra = Console.ReadLine();
            palavra = palavra.ToLower();

            for (var i = palavra.Length - 1; i >= 0; i--)
                invertido += palavra[i].ToString();

            if (palavra == invertido)
                Console.Write("A palavra é um palindromo");
            else
                Console.Write("A palavra nao é um palindromo");

            Console.ReadKey();
        }
    }
}
