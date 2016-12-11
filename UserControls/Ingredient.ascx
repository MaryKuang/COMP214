<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Ingredient.ascx.cs" Inherits="Ingredient" %>
<div class="col-xs-4">
<asp:Label ID="lblName" runat="server" Text="Ingredient Name: "></asp:Label>
<asp:TextBox ID="txtBoxIngredient" runat="server" class="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredIngredient" runat="server" ErrorMessage="Input Ingredient name" ControlToValidate="txtBoxIngredient" SetFocusOnError="True" ViewStateMode="Disabled" ForeColor="Red" ValidationGroup="ingredientGroup"></asp:RequiredFieldValidator>
</div>
<div class="col-xs-4">
<asp:Label ID="lblMeasure" runat="server" Text="Quantity: "></asp:Label>
<asp:TextBox ID="txtBoxMeasure" runat="server" class="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequireMeasure" runat="server" ValidationGroup="ingredientGroup" ErrorMessage="Input Measure" ControlToValidate="txtBoxMeasure" SetFocusOnError="True" ValidateRequestMode="Disabled" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ValidationGroup="ingredientGroup" ErrorMessage="RangeValidator" ValidateRequestMode="Disabled" MinimumValue="1" MaximumValue="10000" ControlToValidate="txtBoxMeasure" ForeColor="Red" Type="Integer"></asp:RangeValidator>
    </div>
<div class="col-xs-4">
<asp:Label ID="lblUnit" runat="server" Text="Unit: "></asp:Label>
<asp:TextBox ID="txtBoxUnit" runat="server" class="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredUnit" runat="server" ValidationGroup="ingredientGroup" ErrorMessage="Required unit name" ValidateRequestMode="Disabled"  ControlToValidate="txtBoxUnit" ForeColor="Red"></asp:RequiredFieldValidator>
</div>
<br />
<div class="form-group">
      <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-toolbar" ValidationGroup="ingredientGroup" OnClick="btnAdd_Click"/>

    <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource2">
        <AlternatingItemTemplate>
            <li style="background-color: #FFFFFF;color: #284775;">IngredientName:
                <asp:Label ID="IngredientNameLabel" runat="server" Text='<%# Eval("IngredientName") %>' />
                <br />
                Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
                <br />
                UnitName:
                <asp:Label ID="UnitNameLabel" runat="server" Text='<%# Eval("UnitName") %>' />
                <br />
            </li>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <li style="background-color: #999999;">IngredientName:
                <asp:TextBox ID="IngredientNameTextBox" runat="server" Text='<%# Bind("IngredientName") %>' />
                <br />
                Quantity:
                <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />
                UnitName:
                <asp:TextBox ID="UnitNameTextBox" runat="server" Text='<%# Bind("UnitName") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </li>
        </EditItemTemplate>
        <EmptyDataTemplate>
            No data was returned.
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <li style="">IngredientName:
                <asp:TextBox ID="IngredientNameTextBox" runat="server" Text='<%# Bind("IngredientName") %>' />
                <br />
                Quantity:
                <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />
                UnitName:
                <asp:TextBox ID="UnitNameTextBox" runat="server" Text='<%# Bind("UnitName") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </li>
        </InsertItemTemplate>
        <ItemSeparatorTemplate>
            <br />
        </ItemSeparatorTemplate>
        <ItemTemplate>
            <li style="background-color: #E0FFFF;color: #333333;">IngredientName:
                <asp:Label ID="IngredientNameLabel" runat="server" Text='<%# Eval("IngredientName") %>' />
                <br />
                Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
                <br />
                UnitName:
                <asp:Label ID="UnitNameLabel" runat="server" Text='<%# Eval("UnitName") %>' />
                <br />
            </li>
        </ItemTemplate>
        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF;">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <li style="background-color: #E2DED6;font-weight: bold;color: #333333;">IngredientName:
                <asp:Label ID="IngredientNameLabel" runat="server" Text='<%# Eval("IngredientName") %>' />
                <br />
                Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
                <br />
                UnitName:
                <asp:Label ID="UnitNameLabel" runat="server" Text='<%# Eval("UnitName") %>' />
                <br />
            </li>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetIngredients" TypeName="IngredientsRepository"></asp:ObjectDataSource>

</div>


