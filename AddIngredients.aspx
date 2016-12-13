<%--Yu Kuang 300540907--%>

<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="AddIngredients.aspx.cs" Inherits="AddIngredients" %>


<%@ Register Src="~/UserControls/A_Ingredient.ascx" TagPrefix="uc1" TagName="A_Ingredient" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content">
       
            <h3 class="alert-info">The recipe name:
                <asp:Label ID="lblRecipeID" runat="server" Text='<%# Request.QueryString["key"] %>'></asp:Label>
            </h3>              
        <h3 class="alert-info">  
            Insert ingredient: </h3>
        <uc1:A_Ingredient runat="server" ID="A_Ingredient" />                               
<br /><asp:Label ID="lblQuantity" runat="server" Text="Quantity" Class="txt-info"></asp:Label>
<asp:TextBox ID="txtQuantity" runat="server" Class="form-control"></asp:TextBox>
 <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Numbers required" ValidationGroup="ingredientGroup" MinimumValue="1" MaximumValue="10000" ControlToValidate="txtQuantity" ForeColor="Red" Type="Integer" ></asp:RangeValidator>
     <br />   <asp:Label ID="lblUnit" runat="server" Text="Unit: "></asp:Label>
<asp:TextBox ID="txtUnit" runat="server"  Class="form-control"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredUnit" runat="server" ErrorMessage="Required unit name" ValidationGroup="ingredientGroup" ValidateRequestMode="Disabled" ControlToValidate="txtUnit" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="543px" Visible="False">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="INGREDIENTID" HeaderText="INGREDIENTID" SortExpression="INGREDIENTID" />
                    <asp:BoundField DataField="QUANTITY" HeaderText="QUANTITY" SortExpression="QUANTITY" />
                    <asp:BoundField DataField="UNIT" HeaderText="UNIT" SortExpression="UNIT" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;INGREDIENTID&quot;, &quot;QUANTITY&quot;, &quot;UNIT&quot; FROM &quot;RECIPEANDINGREDIENT&quot;"></asp:SqlDataSource>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" class="btn btn-toolbar"/>
            
        <asp:Button ID="btnReturn" runat="server" Text="Return" Class="btn btn-toolbar" OnClick="btnReturn_Click" />
     </div>
 

</asp:Content>

