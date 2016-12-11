<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="content">
     <h3 class="alert-info">Search Recipe</h3> <br />
   <div class="form-group row">
     <asp:Label ID="lblSubmitted" runat="server" class="col-lg-2" Text="Submitted by:" ></asp:Label>
     <div class="col-sm-10">
      <asp:DropDownList ID="drpSubmitBy" runat="server" class="form-control" >
</asp:DropDownList>
     </div>
    </div>
      <div class="form-group row">
     <asp:Label ID="lblCategory" runat="server" class="col-lg-2" Text="Category:" ></asp:Label>
     <div class="col-sm-10">
      <asp:DropDownList ID="drpCategory" runat="server" class="form-control">
    </asp:DropDownList>
     </div>
    </div>
   <div class="form-group row">
     <asp:Label ID="lblIngredients" runat="server" class="col-lg-2" Text="Ingredient:"></asp:Label>
     <div class="col-sm-10">
        <asp:DropDownList ID="drpIngredientList" runat="server" class="form-control">
    </asp:DropDownList>
     </div>
    </div>
          <div>
              <asp:Button ID="btnSearch" runat="server" Text="Search" class="btn btn-toolbar" OnClick="btnSearch_Click"/> 
          </div>
   
     <div class="content">
    
         <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" 
             CellPadding="4" GridLines="Horizontal" Width="850px" Height="300Px">
             <AlternatingRowStyle BackColor="#F7F7F7" />
             <EmptyDataTemplate>
                 No recipe is found!
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
     </div>


  </div>  
    
</asp:Content>


