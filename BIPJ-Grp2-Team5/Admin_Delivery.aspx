<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Delivery.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Delivery" %>
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
    <div class="main" style="left: 1px; top: 0px">
			<!-- MAIN CONTENT -->
			<div class="main-content">
				<div class="container-fluid">
					<div class="row">
						<div class="col-md-6">
							<!-- BORDERED TABLE -->
								<div class="panel-heading">
									<h3 class="panel-title">Orders Table</h3>
								</div>
								<div class="panel-body">
									<asp:GridView ID="Gv_Delivery" runat="server" AutoGenerateColumns="False" DataKeyNames="Order_ID" class="table table-bordered"  BackColor="#CCFFFF" BorderColor="#0066FF">
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
                                        </Columns>
                                    </asp:GridView>
								</div>
							<!-- END BORDERED TABLE -->
						</div>


						</div>
							

					</div>
				</div>
			</div>
			<!-- END MAIN CONTENT -->
            <%--</div>--%>
		<!-- END MAIN -->


</asp:Content>


