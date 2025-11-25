<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Captcha.ascx.cs" Inherits="WebApplication.Controls.Captcha" %>

<!-- Lil div that holds the captcha -->
<div>
    <asp:Label ID="lblCode" runat="server" Text="Captcha Text"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtInput" runat="server" Width="180px" />
</div>