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
									<h3 class="panel-title">Manufacturing Form</h3>
								</div>

								<div class="panel-body">

									<p>Manufacturing  ID: <asp:Label ID="lbl_manufacturingid" runat="server"></asp:Label> </p>
									<p>Order ID: <asp:Label ID="lbl_Order_ID" runat="server"></asp:Label></p>									
									<p>Product Info: <asp:Label ID="lbl_Prodinfo" runat="server"></asp:Label></p>									
									<p>Quantity: <asp:Label ID="lbl_Quantity" runat="server"></asp:Label></p>
									<p>Status: <asp:Label ID="lbl_Status" runat="server"></asp:Label></p>
									<asp:RadioButtonList ID="rbl_status" runat="server" OnSelectedIndexChanged="rbl_status_SelectedIndexChanged">
                                        <asp:ListItem>Approved</asp:ListItem>
                                        <asp:ListItem>Rejected</asp:ListItem>
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
									<h3 class="panel-title">Manufacturing Data Table</h3>
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
									<asp:GridView ID="gvManufacture" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvManufacture_SelectedIndexChanged" DataKeyNames="Manufacturing_ID" class="table table-bordered" EmptyDataText="Theres Nothing Inside!">
                                        <Columns>
                                            <asp:BoundField HeaderText="ManufacturingID" DataField="Manufacturing_ID" />
                                            <asp:BoundField HeaderText="Order" DataField="Order_ID" />
                                            <asp:BoundField HeaderText="Product Info" DataField="Product_Info" />
                                            <asp:BoundField HeaderText="Quantity" DataField="Quantity" />
                                            <asp:BoundField HeaderText="Status" DataField="Status"/>
                                             <asp:ImageField HeaderText="Image" DataImageUrlField="Product_Image" DataImageUrlFormatString="~\images\{0}" ControlStyle-Width="100" ControlStyle-Height = "100">
                                                <ControlStyle Height="100px" Width="100px" />
                                            </asp:ImageField>
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
                                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MainDBContext %>" SelectCommand="SELECT DISTINCT * FROM [Manufacturing] WHERE ([Status] = @Status)">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ddl_status" Name="Status" PropertyName="SelectedValue" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MainDBContext %>" SelectCommand="SELECT DISTINCT [Status] FROM [Manufacturing]"></asp:SqlDataSource>
                                    <br />
                                   <asp:GridView ID="gv_openclose" runat="server" AutoGenerateColumns="False"  class="table table-bordered" DataKeyNames="Manufacturing_ID"  DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField HeaderText="ManufacturingID" DataField="Manufacturing_ID" />
                                            <asp:BoundField HeaderText="Order" DataField="Order_ID" />
                                            <asp:BoundField HeaderText="Product Info" DataField="Product_Info" />
                                            <asp:BoundField HeaderText="Quantity" DataField="Quantity" />
                                            <asp:BoundField HeaderText="Status" DataField="Status"/>
                                             <asp:ImageField HeaderText="Image" DataImageUrlField="Product_Img" DataImageUrlFormatString="~\images\{0}" ControlStyle-Width="100" ControlStyle-Height = "100">
                                                <ControlStyle Height="100px" Width="100px" />
                                            </asp:ImageField>
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

