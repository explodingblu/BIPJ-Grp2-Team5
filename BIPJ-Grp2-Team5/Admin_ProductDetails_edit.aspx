<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_ProductDetails_edit.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_ProductDetails_edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 100%;
            height: 414px;
        }
        .auto-style6 {
            height: 52px;
            width: 284px;
        }
        .auto-style7 {
            text-decoration: underline;
            font-weight: bold;
            text-align: center;
            height: 71px;
        }
        .auto-style8 {
            font-size: x-large;
        }
        .auto-style10 {
            width: 883px;
        }
        .auto-style14 {
            font-size: medium;
            width: 332px;
        }
        .auto-style15 {
            height: 52px;
            width: 332px;
            font-size: medium;
        }
        .auto-style16 {
            font-size: medium;
            text-align: center;
            width: 448px;
        }
        .auto-style17 {
            font-size: medium;
            width: 332px;
            height: 30px;
        }
        .auto-style18 {
            font-size: medium;
            height: 30px;
            width: 284px;
        }
        .auto-style19 {
            font-size: medium;
            width: 319px;
            text-align: center;
        }
        .auto-style20 {
            font-size: medium;
            width: 879px;
        }
        .auto-style21 {
            font-size: medium;
            width: 319px;
        }
        .auto-style22 {
            width: 332px
        }
        .auto-style23 {
            font-size: medium;
            width: 277px;
        }
        .auto-style24 {
            font-size: medium;
            height: 30px;
            width: 277px;
        }
        .auto-style25 {
            height: 52px;
            width: 277px;
        }
        .auto-style26 {
            font-size: medium;
            width: 284px;
        }
        .auto-style27 {
            font-size: small;
            width: 879px;
        }
        .auto-style28 {
            text-decoration: underline;
        }
        .auto-style29 {
            font-size: medium;
            width: 448px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style5">
        <tr>
            <td class="auto-style10" colspan="2">&nbsp;</td>
            <td class="auto-style22"><h1 class="auto-style7"><strong>Product Edit</strong></h1></td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style19" rowspan="8">
                &nbsp;</td>
            <td class="auto-style16">
                <asp:LinkButton ID="Link_Product" runat="server" OnClick="Link_Product_Click" CausesValidation="False">Products</asp:LinkButton>
&nbsp;&gt; <span class="auto-style28"><strong>
                <asp:LinkButton ID="Link_ProdID" runat="server" OnClick="Link_ProdID_Click" CausesValidation="False"></asp:LinkButton>
                </strong></span>&nbsp;&gt;<span class="auto-style28"><strong>Edit Product</strong></span></td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
            <td class="auto-style26">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style16" rowspan="7">
                <asp:Image ID="img_result" runat="server" Height="150px" Width="150px" />
            </td>
            <td class="auto-style14">Product ID</td>
            <td class="auto-style23">
                <asp:Label ID="lbl_ProdID" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style26">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Name</td>
            <td class="auto-style23">
                <asp:TextBox ID="tb_ProdName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:RequiredFieldValidator ID="rfv_ProdName" runat="server" ControlToValidate="tb_ProdName" CssClass="auto-style20" ErrorMessage="Please enter Product Name" ForeColor="Red" style="font-size: small"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style17">Product Description</td>
            <td class="auto-style24">
                <asp:TextBox ID="tb_ProdDesc" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style18">
                <asp:RequiredFieldValidator ID="rfv_ProdDesc" runat="server" ControlToValidate="tb_ProdDesc" CssClass="auto-style27" ErrorMessage="Please enter Product Description" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Product Image</td>
            <td class="auto-style25">
                <asp:FileUpload ID="fu_ProdImg" runat="server" />
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="rfv_ProdImg" runat="server" ControlToValidate="fu_ProdImg" CssClass="auto-style27" ErrorMessage="Please input Product Image" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Price (SGD)</td>
            <td class="auto-style23">
                <asp:TextBox ID="tb_ProdPrice" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:RequiredFieldValidator ID="rfv_ProdPrice" runat="server" ControlToValidate="tb_ProdPrice" CssClass="auto-style27" ErrorMessage="Please enter Product Price" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="cv_ProdPrice" runat="server" ControlToValidate="tb_ProdPrice" CssClass="auto-style27" ErrorMessage="Only Numeric value is allowed" ForeColor="Red" Operator="DataTypeCheck" Type="Double">Only Numeric value is allowed</asp:CompareValidator>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Discount (%)</td>
            <td class="auto-style23">
                <asp:TextBox ID="tb_ProdDisc" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Status</td>
            <td class="auto-style23">
                <asp:DropDownList ID="DD_Status" runat="server" Height="22px" Width="169px">
                    <asp:ListItem>In Stock</asp:ListItem>
                    <asp:ListItem>Not In Stock</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style26">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style23">
                <asp:Button ID="Btn_EditProdConfirm" runat="server" Text="Edit" Width="100px" OnClick="Btn_EditProdConfirm_Click" />
&nbsp;<asp:Button ID="Btn_Cancel" runat="server" Text="Cancel" Width="100px" OnClick="Btn_Back_Click" CausesValidation="False" />
            </td>
            <td class="auto-style26">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
