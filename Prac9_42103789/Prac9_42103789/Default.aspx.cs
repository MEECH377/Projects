using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac9_42103789
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                calDate.SelectedDate = DateTime.Today;
                BindGrid();
            }
        }


        protected void btnBook_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string service = ddlService.SelectedValue;
                string payment = ddlPayment.SelectedValue;
                DateTime appointmentDate = calDate.SelectedDate;

                string connStr = ConfigurationManager.ConnectionStrings["BookingsConnectionString"].ConnectionString;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string sql = "INSERT INTO Patients (FullName, Email, ServiceType, PaymentMethod, AppointmentDate) " +
                                     "VALUES (@FullName, @Email, @ServiceType, @PaymentMethod, @AppointmentDate)";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", name);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@ServiceType", service);
                            cmd.Parameters.AddWithValue("@PaymentMethod", payment);
                            cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    lblConfirmation.CssClass = "confirm";
                    lblConfirmation.Text = $"Thank you, {name}! Your booking for {appointmentDate:yyyy-MM-dd} at 00:00 has been confirmed.";
                    ClearForm();
                    BindGrid();
                }
                catch (Exception ex)
                {
                    lblConfirmation.CssClass = "error";
                    lblConfirmation.Text = $"An error occurred while saving your booking {ex.Message}. Please try again later.";
                    // TODO: Log exception ex.Message
                }
            }
        }

        protected void calDate_SelectionChanged(object sender, EventArgs e)
        {
           
        }


        protected void cvDate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime selected = calDate.SelectedDate;
            if (selected < DateTime.Today || selected.DayOfWeek == DayOfWeek.Saturday || selected.DayOfWeek == DayOfWeek.Sunday)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
        private void BindGrid()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BookingsConnectionString"].ConnectionString; using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT Id, FullName, Email, ServiceType, PaymentMethod, AppointmentDate FROM Patients ORDER BY AppointmentDate";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvBookings.DataSource = dt;
                    gvBookings.DataBind();
                }
            }
        }
        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            ddlService.SelectedIndex = 0;
            ddlPayment.SelectedIndex = 0;
            calDate.SelectedDate = DateTime.Today;
        }

        protected void calDate_DayRender(object sender, DayRenderEventArgs e)
        {
            // Disable past dates and weekends
            if (e.Day.Date < DateTime.Today || e.Day.Date.DayOfWeek == DayOfWeek.Saturday || e.Day.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
                if (e.Day.Date < DateTime.Today)
                    e.Cell.BackColor = System.Drawing.Color.LightPink;
                else
                    e.Cell.BackColor = System.Drawing.Color.LightYellow;
            }
        }
    }
}