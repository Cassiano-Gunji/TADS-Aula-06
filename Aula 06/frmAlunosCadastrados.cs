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
    public partial class frmAlunosCadastrados : Form
    {
        public frmAlunosCadastrados()
        {
            InitializeComponent();
        }

        private void frmAlunosCadastrados_Load(object sender, EventArgs e)
        {
            List<Aluno> alunos = AlunoDao.consulteAlunos();

            foreach (Aluno aluno in alunos)
            {
                lbxDados.Items.Add(aluno.Id.ToString());
            }
        }

        private void lbxDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno aluno = AlunoDao.procureAluno(Convert.ToInt32(lbxDados.SelectedItem.ToString()));

            if (aluno != null)
            {
                txtId.Text = aluno.Id.ToString();
                txtNome.Text = aluno.Nome.ToString();
                txtCurso.Text = aluno.Curso.ToString();
            }
        }

        private void btnFeche_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
