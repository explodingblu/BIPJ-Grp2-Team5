<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="ProductCatalogue.aspx.cs" Inherits="BIPJ_Grp2_Team5.ProductCatalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style25 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <table class="auto-style14">
           <tr>
               <td>
                   <asp:LinkButton ID="HomeBC" runat="server">Home</asp:LinkButton>
&nbsp;&gt; Shop</td>
               <td class="auto-style2"><strong>Shop</strong></td>
               <td>Sort By:
                   <asp:DropDownList ID="SortDD" runat="server">
                   </asp:DropDownList>
               </td>
               <td>
                   <asp:TextBox ID="SeachInput" runat="server"></asp:TextBox>
                   <asp:Button ID="SearchButton" runat="server" Text="Search" />
               </td>
           </tr>
           <tr>
               <td>&nbsp;</td>
               <td class="auto-style25">
                   <asp:Image ID="ProdImg2" runat="server" Height="110px" Width="132px" />
                   <br />
                   <asp:Label ID="ProdLabel2" runat="server" Text="Label"></asp:Label>
               </td>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
       </table>
&nbsp;
</asp:Content>
