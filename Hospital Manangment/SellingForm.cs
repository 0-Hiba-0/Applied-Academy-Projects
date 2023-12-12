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
using DGVPrinterHelper;

namespace Hospital_Manangment
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        DBConnect DBConnect = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, DBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName"; 
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
            string selectQuery = "SELECT ProdName, ProdPrice FROM Products";
            SqlCommand command = new SqlCommand(selectQuery, DBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void getSellTable()
        {
            string selectQuery = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuery, DBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_sellist.DataSource = table;
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
         label_date.Text = DateTime.Today.ToShortDateString();
            seller.Text = LoginForm.SellerName;
            getCategory();
            getTable();
            getSellTable();

        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            guna2TextBox_name.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox_price.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();

        }
        int grandTotal = 0, n = 0;

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {


                string insertQuery = "INSERT INTO Bill VALUES(" + TextBox_id.Text + ",'" + guna2TextBox_name.Text + "','" + label_date.Text + "'," + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, DBConnect.GetCon());
                DBConnect.openCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnect.CloseCon();
               // getTable();
                getSellTable();
                //Clear();
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

        private void guna2TextBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
            this.Hide();
        }

        private void DataGridView_sellist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //dgvPrinter
            printer.Title = "Hiba Market Sell Lists";
            printer.SubTitle = String.Format("Date:{0}",DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Willkommen";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_sellist);


        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Goldenrod;
        }

        private void logoutlbl_MouseEnter(object sender, EventArgs e)
        {
            logoutlbl.ForeColor = Color.Red;
        }

        private void logoutlbl_MouseLeave(object sender, EventArgs e)
        {
            logoutlbl.ForeColor = Color.Goldenrod;
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT ProdName,ProdPrice FROM Products WHERE ProdCat='" + comboBox_category.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuery, DBConnect.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void addOrderbtn_Click(object sender, EventArgs e)
        {
            if (guna2TextBox_name.Text == "" || guna2TextBox_qty.Text == "")
            {
                MessageBox.Show("Missing info", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(guna2TextBox_price.Text) * Convert.ToInt32(guna2TextBox_qty.Text);
                DataGridViewRow addrow = new DataGridViewRow();
                addrow.CreateCells(DataGridView_order);
                addrow.Cells[0].Value = ++n;
                addrow.Cells[1].Value = guna2TextBox_name.Text;
                addrow.Cells[2].Value = guna2TextBox_price.Text;
                addrow.Cells[3].Value = guna2TextBox_qty.Text;
                addrow.Cells[4].Value = Total;
                DataGridView_order.Rows.Add(addrow);
                grandTotal += Total;
            }

        }
    }
}
