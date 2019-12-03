<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="ViewAccountsAndBalance.aspx.cs" Inherits="NCBOnlineBank.Pages.Account.ViewAccountsAndBalance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card border-primary mb-3 col-md-8"
        style="margin: auto;color:black">
        <div class="card-header">
            <h1 style="color:black;">Accounts And Balance
            </h1>
        </div>
        <div class="row pt-4 pb-5">
            <div class="col-md-8">
                <asp:Label ID="lblPayeename" runat="server" Text="Payee Name">
                </asp:Label>
                <asp:DropDownList ID="ddlPayee" runat="server"
                    CssClass="form-control" AutoPostBack="true">
                    <asp:ListItem Enabled="true" Text="Select Payee" Value="-1"></asp:ListItem>
                    <asp:ListItem Text="JPS AND PARTNERS COOP CREDIT UNION" Value="JPS"></asp:ListItem>
                    <asp:ListItem Text="National Water Commission (NWC)" Value="NWC"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-2">
                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h4 class="card-title">Balance</h4>
                        <h5>
                            <asp:Label ID="lblbalance" runat="server" Text="0.00"></asp:Label>
                        </h5>
                    </div>
                </div>
            </div>
        </div>
        <div class="card-body text-primary">
            <div class="card" style="width: 18rem;">
                <div class="card-body">
                    <asp:GridView ID="accoutGrid" runat="server" AutoGenerateColumns="false"></asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
