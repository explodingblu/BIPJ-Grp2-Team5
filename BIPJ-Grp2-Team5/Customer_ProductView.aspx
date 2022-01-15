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
        .auto-style19 {
            font-size: medium;
            width: 217px;
        }
        .auto-style20 {
            font-size: medium;
            text-align: right;
        }
        .auto-style21 {
            width: 455px;
            text-align: center;
        }
        .auto-style22 {
            width: 455px;
            text-align: center;
            font-size: large;
        }
        .auto-style23 {
            text-align: center;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">

    <table class="auto-style5">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td colspan="2"><h1 class="auto-style7">View
                <asp:Label ID="lbl_prodName" runat="server" Text="Label"></asp:Label>
                </h1></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:LinkButton ID="Link_Shop" runat="server" OnClick="Link_Product_Click" CssClass="auto-style9">Shop</asp:LinkButton>
                <span class="auto-style9">&nbsp;&gt;</span><span class="auto-style28"><strong><span class="auto-style9"> View Product</span></strong></span></td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">Process</td>
            <td colspan="2" class="auto-style23">Details</td>
            <td class="auto-style23">Review</td>
        </tr>
        <tr>
            <td class="auto-style10" rowspan="6"></td>
            <td colspan="2" class="text-center">
                <asp:Image ID="img_prodImg" runat="server" Height="175px" Width="175px" />
            </td>
            <td rowspan="6">&nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product ID</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodID" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product Description</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodDesc" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product Price ($)</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodPrice" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Product Discount (%)</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_Discount" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19">Status</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_status" runat="server" Text="Label"></asp:Label>
            </td>
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
