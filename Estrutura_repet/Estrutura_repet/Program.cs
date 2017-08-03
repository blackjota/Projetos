using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordena_vet
{
    class Program
    {
        static void Main(string[] args){
            int[] vet = { 34, 2, 6, 10, 2 };
            int aux = 0;

            for (int i = 0; i < vet.Length; i++){
                for (int j = 0; j < vet.Length - 1; j++) {
                    if (vet[j] > vet[j + 1]) {
                        aux = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = aux;
                    }
                }
                Console.Write(vet[i]);
            }
        }


