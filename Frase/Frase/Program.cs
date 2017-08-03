using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frase
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string palavra;
            var aux = "";
            var cont = 0;
            // Usuario inseri dados
            Console.Write("Insira a frase desejada: ");
            frase = Console.ReadLine();
            Console.Write("Insira a palavra: ");
            palavra = Console.ReadLine();

            // Percorrer a variavel frase
            for (var i=0; i < frase.Length;i++)
            {
                //Percorrer variavel palavra
                //for (var j = 0; j < palavra.Length; j++)
                    if (frase == palavra)
                        aux += palavra;
                        cont++;        
            }

            Console.Write($"A palavra {palavra} aparece {cont} vez na frase {frase}");
            //if(frase.Contains(palavra) == true)
            //{
            //    Console.Write($"A palavra {palavra} aparece na frase {frase}");

            //}
            
            Console.ReadKey();        }
    }
}
