using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06.dal
{
    public class UsuarioDao
    {
        public static Usuario validaLogin(string login, string senha)
        {
            Usuario usuario = null;

            string comandoSql = "SELECT id, login, senha, permissao FROM usuarios WHERE login = @login AND senha = @senha";
            SqlCommand comando = new SqlCommand(comandoSql, Conexao.GetConnection());

            // Criação dos parâmetros do comando
            SqlParameter parLogin = new SqlParameter("@login", System.Data.SqlDbType.VarChar, 10);
            SqlParameter parSenha = new SqlParameter("@senha", System.Data.SqlDbType.VarChar, 10);

            // Atribuição dos valores aos parâmetros
            parLogin.Value = login;
            parSenha.Value = senha;

            // Atribuição dos parâmetros ao comando
            comando.Parameters.Add(parLogin);
            comando.Parameters.Add(parSenha);

            // Compila o comando e o submete ao banco de dados
            comando.Prepare();
            SqlDataReader leitor = comando.ExecuteReader();

            // Se a consulta trouxe resultados, prepara a saída
            if (leitor.Read())
            {
                usuario = new Usuario(Convert.ToInt32(leitor["Id"]), leitor["login"].ToString(),
                    leitor["senha"].ToString(), leitor["permissao"].ToString());
            }

            // Limpeza
            leitor.Close();
            comando.Dispose();

            return usuario;
        }
    }
}
