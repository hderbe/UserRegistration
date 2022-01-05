<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User_Reg.aspx.cs" Inherits="RegistrationProject.User_Reg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-6 col-md-offset-3">
                                <h1>User Registration Form</h1>
                                <br />
                                <br />
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txt_FirstName"><b>First Name</b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enable="True" name="BrandName" ID="txt_FirstName" class="form-control input-sm" placeholder="First Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txt_LastName"><b>Last Name</b></asp:Label><br />
                                        <asp:TextBox runat="server" Enable="True" name="UserLastName" ID="txt_LastName" class="form-control input-sm" placeholder="Last Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txt_Email"><b>Email Address</b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enable="True" name="UserEmailAddress" ID="txt_Email" class="form-control input-sm" placeholder="Email Address"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txt_Mobile"><b>Mobile Number</b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enable="True" name="UserMobileNumber" ID="txt_Mobile" class="form-control input-sm" placeholder="Mobile Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txt_CreditCardNumber"><b>Credit Card Number</b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enable="True" name="UserCreditCardNumber" ID="txt_CreditCardNumber" class="form-control input-sm" placeholder="Credit Card Number" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" MaxLength="16"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txt_CreditCardExpiryDate"><b>Credit Card Expiry Date</b></asp:Label><br />
                                        <asp:TextBox runat="server" type="date" required="required" Enable="True" name="UserCreditCardExpiryDate" ID="txt_CreditCardExpiryDate" class="form-control input-sm"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txt_CreditCardCCVNumber"><b>CCV Number</b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enable="True" name="UserCreditCardCCVNumber" ID="txt_CreditCardCCVNumber" class="form-control input-sm" placeholder="CCV Number" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" MaxLength="3"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
            <div class="row">
                <div class="col-md-8 col-md-offset-4">
                    <asp:Button Text="Save" ID="btn_Save" CssClass="btn btn-primary" Width="200" runat="server" Font-Bold="true" Font-Size="Medium" OnClick="btn_Save_Click"/><br /><br /><br />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 col-md-offset-1">
                    <asp:Label runat="server" ID="lab_MessageBuffer" AssociatedControlID="btn_Save" ForeColor="Green"><b></b></asp:Label><br />
                </div>
            </div>
        </section>
    </section>
</asp:Content>
