<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Product.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
    .auto-style5 {
        width: 100%;
        height: 471px;
    }
    .auto-style6 {
        height: 121px;
    }
    .auto-style7 {
        height: 121px;
        text-align: center;
        text-decoration: underline;
        font-weight: bold;
        font-size: xx-large;
        width: 783px;
    }
    .auto-style8 {
        height: 121px;
        width: 498px;
    }
    .auto-style9 {
        width: 498px;
    }
    .auto-style10 {
        width: 783px;
        text-align: right;
    }
    .auto-style12 {
        width: 783px;
        height: 193px;
        text-align: center;
    }
    .auto-style13 {
        height: 193px;
    }
    .auto-style14 {
        width: 498px;
        height: 193px;
        text-align: center;
    }
        .auto-style15 {
            font-size: medium;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form id="form1" runat="server">
    <table class="auto-style5">
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style7"><strong>Product</strong></td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style14"></td>
        <td class="auto-style12">
            <asp:GridView ID="gvProduct" runat="server" Width="706px" AutoGenerateColumns="False" CssClass="auto-style15" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Product_ID" HeaderText="ID" />
                    <asp:BoundField DataField="Product_Name" HeaderText="Name" />
                    <asp:BoundField DataField="Product_Price" HeaderText="Price" />
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </td>
        <td class="auto-style13"></td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style10">
            <asp:Button ID="Btn_AddProd" runat="server" OnClick="Btn_AddProd_Click" Text="Add Product" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</form>
    
</asp:Content>
