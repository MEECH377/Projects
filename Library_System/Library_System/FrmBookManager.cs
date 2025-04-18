using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class FrmBookManager : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\GitHub\Projects\Library_System\Library_System\Librarydb.mdf;Integrated Security=True";
        public FrmBookManager()
        {
            InitializeComponent();
        }

        private void FrmBookManager_Load(object sender, EventArgs e)
        {
            ClearInputFields();
            DisplayBooks();
        }
        private void ClearInputFields()
        {

        }
        private void DisplayBooks()
        {
            try
            {
                using(SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    adapter = new SqlDataAdapter();
                    ds = new DataSet();
                    string sql = "SELECT * FROM Books";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "Books");

                    dgvBooks.DataSource = ds;
                    dgvBooks.DataMember = "Books";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying books {ex.Message}");
            }
        }
    }
}
