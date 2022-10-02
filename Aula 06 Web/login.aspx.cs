using Aula_06.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_06_Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Valida o login e a senha
            Usuario usuario = UsuarioDao.validaLogin(txtLogin.Text.ToString(), txtSenha.Text.ToString());
            // Se o login é válido, armazena o nível de acesso como um valor de sessão
            if(usuario != null)
            {
                Session["permissao"] = usuario.Permissao;
                Session["login"] = usuario.Login;
                Response.Redirect("default.aspx");
            }
            else
            {
                lblErro.Text = "Nome de usuário ou senha inválidos.";
            }
        }
    }
}