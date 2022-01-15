<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="ProductCatalogue.aspx.cs" Inherits="BIPJ_Grp2_Team5.ProductCatalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 307px;
            height: 66px;
            font-size: medium;
        }
        .auto-style10 {
            text-align: center;
            height: 39px;
        }
        .auto-style11 {
            text-align: right;
            width: 1039px;
            height: 66px;
        }
        .auto-style12 {
            width: 1039px;
        }
        .RowSeparator
        {
            margin-right: 250px;
        }
        .auto-style13 {
            text-align: right;
            height: 66px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
           <tr>
               <td class="auto-style10" colspan="4"><h1>Shop</h1></td>
           </tr>
           <tr>
               <td class="auto-style9"><strong>Shop</strong></td>
               <td class="auto-style11">&nbsp;</td>
               <td class="auto-style11">Sort By:&nbsp;
                   <asp:DropDownList ID="DD_scending" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DD_scending_SelectedIndexChanged">
                       <asp:ListItem>Ascending</asp:ListItem>
                       <asp:ListItem>Descending</asp:ListItem>
                   </asp:DropDownList>
                   &nbsp;
                   <asp:DropDownList ID="DD_Theme" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DD_Theme_SelectedIndexChanged">
                       <asp:ListItem>Name</asp:ListItem>
                       <asp:ListItem>Price</asp:ListItem>
                   </asp:DropDownList>
                </td>
               <td class="auto-style13"></td>
           </tr>
           <tr>
               <td>
                   &nbsp;</td>
               <td class="auto-style12" colspan="2">
                   &nbsp;<div class="text-left">
                   <asp:DataList ID="DL_ProdCat" runat="server" BorderColor="Black" CellPadding="1000" CellSpacing="100" RepeatColumns="4" RepeatDirection="Horizontal" onitemcommand="DL_ProdCat_ItemCommand"> 
                       <ItemTemplate>
                           <table>
                               <tr>
                                   <td>Discount</td>
                                   <td><%#Eval("Discount") %></td>
                               </tr>
                               <tr>
                                   <td colspan="2">
                                       <asp:Image ID="Image1" runat="server" ImageURL= <%# "~/images/" + Eval("Product_Image") %> Height="150px" Width="150px"></asp:Image>
                                   </td>
                               </tr>
                               <tr>
                                   <td>ID</td>
                                   <td>
                                        <asp:Label ID="ProdID" runat="server" Text='<%#Eval("Product_ID") %>'></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td>Name</td>
                                   <td><%#Eval("Product_Name") %></td>
                               </tr>
                               <tr>
                                   <td>Price</td>
                                   <td><%#Eval("Product_Price") %></td>
                               </tr>
                               <tr>
                                   <td>Status</td>
                                   <td><%#Eval("Status") %></td>
                               </tr>
                               <tr>
                                   <td>
                                       <asp:Button ID="Btn_View" runat="server" CommandName="ViewBtn" Text="View" />
                                   </td>
                                   <td>
                                       <asp:Button ID="Btn_Cart" runat="server" CommandName="CartBtn" Text="Cart" />
                                   </td>                          
                               </tr>
                           </table>
                       </ItemTemplate>
                       <SeparatorTemplate>
                           <h4 class="RowSeparator"></h4>
                       </SeparatorTemplate>
                       <SeparatorStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Size="Larger" Font-Strikeout="False" Font-Underline="False" />
                   </asp:DataList>
                   </div>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
       </table>
    </form>
</asp:Content>
