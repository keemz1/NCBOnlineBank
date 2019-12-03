<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PayeeListView.ascx.cs" Inherits="NCBOnlineBank.Pages.Payment.Sub_Pages.PayeeListView" %>

<asp:ListView ID="ProductListView" runat="server">
    <LayoutTemplate>
        <div runat="server" id="lstProducts">
            <div runat="server" id="itemPlaceholder"></div>
        </div>
        <asp:DataPager ID="DataPager1" runat="server" PageSize="6">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button"
                    ShowFirstPageButton="True" ShowNextPageButton="False"
                    ShowPreviousPageButton="False" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ButtonType="Button"
                    ShowLastPageButton="True" ShowNextPageButton="False"
                    ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    </LayoutTemplate>
    <ItemTemplate>
        <ul class="list-group list-group-flush">
            <li class="list-group-item">
                <div class="row">
                    <div class="">
                        <asp:Label ID="Label1" runat="server" Text="Label">
                        </asp:Label>
                    </div>
                    <div class="">
                        <asp:DropDownList ID="DropDownList1" runat="server"
                            CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="">
                        <asp:TextBox ID="TextBox1" runat="server"
                            CssClass="form-control">
                        </asp:TextBox>
                    </div>
                    <div class="">
                        <asp:DropDownList ID="DropDownList2" runat="server"
                            CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>
            </li>
        </ul>
    </ItemTemplate>
</asp:ListView>
