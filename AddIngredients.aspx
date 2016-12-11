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
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" class="btn btn-toolbar"/>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" width="500px"  DataSourceID="SqlDataSource1" GridLines="Horizontal" Visible="False"  >
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="ingredientID" runat="server" Text='<%# Bind("IngredientID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="ingredientID" runat="server" Text='<%# Bind("IngredientID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="Quantity" runat="server" Text='<%# Bind("Quantity") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="Unit" runat="server" Text='<%# Bind("Unit") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Unit") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
            <EmptyDataTemplate>
                No ingredients
            </EmptyDataTemplate>
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
            
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;RECIPEANDINGREDIENT&quot; WHERE &quot;BRIDGEID&quot; = ? AND ((&quot;RECIPEID&quot; = ?) OR (&quot;RECIPEID&quot; IS NULL AND ? IS NULL)) AND ((&quot;QUANTITY&quot; = ?) OR (&quot;QUANTITY&quot; IS NULL AND ? IS NULL)) AND ((&quot;UNIT&quot; = ?) OR (&quot;UNIT&quot; IS NULL AND ? IS NULL)) AND ((&quot;INGREDIENTID&quot; = ?) OR (&quot;INGREDIENTID&quot; IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO &quot;RECIPEANDINGREDIENT&quot; (&quot;BRIDGEID&quot;, &quot;RECIPEID&quot;, &quot;QUANTITY&quot;, &quot;UNIT&quot;, &quot;INGREDIENTID&quot;) VALUES (?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT BRIDGEID, RECIPEID, QUANTITY, UNIT, INGREDIENTID FROM COMP214F16_001_P_17.RECIPEANDINGREDIENT" UpdateCommand="UPDATE &quot;RECIPEANDINGREDIENT&quot; SET &quot;RECIPEID&quot; = ?, &quot;QUANTITY&quot; = ?, &quot;UNIT&quot; = ?, &quot;INGREDIENTID&quot; = ? WHERE &quot;BRIDGEID&quot; = ? AND ((&quot;RECIPEID&quot; = ?) OR (&quot;RECIPEID&quot; IS NULL AND ? IS NULL)) AND ((&quot;QUANTITY&quot; = ?) OR (&quot;QUANTITY&quot; IS NULL AND ? IS NULL)) AND ((&quot;UNIT&quot; = ?) OR (&quot;UNIT&quot; IS NULL AND ? IS NULL)) AND ((&quot;INGREDIENTID&quot; = ?) OR (&quot;INGREDIENTID&quot; IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_BRIDGEID" Type="Decimal" />
                <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
                <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
                <asp:Parameter Name="original_QUANTITY" Type="String" />
                <asp:Parameter Name="original_QUANTITY" Type="String" />
                <asp:Parameter Name="original_UNIT" Type="String" />
                <asp:Parameter Name="original_UNIT" Type="String" />
                <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
                <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="BRIDGEID" Type="Decimal" />
                <asp:Parameter Name="RECIPEID" Type="Decimal" />
                <asp:Parameter Name="QUANTITY" Type="String" />
                <asp:Parameter Name="UNIT" Type="String" />
                <asp:Parameter Name="INGREDIENTID" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="RECIPEID" Type="Decimal" />
                <asp:Parameter Name="QUANTITY" Type="String" />
                <asp:Parameter Name="UNIT" Type="String" />
                <asp:Parameter Name="INGREDIENTID" Type="Decimal" />
                <asp:Parameter Name="original_BRIDGEID" Type="Decimal" />
                <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
                <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
                <asp:Parameter Name="original_QUANTITY" Type="String" />
                <asp:Parameter Name="original_QUANTITY" Type="String" />
                <asp:Parameter Name="original_UNIT" Type="String" />
                <asp:Parameter Name="original_UNIT" Type="String" />
                <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
                <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
            
        <asp:Button ID="btnReturn" runat="server" Text="Return" Class="btn btn-toolbar" OnClick="btnReturn_Click" />
     </div>
 

</asp:Content>

