<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Navbar.Master" AutoEventWireup="true" CodeBehind="Admin_Index.aspx.cs" Inherits="BIPJ_Grp2_Team5.Admin_Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

            <style>
            .auto-style1 {
                height: 39px;
            }
            .auto-style2 {
                height: 39px;
                width: 115px;
            }
            .auto-style3 {
                height: 39px;
                width: 85px;
            }
            </style>

    <script>
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
			<!-- MAIN CONTENT -->
			<div class="main-content">
				<div class="container-fluid">
					<!-- OVERVIEW -->
					<div class="panel panel-headline">
						<div class="panel-heading">
							<h3 class="panel-title">Shop Overview</h3>
						</div>
						<div class="panel-body">
							<div class="row">
								<div class="col-md-3">
									<div class="metric">
										<span class="icon"><a href="AdminUser.aspx"><i class="fa fa-users"></i></a></span>
										<p>
											<span id="totalmembers" class="number" runat="server"></span>
											<span class="number">
                                            <asp:Label ID="lbl_UserCounts" runat="server"></asp:Label>
                                            </span>&nbsp;<span class="title">Employees</span>
										</p>
									</div>
								</div>
								<div class="col-md-3">
									<div class="metric">
										<span class="icon"><a href="AdminProduct.aspx"><i class="fa fa-shopping-bag"></i></a></span>
										<p>
											<span class="number">
                                            <asp:Label ID="lbl_ProductCounts" runat="server"></asp:Label>
                                            </span>&nbsp;<span class="title">Products</span>
										</p>
									</div>
								</div>
								<div class="col-md-3">
									<div class="metric">
										<span class="icon"><a href="AdminOrders.aspx"><i class="fa fa-eye"></i></a></span>
										<p>
											<span class="number">
                                            <asp:Label ID="lbl_OrdersCount" runat="server"></asp:Label>
                                            </span>&nbsp;<span class="title">Orders</span>
										</p>
									</div>
								</div>
								<div class="col-md-3">
									<div class="metric">
										<span class="icon"><i class="fa fa-envelope"></i></span>
										<p>
											<span class="number">
                                            <asp:Label ID="lbl_RepairCount" runat="server" Visible="False"></asp:Label>
                                            <asp:Label ID="lbl_EconsultCount" runat="server" Visible="False"></asp:Label>
                                            <asp:Label ID="lbl_ContactusCount" runat="server" Visible="False"></asp:Label>
                                            <asp:Label ID="lbl_NotificationsCount" runat="server"></asp:Label>
                                            </span>&nbsp;<span class="title">Notifications</span>
										</p>
									</div>
								</div>
							</div>

						</div>
					</div>
					<!-- END OVERVIEW -->
					<div class="row">
						<div class="col-md-6">
							<!-- RECENT PURCHASES -->
							<div class="panel">
								<div class="panel-heading">
									<h3 class="panel-title">Recent Purchases</h3>
									<div class="right">
										<button type="button" class="btn-toggle-collapse"><i class="lnr lnr-chevron-up"></i></button>
									</div>
								</div>
								<div class="panel-body no-padding">
									<table class="table table-striped">
										<thead>
											<tr>
												<th class="auto-style2">Order No.</th>
												<th class="auto-style3">Name</th>
												<th class="auto-style1">Amount</th>
												<th class="auto-style1">Date &amp; Time</th>
												<th class="auto-style1">Status</th>
											</tr>
										</thead>
									</table>
<%--                                    <asp:GridView ID="gv_recentorders" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataKeyNames="Checkout_ID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="gv_recentorders_SelectedIndexChanged" ShowHeader="False" style="margin-left: 16px">
                                        <Columns>
                                            <asp:BoundField DataField="Checkout_ID" HeaderText="Checkout_ID" InsertVisible="False" ReadOnly="True" SortExpression="Checkout_ID" />
                                            <asp:BoundField DataField="Session_Name" HeaderText="Session_Name" SortExpression="Session_Name" />
                                            <asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" SortExpression="TotalAmount" />
                                            <asp:BoundField DataField="PaymentDate" HeaderText="PaymentDate" SortExpression="PaymentDate" />
                                            <asp:BoundField DataField="DeliveryStatus" HeaderText="DeliveryStatus" SortExpression="DeliveryStatus" />
                                        </Columns>
                                    </asp:GridView>--%>
<%--								    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JextechDBContext %>" SelectCommand="SELECT top 3 [Checkout_ID], [Session_Name], [TotalAmount], [PaymentDate], [DeliveryStatus] FROM [Checkout] order by [PaymentDate] DESC"></asp:SqlDataSource>--%>
								</div>
								<div class="panel-footer">
									<div class="row">
										<div class="col-md-6"><span class="panel-note"><i class="fa fa-clock-o"></i> Top 3 orders</span></div>
										<div class="col-md-6 text-right"><a href="AdminOrders.aspx" class="btn btn-primary">View All Purchases</a></div>
									</div>
								</div>
							</div>
							<!-- END RECENT PURCHASES -->
						</div>
						<div class="col-md-6">
							<!-- MULTI CHARTS -->
							<div class="panel">
								<div class="panel-heading">
									<h3 class="panel-title">Real-Time Inventory Tracking</h3>
									<div class="right">
										<button type="button" class="btn-toggle-collapse"><i class="lnr lnr-chevron-up"></i></button>
										<button type="button" class="btn-remove"><i class="lnr lnr-sync"></i></button>
									</div>
								</div>
								 <div class="panel-body">
											<asp:ScriptManager ID="ScriptManager1" runat="server">
											</asp:ScriptManager>
											<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<%--												<ContentTemplate>
													 <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
													<asp:Label ID="Label1" runat="server" Text="Label" Width="435px"></asp:Label>
												</ContentTemplate>--%>
											</asp:UpdatePanel>
										<asp:Label ID="lbl_StockLevel" runat="server" Width="493px"></asp:Label>
									 <br />
									 <br />
										Inventory Breakdown:
									 <br />
										<asp:Label ID="lbl_Phonecount" runat="server" Width="493px" ForeColor="#0066CC"></asp:Label>
									 									 <br />
									 <br />
										<asp:Label ID="lbl_Keyboardcount" runat="server" Width="493px" ForeColor="Lime"></asp:Label>
									 									 <br />
									 <br />
										 <asp:Label ID="lbl_Mousecount" runat="server" Width="493px" ForeColor="Red"></asp:Label>
									 									 <br />
									 <br />
										<asp:Label ID="lbl_Headsetcoun" runat="server" Width="493px" ForeColor="#663300"></asp:Label>

									 </div>
							</div>
							<!-- END MULTI CHARTS -->
						</div>
					</div>
				</div>
			</div>
			<!-- END MAIN CONTENT -->
		</div>
		<!-- END MAIN -->

	<script>
        $(function () {
            var data, options;

            // headline charts
            data = {
                labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'],
                series: [
                    [23, 29, 24, 40, 25, 24, 35],
                    [14, 25, 18, 34, 29, 38, 44],
                ]
            };

            options = {
                height: 300,
                showArea: true,
                showLine: false,
                showPoint: false,
                fullWidth: true,
                axisX: {
                    showGrid: false
                },
                lineSmooth: false,
            };

            new Chartist.Line('#headline-chart', data, options);


            // visits trend charts
            data = {
                labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
                series: [{
                    name: 'series-real',
                    data: [200, 380, 350, 320, 410, 450, 570, 400, 555, 620, 750, 900],
                }, {
                    name: 'series-projection',
                    data: [240, 350, 360, 380, 400, 450, 480, 523, 555, 600, 700, 800],
                }]
            };

            options = {
                fullWidth: true,
                lineSmooth: false,
                height: "270px",
                low: 0,
                high: 'auto',
                series: {
                    'series-projection': {
                        showArea: true,
                        showPoint: false,
                        showLine: false
                    },
                },
                axisX: {
                    showGrid: false,

                },
                axisY: {
                    showGrid: false,
                    onlyInteger: true,
                    offset: 0,
                },
                chartPadding: {
                    left: 20,
                    right: 20
                }
            };

            new Chartist.Line('#visits-trends-chart', data, options);


            // visits chart
            data = {
                labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'],
                series: [
                    [6384, 6342, 5437, 2764, 3958, 5068, 7654]
                ]
            };

            options = {
                height: 300,
                axisX: {
                    showGrid: false
                },
            };
        };

        new Chartist.Bar('#visits-chart', data, options);


        // real-time pie chart
        var sysLoad = $('#system-load').easyPieChart({
            size: 130,
            barColor: function (percent) {
                return "rgb(" + Math.round(200 * percent / 100) + ", " + Math.round(200 * (1.1 - percent / 100)) + ", 0)";
            },
            trackColor: 'rgba(245, 245, 245, 0.8)',
            scaleColor: false,
            lineWidth: 5,
            lineCap: "square",
            animate: 800
        });

        var updateInterval = 3000; // in milliseconds

        setInterval(function () {
            var randomVal;
            randomVal = getRandomInt(0, 100);

            sysLoad.data('easyPieChart').update(randomVal);
            sysLoad.find('.percent').text(randomVal);
        }, updateInterval);

        function getRandomInt(min, max) {
            return Math.floor(Math.random() * (max - min + 1)) + min;
        }

        });
    </script>
</asp:Content>