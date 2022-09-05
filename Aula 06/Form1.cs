using Aula_06.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            frmAlunosCadastrados f2 = new frmAlunosCadastrados();
            f2.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(Convert.ToInt32(txtId.Text), txtNome.Text, txtCurso.Text);
            AlunoDao.insiraAluno(aluno);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCurso.Text = "";

            Aluno aluno = AlunoDao.procureAluno(Convert.ToInt32(txtId.Text));
            if (aluno != null)
            {
                txtNome.Text = aluno.Nome;
                txtCurso.Text = aluno.Curso;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(Convert.ToInt32(txtId.Text), txtNome.Text, txtCurso.Text);
            AlunoDao.atualizeAluno(aluno);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AlunoDao.excluaAluno(Convert.ToInt32(txtId.Text));
        }
    }
}
