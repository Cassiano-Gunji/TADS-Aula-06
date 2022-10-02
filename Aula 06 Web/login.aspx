<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Aula_06_Web.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Log-in</h1>
            <p>Usuário: <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox></p>
            <p>Senha: <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox></p>
            <p>
                <asp:Label ID="lblErro" runat="server" ForeColor="Red"></asp:Label></p>
            <p>
                <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" /></p>
        </div>
        
    </form>
</body>
</html>
