<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="NCBOnlineBank.Pages.Payment.Transactions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="card border-primary mb-3 col-md-8"
        style="margin:auto">
        <div class="card-header">Transaction Summary</div>
        <div class="card-body text-primary">
            <asp:GridView ID="paymentGrid" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>
