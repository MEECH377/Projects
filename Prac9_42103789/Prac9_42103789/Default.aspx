<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prac9_42103789.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Dr. C# Booking System</title>
    <style>
        .error { color: red; }
        .confirm { color: green; font-weight: bold; }
        .form-group { margin-bottom: 10px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Book an Appointment</h2>
            <div class="form-group">
                <asp:Label ID="lblName" runat="server" Text="Full Name:" AssociatedControlID="txtName" />
                <asp:TextBox ID="txtName" runat="server" />
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                    ErrorMessage="Name is required." CssClass="error" Display="Dynamic" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail" />
                <asp:TextBox ID="txtEmail" runat="server" />
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Email is required." CssClass="error" Display="Dynamic" />
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Invalid email format." CssClass="error"
                    ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" Display="Dynamic" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblService" runat="server" Text="Service Type:" AssociatedControlID="ddlService" />
                <asp:DropDownList ID="ddlService" runat="server">
                    <asp:ListItem Text="Select..." Value="" />
                    <asp:ListItem Text="Eye Exam" Value="Eye Exam" />
                    <asp:ListItem Text="Contact Lens Fitting" Value="Contact Lens Fitting" />
                    <asp:ListItem Text="Eye Health Advice" Value="Eye Health Advice" />
                    <asp:ListItem Text="Care for Eye Injuries" Value="Care for Eye Injuries" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvService" runat="server" ControlToValidate="ddlService"
                    InitialValue="" ErrorMessage="Select a service." CssClass="error" Display="Dynamic" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblPayment" runat="server" Text="Payment Method:" AssociatedControlID="ddlPayment" />
                <asp:DropDownList ID="ddlPayment" runat="server">
                    <asp:ListItem Text="Select..." Value="" />
                    <asp:ListItem Text="Cash" Value="Cash" />
                    <asp:ListItem Text="Medical Aid" Value="Medical Aid" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvPayment" runat="server" ControlToValidate="ddlPayment"
                    InitialValue="" ErrorMessage="Select a payment method." CssClass="error" Display="Dynamic" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblDate" runat="server" Text="Appointment Date:" AssociatedControlID="calDate" />
                <asp:Calendar ID="calDate" runat="server" OnDayRender="calDate_DayRender" OnSelectionChanged="calDate_SelectionChanged" />
                <asp:CustomValidator ID="cvDate" runat="server"
                    OnServerValidate="cvDate_ServerValidate" ErrorMessage="Invalid date selected."
                    CssClass="error" Display="Dynamic" />
            </div>
            <asp:Button ID="btnBook" runat="server" Text="Book Appointment" OnClick="btnBook_Click" />
            <br /><br />
            <asp:Label ID="lblConfirmation" runat="server" CssClass="confirm" />
            <hr />
            <h3>All Bookings</h3>
            <asp:GridView ID="gvBookings" runat="server" AutoGenerateColumns="False" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField DataField="FullName" HeaderText="Full Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="ServiceType" HeaderText="Service Type" />
                    <asp:BoundField DataField="PaymentMethod" HeaderText="Payment Method" />
                    <asp:BoundField DataField="AppointmentDate" HeaderText="Appointment Date" DataFormatString="{0:yyyy-MM-dd}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
