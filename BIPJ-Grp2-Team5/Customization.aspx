<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="Customization.aspx.cs" Inherits="BIPJ_Grp2_Team5.Customization" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Customization</h1>
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td style="width: 288px">Customization Menu</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 288px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td rowspan="6" style="width: 288px">
                <asp:Image ID="Image1" runat="server" Height="303px" Width="380px" style="margin-top: 0px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px">
                <span style="text-decoration: underline"><strong>Size</strong></span><br />
                <asp:DropDownList ID="DropDownList3" runat="server" Height="21px" Width="186px">
                </asp:DropDownList>
            </td>
            <td style="height: 22px">
                <span style="text-decoration: underline"><strong>Colour:</strong><asp:Label ID="Label1" runat="server" style="" Text="Label"></asp:Label>
                </span>
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" Width="50px" />
            </td>
        </tr>
        <tr>
            <td>
                <span style="text-decoration: underline"><strong>Material</strong></span><br />
                <asp:DropDownList ID="DropDownList4" runat="server" Height="18px" Width="186px">
                </asp:DropDownList>
            </td>
            <td>
                <span style="text-decoration: underline"><strong>Add Image</strong></span><br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <span style="text-decoration: underline"><strong>Compartment</strong></span><br />
                <asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" Height="16px" Width="186px">
                </asp:DropDownList>
            </td>
            <td style="text-decoration: underline">
                <strong>Add Texts<br />
                </strong>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <span style="text-decoration: underline"><strong>Stackable</strong></span><asp:CheckBoxList ID="CheckBoxList1" runat="server" style="margin-top: 0px" Height="17px" Width="186px">
                </asp:CheckBoxList>
            </td>
            <td style="text-decoration: underline">
                <strong>Any Comments?<br />
                </strong>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px">
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 288px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 288px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Accept" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>
