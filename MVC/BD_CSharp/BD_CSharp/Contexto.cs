using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BD_CSharp
{
    class Contexto : IDisposable
    {
        private readonly SqlConnection minhaConexao;

        public Contexto()
        {
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["TestesConfig"].ConnectionString);
            minhaConexao.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = minhaConexao
            };
        }

        public SqlDataReader ExecCmdComRetorno(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, minhaConexao);
            return cmdComando.ExecuteReader();
        }

        public void Dispose()
        {
            if (minhaConexao.State == ConnectionState.Open)
                minhaConexao.Close();
        }
    }
}
