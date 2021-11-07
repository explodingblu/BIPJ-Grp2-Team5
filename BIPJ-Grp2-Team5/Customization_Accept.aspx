<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="Customization_Accept.aspx.cs" Inherits="BIPJ_Grp2_Team5.Customization_Accept" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1493px;
            height: 463px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td style="width: 478px">&nbsp;</td>
            <td class="modal-sm" style="text-decoration: underline; width: 424px"><strong>Customization Accept</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 478px">
                <span style="text-decoration: underline"><strong>Size<br />
                </strong>
                <asp:Label ID="Label7" runat="server" style="" Text="Label"></asp:Label>
                </span></td>
            <td class="modal-sm" rowspan="4" style="width: 424px">
                <asp:Image ID="Image1" runat="server" Height="303px" Width="409px" style="margin-top: 0px" />
            </td>
            <td>
                <span style="text-decoration: underline"><strong>Colour:<br />
                </strong>
                <asp:Label ID="Label1" runat="server" style="" Text="Label"></asp:Label>
                </span>
                </td>
        </tr>
        <tr>
            <td style="width: 478px">
                <span style="text-decoration: underline"><strong>Material<br />
                </strong>
                <asp:Label ID="Label6" runat="server" style="" Text="Label"></asp:Label>
                </span></td>
            <td>
                <span style="text-decoration: underline"><strong>Add Image<br />
                <asp:Image ID="Image2" runat="server" Height="44px" Width="49px" />
                </strong></span></td>
        </tr>
        <tr>
            <td style="width: 478px">
                <span style="text-decoration: underline"><strong>Compartment<br />
                </strong>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </span></td>
            <td>
                <strong>Add Texts<br />
                </strong>
                <span style="text-decoration: underline">
                <asp:Label ID="Label2" runat="server" style="" Text="Label"></asp:Label>
                </span>
                </td>
        </tr>
        <tr>
            <td style="width: 478px">
                <span style="text-decoration: underline"><strong>Stackable<br />
                </strong>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </span></td>
            <td><strong>Comments<br />
                </strong>
                <span style="text-decoration: underline">
                <asp:Label ID="Label3" runat="server" style="" Text="Label"></asp:Label>
                </span>
                </td>
        </tr>
        <tr>
            <td style="width: 478px">&nbsp;</td>
            <td class="modal-sm" style="width: 424px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Accept" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>
