<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="BillPayments.aspx.cs" Inherits="NCBOnlineBank.Pages.Payment.BillPayments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group row pt-4 pb-4" style="margin: auto">
            <div class="col-md-2 rounded pr-0 text-center"
                style="background-color: midnightblue; color: white">
                <asp:Label ID="lblsearch" runat="server" Text="Quick Search"></asp:Label>
            </div>
            <div class="col-md-8 pl-0 pr-0">
                <asp:TextBox runat="server" CssClass="form-control"
                    placeholder="Search here..."></asp:TextBox>
            </div>
            <div class="col-md-2 pl-0">
                <asp:Button runat="server" Text="Search"
                    ID="btnSearch"
                    class="form-control btn rounded text-primary
                    btn-warning btn-outline-light" />
            </div>
        </div>
        <div class="form-group row">
            <div class="card col-md-8">
                <div class="float-right">
                    <button type="button" id="btnAddPayee" runat="server"
                        class="btn rounded" onserverclick="btnAddPayee_ServerClick">
                        <span class="badge badge-light">
                            <i class="fa fa-plus-circle fa-lg"></i>
                        </span>
                        Add Bill Payee
                    </button>
                </div>
                <asp:GridView ID="payeeGridView" runat="server" AutoGenerateColumns="False" OnRowUpdating="payeeGridView_RowUpdating">
                    <Columns>
                        <asp:BoundField DataField="CustomerPayeeID" ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol" SortExpression="CustomerPayeeID" />
                        <asp:BoundField DataField="PayeeId" ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol" SortExpression="PayeeId" />
                        <asp:BoundField DataField="CustomerName" ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol" SortExpression="CustomerName" />
                        <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                        <asp:BoundField DataField="PremiseNumber" HeaderText="PremiseNumber" SortExpression="PremiseNumber" />
                        <asp:BoundField DataField="AccountNumber" HeaderText="AccountNumber" SortExpression="AccountNumber" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <div class="col-md-7">
                                    <asp:TextBox ID="txtBoxAmount" runat="server" CommandArguments="" OnTextChanged="textBoxAmount_TextChanged"
                                        CssClass="form-control" placeholder="Amount">
                                    </asp:TextBox>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <button type="button" class="alert-target btn btn-outline-secondary rounded"
                                    title="Confirm Payment"
                                    id="btnConfirm"
                                    style="margin: auto"
                                    runat="server"
                                    onserverclick="btnConfirm_ServerClick" formnovalidate>
                                    <span class="badge badge-success">
                                        <i class="fa fa-plus-circle fa-lg"
                                            aria-hidden="true"></i>
                                    </span>
                                    Confirm Payment
                                </button>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </div>
            <div class="col-md-4">
                <div class="card" style="width: 18rem;">
                    <div class="card-header">
                        Featured
                    </div>
                    <div class="row">
                        <div class="col-sm">
                            Payee
                        </div>
                        <div class="col-sm">
                            Payment(s)
                        </div>
                        <div class="col-sm">
                            Currency
                        </div>
                    </div>
                    <div class="col-md-8"
                        style="float: left; background-color: #282E58; color: white; overflow-x: hidden">
                        <asp:Label ID="Label1" runat="server" Text="Total Payment"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="col-md" style="float: right">
                            <span style="background-color: midnightblue; color: white">
                                <asp:Label ID="lblTotalPayment" runat="server" Text="$0.00"></asp:Label>
                            </span>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md">
                            <asp:Button runat="server" Text="Go to next Step"
                                ID="btngotoPayment"
                                class="form-control btn rounded text-primary btn-warning
                                btn-outline-light"
                                OnClick="btngotoPayment_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <style type="text/css">
        .hiddencol {
            display: none;
        }
    </style>

    <script type="text/javascript">
        $(".alert-target").click(function () {
            toastr["info"]("I was launched via jQuery!")
        });
    </script>
</asp:Content>
