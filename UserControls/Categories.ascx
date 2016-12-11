<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Categories.ascx.cs" Inherits="Categories" %>
<asp:DropDownList ID="drpListCategories" runat="server" Class="form-control" AutoPostBack="True" OnSelectedIndexChanged="drpListCategories_SelectedIndexChanged">
</asp:DropDownList>
<asp:Label ID="lblInput" runat="server" Text="Input new Category: " Class="txt-info"></asp:Label>
<asp:TextBox ID="txtCategory" runat="server" Class="form-control" ></asp:TextBox>



 <asp:Button ID="btnCategoryAdd" runat="server" Text="Add a new Category" class="btn btn-default" OnClick="btnCategoryAdd_Click"/>




 