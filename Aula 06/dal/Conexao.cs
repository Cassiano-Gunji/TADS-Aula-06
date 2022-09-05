using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06.dal
{
    internal class Conexao
    {
        // Vamos nos conectar ao SQL Server e à base de dados
        private static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\banco.mdf;Integrated Security=True";

        // Representa a conexão com o banco
        private static SqlConnection conn = null;

        // Método que permite obter a conexão
        public static SqlConnection GetConnection()
        {
            // Vamos criar a conexão, se uma ainda não existe (Padrão de Projeto Singleton)
            if (conn == null)
            {
                conn = new SqlConnection(connString);

                // Vamos tentar abrir a conexão
                try
                {
                    conn.Open();
                }
                catch (SqlException sqle)
                {
                    conn = null;
                    // Algo deu errado. Precisamos saber o que foi. Então vamos exportar a mensagem de exceção para o console
                    TextWriter erro = Console.Error;
                    erro.WriteLine("***************Depuração*******************\n", sqle.Message);
                }
            }
            return conn;
        }

        public static void closeConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
