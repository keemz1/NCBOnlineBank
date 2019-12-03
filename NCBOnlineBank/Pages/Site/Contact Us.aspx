<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Contact Us.aspx.cs" Inherits="NCBOnlineBank.Pages.Site.Contact_Us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid row">
        <div>
            <div class="registerBody container-fluid" style="padding-top: 30px">
                <div class="form-group row">
                    <div class="col-md col-sm">
                        <asp:TextBox ID="txtUserName" placeholder="Name" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Enter your name" ControlToValidate="txtUserName" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-md col-sm">
                        <asp:TextBox ID="txtenmail" placeholder="Email" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter your email" ControlToValidate="txtUserName" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-md col-sm">
                        <textarea id="txtarea" cols="30" rows="4"></textarea>
                    </div>
                </div>
                </div>
            </div>
            <div class="h3">
                NCB Headquarters
            </div>
            <div class="h4">
                NATIONAL COMMERCIAL BANK LIMITED
            </div>
            <div>
                32 Trafalgar Road,
                Kingston 10
                Jamaica W.I.
            </div>
        </div>
</asp:Content>
