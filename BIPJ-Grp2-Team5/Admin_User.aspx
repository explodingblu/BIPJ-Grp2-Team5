<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_User.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <style type="text/css">
        .UpperCaseFirstLetter{
            text-transform: capitalize;
        }
    </style>
    <div class ="container">
        <h3>Customer Information</h3>
        <p>Table sorted in <asp:Label ID="lbl_SortDr" runat="server"></asp:Label>&nbsp;order.</p>
        <p>
            Search Customer By Name/Phone Number:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_SearchResult" runat="server" CssClass="UpperCaseFirstLetter"></asp:TextBox> &nbsp;&nbsp;&nbsp; <asp:Button ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click" /> 
            &nbsp;&nbsp;&nbsp; 
            <asp:Button ID="btn_Reset" runat="server" OnClick="btn_Reset_Click" Text="Reset" />
    &nbsp;&nbsp;&nbsp; <asp:Label ID="lbl_NotFound" runat="server" ForeColor="Red" Visible="False">No Result Found!</asp:Label>
        </p>

        <asp:GridView ID="gv_Customer" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="2" CellSpacing="2" DataKeyNames="Id" HorizontalAlign="Left" 
        OnRowDeleting="gv_Customer_RowDeleting" AllowPaging="True" Width="600px" OnRowCancelingEdit="gv_Customer_RowCancelingEdit" 
        OnRowEditing="gv_Customer_RowEditing" OnRowUpdating="gv_Customer_RowUpdating" OnRowDataBound="gv_Customer_RowDataBound" CssClass="auto-style1" 
        PageSize="4" OnPageIndexChanging="gv_Customer_PageIndexChanging" 
        OnSorting="gv_Customer_Sorting">
            
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"/>
            <asp:BoundField DataField="Gender" HeaderText="Gender" ReadOnly="True" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" ReadOnly="True"/>
            <asp:BoundField DataField="Hp" HeaderText="Hp" SortExpression="Hp"/>
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
    </div>
    <br />
</asp:Content>
