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
    public partial class ProductForm : Form
    {
        DBConnect dBConnect = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }
        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "CatName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Products WHERE ProdId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBConnect.GetCon());
                    dBConnect.openCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox_id.Text == "" || guna2TextBox_price.Text == "" || guna2TextBox_qty.Text == "" || comboBox_category.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    string updateQuery = "UPDATE Products SET ProdName='" + guna2TextBox_name.Text + "', ProdPrice=" + guna2TextBox_price.Text + ", ProdQty=" + guna2TextBox_qty.Text + ",ProdCat='" + comboBox_category.Text + "'WHERE ProdId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBConnect.GetCon());
                    dBConnect.openCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_categories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoriesForm category = new CategoriesForm();
            category.Show();
            this.Hide();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Clear()
        {
            TextBox_id.Clear();
            guna2TextBox_name.Clear();
            guna2TextBox_price.Clear();
            guna2TextBox_qty.Clear();
            comboBox_category.SelectedIndex = 0;
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {

            
         string insertQuery = "INSERT INTO Products VALUES("+TextBox_id.Text+",'"+guna2TextBox_name.Text+"','"+guna2TextBox_price.Text+ "','" + guna2TextBox_qty.Text + "','" + comboBox_category.Text + "')";
            SqlCommand command = new SqlCommand(insertQuery, dBConnect.GetCon());
            dBConnect.openCon();
            command.ExecuteNonQuery();
            MessageBox.Show("Product Added successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DataGridView_product_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_id.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox_name.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox_price.Text = DataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox_qty.Text = DataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_category.SelectedValue= DataGridView_product.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Products WHERE ProdCat='"+comboBox_search.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(selectQuery, dBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Goldenrod;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Goldenrod;
        }
    }
}
