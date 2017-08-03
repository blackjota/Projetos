using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj_mediaaluno
{
    class Program
    {
        static void Main(string[] args)
        {
          Aluno objAluno = new Aluno();
            string dados = "";

            Console.WriteLine("Nome do aluno: ");
            dados = Console.ReadLine();
            objAluno.nome = dados;

            Console.WriteLine("Nota 1: ");
            dados = Console.ReadLine();
            objAluno.nota1 = Convert.ToDouble(dados);

            Console.WriteLine("Nota 2: ");
            dados = Console.ReadLine();
            objAluno.nota2 = Convert.ToDouble(dados);

            Console.WriteLine("Nota 3: ");
            dados = Console.ReadLine();
            objAluno.nota3 = Convert.ToDouble(dados);

            Console.WriteLine("Nota 4: ");
            dados = Console.ReadLine();
            objAluno.nota4 = Convert.ToDouble(dados);

            objAluno.exibeMedia();

            Console.ReadKey();
        }
        
    }
}
