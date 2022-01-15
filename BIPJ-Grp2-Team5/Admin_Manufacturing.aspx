<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Manufacturing.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Manufacturing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
									<h3 class="panel-title">Update Repair Form</h3>
								</div>

								<div class="panel-body">

									<p>Repair ID: <asp:Label ID="lbl_repairid" runat="server"></asp:Label> </p>
									<p>Name: <asp:Label ID="lbl_name" runat="server"></asp:Label></p>									
									<p>Handphone Number: <asp:Label ID="lbl_Hp" runat="server"></asp:Label></p>									
									<p>Email: <asp:Label ID="lbl_Email" runat="server"></asp:Label></p>									
									<p>Subject: <asp:Label ID="lbl_Subject" runat="server"></asp:Label></p>
									<p>Comments: </p><p><asp:Label ID="lbl_Comments" runat="server"></asp:Label></p>
									<p>Status: <asp:Label ID="lbl_Status" runat="server"></asp:Label></p>
									<asp:RadioButtonList ID="rbl_status" runat="server" OnSelectedIndexChanged="rbl_status_SelectedIndexChanged">
                                        <asp:ListItem>Open</asp:ListItem>
                                        <asp:ListItem>Closed</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <br />
                                    <asp:Button ID="btn_submitUp" runat="server"  Text="Submit" OnClick="btn_submitUp_Click" />
								</div>
							</div>
							<!-- END INPUTS -->
						
						</div>
						<div class="auto-style1">
								<!-- BORDERED TABLE -->
							<div class="panel">
								<div class="panel-heading">
									<h3 class="panel-title">Repairs Table</h3>
								</div>
								<div class="panel-body">
									<table class="nav-justified">
                                 <tr>
                                     <td>Search by ID:</td>
                                     <td>
                                         <asp:TextBox ID="tb_search" runat="server"></asp:TextBox>
                                         <asp:Button ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search"       />
                                     </td>
                                 </tr>
                             </table>
                        <br />
									<asp:GridView ID="gvRepair" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvRepair_SelectedIndexChanged" DataKeyNames="Repair_ID" class="table table-bordered" OnRowDeleting="gvRepair_RowDeleting" EmptyDataText="Theres Nothing Inside!">
                                        <Columns>
                                            <asp:BoundField HeaderText="RepairID" DataField="Repair_ID" />
                                            <asp:BoundField HeaderText="Name" DataField="Name" />
                                            <asp:BoundField HeaderText="Hp" DataField="Hp" />
                                            <asp:BoundField HeaderText="Email" DataField="Email" />
                                            <asp:BoundField HeaderText="Subject"  DataField="Subject"/>
                                            <asp:BoundField HeaderText="Comments" DataField="Comments"/>
                                            <asp:BoundField HeaderText="Status" DataField="Status"/>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Select" Text="Select" />
                                                    <asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete?');"/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
								</div>
							</div>
							<!-- END BORDERED TABLE -->
						</div>
						<table class="nav-justified">
                                        <tr>
                                            <td>Filter Status</td>
                                            <td>
                                                <asp:DropDownList ID="ddl_status" runat="server" DataSourceID="SqlDataSource2" DataTextField="Status" DataValueField="Status">
                                                </asp:DropDownList>
                                                <asp:Button ID="Button3" runat="server" Text="Filter" OnClick="Button3_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JextechDBContext %>" SelectCommand="SELECT DISTINCT * FROM [Repair] WHERE ([Status] = @Status)">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ddl_status" Name="Status" PropertyName="SelectedValue" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:JextechDBContext %>" SelectCommand="SELECT DISTINCT [Status] FROM [Repair]"></asp:SqlDataSource>
                                    <br />
                                   <asp:GridView ID="gv_openclose" runat="server" AutoGenerateColumns="False"  class="table table-bordered" DataKeyNames="Repair_ID"  DataSourceID="SqlDataSource1">
                                        <Columns>
                                             <asp:BoundField HeaderText="RepairID" DataField="Repair_ID" />
                                            <asp:BoundField HeaderText="Name" DataField="Name" />
                                            <asp:BoundField HeaderText="Hp" DataField="Hp" />
                                            <asp:BoundField HeaderText="Email" DataField="Email" />
                                            <asp:BoundField HeaderText="Subject"  DataField="Subject"/>
                                            <asp:BoundField HeaderText="Comments" DataField="Comments"/>
                                            <asp:BoundField HeaderText="Status" DataField="Status"/>
                                        </Columns>
                                    </asp:GridView>
						</div>
					</div>
				</div>
			</div>
			<!-- END MAIN CONTENT -->
            <%--</div>--%>
		<!-- END MAIN -->
</asp:Content>

