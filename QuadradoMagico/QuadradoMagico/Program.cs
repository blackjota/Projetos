using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradoMagico
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int somacol = 0, somalin = 0, somadiagp = 0, somadiads = 0, col1 = 0, col2 = 0, lin1 = 0, lin2 = 0;
        //    int[,] matriz = new int[3, 3] {{2, 9, 4}, {7, 5, 3}, {6, 1, 8}};
        //    var somai = 0;
        //    var aux = 0;

        //    // testar primeira coluna e guardar a soma em uma variavel inicial para comparar 
        //    for (var lin = 0; lin < 3; lin++)
        //        somai += matriz[lin, 0];
        //    Console.WriteLine($"soma da primeira col {somai}");

        //    // somando as linhas
        //    for (var col = 0; col < 3; col++)
        //    {
        //        somalin += matriz[0, col];
        //        lin1 += matriz[1, col];
        //        lin2 += matriz[2, col];
        //    }

        //    //somando as colunas
        //    for (var lin = 0; lin < 3; lin++)
        //    {
        //        somacol += matriz[lin, 0];
        //        col1 += matriz[lin, 1];
        //        col2 += matriz[lin, 2];
        //    }

        //    // somando a diagonalp
        //    for (var lin = 0; lin < 3; lin++)
        //    {
        //        for (var col = 0; col < 3; col++)
        //        {
        //            if (lin == col)
        //            {
        //                somadiagp += matriz[lin, col];
        //            }
        //        }
        //    }

        //    // somnado a diags
        //    for (var lin = 0; lin < 3; lin++)
        //    {
        //        for (var col = 2; col > -1; col--)
        //        {
        //            if (lin + col == 2)
        //                somadiads += matriz[lin, col];
        //        }
        //    }

        //    if ((somai == somacol) && (somai == col1) && (somai == col2) && (somai == somalin) 
        //        && (somai == lin1) && (somai == lin2) && (somai == somadiagp) && (somai == somadiads))
        //        Console.WriteLine("È um quadrado magico");
        //    else
        //        Console.WriteLine("Não é quadrado magico");

        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            var resultado = new int[8];
            var matriz = new[,] { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } };
            var somai = 0;

            // testar primeira coluna e guardar a soma em uma variavel inicial para comparar 
            for (var lin = 0; lin < 3; lin++)
                somai += matriz[lin, 0];
            Console.WriteLine($"soma da primeira col {somai}");


            for (var i = 0; i < 3; i++)
                for (var col = 0; col < 3; col++)
                {
                    resultado[i] += matriz[i, col];// somando as linhas
                    resultado[i + 3] += matriz[col, i];//somando as colunas
                    if (i == col)
                        resultado[6] += matriz[i, col];
                }

            // somnado a diags
            for (var lin = 0; lin < 3; lin++)
                for (var col = 2; col > -1; col--)
                    if (lin + col == 2)
                        resultado[7] += matriz[lin, col];

            for (int i = 0; i < 8; i++)
            {
                if (resultado[i] != somai)
                {
                    Console.WriteLine("Não é quadrado magico");
                    break;
                }
                if (i == 7)
                    Console.WriteLine("È um quadrado magico");
            }
            Console.ReadKey();
        }
    }
}
