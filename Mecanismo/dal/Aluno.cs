using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06.dal
{
    public class Aluno
    {
        // Atributos
        private int id;
        private string nome;
        private String curso;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Curso { get => curso; set => curso = value; }

        // Construtores
        public Aluno(int id, string nome, string curso)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
        }

    }
}
