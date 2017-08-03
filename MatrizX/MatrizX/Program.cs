using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5] { {0,0,0,0,0}, {0,0,0,0,0}, {0,0,0,0,0}, {0,0,0,0,0}, {0,0,0,0,0} };

            for (var lin = 0; lin < 5; lin++)
            {
                for (var col = 0; col < 5; col++)
                {
                    //if (lin == 0 && col == 0)
                    //{
                    //    matriz[lin, col] = 1;
                    //}

                    //if (lin == 4 && col == 0)
                    //{
                    //    matriz[lin, col] = 1;
                    //}

                    //if (lin == 0 && col == 4)
                    //{
                    //    matriz[lin, col] = 1;
                    //}

                    //if (lin == 4 && col == 4)
                    //{
                    //    matriz[lin, col] = 1;
                    //}
                    //----------------------------------------------------------------
                    //if ((lin == 0) || (col == 0))
                    //{
                    //    matriz[lin, col] = 1;
                    //}

                    if ((col == 0) || (lin == 0))
                    {
                        matriz[lin, col] = 1;
                    }

                    if ((col == 4) || (lin == 4))
                    {
                        matriz[lin, col] = 1;
                    }
                    Console.Write(matriz[lin, col]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
