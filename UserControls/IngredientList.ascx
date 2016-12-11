<%@ Control Language="C#" AutoEventWireup="true" CodeFile="IngredientList.ascx.cs" Inherits="UserControls_IngredientList" %>
<%@ Register Src="~/UserControls/A_Ingredient.ascx" TagPrefix="uc1" TagName="A_Ingredient" %>

<uc1:A_Ingredient runat="server" ID="A_Ingredient" />
<br />
<asp:Label ID="lblQuantity" runat="server" Text="Quantity" Class="txt-info"></asp:Label>
<asp:TextBox ID="txtQuantity" runat="server" Class="form-control"></asp:TextBox>
 <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Numbers required" ValidationGroup="ingredientGroup" MinimumValue="1" MaximumValue="10000" ControlToValidate="txtQuantity" ForeColor="Red" Type="Integer" ></asp:RangeValidator>
<br /><asp:Label ID="lblUnit" runat="server" Text="Unit: "></asp:Label>
<asp:TextBox ID="txtUnit" runat="server"  Class="form-control"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredUnit" runat="server" ErrorMessage="Required unit name" ValidationGroup="ingredientGroup" ValidateRequestMode="Disabled" ControlToValidate="txtUnit" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" ValidationGroup="ingredientGroup"  Class="btn btn-default"/>
<asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="BRIDGEID" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3"  Width="600px" Height="200px" GridLines="Horizontal" OnRowUpdating="GridView1_RowUpdating" Visible="false">
    <AlternatingRowStyle BackColor="#F7F7F7" />
    <Columns>
        <asp:BoundField DataField="RECIPEID" HeaderText="RECIPEID" SortExpression="RECIPEID" />
        <asp:TemplateField HeaderText="INGREDIENTID" SortExpression="INGREDIENTID">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("INGREDIENTID") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("INGREDIENTID") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="QUANTITY" SortExpression="QUANTITY">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("QUANTITY") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("QUANTITY") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="UNIT" SortExpression="UNIT">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("UNIT") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("UNIT") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="BRIDGEID" HeaderText="BRIDGEID" ReadOnly="True" SortExpression="BRIDGEID" />
        <asp:TemplateField ShowHeader="False">
            <EditItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        No ingredients in this recipe
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
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;RECIPEANDINGREDIENT&quot; WHERE &quot;BRIDGEID&quot; = ? AND ((&quot;RECIPEID&quot; = ?) OR (&quot;RECIPEID&quot; IS NULL AND ? IS NULL)) AND ((&quot;INGREDIENTID&quot; = ?) OR (&quot;INGREDIENTID&quot; IS NULL AND ? IS NULL)) AND ((&quot;QUANTITY&quot; = ?) OR (&quot;QUANTITY&quot; IS NULL AND ? IS NULL)) AND ((&quot;UNIT&quot; = ?) OR (&quot;UNIT&quot; IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO &quot;RECIPEANDINGREDIENT&quot; (&quot;RECIPEID&quot;, &quot;INGREDIENTID&quot;, &quot;QUANTITY&quot;, &quot;UNIT&quot;, &quot;BRIDGEID&quot;) VALUES (?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;RECIPEID&quot;, &quot;INGREDIENTID&quot;, &quot;QUANTITY&quot;, &quot;UNIT&quot;, &quot;BRIDGEID&quot; FROM &quot;RECIPEANDINGREDIENT&quot;" UpdateCommand="UPDATE &quot;RECIPEANDINGREDIENT&quot; SET &quot;RECIPEID&quot; = ?, &quot;INGREDIENTID&quot; = ?, &quot;QUANTITY&quot; = ?, &quot;UNIT&quot; = ? WHERE &quot;BRIDGEID&quot; = ? AND ((&quot;RECIPEID&quot; = ?) OR (&quot;RECIPEID&quot; IS NULL AND ? IS NULL)) AND ((&quot;INGREDIENTID&quot; = ?) OR (&quot;INGREDIENTID&quot; IS NULL AND ? IS NULL)) AND ((&quot;QUANTITY&quot; = ?) OR (&quot;QUANTITY&quot; IS NULL AND ? IS NULL)) AND ((&quot;UNIT&quot; = ?) OR (&quot;UNIT&quot; IS NULL AND ? IS NULL))">
    <DeleteParameters>
        <asp:Parameter Name="original_BRIDGEID" Type="Decimal" />
        <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
        <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
        <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
        <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
        <asp:Parameter Name="original_QUANTITY" Type="String" />
        <asp:Parameter Name="original_QUANTITY" Type="String" />
        <asp:Parameter Name="original_UNIT" Type="String" />
        <asp:Parameter Name="original_UNIT" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="RECIPEID" Type="Decimal" />
        <asp:Parameter Name="INGREDIENTID" Type="Decimal" />
        <asp:Parameter Name="QUANTITY" Type="String" />
        <asp:Parameter Name="UNIT" Type="String" />
        <asp:Parameter Name="BRIDGEID" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="RECIPEID" Type="Decimal" />
        <asp:Parameter Name="INGREDIENTID" Type="Decimal" />
        <asp:Parameter Name="QUANTITY" Type="String" />
        <asp:Parameter Name="UNIT" Type="String" />
        <asp:Parameter Name="original_BRIDGEID" Type="Decimal" />
        <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
        <asp:Parameter Name="original_RECIPEID" Type="Decimal" />
        <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
        <asp:Parameter Name="original_INGREDIENTID" Type="Decimal" />
        <asp:Parameter Name="original_QUANTITY" Type="String" />
        <asp:Parameter Name="original_QUANTITY" Type="String" />
        <asp:Parameter Name="original_UNIT" Type="String" />
        <asp:Parameter Name="original_UNIT" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>








