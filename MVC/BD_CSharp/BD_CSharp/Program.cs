using System;
using System.Data.SqlClient;

namespace BD_CSharp
{
    class Program
    {
        static void Main()
        {
            var alunoAplicacao = new AlunoAplicacao();
            //Criando string connection 
            SqlConnection minhaConexao = new SqlConnection(@"data source=(localdb)\mssqllocaldb;Integrated Security=SSPI;Initial Catalog=BancoeMVC");
            // abrindo conexao com banco de dados
            minhaConexao.Open();

            //string strQueryUpdate = "UPDATE Aluno SET Nome = 'Samara Leme' WHERE AlunoId = 1";
            //SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, minhaConexao);
            //cmdComandoUpdate.ExecuteNonQuery();

            //string strQueryDelete = "DELETE FROM Aluno WHERE AlunoId = 1005";
            //SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, minhaConexao);
            //cmdComandoDelete.ExecuteNonQuery();

            Console.WriteLine("Digite o Nome do Aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o Nome da Mãe do aluno");
            string nomeMae = Console.ReadLine();
            Console.WriteLine("Digite a data de Nascimento do aluno");
            string dataNasc = Console.ReadLine();

            var aluno = new Aluno
            {
                Nome = nome,
                Mae = nomeMae,
                DataNascimento = DateTime.Parse(dataNasc)
            };

            aluno.Id = 2;
            alunoAplicacao.Alterar(aluno);

            string strQuerySelect = "SELECT * FROM Aluno";
            SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect, minhaConexao);
            SqlDataReader dados = cmdComandoSelect.ExecuteReader();

            while (dados.Read())
            {
                Console.WriteLine($"ID:{dados["AlunoId"]}, Nome:{dados["Nome"]}, Mae:{dados["Mae"]}, DataNascimento:{dados["DataNascimento"]}");
            }
            Console.ReadKey();
        }
    }
}
