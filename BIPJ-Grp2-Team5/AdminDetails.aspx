<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDetails.aspx.cs" Inherits="RIFT_New.AdminDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .UpperCaseFirstLetter{
            text-transform: capitalize;
        }
    </style>
    <h3>Admin Details</h3>
    <p>Table sorted in <asp:Label ID="lbl_SortDr" runat="server"></asp:Label>&nbsp;order.</p>
    <p>
        Search Admin By ID/Name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_SearchResult" runat="server" CssClass="UpperCaseFirstLetter"></asp:TextBox> &nbsp;&nbsp;&nbsp; 
        <asp:Button ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click" /> &nbsp;&nbsp;&nbsp; 
        <asp:Button ID="btn_Reset" runat="server" Text="Reset" OnClick="btn_Reset_Click" />
&nbsp;&nbsp;&nbsp; <asp:Label ID="lbl_NotFound" runat="server" ForeColor="Red" Visible="False">No Result Found!</asp:Label>
    </p>
    <p>
        <asp:Button ID="btn_AddAdmin" runat="server" Text="Register New Admin" OnClick="btn_AddAdmin_Click" Width="184px" />    
    </p>

    <asp:GridView ID="gv_Admin" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="2" CellSpacing="2" DataKeyNames="AdminID" HorizontalAlign="Left" 
         AllowPaging="True" Width="600px" CssClass="auto-style1" PageSize="5" OnPageIndexChanging="gv_Admin_PageIndexChanging" OnRowCancelingEdit="gv_Admin_RowCancelingEdit" OnRowDataBound="gv_Admin_RowDataBound" OnRowDeleting="gv_Admin_RowDeleting" OnRowEditing="gv_Admin_RowEditing" OnRowUpdating="gv_Admin_RowUpdating" OnSorting="gv_Admin_Sorting" >
            
        <Columns>
            <asp:BoundField DataField="AdminID" HeaderText="Admin ID" ReadOnly="True" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"/>
            <asp:BoundField DataField="Password" HeaderText="Password" ReadOnly="True" />

            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="UpdateLB" runat="server" CausesValidation="True" CommandName="Update" OnClientClick="return confirm('Are you sure you want to update this customer record?');" Text="Update"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="CancelLB" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="EditLB" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="DeleteLB" runat="server" CausesValidation="False" CommandArgument='<%# Eval("Name") %>' CommandName="Delete" Text="Delete"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <SelectedRowStyle BackColor="#FFF0D5" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />  
        <SortedAscendingHeaderStyle BackColor="#808080"/>  
        <SortedDescendingCellStyle BackColor="#CAC9C9" />  
        <SortedDescendingHeaderStyle BackColor="#383838"/>  
    </asp:GridView>

</asp:Content>
