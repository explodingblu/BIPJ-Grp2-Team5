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
            <asp:GridView ID="gvProduct" runat="server" Width="706px" AutoGenerateColumns="False" CssClass="auto-style15" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" OnRowDeleting="gvProduct_RowDeleting">
                <Columns>
                    <asp:ImageField HeaderText="Image" DataImageUrlField="Product_Image" DataImageUrlFormatString="~\images\{0}" ControlStyle-Width="100" ControlStyle-Height = "100">
                    </asp:ImageField>
                    <asp:BoundField DataField="Product_ID" HeaderText="ID" />
                    <asp:BoundField DataField="Product_Name" HeaderText="Name" />
                    <asp:BoundField DataField="Product_Price" HeaderText="Price" />
                    <asp:BoundField DataField="Discount" HeaderText="Discount" />
                    <asp:BoundField HeaderText="Stock" />
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <input type="checkbox" data-toggle="toggle" data-style="ios" class="toggle-two"/>
                            <div id="alertvalue" ></div>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowSelectButton="True" />
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
