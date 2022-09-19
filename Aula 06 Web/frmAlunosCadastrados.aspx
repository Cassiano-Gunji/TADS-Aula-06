<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAlunosCadastrados.aspx.cs" Inherits="Aula_06_Web.frmAlunosCadastrados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Alunos Cadastrados</h1>
            <table style="width:100%;">
                <tr>
                    <td>Id:<br />
                        <asp:ListBox ID="lbxDados" runat="server"></asp:ListBox>
                        <br />
                        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                    </td>
                    <td>Id:<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                        <br />
                        Nome:<asp:TextBox ID="txtNome" runat="server" Width="414px"></asp:TextBox>
                        <br />
                        Curso:<asp:TextBox ID="txtCurso" runat="server" Width="413px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
    </form>
</body>
</html>
