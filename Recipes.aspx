<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="Recipes.aspx.cs" Inherits="Recipes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
    <div><h3 class="alert-info">  Listing of recipes</h3></div>
        <div class="content">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderWidth="1px" CellPadding="3" 
             Width="850px" Height="300px" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" GridLines="Horizontal">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>            
                    <asp:HyperLinkField DataNavigateUrlFields="RecipeId" DataNavigateUrlFormatString="~/DetailRecipe.aspx?param={0}" HeaderText="Recipe Name" DataTextField="RecipeName" />
                    <asp:BoundField DataField="Userid" HeaderText="User" />
                    <asp:BoundField DataField="CategoryID" HeaderText="Category" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
         

        </div>
</asp:Content>

