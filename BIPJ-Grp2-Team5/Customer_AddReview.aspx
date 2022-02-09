<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="Customer_AddReview.aspx.cs" Inherits="BIPJ_Grp2_Team5.Customer_AddReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            height: 400px;
        }
        .auto-style3 {
            height: 67px;
        }
        .auto-style4 {
            width: 151px;
        }
        .auto-style5 {
            height: 67px;
            width: 151px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style3" colspan="2">
                    <h1 class="text-center"><strong>Review</strong></h1>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td colspan="2">Breadcrumb</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>Reviewing :
                    <asp:DropDownList ID="DDL_Product" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td>Star Rating:&nbsp;
                    <asp:ImageButton ID="ImgBtn_1" runat="server" Height="50px" OnClick="ImgBtn_1_Click" Width="50px" />
&nbsp;
                    <asp:ImageButton ID="ImgBtn_2" runat="server" Height="50px" OnClick="ImgBtn_2_Click" Width="50px" />
&nbsp;
                    <asp:ImageButton ID="ImgBtn_3" runat="server" Height="50px" OnClick="ImgBtn_3_Click" Width="50px" />
&nbsp;
                    <asp:ImageButton ID="ImgBtn_4" runat="server" Height="50px" OnClick="ImgBtn_4_Click" Width="50px" />
&nbsp;
                    <asp:ImageButton ID="ImgBtn_5" runat="server" Height="50px" OnClick="ImgBtn_5_Click" Width="50px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="text-left" colspan="2">Review:<br />
                    <asp:TextBox ID="tb_Comment" runat="server" Height="140px" Width="972px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="text-right" colspan="2">&nbsp;<asp:Button ID="btn_Create" runat="server" Text="Create" OnClick="btn_Create_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="btn_Cancel" runat="server" CausesValidation="False" Text="Cancel" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
