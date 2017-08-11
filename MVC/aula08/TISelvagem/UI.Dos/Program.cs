using System;
using TISelvagem.Aplicacao;
using TISelvagem.Dominio;

namespace UI.Dos
{
    class Program
    {
        static void Main()
        {
            var appAluno = new AlunoAplicacao();

            Console.Write("Digite o nome do aluno: ");
            var nome = Console.ReadLine();

            Console.Write("Digite o nome da mãe do aluno: ");
            var mae = Console.ReadLine();

            Console.Write("Digite a data de nascimento do aluno: ");
            var data = Console.ReadLine();

            var aluno1 = new Aluno
                            {
                                Nome = nome,
                                Mae = mae,
                                DataNascimento = DateTime.Parse(data)
                            };

            appAluno.Salvar(aluno1);

            var dados = appAluno.ListarTodos();

            foreach (var aluno in dados)
            {
                Console.WriteLine($"Id:{aluno.Id}, Nome:{aluno.Nome}, Mae:{aluno.Mae}, DataNascimento:{aluno.DataNascimento}");
            }
        }
    }
}
