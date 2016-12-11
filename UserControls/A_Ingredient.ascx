<%@ Control Language="C#" AutoEventWireup="true" CodeFile="A_Ingredient.ascx.cs" Inherits="UserControls_A_Ingredient" %>
<asp:DropDownList ID="drpIngredient" runat="server" Class="form-control" AutoPostBack="True" OnSelectedIndexChanged="drpIngredient_SelectedIndexChanged" >
</asp:DropDownList>
<asp:Label ID="lblInputIngre" runat="server" Text="Input new Ingredient: " Class="txt-info"></asp:Label>
<asp:TextBox ID="txtIngredient" runat="server" Class="form-control" ></asp:TextBox>


 <asp:Button ID="btnIngredientAdd" runat="server" Text="Add a new Ingredient" class="btn btn-default" OnClick="btnIngredientAdd_Click" />




 