<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Delivery.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Delivery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <style>  
		/* .auto-style1 {
            padding: 10px 15px;
            border-bottom: 1px solid transparent;
            border-top-left-radius: 3px;
            border-top-right-radius: 3px;
            left: 0px;
            top: 0px;
            height: 19px;
        }*/
        .auto-style1 {
            width: 97%
        }
        </style>

	<script>

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- MAIN -->
		<div class="main" style="left: 1px; top: 0px">
			<!-- MAIN CONTENT -->
			<div class="main-content">
				<div class="container-fluid">
					<div class="row">
						<div class="col-md-6">
							<!-- INPUTS -->
							<div class="panel">
								<div class="panel-heading">
									<h3 class="panel-title">Delivery Details</h3>
								</div>

								<div class="panel-body">
								</div>
							</div>
							<!-- END INPUTS -->
						
						</div>
						<div class="col-md-6">
						</div>
						   <table class="nav-justified">
<%--                                        <tr>
                                            <td>Filter Status</td>
                                            <td>
                                                <asp:DropDownList ID="ddl_status" runat="server" DataSourceID="SqlDataSource2" DataTextField="Status" DataValueField="Status" >
                                                </asp:DropDownList>
                                                <asp:Button ID="Button2" runat="server" Text="Filter" OnClick="Button2_Click" />
                                            </td>
                                        </tr>--%>
                                    </table>
<%--                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JextechDBContext %>" SelectCommand="SELECT DISTINCT * FROM [Econsult] WHERE ([Status] = @Status)">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ddl_status" Name="Status" PropertyName="SelectedValue" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:JextechDBContext %>" SelectCommand="SELECT DISTINCT [Status] FROM [Econsult]"></asp:SqlDataSource>
									<asp:GridView ID="gv_openclose" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvRestore_SelectedIndexChanged" class="table table-bordered" DataKeyNames="Restore_ID" OnRowDeleting="gvRestore_RowDeleting" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField HeaderText="Restore_ID" DataField="Restore_ID" InsertVisible="False" ReadOnly="True" SortExpression="Restore_ID" />
                                            <asp:BoundField HeaderText="Name" DataField="Name" SortExpression="Name" />
                                            <asp:BoundField HeaderText="Hp" DataField="Hp" SortExpression="Hp" />
                                            <asp:BoundField HeaderText="Email" DataField="Email" SortExpression="Email" />
                                            <asp:BoundField HeaderText="Subject"  DataField="Subject" SortExpression="Subject"/>
                                            <asp:BoundField HeaderText="Comments" DataField="Comments" SortExpression="Comments"/>
                                            <asp:BoundField HeaderText="Status" DataField="Status" SortExpression="Status"/>
                                        </Columns>
                                    </asp:GridView>--%>
						</div>
					</div>
				</div>
			</div>
			<!-- END MAIN CONTENT -->
        <%--</div>--%>
		<!-- END MAIN -->
</asp:Content>


