<%@ Page Title="" Language="C#" MasterPageFile="~/Customer_Navbar.Master" AutoEventWireup="true" CodeBehind="Customer_AllReview.aspx.cs" Inherits="BIPJ_Grp2_Team5.Customer_AllReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style2 {
            width: 474px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:GridView ID="gv_Reviews" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Review_ID" HeaderText="ID" />
                            <asp:BoundField DataField="Product_Rating" HeaderText="Rating" />
                            <asp:BoundField DataField="Product_Comment" HeaderText="Comment" />
                            <asp:BoundField DataField="Product_ID" HeaderText="Prod ID" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Btn_AddReview" runat="server" Text="Add Review" OnClick="Btn_AddReview_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
 
</asp:Content>
