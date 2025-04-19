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
            PopulateBookId();
        }
        private void PopulateBookId()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    adapter = new SqlDataAdapter("SELECT Book_ID FROM Books", cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Book_ID");
                    cmbBookId.DataSource = ds.Tables["Book_ID"];
                    cmbBookId.DisplayMember = "Book_ID";
                    cmbBookId.ValueMember = "Book_ID";
                    cmbBookId.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating Book ID: {ex.Message}");
            }
        }
        private void ClearInputFields()
        {
            // Clear add book fields
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            cbxAvailable.Checked = false;

            // Clear edit book fields
            txtTitleEdit.Clear();
            txtAuthorEdit.Clear();
            txtGenreEdit.Clear();
            cbxAvailableEdit.Checked = false;

            // Reset combo box selection
            cmbBookId.SelectedIndex = -1;
        }
        private void DisplayBooks()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM Books", cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Books");
                    dgvBooks.DataSource = ds.Tables["Books"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying books: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Please fill in all book details before adding.");
                return;
            }

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sql = @"INSERT INTO Books(Title, Author, Genre, isAvailable) VALUES (@Title, @Author, @Genre, @isAvailable)";
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                        command.Parameters.AddWithValue("@Author", txtAuthor.Text.Trim());
                        command.Parameters.AddWithValue("@Genre", txtGenre.Text.Trim());
                        command.Parameters.AddWithValue("@isAvailable", cbxAvailable.Checked);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Book added successfully!");
                    DisplayBooks();
                    PopulateBookId();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sql = "SELECT * FROM Books WHERE Title LIKE @keyword OR Author LIKE @keyword OR Genre LIKE @keyword";
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@keyword", "%" + txtSearch.Text.Trim() + "%");
                        adapter = new SqlDataAdapter(command);
                        ds = new DataSet();
                        adapter.Fill(ds, "Books");
                        dgvBooks.DataSource = ds.Tables["Books"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBookId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTitleEdit.Text) || string.IsNullOrWhiteSpace(txtAuthorEdit.Text) || string.IsNullOrWhiteSpace(txtGenreEdit.Text))
            {
                MessageBox.Show("Please fill in all book details before updating.");
                return;
            }

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sql = "UPDATE Books SET Title = @Title, Author = @Author, Genre = @Genre, isAvailable = @isAvailable WHERE Book_ID = @Book_ID";
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@Title", txtTitleEdit.Text.Trim());
                        command.Parameters.AddWithValue("@Author", txtAuthorEdit.Text.Trim());
                        command.Parameters.AddWithValue("@Genre", txtGenreEdit.Text.Trim());
                        command.Parameters.AddWithValue("@isAvailable", cbxAvailableEdit.Checked);
                        command.Parameters.AddWithValue("@Book_ID", cmbBookId.SelectedValue);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Update successful!");
                    DisplayBooks();
                    PopulateBookId();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbBookId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sql = "DELETE FROM Books WHERE Book_ID = @Book_ID";
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@Book_ID", cmbBookId.SelectedValue);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Deleted successfully!");
                    DisplayBooks();
                    PopulateBookId();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}");
            }
        }

        private void cmbBookId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBookId.SelectedIndex == -1)
            {
                ClearInputFields();
                return;
            }

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sql = "SELECT * FROM Books WHERE Book_ID = @Book_ID";
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@Book_ID", cmbBookId.SelectedValue);
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                txtTitleEdit.Text = dataReader["Title"].ToString();
                                txtAuthorEdit.Text = dataReader["Author"].ToString();
                                txtGenreEdit.Text = dataReader["Genre"].ToString();
                                cbxAvailableEdit.Checked = Convert.ToBoolean(dataReader["isAvailable"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book details: {ex.Message}");
            }
        }
    }
}
