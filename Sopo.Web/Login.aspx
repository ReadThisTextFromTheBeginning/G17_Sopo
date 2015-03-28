<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Login</title>
    <link type="text/css" runat="server" rel="stylesheet" href="/styleSheet/StyleSheet.less" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Begin Page Content -->

        <div id="container">

            <label for="username">Username:</label>

            <input id="username" type="text" name="username" />

            <label for="password">Password:</label>

            <p><a href="#">Forgot your password?</a></p>

            <input id="password" type="password" name="password" />

            <div id="lower">
            <asp:Button ID="Login" CausesValidation="true" OnClick="BtnLogin_Click" Text="Login" runat="server" />
            <asp:Button ID="Register" CausesValidation="false" OnClick="BtnLogin_Click" Text="Register" runat="server" />

                <%--<input id="BtnLogin" type="submit" value="Login" onsubmit="BtnLogin_Click" />--%>
            </div>
        </div>
    </form>
</body>
</html>
