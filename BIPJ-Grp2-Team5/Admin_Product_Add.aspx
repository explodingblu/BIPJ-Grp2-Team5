<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Product_Add.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Product_Add" %>
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
            height: 70px;
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
            width: 295px;
        }
        .auto-style14 {
            font-size: medium;
            width: 295px;
        }
        .auto-style15 {
            height: 52px;
            width: 295px;
            font-size: medium;
        }
        .auto-style16 {
            font-size: medium;
            width: 270px;
            text-align: center;
        }
        .auto-style17 {
            font-size: medium;
            width: 268px;
            text-align: center;
        }
        .auto-style18 {
            font-size: medium;
            width: 375px;
        }
        .auto-style19 {
            height: 52px;
            width: 375px;
        }
        .auto-style20 {
            font-size: small;
        }
        .auto-style21 {
            font-size: medium;
            width: 295px;
            height: 32px;
        }
        .auto-style22 {
            font-size: medium;
            width: 375px;
            height: 32px;
        }
        .auto-style23 {
            font-size: medium;
            height: 32px;
        }
        .auto-style24 {
            font-size: medium;
            width: 295px;
            height: 4px;
        }
        .auto-style25 {
            font-size: medium;
            width: 375px;
            height: 4px;
        }
        .auto-style26 {
            font-size: medium;
            height: 4px;
        }
        .auto-style27 {
            font-size: medium;
            width: 270px;
            text-align: left;
        }
        .auto-style28 {
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

    <table class="auto-style5">
        <tr>
            <td class="auto-style10" colspan="2">&nbsp;</td>
            <td class="auto-style13"><h1 class="auto-style7"><strong>Product Add</strong></h1></td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style17" rowspan="7">
                &nbsp;</td>
            <td class="auto-style27">
                <asp:LinkButton ID="Link_Product" runat="server" OnClick="Link_Product_Click">Product</asp:LinkButton>
&nbsp;&gt; <span class="auto-style28"><strong>Add Product</strong></span></td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style18">
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style16" rowspan="6">
                <asp:Label ID="lbl_ImgTemp" runat="server" Text="&lt;&lt;&gt;&gt;"></asp:Label>
            </td>
            <td class="auto-style24">Product ID*</td>
            <td class="auto-style25">
                <asp:TextBox ID="tb_ProdID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:RequiredFieldValidator ID="rfv_ProdID" runat="server" ControlToValidate="tb_ProdID" CssClass="auto-style20" ErrorMessage="Please enter Product ID" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CustomValidator ID="cv_ExistProdID" runat="server" ControlToValidate="tb_ProdID" ErrorMessage="Product ID already exist" ForeColor="Red" OnServerValidate="CV_Exist_ServerValidate"></asp:CustomValidator>
                <br />
                <asp:CompareValidator ID="cv_ProdID" runat="server" ControlToValidate="tb_ProdID" CssClass="auto-style20" ErrorMessage="Only Interger value is allowed" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">Only Numeric value is allowed</asp:CompareValidator>
                <br />
                <asp:CustomValidator ID="cv_LessProdID" runat="server" CssClass="auto-style20" ErrorMessage="Product ID cannot be less than 0" ForeColor="Red" OnServerValidate="cv_LessProdID_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style21">Product Name*</td>
            <td class="auto-style22">
                <asp:TextBox ID="tb_ProdName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style23">
                <asp:RequiredFieldValidator ID="rfv_ProdName" runat="server" ControlToValidate="tb_ProdName" CssClass="auto-style20" ErrorMessage="Please enter Product Name" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Description*</td>
            <td class="auto-style18">
                <asp:TextBox ID="tb_ProdDesc" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style9">
                <asp:RequiredFieldValidator ID="rfv_ProdDesc" runat="server" ControlToValidate="tb_ProdDesc" CssClass="auto-style20" ErrorMessage="Please enter Product Description" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Product Image*</td>
            <td class="auto-style19">
                <asp:FileUpload ID="fu_ProdImg" runat="server" CssClass="auto-style20" />
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="rfv_ProdImg" runat="server" ControlToValidate="fu_ProdImg" CssClass="auto-style20" ErrorMessage="Please input Product Image" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Price ($)*</td>
            <td class="auto-style18">
                <asp:TextBox ID="tb_ProdPrice" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style9">
                <asp:RequiredFieldValidator ID="rfv_ProdPrice" runat="server" ControlToValidate="tb_ProdPrice" CssClass="auto-style20" ErrorMessage="Please enter Product Price" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="cv_ProdPrice" runat="server" ControlToValidate="tb_ProdPrice" CssClass="auto-style20" ErrorMessage="Only Numeric value is allowed" ForeColor="Red" Operator="DataTypeCheck" Type="Double">Only Numeric value is allowed</asp:CompareValidator>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style14">Product Discount (%)*</td>
            <td class="auto-style18">
                <asp:TextBox ID="tb_ProdDisc" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style9">
                <asp:CustomValidator ID="cv_LessDiscount" runat="server" CssClass="auto-style20" ErrorMessage="Discount cannot be less than 0" ForeColor="Red" OnServerValidate="cv_LessDiscount_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr class="auto-style8">
            <td class="auto-style11" colspan="2">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style9" colspan="2">
                <asp:Button ID="Btn_AddProdConfirm" runat="server" Text="Add" Width="100px" OnClick="Btn_AddProdConfirm_Click" />
&nbsp;<asp:Button ID="Btn_Back" runat="server" Text="Cancel" Width="100px" OnClick="Btn_Back_Click" />
            </td>
        </tr>
    </table>

    </form>

</asp:Content>
