<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>

    <style>

        body{
            padding-left: 20%;
            padding-right: 20%;
        }

    </style>

</head>

<body>
    
    <h2 style="text-align:center;">REGISTRATION</h2>

    <form action="#" id="form1" runat="server" class="form-group" onsubmit="return validateForm()">
        User Name:
        <input id="userName" type="text" class="form-control" runat="server"/>
        <p id="userNameWarning" style="color:red; text-decoration: bold;"></p>
        Email:
        <input id="email" type="email" class="form-control" runat="server"/>
        <p id="emailWarning" style="color:red; text-decoration: bold;"></p>
        Password:
        <input id="password" type="password" class="form-control" runat="server"/>
        <p id="passwordWarning" style="color:red; text-decoration: bold;"></p>
        Confirm Password:
        <input id="confirmPassword" type="password" class="form-control" runat="server"/>
        <p id="cPasswordWarning" style="color:red; text-decoration: bold;"></p>
        <input type="submit" name="Submit" />
       
    </form>
    


</body>
</html>

<script type="text/javascript">
	
	function validateForm(){
        document.getElementById("userNameWarning").innerHTML = "";

		if(document.getElementById("userName").value.trim() === ""){
			document.getElementById("userNameWarning").innerHTML="*User Name can not be empty...";			
			return false;
		}

        if(document.getElementById("email").value.trim() === ""){
			document.getElementById("emailWarning").innerHTML="*Email can not be empty...";			
			return false;
        }

        if(document.getElementById("password").value.trim() === ""){
			document.getElementById("passwordWarning").innerHTML="*Password can not be empty...";			
			return false;
        }

        if(document.getElementById("confirmPassword").value.trim() === ""){
			document.getElementById("cPasswordWarning").innerHTML="*Confirm password can not be empty...";			
			return false;
		}

		return true;

		
	}



</script>


