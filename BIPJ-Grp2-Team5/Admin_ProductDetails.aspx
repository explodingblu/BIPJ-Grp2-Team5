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
        .auto-style16 {
                font-size: medium;
                width: 601px;
                text-align: center;
            }
            .auto-style20 {
                font-size: medium;
                text-align: right;
                width: 303px;
            }
            .auto-style27 {
                height: 102px;
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
            .auto-style43 {
                font-size: medium;
                width: 592px;
                text-align: left;
            }
            .auto-style44 {
                text-decoration: underline;
            }
            .auto-style45 {
                font-size: medium;
                text-align: center;
            }
            .auto-style46 {
                height: 102px;
                width: 509px;
            }
            .auto-style47 {
                font-size: medium;
                width: 509px;
            }
            .auto-style48 {
                font-size: medium;
                text-align: center;
                width: 509px;
            }
            .auto-style49 {
                font-size: medium;
                width: 303px;
            }
            .auto-style50 {
                font-size: medium;
                height: 60px;
                width: 303px;
            }
            .auto-style51 {
                font-size: medium;
                height: 40px;
                width: 303px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style5">
        <tr>
            <td class="auto-style38"></td>
            <td class="auto-style41"></td>
            <td class="auto-style10"></td>
            <td colspan="2" class="auto-style27"><h1 class="auto-style7"><strong>Product Add</strong></h1></td>
            <td class="auto-style46"></td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style39" rowspan="10">
                &nbsp;</td>
            <td class="auto-style43">
                <asp:LinkButton ID="Link_Product" runat="server" OnClick="Link_Product_Click" CausesValidation="False">Products</asp:LinkButton>
&nbsp;&gt; <strong>
                <asp:Label ID="lbl_Breadcrumb" runat="server" CssClass="auto-style44" Text="Label"></asp:Label>
                </strong></td>
            <td class="auto-style16">
            </td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style49">
                &nbsp;</td>
            <td class="auto-style47">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style42">
                Process</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style49">
                &nbsp;</td>
            <td class="auto-style48">
                Review</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style42" rowspan="7">
                &nbsp;</td>
            <td class="auto-style45" colspan="3">
                <asp:Image ID="img_prodImg" runat="server" Height="175px" Width="175px" />
            </td>
            <td class="auto-style47" rowspan="7">
                <asp:GridView ID="gv_ProdReview" runat="server" AutoGenerateColumns="False" Width="308px">
                    <Columns>
                        <asp:BoundField DataField="Review_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Product_Rating" HeaderText="Rating" />
                        <asp:BoundField DataField="Product_Comment" HeaderText="Comment" />
                        <asp:BoundField DataField="Customer_ID" HeaderText="By Customer ID" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Ratings</td>
            <td class="auto-style49">
                <asp:Label ID="lbl_prodReview" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product ID</td>
            <td class="auto-style49">
                <asp:Label ID="lbl_prodID" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Name</td>
            <td class="auto-style49">
                <asp:Label ID="lbl_prodName" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Description</td>
            <td class="auto-style50">
                <asp:Label ID="lbl_prodDesc" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Price (SGD)</td>
            <td class="auto-style51">
                <asp:Label ID="lbl_prodPrice" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style37" colspan="2">
                Product Discount (%)</td>
            <td class="auto-style49">
                <asp:Label ID="lbl_Discount" runat="server" Text="Label"></asp:Label>
            </td>
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
            <td class="auto-style47">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
