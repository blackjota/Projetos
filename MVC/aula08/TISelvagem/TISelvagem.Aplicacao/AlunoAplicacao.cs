using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TiSelvagem.Repositorio;
using TISelvagem.Dominio;

namespace TISelvagem.Aplicacao
{
    public class AlunoAplicacao
    {
        private Contexto _contexto;

        private void Inserir(Aluno aluno)
        {
            var strQuery = "";
            strQuery += " INSERT INTO ALUNO (Nome, Mae, DataNascimento) ";
            strQuery += $" VALUES ('{aluno.Nome}','{aluno.Mae}','{aluno.DataNascimento}') ";
            using (_contexto = new Contexto())
            {
                _contexto.ExecutaComando(strQuery);
            }
        }

        private void Alterar(Aluno aluno)
        {
            var strQuery = "";
            strQuery += " UPDATE ALUNO SET ";
            strQuery += $" Nome = '{aluno.Nome}', ";
            strQuery += $" Mae = '{aluno.Mae}', ";
            strQuery += $" DataNascimento = '{aluno.DataNascimento}' ";
            strQuery += $" WHERE AlunoId = {aluno.Id} ";
            using (_contexto = new Contexto())
            {
                _contexto.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Aluno aluno)
        {
            if (aluno.Id > 0)
                Alterar(aluno);
            else
                Inserir(aluno);
        }

        public void Excluir(int id)
        {
            using (_contexto = new Contexto())
            {
                var strQuery = $" DELETE FROM ALUNO WHERE AlunoId = {id}";
                _contexto.ExecutaComando(strQuery);
            }
        }

        public List<Aluno> ListarTodos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = " SELECT * FROM ALUNO ";
                var retornoDataReader = _contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        public Aluno ListarPorId(int id)
        {
            using (_contexto = new Contexto())
            {
                var strQuery = $" SELECT * FROM ALUNO WHERE AlunoId = {id} ";
                var retornoDataReader = _contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }

        private List<Aluno> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var alunos = new List<Aluno>();
            while (reader.Read())
            {
                var temObjeto = new Aluno()
                                    {
                                        Id = int.Parse(reader["AlunoId"].ToString()),
                                        Nome = reader["Nome"].ToString(),
                                        Mae = reader["Mae"].ToString(),
                                        DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString())
                                    };
                alunos.Add(temObjeto);
            }
            reader.Close();
            return alunos;
        }
    }
}
