<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgetPass2.aspx.cs" Inherits="ForgetPass2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form action="#" id="form1" runat="server" class="form-group" onsubmit="return validateForm()">
        Verification Code:
        <input id="vcode" type="text" class="form-control" runat="server"/>
        <br />
        <br />
        Password:
        <input id="password" type="password" class="form-control" runat="server"/>
        <p id="passwordWarning" style="color:red; "></p>
        Confirm Password:
        <input id="confirmPassword" type="password" class="form-control" runat="server"/>
        <p id="cPasswordWarning" style="color:red; "></p>
        <input type="submit" name="Submit" />
       
    </form>
</body>
</html>
