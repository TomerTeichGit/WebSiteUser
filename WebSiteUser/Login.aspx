<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebSiteUser.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />

</head>
<body style="direction: ltr" runat="server">
    <form class="login-form" runat="server">
          <p class="login-text">
            <span class="fa-stack fa-lg">
              <i class="fa fa-circle fa-stack-2x"></i>
              <i class="fa fa-lock fa-stack-1x"></i>
            </span>
          </p>
          <asp:TextBox runat="server" class="login-username" autofocus="true" required="true" placeholder="Username" name="username" ID="username"/>
          <asp:TextBox runat="server" class="login-password" required="true" TextMode="Password" placeholder="Password" name="password" ID="password"/>
          <asp:Button runat="server" Text="login" name="Login" value="Login" CssClass="login-submit" OnClick="submit_Click"/>

        </form>
        <a href="#" class="login-forgot-pass">forgot password?</a>
        <div class="underlay-photo"></div>
        <div class="underlay-black"></div> 
</body>
</html>
