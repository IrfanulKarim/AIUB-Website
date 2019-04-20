<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userHome.aspx.cs" Inherits="userHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
</head>
<body>
    <form id="form1" runat="server">
    
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
      <a class="navbar-brand" href="#">Tanvir</a>
      
      <div class="collapse navbar-collapse" id="navbarNav" style="text-align: right;">
        <ul class="navbar-nav mr-auto">

          <li class="nav-item active mr-sm-2">
            <a class="nav-link" href="Page1.aspx">Page1</a>
          </li>
           <li class="nav-item active mr-sm-2">
            <a class="nav-link" href="Page2.aspx">Page2</a>
          </li>

            <li class="nav-item active mr-sm-2">
            <a class="nav-link" href="Logout.aspx">Logout</a>
          </li>
          
        </ul>
      </div>
       </nav>
    
        <h1 id="welcome" runat="server"></h1>
        

    </form>
    
   <img src="AiubPermanentCampus_7.jpg" style="width:100%; height:50%;" />

</body>
</html>
