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
    
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        DBConnect dBConnect = new DBConnect();


        private void getTable()
        {
            string selectQuery = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_seller.DataSource = table;

        }
        private void Clear()
        {
            TextBox_id.Clear();
            guna2TextBox_name.Clear();
            guna2TextBox_age.Clear();
            guna2TextBox_phone.Clear();
            TextBox_pass.Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {


                string insertQuery = "INSERT INTO Seller VALUES(" + TextBox_id.Text + ",'" + guna2TextBox_name.Text + "','" + guna2TextBox_age.Text + "','" + guna2TextBox_phone.Text + "','" + TextBox_pass.Text+ "')";
                SqlCommand command = new SqlCommand(insertQuery, dBConnect.GetCon());
                dBConnect.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller Added successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBConnect.CloseCon();
               getTable();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || guna2TextBox_name.Text == "" || guna2TextBox_phone.Text == "" || TextBox_pass.Text == ""||guna2TextBox_age.Text=="")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    string updateQuery = "UPDATE Seller SET SellerName='" + guna2TextBox_name.Text + "', SellerAge=" + guna2TextBox_age.Text + ", SellerPhone=" + guna2TextBox_phone.Text + ",SellerPass='" + TextBox_pass.Text + "'WHERE SellerId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBConnect.GetCon());
                    dBConnect.openCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBConnect.CloseCon();
                    getTable();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void DataGridView_seller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void DataGridView_seller_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = DataGridView_seller.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox_name.Text= DataGridView_seller.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox_age.Text = DataGridView_seller.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox_phone.Text= DataGridView_seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_pass.Text= DataGridView_seller.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   if((MessageBox.Show("Are You Sure You Want to delete this record?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBConnect.GetCon());
                        dBConnect.openCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBConnect.CloseCon();
                        getTable();
                        Clear();
                    }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
            this.Hide();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {

        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void logoutlbl_MouseEnter(object sender, EventArgs e)
        {
            logoutlbl.ForeColor = Color.Red;
        }

        private void logoutlbl_MouseLeave(object sender, EventArgs e)
        {
            logoutlbl.ForeColor = Color.Goldenrod;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Goldenrod;
        }
    }
}
