<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="PaymentSummary.aspx.cs" Inherits="NCBOnlineBank.Pages.Payment.PaymentSummary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card border-primary mb-3 col-md-8"
        style="margin:auto">
        <div class="card-header">Payment Summary</div>
        <div class="card-body text-primary">
            <asp:GridView ID="paymentGrid" runat="server"></asp:GridView>
        </div>
    </div>
    <div class="row pb-2 float-right">
            <div class="pr-3">
                <asp:Button ID="btnCancel" runat="server"
                    Text="Previous"
                    CssClass="btn rounded btn-light btn-outline-primary"
                    OnClick="btnCancel_Click" />
            </div>
            <div>
                <asp:Button ID="btnConfirm" runat="server"
                    Text="Confirm"
                    CssClass="btn rounded btn-primary btn-outline-light"
                    OnClick="btnConfirm_Click" />
            </div>
        </div>
</asp:Content>
