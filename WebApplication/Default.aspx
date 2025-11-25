<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>
<%@ Register Src="~/Controls/Captcha.ascx" TagPrefix="uc" TagName="Captcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 5 - TryItPage</title>
    <style>
        .section {
            border: 1px solid #999;
            padding: 15px;
            margin-bottom: 20px;
            width: 450px;
        }
        .title {
            font-size: 20px;
            font-weight: bold;
            margin-bottom: 10px;
            display: block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:HyperLink ID="lnkMember" runat="server" NavigateUrl="~/Member.aspx" Text="Go to Member" />
        <br /><br />
        <asp:HyperLink ID="lnkStaff"  runat="server" NavigateUrl="~/Staff.aspx"  Text="Go to Staff"  />


        <!-- Description & Component Table -->
        <div class="section">
            <span class="title">Service Directory (Assignment 5)</span>
            <asp:Label ID="lblDescription" runat="server" Text="This application is a refresher as I used Assignment 3 as my skip. It ill eventually include Member and Staff pages (Assignment 6). For assignment 5 this page allows for testing of components and services"></asp:Label>
            <table>
                <tr>
                    <th>Component/Service</th>
                    <th>Description</th>
                </tr>
                <tr>
                    <td>Cookie Management</td>
                    <td>Demonstrates setting, reading, and deleting cookies.</td>
                </tr>
                <tr>
                    <td>Captcha User Control</td>
                    <td>Custom user control for CAPTCHA verification.</td>
                </tr>
                <tr>
                    <td>WebStrar Utility Class</td>
                    <td>Utility functions for string manipulation and arithmetic operations. This highlights the ability to communicate with WebStrar.</td>
                </tr>
            </table>
        </div>


        <!-- Cookie TryIt Section -->
        <div class="section">
            <span class="title">Cookie TryIt</span>

            <table>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="txtCookieName" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Favorite Color:</td>
                    <td><asp:TextBox ID="txtCookieColor" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
            </table>

            <br /><br />

            <asp:Button ID="btnSaveCookie" runat="server" Text="Save Cookie" OnClick="btnSaveCookie_Click" />
            &nbsp;
            <asp:Button ID="btnReadCookie" runat="server" Text="Read Cookie" OnClick="btnReadCookie_Click" />
            &nbsp;
            <asp:Button ID="btnDeleteCookie" runat="server" Text="Delete Cookie" OnClick="btnDeleteCookie_Click" />

            <br /><br />

            <asp:Label ID="lblCookieResult" runat="server" Text="" ForeColor="Blue"></asp:Label>
        </div>


        <!-- Captcha TryIt Section -->
        <div class="section">
            <span class="title">Captcha User Control TryIt</span>

            <uc:Captcha ID="CaptchaControl" runat="server" />

            <br /><br />
            <asp:Button ID="btnVerifyCaptcha" runat="server" Text="Verify" OnClick="btnVerifyCaptcha_Click" />
            &nbsp;
            <asp:Button ID="btnRefreshCaptcha" runat="server" Text="Refresh" OnClick="btnRefreshCaptcha_Click" />

            <br /><br />
            <asp:Label ID="lblCaptchaResult" runat="server" Text="" ForeColor="Blue"></asp:Label>
        </div>

        <!-- WebStrar TryIt Section -->
        <div class="section">
            <span class="title">WebStrar TryIt</span>

            <!-- Count Chars -->
            <table>
                <tr>
                    <td>String: </td>
                    <td><asp:TextBox ID="txtCharCount" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblCharCount" runat="server" Text="" ForeColor="Blue"></asp:Label></td>
                    <td><asp:Button ID="btnCharCount" runat="server" Text="Count Chars" OnClick="btnCharCount_Click" /></td>
                </tr>
            </table>

            <br /><br />

            <table>
                <tr>
                    <td><asp:TextBox ID="txtNum1" runat="server" Width="75px"></asp:TextBox></td>
                    <td><p style="text-align:center;">+</p></td>
                    <td><asp:TextBox ID="txtNum2" runat="server" Width="75px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblSum" runat="server" Text="" ForeColor="Blue"></asp:Label></td>
                    <td><asp:Button ID="btnAdd" runat="server" Text="Calculate Sum" OnClick="btnAdd_Click" /></td>
                </tr>
            </table>

            <br /><br />

            <table>
                <tr>
                    <td>String: </td>
                    <td><asp:TextBox ID="txtRevString" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblRevString" runat="server" Text="" ForeColor="Blue"></asp:Label></td>
                    <td><asp:Button ID="btnRevString" runat="server" Text="Reverse String" OnClick="btnRevString_Click" /></td>
                </tr>
            </table>


        </div>

    </form>
</body>
</html>
