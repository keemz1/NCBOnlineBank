<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="HomeJPS.aspx.cs" Inherits="AccountSystems.Pages.JPS.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p>Not a Member? Register Today!</p>
        <asp:Button CssClass="btn btn-outline-dark btn-light btn-rounded" ID="btnform" runat="server" Text="Go to Registration Form" OnClick="btnform_Click" />
    </div>
    <div class="pb-3 pt-2">
        <asp:Button CssClass="btn btn-light btn-rounded btn-outline-primary"
            ID="btnWelcome" runat="server" Text="Go to Welcome"
            OnClick="btnWelcome_Click" />
    </div>
</asp:Content>
