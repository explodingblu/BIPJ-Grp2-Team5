<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_ProductDetails.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_ProductDetails" %>
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
            width: 601px;
                height: 102px;
            }
        .auto-style14 {
            font-size: medium;
            width: 614px;
        }
        .auto-style16 {
                font-size: medium;
                width: 601px;
                text-align: center;
            }
            .auto-style20 {
                font-size: medium;
                text-align: right;
            }
            .auto-style27 {
                height: 102px;
            }
            .auto-style29 {
                font-size: medium;
                width: 614px;
                height: 60px;
            }
            .auto-style30 {
                font-size: medium;
                height: 60px;
            }
            .auto-style33 {
                font-size: medium;
                width: 614px;
                height: 40px;
            }
            .auto-style34 {
                font-size: medium;
                height: 40px;
            }
            .auto-style36 {
                font-size: medium;
                text-align: center;
            }
            .auto-style37 {
                font-size: medium;
                text-align: left;
            }
            .auto-style38 {
                width: 441px;
                height: 102px;
            }
            .auto-style39 {
                font-size: medium;
                width: 441px;
                text-align: center;
            }
            .auto-style41 {
                width: 592px;
                height: 102px;
            }
            .auto-style42 {
                font-size: medium;
                width: 592px;
                text-align: center;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server">

    <table class="auto-style5">
        <tr>
            <td class="auto-style38"></td>
            <td class="auto-style41"></td>
            <td class="auto-style10"></td>
            <td colspan="2" class="auto-style27"><h1 class="auto-style7"><strong>Product Add</strong></h1></td>
            <td class="auto-style27"></td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style39" rowspan="9">
                &nbsp;</td>
            <td class="auto-style42">
                &nbsp;</td>
            <td class="auto-style16">
            </td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style42">
                Process</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style42" rowspan="6">
                &nbsp;</td>
            <td class="auto-style36" colspan="3">
                <asp:Image ID="img_prodImg" runat="server" Height="175px" Width="175px" />
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product ID</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodID" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Name</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_prodName" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Description</td>
            <td class="auto-style29">
                <asp:Label ID="lbl_prodDesc" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style30">
                </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Price (SGD)</td>
            <td class="auto-style33">
                <asp:Label ID="lbl_prodPrice" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style34">
                </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Discount (%)</td>
            <td class="auto-style14">
                <asp:Label ID="lbl_Discount" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style42">
                <asp:Button ID="Btn_Insert" runat="server" Text="Insert" Width="100px" OnClick="Btn_Edit_Click" />
            </td>
            <td class="auto-style9" colspan="2">&nbsp;</td>
            <td class="auto-style20">
                <asp:Button ID="Btn_Edit" runat="server" Text="Edit" Width="100px" OnClick="Btn_Edit_Click" />
&nbsp; <asp:Button ID="Btn_Back" runat="server" Text="Cancel" Width="100px" OnClick="Btn_Back_Click" />
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
    </table>

    </form>
</asp:Content>
