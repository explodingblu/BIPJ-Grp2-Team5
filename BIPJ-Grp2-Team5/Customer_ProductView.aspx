<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="Customer_ProductView.aspx.cs" Inherits="BIPJ_Grp2_Team5.Customer_ProductView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 100%;
            height: 414px;
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
        .auto-style14 {
            font-size: medium;
            width: 614px;
        }
        .auto-style16 {
            font-size: medium;
            width: 455px;
            text-align: center;
        }
        .auto-style19 {
            font-size: medium;
            width: 217px;
        }
        .auto-style20 {
            font-size: medium;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">

    <table class="auto-style5">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td colspan="2"><h1 class="auto-style7"><strong>Product View</strong></h1></td>
            <td>&nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style16" rowspan="5">
                <asp:Image ID="img_prodImg" runat="server" Height="175px" Width="175px" />
            </td>
            <td class="auto-style19">Product ID</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodID" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product Name</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodName" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product Description</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodDesc" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product Price ($)</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodPrice" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product Discount (%)</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_Discount" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style20">
                <asp:Button ID="Btn_Buy" runat="server" Text="Buy" Width="100px" OnClick="Btn_Buy_Click" />
                &nbsp;
                <asp:Button ID="Btn_Edit" runat="server" Text="Customize" Width="100px" OnClick="Btn_Edit_Click" />
&nbsp; <asp:Button ID="Btn_Back" runat="server" Text="Back" Width="100px" OnClick="Btn_Back_Click" />
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
    </table>

    </form>
</asp:Content>
