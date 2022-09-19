using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06.dal
{
    public class AlunoDao
    {
        public static bool insiraAluno(Aluno aluno)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "INSERT INTO alunos (Id, nome, curso) VALUES (@id, @nome, @curso)";
            SqlCommand comando = new SqlCommand(comandoSql, Conexao.GetConnection());

            // Configuração dos parâmetros do comando SQL
            SqlParameter idAluno = new SqlParameter("@Id", System.Data.SqlDbType.Int, 0);
            SqlParameter nomeAluno = new SqlParameter("@nome", System.Data.SqlDbType.Text, 80);
            SqlParameter cursoAluno = new SqlParameter("@curso", System.Data.SqlDbType.Text, 150);

            // Atribuição dos valores aos parâmetros do comando SQL
            idAluno.Value = aluno.Id;
            nomeAluno.Value = aluno.Nome;
            cursoAluno.Value = aluno.Curso;

            // Adição dos parâmetros ao comando SQL
            comando.Parameters.Add(idAluno);
            comando.Parameters.Add(nomeAluno);
            comando.Parameters.Add(cursoAluno);

            // Compila a instrução e a submete ao banco de dados
            comando.Prepare();
            retorno = comando.ExecuteNonQuery();

            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();
            return resultado;
        }
        public static Aluno procureAluno(int id)
        {
            Aluno aluno = null;

            string comandoSql = "SELECT Id, nome, curso FROM alunos WHERE Id = @id";
            SqlCommand comando = new SqlCommand(comandoSql, Conexao.GetConnection());

            // Configuração dos parâmetros do comando SQL
            SqlParameter idAluno = new SqlParameter("@id", System.Data.SqlDbType.Int, 0);

            // Atribuição dos valores aos parâmetros do comando SQL
            idAluno.Value = id;

            // Adição dos parâmetros ao comando SQL
            comando.Parameters.Add(idAluno);

            // Compila a instrução e a submente ao banco de dados, armazenando o retorno
            comando.Prepare();
            SqlDataReader leitor = comando.ExecuteReader();

            if (leitor.HasRows)
            {
                leitor.Read();
                aluno = new Aluno(Convert.ToInt32(leitor["Id"]), leitor["nome"].ToString(), leitor["curso"].ToString());
            }
            leitor.Close();
            comando.Dispose();

            return aluno;
        }
        public static bool atualizeAluno(Aluno aluno)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "UPDATE alunos SET nome=@nome, curso=@curso WHERE Id=@id";
            SqlCommand comando = new SqlCommand(comandoSql, Conexao.GetConnection());

            // Configuração dos parâmetros do comando SQL
            SqlParameter id = new SqlParameter("@id", System.Data.SqlDbType.Int, 0);
            SqlParameter nome = new SqlParameter("@nome", System.Data.SqlDbType.Text, 80);
            SqlParameter curso = new SqlParameter("@curso", System.Data.SqlDbType.Text, 150);

            // Atribuição dos valores aos parâmetros do comando SQL
            id.Value = aluno.Id;
            nome.Value = aluno.Nome;
            curso.Value = aluno.Curso;

            // Adição dos parâmetros ao comando SQL
            comando.Parameters.Add(id);
            comando.Parameters.Add(nome);
            comando.Parameters.Add(curso);

            // Compila a instrução e a submete ao banco de dados
            comando.Prepare();
            retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();

            return resultado;
        }
        public static bool excluaAluno(int id)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "DELETE FROM alunos WHERE Id=@id";
            SqlCommand comando = new SqlCommand(comandoSql, Conexao.GetConnection());

            // Configuração dos parâmetros do comando SQL
            SqlParameter idAluno = new SqlParameter("@id", System.Data.SqlDbType.Int, 0);

            // Atribuição dos valorees aos parâmetros do comando SQL
            idAluno.Value = id;

            // Adição dos parâmetros ao comando SQL
            comando.Parameters.Add(idAluno);

            // Compila a instrução e a submete ao banco de dados
            comando.Prepare();
            retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();

            return resultado;
        }
        public static List<Aluno> consulteAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            string comandoSql = "SELECT Id, nome, curso FROM alunos";
            SqlCommand comando = new SqlCommand(comandoSql, Conexao.GetConnection());

            // Compila a instrução e a submete ao banco de dados
            comando.Prepare();
            SqlDataReader leitor = comando.ExecuteReader();

            // Recupera os dados retornados pelo banco de dados
            Aluno aluno;
            while (leitor.Read())
            {
                aluno = new Aluno(Convert.ToInt32(leitor["Id"]), leitor["nome"].ToString(), leitor["curso"].ToString());
                alunos.Add(aluno);
            }
            leitor.Close();
            comando.Dispose();

            return alunos;
        }
    }
}
