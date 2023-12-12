using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Manangment
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startPoint = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            guna2CircleProgressBar1.Value = startPoint;
            if(guna2CircleProgressBar1.Value==100)
            {
                guna2CircleProgressBar1.Value = 0;
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        { 

        }
    }
}
