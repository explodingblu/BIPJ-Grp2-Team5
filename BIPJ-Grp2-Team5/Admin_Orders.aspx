<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Orders.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    	<style>
       
        .auto-style2 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 50%;
            left: 1px;
            top: 0px;
            padding-left: 15px;
            padding-right: 15px;
        }
       
    </style>
	<script>

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main" sty
		le="left: 1px; top: 0px">
			<!-- MAIN CONTENT -->
			<div class="main-content">
				<div class="container-fluid">
					<div class="row">
						<div class="col-md-6">
							<!-- INPUTS -->
							<div class="panel">
								<div class="panel-heading">
                                    <h3 class="panel-title">Update Order Form</h3>
                                </div>

								<div class="panel-body">

									<p>Order ID: <asp:Label ID="lbl_orderid" runat="server"></asp:Label> </p>
									<p>First Name: <asp:Label ID="lbl_fname" runat="server"></asp:Label></p>
									<p>Last Name: <asp:Label ID="lbl_lname" runat="server"></asp:Label></p>
									<p>Country: <asp:Label ID="lbl_country" runat="server"></asp:Label></p>
									<p>City: <asp:Label ID="lbl_city" runat="server"></asp:Label></p>
									<p>Address: <asp:Label ID="lbl_address" runat="server"></asp:Label></p>
									<p>Zipcode: <asp:Label ID="lbl_zipcode" runat="server"></asp:Label></p>
									<p>Handphone Number: <asp:Label ID="lbl_phoneno" runat="server"></asp:Label></p>
									<p>Comments: </p><p><asp:Label ID="lbl_comment" runat="server"></asp:Label></p>
									<p>Products: </p><p><asp:Label ID="lbl_products" runat="server"></asp:Label></p>
									<p>Total Amount: <asp:Label ID="lbl_totalamt" runat="server"></asp:Label></p>									
									<p>Payment Date: <asp:Label ID="lbl_date" runat="server"></asp:Label></p>
									<p>Delivery Status: <asp:Label ID="lbl_Status" runat="server"></asp:Label></p>
									<asp:BoundField DataField="DeliveryStatus" HeaderText="Delivery Status"/>
									<asp:RadioButtonList ID="rbl_status" runat="server">
                                        <asp:ListItem>Undelivered</asp:ListItem>
                                        <asp:ListItem>Delivered</asp:ListItem>
										<asp:ListItem>In Transit</asp:ListItem>
										<asp:ListItem>Awaiting Design</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <br />
                                    <asp:Button ID="btn_submitUp" runat="server"  Text="Submit" OnClick="btn_submitUp_Click" />
								</div>
							</div>
							<!-- END INPUTS -->
						
						</div>
						<div class="col-md-6">
                                <!-- BORDERED TABLE -->
                            <div class="panel">
                                <div class="panel-heading">
                                    <h3 class="panel-title">Orders Search Table</h3>
                                </div>
                                <div class="panel-body">
                                    <table class="auto-style1">
                                        <tr>
                                            <td>Search ID: </td>
                                            <td>
                                                <asp:TextBox ID="tb_search" runat="server"></asp:TextBox>
                                                <asp:Button ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
                                            </td>
                                        </tr>
                                    </table>
                                    <br />

                                    <asp:GridView ID="gv_OrderSearch" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_OrderSearch_SelectedIndexChanged" class="table table-bordered" DataKeyNames="Order_ID" OnRowDeleting="Gv_Orders_RowDeleting" EmptyDataText="Theres Nothing Inside!">
                                        <Columns>
                                            <asp:BoundField HeaderText="OrderID" DataField="Order_ID" />
                                            <asp:BoundField HeaderText="FirstName" DataField="FName" />
                                            <asp:BoundField HeaderText="LastName" DataField="LName" />
                                            <asp:BoundField HeaderText="PhoneNo"  DataField="PhoneNo"/>
                                            <asp:BoundField DataField="Product" HeaderText="Products" />
                                            <asp:BoundField HeaderText="Total Amount" DataField="TotalAmount"/>
											<asp:BoundField HeaderText="Payment Date" DataField="PaymentDate"/>
											<asp:BoundField DataField="DeliveryStatus" HeaderText="Delivery Status" />
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

						</div>
								<!-- BORDERED TABLE -->
							<div class="panel">
								<div class="panel-heading">
									<h3 class="panel-title">Orders Table</h3>
								</div>
								<div class="panel-body">
									<asp:GridView ID="Gv_Orders" runat="server" AutoGenerateColumns="False" DataKeyNames="Order_ID" class="table table-bordered" OnRowDeleting="Gv_Orders_RowDeleting" OnSelectedIndexChanged="Gv_Orders_SelectedIndexChanged" BackColor="#CCFFFF" BorderColor="#0066FF">
                                        <Columns>
                                            <asp:BoundField HeaderText="OrderID" DataField="Order_ID" />
                                            <asp:BoundField HeaderText="FirstName" DataField="FName" />
                                            <asp:BoundField HeaderText="LastName" DataField="LName" />
                                            <asp:BoundField HeaderText="Country" DataField="Country" />
                                            <asp:BoundField HeaderText="City"  DataField="City"/>
                                            <asp:BoundField HeaderText="Address"  DataField="Address"/>
                                            <asp:BoundField HeaderText="Zipcode" DataField="Zipcode"/>
                                            <asp:BoundField HeaderText="PhoneNo"  DataField="PhoneNo"/>
                                            <asp:BoundField HeaderText="Comment" DataField="Comment"/>
                                            <asp:BoundField DataField="Product" HeaderText="Products" />
                                            <asp:BoundField HeaderText="Total Amount" DataField="TotalAmount"/>
											<asp:BoundField HeaderText="Payment Date" DataField="PaymentDate"/>
											<asp:BoundField DataField="DeliveryStatus" HeaderText="Delivery Status" />
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
				</div>
			</div>
			<!-- END MAIN CONTENT -->
            <%--</div>--%>
		<!-- END MAIN -->


</asp:Content>

