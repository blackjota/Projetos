using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = {-1.7, 3.0, 0.0, 1.5, 0.0, -1.7, 2.3,-1.7};
            var contador = 0;
            var numsprintados = "";

            for (int j = 0; j < nums.Length; j++)
            {
                if (numsprintados.Contains(nums[j].ToString()))
                    continue;
                    contador = 0;
                for (int i = 0; i < nums.Length; i++) 
                {
                    if (nums[j] == nums[i])
                    {
                        contador++;
                        numsprintados += nums[j].ToString(); 
                    }
                }
                Console.WriteLine($"O numero {nums[j]} , ocorre {contador} vezes");
            }
            Console.WriteLine($"Qtde numeros: {nums.Length}");
            Console.ReadKey();   
        }
    }
}

