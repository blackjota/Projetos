using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Aritimetica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { };
            float media;
            int tam;

            // Pergunta ao usuario quantos numeros deseja inserir
            Console.WriteLine("Quantos numeros deseja inserir? : ");
            tam = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < tam; i++)
            {
                nums[i] = nums[tam];

                Console.Write($"Insira {tam} numeros");
                nums = int.Parse(Console.ReadLine());


            }
            Console.ReadKey();
        }
    }
}
