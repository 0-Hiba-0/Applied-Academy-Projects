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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        DBConnect DBConnect = new DBConnect();
        public static string SellerName;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Goldenrod;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if(TextBox_username.Text==""||TextBox_password.Text=="")
            {
                MessageBox.Show("Please Enter User Name and Password", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox_role.SelectedIndex > -1)
            {
                if (comboBox_role.SelectedItem.ToString() == "ADMIN")
                {
                    if (TextBox_username.Text == "Admin" && TextBox_password.Text == "Admin123")
                    {
                        ProductForm productForm = new ProductForm();
                        productForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If you are Admin, Pleasee enter correct Id and Password", "Missimg Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    string selectQuery = "SELECT * FROM Seller WHERE SellerName='" + TextBox_username.Text + "' AND SellerPass='" + TextBox_password.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, DBConnect.GetCon());
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        SellerName = TextBox_username.Text;
                        SellingForm selling = new SellingForm();
                        selling.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User or password", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Role", "Wrong Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
