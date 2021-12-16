<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="Customization.aspx.cs" Inherits="BIPJ_Grp2_Team5.Customization" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        text-align: center;
        text-decoration: underline;
    }
    .auto-style3 {
        width: 503px
    }
    .auto-style4 {
        width: 379px;
        text-decoration: underline;
    }
    .auto-style5 {
        text-decoration: underline;
        width: 461px;
    }
    .auto-style6 {
        width: 120px;
    }
    .auto-style7 {
        width: 461px;
    }
    .auto-style8 {
        width: 379px
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style3"><h1 class="auto-style1">Customization</h1></td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">Shape<br />
                <asp:DropDownList ID="DD_Shape" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">Color<br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">Size<br />
                <asp:DropDownList ID="DD_Size" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">Stackable<br />
                <asp:CheckBox ID="CB_Stackable" runat="server" Text="Stackable" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">Compartment<br />
                <asp:DropDownList ID="DD_Compartment" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">Comments<br />
                <asp:TextBox ID="TB_Comments" runat="server" Height="42px" Width="160px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
&nbsp;
</form>
</asp:Content>
