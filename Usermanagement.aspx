<%--Yu Kuang 300540907--%>

<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="Usermanagement.aspx.cs" Inherits="Usermanagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content">
    <div>
       <h3 class="alert-info"> Create a User:</h3>
        <asp:TextBox ID="txtUserName" runat="server" Class="form-control"></asp:TextBox>
    
       <h3 class="alert-info"> Create Role:</h3>
        <asp:DropDownList ID="DropDownList2" runat="server" Class="form-control">
            <asp:ListItem Value="admin">administrator</asp:ListItem>
            <asp:ListItem Value="user">User</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnAddRole" runat="server" Text="Add new User" Class="btn btn-toolbar" OnClick="btnAddRole_Click" />
        <asp:Button ID="btnReturn1" runat="server" Text="Return" Class="btn btn-toolbar" OnClick="btnReturn1_Click" />
    </div>

     <div>
        <h3 class="alert-info">View User and Role:</h3>
         <asp:GridView ID="GridView1" runat="server" Width="600px" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="USERID" GridLines="Horizontal">
             <AlternatingRowStyle BackColor="#F7F7F7" />
             <Columns>
                 <asp:BoundField DataField="USERID" HeaderText="USERID" ReadOnly="True" SortExpression="USERID" />
                 <asp:BoundField DataField="USERNAME" HeaderText="USERNAME" SortExpression="USERNAME" />
                 <asp:BoundField DataField="ROLE" HeaderText="ROLE" SortExpression="ROLE" />
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
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;USERID&quot;, &quot;USERNAME&quot;, &quot;ROLE&quot; FROM &quot;USERS&quot;"></asp:SqlDataSource>
    </div>
</div>
</asp:Content>

