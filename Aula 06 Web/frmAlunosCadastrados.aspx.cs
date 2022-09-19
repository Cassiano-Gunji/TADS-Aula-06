using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aula_06.dal;

namespace Aula_06_Web
{
    public partial class frmAlunosCadastrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Aluno> alunos = AlunoDao.consulteAlunos();
                lbxDados.Items.Clear();

                foreach (Aluno aluno in alunos)
                {
                    lbxDados.Items.Add(aluno.Id.ToString());
                } 
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Aluno aluno = AlunoDao.procureAluno(Convert.ToInt32(lbxDados.SelectedItem.ToString()));
            if (aluno != null)
            {
                txtId.Text = aluno.Id.ToString();
                txtNome.Text = aluno.Nome;
                txtCurso.Text = aluno.Curso;
            }

        }
    }
}