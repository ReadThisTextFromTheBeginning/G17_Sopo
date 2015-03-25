<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginForm.aspx.cs" Inherits="LoginForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link type="text/css" runat="server" rel="stylesheet" href="/styleSheet/StyleSheet.less" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Begin Page Content -->

        <div id="container">

            <label for="username">Username:</label>

            <input type="text" id="username" name="username" />

            <label for="password">Password:</label>

            <p><a href="#">Forgot your password?</a></p>

            <input type="password" id="password" name="password" />

            <div id="lower">
                <input type="submit" value="Login" />
            </div>
        </div>
    </form>
</body>
</html>
