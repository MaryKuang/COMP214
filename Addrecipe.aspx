<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="Addrecipe.aspx.cs" Inherits="Addrecipe" %>

<%@ Register Src="~/UserControls/Ingredient.ascx" TagPrefix="uc1" TagName="Ingredient" %>
<%@ Register Src="~/UserControls/Categories.ascx" TagPrefix="uc1" TagName="Categories" %>
<%@ Register Src="~/UserControls/A_Ingredient.ascx" TagPrefix="uc1" TagName="A_Ingredient" %>
<%@ Register Src="~/UserControls/IngredientList.ascx" TagPrefix="uc1" TagName="IngredientList" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content">
   <div class="form-group row">
     <asp:Label ID="lblRecipeName" runat="server" class="col-sm-2" Text="Name of Recipe:"></asp:Label>
     <div class="col-sm-10">
     <asp:TextBox ID="tbxRecipeName" class="form-control" runat="server" ></asp:TextBox>
     <asp:RequiredFieldValidator ID="requiredRecipeName" runat="server" ErrorMessage="Please Input recipe name" ValidationGroup="RecipeGroup" SetFocusOnError="True" ControlToValidate="tbxRecipeName" ForeColor="Red"></asp:RequiredFieldValidator>
     </div>
    </div>
    
     <div class="form-group row">
     <asp:Label ID="lblSubmit" runat="server" class="col-sm-2" Text="Submitted By:"></asp:Label>
          <div class="col-sm-10">
    <asp:TextBox ID="tbxSubmit" runat="server" class="form-control"></asp:TextBox>
              <asp:RequiredFieldValidator ID="requiredSubmitName" runat="server" ErrorMessage="Please input the submit name" ValidationGroup="RecipeGroup" ControlToValidate="tbxSubmit" ForeColor="Red"></asp:RequiredFieldValidator>
          </div> 
         </div>
    
     <div class="form-group row">
    <asp:Label ID="lblCategory" runat="server" class="col-sm-2" Text="Category:"></asp:Label>
          <div class="col-sm-10">
              <uc1:Categories runat="server" ID="Categories" />
          </div>
         </div>
    
     <div class="form-group row">
     <asp:Label ID="lblPrepare" runat="server" class="col-lg-2" Text="Prepare time:"></asp:Label>
          <div class="col-sm-10">
    <asp:TextBox ID="tbxPrepare" runat="server" class="form-control"></asp:TextBox>
    </div>
        </div>
     <div class="form-group row">
     <asp:Label ID="lblServings" runat="server" class="col-sm-2" Text="Serving Number:" ></asp:Label>
           <div class="col-sm-10">
    <asp:TextBox ID="tbxServings" runat="server" class="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please input the serving number" ValidationGroup="RecipeGroup" ControlToValidate="tbxServings" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>
     </div>
     <div class="form-group row">
     <asp:Label ID="lblDescription" runat="server" class="col-sm-2" Text="Recipe description:"></asp:Label>
     <div class="col-sm-10">
    <asp:TextBox ID="tbxDescription" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox> 
 <asp:RequiredFieldValidator ID="requiredDescription" runat="server" ErrorMessage="Please input description" ValidationGroup="RecipeGroup" ControlToValidate="tbxDescription" ForeColor="Red"></asp:RequiredFieldValidator>
           </div>
  </div>
        <div>
            <asp:Button ID="AddIngredients" runat="server" Text="Add Ingredients" Class="btn btn-info" ValidationGroup="RecipeGroup" OnClick="AddIngredients_Click" />
           <asp:Button ID="btnSummit" runat="server" Class="btn btn-danger" Text="Submit without ingredients" ValidationGroup="RecipeGroup" OnClick="btnSummit_Click" />
    
    <asp:Button ID="btnCancel" runat="server" Class="btn btn-toolbar" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false" />

        </div>
       

   <%--  <div class="form-group row">
      <asp:Label ID="lblIngredients" runat="server" class="col-sm-2" Text="List of Ingredients:"></asp:Label>
          <div class="col-sm-10">
             <%--  <uc1:A_Ingredient runat="server" id="A_Ingredient" />--%>
                 <%-- <uc1:Ingredient runat="server" ID="Ingredient1" />--%>

<%--              <uc1:IngredientList runat="server" id="IngredientList" />
     </div>
     </div>  --%>
     <%--  <asp:Button ID="btnSummit" runat="server" Class="btn btn-toolbar" Text="Submit" ValidationGroup="RecipeGroup" OnClick="btnSummit_Click" />
    
    <asp:Button ID="btnCancel" runat="server" Class="btn btn-toolbar" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false" />    --%>
   
    
</asp:Content>

