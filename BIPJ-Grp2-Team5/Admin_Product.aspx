<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Product.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">Product</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:GridView ID="gvProduct" runat="server" Width="749px">
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:Button ID="AddProdButton" runat="server" Text="Add Product" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
