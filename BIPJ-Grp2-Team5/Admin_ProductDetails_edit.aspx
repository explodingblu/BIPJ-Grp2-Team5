<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_ProductDetails_edit.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_ProductDetails_edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 100%;
            height: 414px;
        }
        .auto-style6 {
            height: 52px;
        }
        .auto-style7 {
            text-decoration: underline;
            font-weight: bold;
            text-align: center;
        }
        .auto-style8 {
            font-size: x-large;
        }
        .auto-style9 {
            font-size: medium;
        }
        .auto-style10 {
            width: 455px;
        }
        .auto-style11 {
            font-size: medium;
            width: 455px;
        }
        .auto-style13 {
            width: 614px;
        }
        .auto-style14 {
            font-size: medium;
            width: 614px;
        }
        .auto-style15 {
            height: 52px;
            width: 614px;
            font-size: medium;
        }
        .auto-style16 {
            font-size: medium;
            width: 455px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">

    <table class="auto-style5">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style13"><h1 class="auto-style7"><strong>Product Edit</strong></h1></td>
            <td>&nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style16" rowspan="7">
                <asp:Image ID="img_result" runat="server" Height="150px" Width="150px" />
            </td>
            <td class="auto-style14">Product ID</td>
            <td class="auto-style9">
                <asp:Label ID="lbl_ProdID" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Name</td>
            <td class="auto-style9">
                <asp:TextBox ID="tb_ProdName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Description</td>
            <td class="auto-style9">
                <asp:TextBox ID="tb_ProdDesc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Product Image</td>
            <td class="auto-style6">
                <asp:FileUpload ID="fu_ProdImg" runat="server" />
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Price ($)</td>
            <td class="auto-style9">
                <asp:TextBox ID="tb_ProdPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Discount (%)</td>
            <td class="auto-style9">
                <asp:TextBox ID="tb_ProdDisc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Status</td>
            <td class="auto-style9">
                <asp:DropDownList ID="DD_Status" runat="server" Height="22px" Width="169px">
                    <asp:ListItem>In Stock</asp:ListItem>
                    <asp:ListItem>Not In Stock</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="Btn_EditProdConfirm" runat="server" Text="Edit" Width="100px" OnClick="Btn_EditProdConfirm_Click" />
&nbsp;<asp:Button ID="Btn_Cancel" runat="server" Text="Cancel" Width="100px" OnClick="Btn_Back_Click" />
            </td>
        </tr>
    </table>

    </form>
</asp:Content>
