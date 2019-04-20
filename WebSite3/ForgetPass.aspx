<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgetPass.aspx.cs" Inherits="ForgetPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forget Password</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>


</head>
<body>

    <form id="form1" runat="server">

    Enter your userName...
    <input type="text" id="userName" runat="server" />

    <p style="color: red">*We will send you a varification code to your email id...</p>

    
     
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>

    
     
</body>
</html>
