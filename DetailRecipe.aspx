<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="DetailRecipe.aspx.cs" Inherits="DetailRecipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <h3 class="alert-info"> Details </h3>
    <div class="content">
        <asp:DetailsView ID="DetailsView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" 
            BorderWidth="1px" CellPadding="4" 
             Width="850px" Height="300px" Font-Size="Medium" AutoGenerateRows="False" OnItemUpdating="DetailsView1_ItemUpdating" OnModeChanging="DetailsView1_ModeChanging">
            <AlternatingRowStyle  />
            <EditRowStyle Font-Bold="True"  />
            <EmptyDataTemplate>
                No data found!
            </EmptyDataTemplate>
            <Fields>
                <asp:TemplateField HeaderText="Recipe Name" SortExpression="RecipeName">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtRecipeName" runat="server" class="form-control" Text='<%# Bind("RecipeName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" class="form-control" Text='<%# Bind("RecipeName") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("RecipeName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="User Name" SortExpression="UserID">
                    <EditItemTemplate>
                        <asp:Label ID="lblUserID" runat="server" Text='<%# Eval("UserID") %>'></asp:Label>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" class="form-control" Text='<%# Bind("UserID") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("UserID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Category" SortExpression="CategoryID">
                    <EditItemTemplate>
                       <%-- <asp:DropDownList ID="" runat="server" --%>
                        <asp:TextBox ID="txtCategoryID" runat="server" class="form-control" Text='<%# Bind("CategoryID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" class="form-control" Text='<%# Bind("CategoryID") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("CategoryID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cooking Time" SortExpression="Cookingtime">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCookingtime" runat="server" class="form-control" Text='<%# Bind("Cookingtime") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" class="form-control" Text='<%# Bind("Cookingtime") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Cookingtime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Serving number" SortExpression="Servingtime">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtServingtime" runat="server" class="form-control" Text='<%# Bind("Servingtime") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" class="form-control" Text='<%# Bind("Servingtime") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Servingtime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description" SortExpression="Description">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDescription" runat="server" class="form-control" Text='<%# Bind("Description") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" class="form-control" Text='<%# Bind("Description") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:Button ID="btnUpdate" runat="server" CommandName="Update" Text="Update" class="btn btn-toolbar"/>
                        &nbsp;<asp:Button ID="btnCancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" class="btn btn-toolbar" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" class="btn btn-toolbar"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Fields>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <HeaderTemplate>
               <%#Eval("RecipeName") %>
            </HeaderTemplate>
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        </asp:DetailsView>
        <asp:button id="btnDetailIngredients" runat="server" text="Show Ingredients" class="btn btn-toolbar" OnClick="btnDetailIngredients_Click" />
        <asp:DetailsView ID="DetailsView2" runat="server"  Width="850px" Height="200px" BackColor="White" 
            BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Size="Medium">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <EmptyDataTemplate>
              <p class="alert-info">   No ingredients in the recipe.</p>
            </EmptyDataTemplate>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <HeaderTemplate>
                Ingredient detail
            </HeaderTemplate>
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

        </asp:DetailsView>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-toolbar" OnClick="btnDelete_Click" />
        <asp:Button ID="btnDetailCancel" runat="server" Text="Cancel"  class="btn btn-toolbar" OnClick="btnDetailCancel_Click"/>
   </div>
</asp:Content>

