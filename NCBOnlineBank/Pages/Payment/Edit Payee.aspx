<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="Edit Payee.aspx.cs" Inherits="NCBOnlineBank.Pages.Payment.Edit_Payee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div>
            <div class="col-md-6">
                <asp:Label ID="lblCategory" runat="server"
                    Text="Category"></asp:Label>
                <asp:TextBox ID="txtCategory" runat="server"
                    CssClass="form-control"
                    ReadOnly="true">
                </asp:TextBox>
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblPayeeName" runat="server"
                    Text="Payee Name"></asp:Label>
                <asp:TextBox ID="txtPayeeName" runat="server"
                    CssClass="form-control"
                    ReadOnly="true">
                </asp:TextBox>
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblNickName" runat="server"
                    Text="NickName"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"
                    CssClass="form-control"
                    ReadOnly="true">
                </asp:TextBox>
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblPaymentType" runat="server"
                    Text="Payment Type"></asp:Label>
                <asp:TextBox ID="txtPaymentType" runat="server"
                    CssClass="form-control">
                </asp:TextBox>
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblCustomerName" runat="server"
                    Text="Customer Name"></asp:Label>
                <asp:TextBox ID="txtCustomerName" runat="server"
                    CssClass="form-control">
                </asp:TextBox>
            </div>
            <div class="row pb-2 float-right">
                <div class="pr-3 col-md-5">
                    <asp:Button ID="btnCancel" runat="server"
                        Text="Cancel"
                        CssClass="btn rounded btn-light btn-outline-primary"
                        OnClick="btnCancel_Click" />
                </div>
                <div class="col-md-5">
                    <asp:Button ID="btnUpdate" runat="server"
                        Text="Update"
                        CssClass="btn rounded btn-primary btn-outline-light"
                        OnClick="btnUpdate_Click" />
                </div>
            </div>
            <div class="row float-left">
                <div class="col-md-2 pt-3">
                    <asp:Button ID="btnDelete" runat="server"
                        Text="Delete"
                        CssClass="btn rounded btn-light btn-outline-primary"
                        OnClick="btnDelete_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
