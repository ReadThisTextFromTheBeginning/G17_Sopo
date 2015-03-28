<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styleSheet/StyleSheet.less"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <label for="username">Enter new Username:</label>

            <input type="text" id="username" name="username" />

            <label for="password">Enter Your Password:</label>

            <p><a href="#">Forgot your password?</a></p>

            <input type="password" id="password" name="password" />

            <div id="lower">
            <asp:Button ID="BtnLogin" CausesValidation="false"  OnClick="BtnLogin_Click" Text="Login" runat="server" />

            <asp:Button ID="BtnRegister" CausesValidation="true" OnClick="BtnRegister_Click" Text="Register" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
