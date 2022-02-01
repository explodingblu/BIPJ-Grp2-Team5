<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Product.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
    .auto-style5 {
        width: 100%;
        height: 471px;
            margin-right: 1px;
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
        width: 765px;
    }
    .auto-style8 {
            height: 121px;
            width: 8815px;
        }
    .auto-style10 {
        width: 765px;
        text-align: center;
    }
    .auto-style12 {
        width: 765px;
        height: 193px;
        }
    .auto-style13 {
        height: 193px;
    }
    .auto-style14 {
        width: 8815px;
        height: 193px;
        text-align: center;
    }
        .auto-style15 {
            font-size: medium;
        }
        .auto-style17 {
            height: 25px;
            text-align: left;
            text-decoration: underline;
            font-weight: bold;
            font-size: medium;
            width: 765px;
        }
        .auto-style18 {
            width: 8815px;
            height: 25px;
            font-size: medium;
        }
        .auto-style19 {
            height: 25px;
        }
        .auto-style20 {
            height: 121px;
            width: 219px;
        }
        .auto-style21 {
            width: 219px;
            height: 25px;
        }
        .auto-style22 {
            width: 219px;
            height: 193px;
            text-align: center;
        }
        .auto-style23 {
            width: 219px;
        }
        .auto-style24 {
            width: 219px;
            height: 26px;
            text-align: center;
        }
        .auto-style25 {
            width: 8815px;
            height: 26px;
            text-align: center;
        }
        .auto-style26 {
            width: 765px;
            height: 26px;
            text-align: center;
        }
        .auto-style27 {
            height: 26px;
        }
        .auto-style28 {
            height: 25px;
            text-align: right;
            font-weight: bold;
            font-size: medium;
            width: 765px;
        }
        .auto-style29 {
            width: 8815px
        }
        .auto-style30 {
            height: 25px;
            text-align: left;
            font-weight: bold;
            font-size: medium;
            width: 825px;
        }
        .auto-style31 {
            margin-left: 1;
        }
    </style>
    <script>
        $(function () {

            var jq = $.noConflict();
            jq(function () {
                jq('.toggle-two').bootstrapToggle({
                    Yes: 'Yes',
                    No: 'No'
                })
            })
            jq(function () {
                jq('.toggle-two').change(function () {
                var vbv = jq(this).prop('checked');
                    alert(vbv);
                    jq(this).parent().siblings("div").html('Toggle: ' + jq(this).prop('checked'))



                })
            })

        })

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  <%--</form>--%>
    <table class="auto-style5">
    <tr>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style7" colspan="2"><strong>Product</strong></td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style20"></td>
        <td class="auto-style8"></td>
        <td class="auto-style7" colspan="2">View All Products</td>
        <td class="auto-style6"></td>
    </tr>
    <tr>
        <td class="auto-style21"></td>
        <td class="auto-style18"></td>
        <td class="auto-style17" colspan="2"><strong>&nbsp;Products</strong></td>
        <td class="auto-style19"></td>
    </tr>
    <tr>
        <td class="auto-style21">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style30">
            &nbsp;
            <asp:ImageButton ID="ImgBtn_Refresh" runat="server" Height="35px" ImageUrl="~/Images/Refresh.jpeg" OnClick="ImgBtn_Refresh_Click" Width="35px" />
        </td>
        <td class="auto-style28">Search By ID:&nbsp;
            <asp:TextBox ID="tb_Search" runat="server" CssClass="auto-style31"></asp:TextBox>
&nbsp;<asp:Button ID="Btn_Search" runat="server" OnClick="Btn_Search_Click" Text="Search" />
        </td>
        <td class="auto-style19">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style14">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        <td class="auto-style12" colspan="2">
            <asp:GridView ID="gvProduct" runat="server" Width="1250px" AutoGenerateColumns="False" CssClass="auto-style15" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" OnRowDeleting="gvProduct_RowDeleting" DataKeyNames="Product_ID" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSorting="gvProduct_Sorting" onrowdatabound="gvProduct_RowDataBound" AllowPaging="True">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:ImageField HeaderText="Image" DataImageUrlField="Product_Image" DataImageUrlFormatString="~\images\{0}" ControlStyle-Width="100" ControlStyle-Height = "100">
                        <ControlStyle Height="100px" Width="100px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Product_ID" HeaderText="ID" SortExpression="Product_ID" />
                    <asp:BoundField DataField="Product_Name" HeaderText="Name" SortExpression="Product_Name" />
                    <asp:BoundField DataField="Product_Price" HeaderText="Price" SortExpression="Product_Price" />
                    <asp:BoundField DataField="Discount" HeaderText="Discount" />
                    <asp:BoundField HeaderText="Stock" DataField="Stock_Lvl" />
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Button ID="btn_Status" runat="server" CommandArgument='<%# Eval("Product_ID") %>' CommandName='<%# Eval("Status") %>' ForeColor='<%# Eval("Status").ToString()=="In Stock"?System.Drawing.Color.Green:System.Drawing.Color.Red %>' OnClick="btn_Status_Click" text="" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </td>
        <td class="auto-style13"></td>
    </tr>
    <tr>
        <td class="auto-style24"></td>
        <td class="auto-style25"></td>
        <td class="auto-style26" colspan="2">
        </td>
        <td class="auto-style27"></td>
    </tr>
    <tr>
        <td class="auto-style23">&nbsp;</td>
        <td class="auto-style29">&nbsp;</td>
        <td class="auto-style10" colspan="2">
            <asp:Button ID="Btn_AddProd" runat="server" OnClick="Btn_AddProd_Click" Text="Add Product" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
<%--</form>--%>
    
</asp:Content>
