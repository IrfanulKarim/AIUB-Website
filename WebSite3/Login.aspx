<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>

        

        <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me" />
        <p>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />


        </p>
        <p>

            <a href="ForgetPass.aspx?" >Forget password ?</a>
        </p>
    </form>
</body>
</html>
