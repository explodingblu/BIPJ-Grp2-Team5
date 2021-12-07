<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Product_Add.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Product_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    
        .auto-style3 {
            text-align: center;
        }
        .auto-style5 {
            width: 145px;
        }
        .auto-style6 {
            width: 151px;
        }
        .auto-style7 {
            width: 156px;
        }
        .auto-style8 {
            width: 161px;
        }
        .auto-style9 {
            width: 168px;
        }
        .auto-style10 {
            width: 175px;
        }
        .auto-style13 {
            width: 152px;
            text-align: left;
        }
        .auto-style15 {
            width: 152px;
            height: 33px;
        }
        .auto-style16 {
            width: 182px;
            text-align: left;
        }
        .auto-style17 {
            width: 373px;
            height: 33px;
            text-align: right;
        }
        .auto-style18 {
            width: 168px;
            height: 33px;
        }
        .auto-style19 {
            height: 33px;
            text-align: center;
        }
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
    <tr>
        <td class="auto-style7"></td>
        <td class="auto-style10" colspan="2"></td>
        <td class="auto-style6"></td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style3" colspan="2">
            <asp:Image ID="ProdImg" runat="server" Height="143px" Width="150px" />
        </td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style13">Product Image :&nbsp; </td>
        <td class="auto-style16">
            <asp:FileUpload ID="ProdImg_FileUpload" runat="server" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style13">Product ID :&nbsp; </td>
        <td class="auto-style16">
            <asp:Label ID="ProdID_Label" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style13">Name :&nbsp; </td>
        <td class="auto-style16">
            <asp:TextBox ID="ProdName_Input" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style13">Price : </td>
        <td class="auto-style16">
            <asp:TextBox ID="ProdPrice_Input" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style13">Description : </td>
        <td class="auto-style16">
            <asp:TextBox ID="ProdDesc_Input" runat="server" Height="68px" Width="374px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style18"></td>
        <td class="auto-style15"></td>
        <td class="auto-style17">&nbsp;<asp:Button ID="ProdAdd_Btn" runat="server" OnClick="ProdAdd_Btn_Click" Text="Add" Width="88px" />
&nbsp;&nbsp;
            <asp:Button ID="ProdBackBtn" runat="server" Text="Back" Width="92px" />
        </td>
        <td class="auto-style19">&nbsp;</td>
    </tr>
</table>
</asp:Content>
