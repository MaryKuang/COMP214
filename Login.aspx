<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
 <div class="col-md-4"></div>       
    <div class="col-md-4">
       <div class="thumbnail">
        <p></p>    
        Username:<asp:textbox  id="userName" runat="server" class="form-control"></asp:textbox>
        Password: <asp:textbox id="password" runat="server" TextMode="Password" class="form-control" MaxLength="10" ></asp:textbox> 
            <asp:button id="btnLogin" runat="server" text="Login" class="btn btn-primary" OnClick="btnLogin_Click" />
            <asp:Button ID="btnSignUp" runat="server" Text="Sign Up"  class="btn btn-toolbar" OnClick="btnSignUp_Click" />
           
   </div>
  </div>
 
     <div class="col-md-4"></div>
   
   
   
</asp:Content>

