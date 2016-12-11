<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="col-md-4">
 </div>
    <div class="col-md-4">
        <p></p>
        Username:<asp:textbox  id="userName" runat="server" class="form-control"></asp:textbox>
        Password: <asp:textbox id="password" runat="server" TextMode="Password" class="form-control" MaxLength="10" ></asp:textbox> 
        Confirm password: <asp:textbox id="txtConfirm" runat="server" TextMode="Password" class="form-control" MaxLength="10" ></asp:textbox> 
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password is not same" ControlToCompare="password" ControlToValidate="txtConfirm" ForeColor="Red"></asp:CompareValidator>
            <asp:Button ID="btnSignUp" runat="server" Text="Sign Up"  class="btn btn-toolbar" OnClick="btnSignUp_Click" />
            <p></p>
    </div>
</asp:Content>

