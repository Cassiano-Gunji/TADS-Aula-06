<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Aula_06_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro de Alunos</h1>
            <p>Usuário: <asp:Label ID="lblLogin" runat="server" Text="Label"></asp:Label>
                , permissão: <asp:Label ID="lblPermissao" runat="server" Text="Label"></asp:Label></p>
            <p>Id:
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </p>
            <p>Nome:
                <asp:TextBox ID="txtNome" runat="server" Width="397px"></asp:TextBox>
            </p>
            <p>Curso:
                <asp:TextBox ID="txtCurso" runat="server" Width="402px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnExibir" runat="server" Text="Exibir" OnClick="btnExibir_Click" />
            </p>
            <p>
                <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
            </p></div>
    </form>
</body>
</html>
