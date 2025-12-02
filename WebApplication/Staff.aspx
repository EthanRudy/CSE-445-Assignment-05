<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="WebApplication.Staff" %>
<%@ Register Src="~/Controls/Captcha.ascx" TagPrefix="uc" TagName="Captcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 6 - Staff Page</title>
    <style>
        .section {
            border: 1px solid #999;
            padding: 15px;
            margin-bottom: 20px;
            width: 450px;
        }
        .title {
            width: 50%;
            font-size: 20px;
            font-weight: bold;
            margin: 10px;
            display: flex;
            flex-direction: row;
            justify-content: space-around;
        }

    </style>
</head> 
<body>
    <form id="form1" runat="server">
        <div class="title">
            <asp:Label ID="lblTitle" runat="server" Text="Assignment 5: Hotel Booking Site"></asp:Label>
            <asp:HyperLink ID="lnkStaff" runat="server" NavigateUrl="~/Staff.aspx">Staff Sign in</asp:HyperLink>
        </div>

        <asp:Panel ID="pnlSignIn" runat="server" Visible="true">
            <div class="section">
                <table>
                    <!-- Username -->
                    <tr>
                        <td><asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label></td>
                        <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                    </tr>

                    <!-- Password -->
                    <tr>
                        <td><asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label></td>
                        <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                    </tr>

                    <!-- Button -->
                    <tr>
                        <td><asp:Button ID="btnSignIn" runat="server" Text="Sign In"/></td>
                    </tr>
                </table>
            </div>
        </asp:Panel>

        <asp:Panel ID="pnlMain" runat="server" Visible="false">
            <div class="section">
                <h1>Admin goodies here!</h1>
            </div>
        </asp:Panel>

    </form>
</body>
</html>
