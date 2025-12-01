<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>
<%@ Register Src="~/Controls/Captcha.ascx" TagPrefix="uc" TagName="Captcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 5 - Homepage</title>
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
            <asp:HyperLink ID="lnkMember" runat="server" NavigateUrl="~/Member.aspx">Member Sign in</asp:HyperLink>
            <asp:HyperLink ID="lnkStaff" runat="server" NavigateUrl="~/Staff.aspx">Staff Sign in</asp:HyperLink>
        </div>

        <div class="section">
            <asp:Panel ID="pnlHotelList" runat="server">

            </asp:Panel>
            <asp:Label ID="lblBook" runat="server" Text="Sign in as a Member to book"></asp:Label>
        </div>

    </form>
</body>
</html>
