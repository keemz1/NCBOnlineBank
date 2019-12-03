<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Main.Master" AutoEventWireup="true" CodeBehind="NCBRegister.aspx.cs" Inherits="NCBOnlineBank.Pages.Account.NCBRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container card text-center" style="width: 18rem;margin:auto">
        <div class="card-body">
            <div class="h1">
                Registeration Form
            </div>
            <div class="registerBody container-fluid" style="padding-top: 30px">
                <div class="form-group row">
                    <asp:Label ID="lbluserName" runat="server" class="col-4 col-form-label no-wrap"
                        Text="User Name"></asp:Label>
                    <div class="col-7">
                        <asp:TextBox ID="txtUserName" placeholder="Jane101" runat="server"
                            CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
                            ErrorMessage="Enter a unique user name" ControlToValidate="txtUserName"
                            ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lblfn" runat="server" class="col-4 col-form-label no-wrap"
                        Text="First Name"></asp:Label>
                    <div class="col-7">
                        <asp:TextBox ID="txtfname" placeholder="Jane" runat="server"
                            CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ErrorMessage="Enter your first name" ControlToValidate="txtfname"
                            ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group row">
                    <asp:Label ID="lblln" runat="server" class="col-4 col-form-label no-wrap"
                        Text="Last Name"></asp:Label>

                    <div class="col-7">
                        <asp:TextBox ID="txtlname" placeholder="Doe" runat="server"
                            CssClass="form-control"></asp:TextBox>

                    </div>
                    <div class="col-1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ErrorMessage="Enter your last name" ControlToValidate="txtlname"
                            ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lblemail" runat="server" class="col-4 col-form-label no-wrap"
                        Text="Email Address"></asp:Label>

                    <div class="col-7">
                        <asp:TextBox ID="txtemail" placeholder="myemail@gmail.com" runat="server"
                            CssClass="form-control"></asp:TextBox>

                    </div>
                    <div class="col-1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                            ErrorMessage="Enter your email address" ControlToValidate="txtemail"
                            ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                            ErrorMessage="Incorrect email format" ControlToValidate="txtemail"
                            ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            SetFocusOnError="True">*</asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lblpnum" runat="server" class="col-4 col-form-label no-wrap" Text="Phone Number"></asp:Label>

                    <div class="col-7">
                        <asp:TextBox ID="txtphonenum" placeholder="555-555-5555" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter your Phone #" ControlToValidate="txtphonenum" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Incorrect format! Please Re-enter number" ControlToValidate="txtphonenum" ForeColor="Red" ViewStateMode="Disabled" Visible="False" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*</asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lbladdress" runat="server" class="col-4 col-form-label no-wrap" Text="Address"></asp:Label>

                    <div class="col-7">
                        <asp:TextBox ID="txtaddress" placeholder="18 Jamaica Ave." runat="server" CssClass="form-control"></asp:TextBox>

                    </div>
                    <div class="col-1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter your Address" ControlToValidate="txtaddress" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lblpass" runat="server" class="col-4 col-form-label no-wrap" Text="Password"></asp:Label>

                    <div class="col-7">
                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"
                            CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ErrorMessage="Please enter your password" ControlToValidate="txtpassword"
                            ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lblcpass" runat="server" class="col-4 col-form-label no-wrap"
                        Text="Confirm Password"></asp:Label>

                    <div class="col-7">
                        <asp:TextBox ID="txtconfirmpass" runat="server" TextMode="Password"
                            CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-1">
                        <asp:CompareValidator ID="CompareValidator1" runat="server"
                            ErrorMessage="Password entered didn't match"
                            ControlToCompare="txtpassword" ControlToValidate="txtconfirmpass"
                            ForeColor="Red">*</asp:CompareValidator>

                        <asp:RegularExpressionValidator ID="valPassword" runat="server"
                            ControlToValidate="txtPassword"
                            ErrorMessage="Minimum password length is 8"
                            ValidationExpression=".{8}.*" />
                    </div>
                </div>

                <div>
                    <asp:Button CssClass="btn btn-outline-dark btn-light btn-rounded" ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </div>
                <asp:Label ID="lblRegisted" runat="server" Text="Total registered Users: "></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="form-control" HeaderText="Validation Errors:" ForeColor="Red" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
