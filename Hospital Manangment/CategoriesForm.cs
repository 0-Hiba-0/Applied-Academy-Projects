using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Manangment
{
    public partial class CategoriesForm : Form
    {
        DBConnect dbconnect = new DBConnect();
        public CategoriesForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, dbconnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_category.DataSource = table;

        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + TextBox_id.Text + ",'" + guna2TextBox_name.Text + "','" + guna2TextBox_description.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery,dbconnect.GetCon());
                dbconnect.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbconnect.CloseCon();
                clear();



            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || guna2TextBox_name.Text == "" || guna2TextBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName='" + guna2TextBox_name.Text + "', CatDes='" + guna2TextBox_description.Text + "'WHERE CatId = " + TextBox_id.Text + " ";
                    SqlCommand command = new SqlCommand(updateQuery, dbconnect.GetCon());
                    dbconnect.openCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbconnect.CloseCon();
                    getTable();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void DataGridView_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_id.Text = DataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox_name.Text= DataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox_description.Text= DataGridView_category.SelectedRows[0].Cells[2].Value.ToString();

        }
        private void clear()
        {
            TextBox_id.Clear();
            guna2TextBox_name.Clear();
            guna2TextBox_description.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE CatId=" + TextBox_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dbconnect.GetCon());
                dbconnect.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbconnect.CloseCon();
                getTable();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Goldenrod;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Goldenrod;
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }
    }
}
