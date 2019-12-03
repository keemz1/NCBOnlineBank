<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="NCBOnlineBank.Pages.PayeeAccounts.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div>
            <h1>Create Account</h1>
        </div>
        <div class="pb-4">
            <asp:Label ID="lblPayeename" runat="server" Text="Account Category">
            </asp:Label>
            <asp:DropDownList ID="ddlPayee" runat="server"
                CssClass="form-control" AutoPostBack="true">
                <asp:ListItem Enabled="true" Text="Select Account" Value="-1"></asp:ListItem>
                <asp:ListItem Text="JPS AND PARTNERS COOP CREDIT UNION" Value="1"></asp:ListItem>
                <asp:ListItem Text="National Water Commission (NWC)" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row pb-3">
            <div class="col-md-6">
                <asp:Label ID="Label1" runat="server"
                    Text="Account Number [6-15 Characters]"></asp:Label>
                <asp:TextBox ID="txtAccountNumber" runat="server"
                    placeholder="Account Number"
                    CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row pb-4 col-md-6">
            <asp:Label ID="lblpremises" runat="server"
                Text="Premises Number"></asp:Label>
            <asp:TextBox ID="txtpremisesNumber" runat="server"
                placeholder="ENTER PREMISES NUMBER"
                CssClass="form-control"></asp:TextBox>
        </div>
        <div class="row pb-2 float-right">
            <div class="pr-3">
                <asp:Button ID="btnprevious" runat="server"
                    Text="Previous"
                    CssClass="btn rounded btn-light btn-outline-primary"
                    OnClick="btnprevious_Click" />
            </div>
            <div>
                <asp:Button ID="btnConfirm" runat="server"
                    Text="Confirm"
                    CssClass="btn rounded btn-primary btn-outline-light"
                    OnClick="btnConfirm_Click" />
            </div>
        </div>
    </div>
</asp:Content>
