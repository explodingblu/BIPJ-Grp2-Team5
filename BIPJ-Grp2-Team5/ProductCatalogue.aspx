<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="ProductCatalogue.aspx.cs" Inherits="BIPJ_Grp2_Team5.ProductCatalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 515px
        }
        .auto-style6 {
            width: 342px
        }
        .auto-style8 {
            width: 256px
        }
        .auto-style9 {
            width: 307px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
&nbsp;<table class="nav-justified">
           <tr>
               <td class="auto-style9">&nbsp;</td>
               <td class="text-center" colspan="3"><h1>Product Catalogue</h1></td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td class="auto-style9">&nbsp;</td>
               <td class="text-right" colspan="3">Sort By:&nbsp;&nbsp;
                   <asp:DropDownList ID="DD_scending" runat="server" AutoPostBack="True">
                       <asp:ListItem>Ascending</asp:ListItem>
                       <asp:ListItem>Descending</asp:ListItem>
                   </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:DropDownList ID="DD_Theme" runat="server" AutoPostBack="True">
                       <asp:ListItem>Name</asp:ListItem>
                       <asp:ListItem>Price</asp:ListItem>
                   </asp:DropDownList>
&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td class="auto-style9">&nbsp;</td>
               <td colspan="3">
                   <asp:DataList ID="DL_ProdCat" runat="server" BorderColor="Black" CellPadding="500" CellSpacing="50" GridLines="Both" RepeatColumns="3" RepeatDirection="Horizontal">
                       <ItemTemplate>
                           <table>
                               <tr>
                                   <td>Discount</td>
                                       <br />
                                       <td><%#Eval("Discount") %></td>
                               </tr>
                               <tr>
                                   <td class="text-center">
                                       <asp:Image ID="Image1" runat="server" ImageURL='~/images/<%#Eval("Product_Img") %>' Height="150px" Width="150px"></asp:Image>
                                   </td>
                               </tr>
                               <tr>
                                   <td>ID</td>
                                       <br />
                                       <td>
                                           <asp:Label ID="ProdID" runat="server" Text='<%#Eval("Product_ID") %>'></asp:Label>
                                       </td>
                               </tr>
                               <tr>
                                   <td>Name</td>
                                       <br />
                                       <td><%#Eval("Product_Name") %></td>
                               </tr>
                               <tr>
                                   <td>Price</td>
                                       <br />
                                       <td><%#Eval("Product_Price") %></td>
                               </tr>
                               <tr>
                                   <td>Status</td>
                                       <br />
                                       <td><%#Eval("Status") %></td>
                               </tr>
                               <tr>
                                   <asp:Button ID="Btn_View" runat="server" Text="View" />
                                       <br />
                                       <asp:Button ID="Btn_AddCart" runat="server" Text="Cart" />
                               </tr>
                           </table>
                       </ItemTemplate>
                   </asp:DataList>
               </td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td class="auto-style9">&nbsp;</td>
               <td class="auto-style6">&nbsp;</td>
               <td class="auto-style4">&nbsp;</td>
               <td class="auto-style8">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
       </table>
&nbsp;
    </form>
</asp:Content>
