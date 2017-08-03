using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            
            for(var col = 0; col < 3; col++)
            {
                for (var lin = 0; lin < 3; lin++)
                {
                    Console.WriteLine($"Col: {col} Lin: {lin}");
                    matriz[lin, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Insira um numero: que deseja procurar: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int cont = 0;

            for (var col = 0; col < 3; col++)
            {
                for (var lin = 0; lin < 3; lin++)
                {
                    if (matriz[lin, col] == num)
                        cont++;
                }
            }
            Console.WriteLine($"O numero {num} ocorre {cont} vezes na matriz");
            Console.ReadKey();
        }
    }
}
