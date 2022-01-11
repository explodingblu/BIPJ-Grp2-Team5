<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="BIPJ_Grp2_Team5.WebForm3" %>
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
           <table border="0" cellpadding="0" cellspacing="0">
<tr>
    <td>
        Name:
    </td>
</tr>
<tr>
    <td>
        <asp:TextBox ID="txtPageName" runat="server" />
    </td>
</tr>
<tr>
    <td>
        &nbsp;
    </td>
</tr>
<tr>
    <td>
        Title:
    </td>
</tr>
<tr>
    <td>
        <asp:TextBox ID="txtTitle" runat="server" />
    </td>
</tr>
<tr>
    <td>
        &nbsp;
    </td>
</tr>
<tr>
    <td>
        Content:
    </td>
</tr>
<tr>
    <td>
        <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" />
    </td>
</tr>
<tr>
    <td>
        &nbsp;
    </td>
</tr>
<tr>
    <td>
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="Submit" />
    </td>
</tr>
</table>
<script type="text/javascript" src="//tinymce.cachefly.net/4.0/tinymce.min.js"></script>
<script type="text/javascript">
    tinymce.init({ selector: 'textarea' });
</script>


</table>
</form>
</asp:Content>