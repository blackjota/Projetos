using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarVetor
{
    class Program
    {
        static void Main(string[] args){
            int[] vet = { 34, 2, 6, 10, 20 };
            int aux;

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[i] > vet[j + 1])
                    {
                        aux = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = aux;
                    }
                }
                Console.Write("Vetor Ordenado : ");
                Console.WriteLine( vet[i]);
            }
            Console.ReadKey();
        }
    }
}
