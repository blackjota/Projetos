using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaaritmética_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            var tam = 0;
            var i = 0;
            float media = 0;
            var soma = 0;
            var numpar = 0;

            Console.WriteLine("Quantos numeros deseja inserir? : ");
            tam = int.Parse(Console.ReadLine());

            int[] vet = new int[tam];
            do
            {
                Console.WriteLine($"Insira {tam} numeros desejado: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());

            } while (vet[i] < tam );

            for ( i = 0; i < tam; i++)
            {
                if (vet[i] % 2 == 0)
                    {
                        numpar =+ vet[i];
                        soma = numpar + numpar;
                    }
                media = soma / tam;

            }
            Console.Write($"A media dos numeros pares é {media} ");
            Console.ReadKey();
        }
    }
}
