using Aula_06.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_06_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExibir_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmAlunosCadastrados.aspx");
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(Convert.ToInt32(txtId.Text), txtNome.Text, txtCurso.Text);
            AlunoDao.insiraAluno(aluno);
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Aluno aluno = AlunoDao.procureAluno(Convert.ToInt32(txtId.Text));
            txtNome.Text = "";
            txtCurso.Text = "";
            if(aluno != null)
            {
                txtNome.Text = aluno.Nome;
                txtCurso.Text = aluno.Curso;
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(Convert.ToInt32(txtId.Text), txtNome.Text, txtCurso.Text);
            AlunoDao.atualizeAluno(aluno);
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            AlunoDao.excluaAluno(Convert.ToInt32(txtId.Text));
        }
    }
}