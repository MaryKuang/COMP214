<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="SetUp.aspx.cs" Inherits="SetUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content">
        <div class="thumbnail">
        <asp:RadioButton ID="rdnDark" runat="server" class="radio-danger" Text="  Dark Theme" GroupName="Theme"/><br />
         </div>
        <div class="thumbnail">
        <asp:RadioButton ID="rdnLight" runat="server" class="radio-danger" Text="  Light Theme" GroupName="Theme" /><br />
         </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Class="btn btn-toolbar" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Class="btn btn-toolbar" OnClick="btnCancel_Click" />

    </div>
</asp:Content>

