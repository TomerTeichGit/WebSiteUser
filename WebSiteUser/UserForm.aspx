<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserForm.aspx.cs" Inherits="WebSiteUser.UserForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxFirstname" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
            <br />
            <br />
            ID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="phone" runat="server"></asp:TextBox>
            <br />
            <br />
            Birth Date&nbsp;&nbsp;&nbsp;
            <input type="date" id="birthdate" runat="server" />
            <br />
            <br />
            City&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="cities" runat="server"></asp:DropDownList>
            <br />
            <br />
            Address&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
            <br />
            <br />
            State&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="state" runat="server"></asp:TextBox>
            <br />
            <br />
            ZIP Code&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="zip" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            USERNAME&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
            PASSWORD&nbsp;&nbsp;&nbsp;
            <input id="password" type="password" runat="server"/><br />
            <br />
            <asp:Button ID="submit" runat="server" Text="SUBMIT" OnClick="submit_Click" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
