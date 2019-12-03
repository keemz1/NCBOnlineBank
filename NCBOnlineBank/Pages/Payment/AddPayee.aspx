<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="AddPayee.aspx.cs" Inherits="NCBOnlineBank.Pages.Payment.AddPayee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="pb-4">
            <asp:Label ID="lblPayeename" runat="server" Text="Payee Name">
            </asp:Label>
            <asp:DropDownList ID="ddlPayee" runat="server"
                CssClass="form-control" AutoPostBack="true">
                <asp:ListItem Enabled="true" Text="Select Payee" Value="-1"></asp:ListItem>
                <asp:ListItem Text="JPS AND PARTNERS COOP CREDIT UNION" Value="JPS"></asp:ListItem>
                <asp:ListItem Text="National Water Commission (NWC)" Value="NWC"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row pb-3">
            <div class="col-md-6">
                <asp:Label ID="Label1" runat="server"
                    Text="Account Number [9-15 Characters]"></asp:Label>
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
        <div class="row pb-5">
            <div class="input-group col-md-1 pr-0">
                <span class="input-group-text" id="basic-addon1">
                    <img src="/Images/Icons/RSA.png" height="20" width="25" />
                </span>
            </div>
            <div class="col-md-5 pl-0">
                <asp:TextBox ID="txtRSA" runat="server" TextMode="Password"
                    placeholder="PIN + RSA Secure ID Token Code"
                    CssClass="form-control"></asp:TextBox>
            </div>
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
