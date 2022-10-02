using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06.dal
{
    public class Usuario
    { 
        // Atributos
        private int id;
        private string login;
        private string senha;
        private string permissao;

        // Propriedades
        public int Id { get => id; }
        public string Login { get => login;  }
        public string Senha { get => senha;  }
        public string Permissao { get => permissao;  }

        // Construtores
        internal Usuario(int id, string login, string senha, string permissao)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.permissao = permissao;
        }
    }
}
