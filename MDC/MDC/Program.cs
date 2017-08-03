using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            var result = 0;
            var result2 = 0;


            Console.Write("Insira 1° numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o 2° numero: ");
            num2 = int.Parse(Console.ReadLine());

            while(result != 0)
                result = num1 % num2;
                //result2 = num2 \ result;
            Console.WriteLine($"O MDS dos numesros {num1} e {num2} é {result}");


            Console.ReadKey();
        }
    }
}
