using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TiSelvagem.Repositorio
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection _minhaConexao;

        public Contexto()
        {
            _minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["TISelvagemConfig"].ConnectionString);
            _minhaConexao.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = _minhaConexao
            };
            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, _minhaConexao);
            return cmdComando.ExecuteReader();
        }

        public void Dispose()
        {
            if (_minhaConexao.State == ConnectionState.Open)
                _minhaConexao.Close();
        }
    }
}
