namespace Hospital_Manangment
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logoutlbl = new System.Windows.Forms.Label();
            this.DataGridView_seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.guna2TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_seller)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutlbl
            // 
            this.logoutlbl.AutoSize = true;
            this.logoutlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.logoutlbl.Location = new System.Drawing.Point(11, 463);
            this.logoutlbl.Name = "logoutlbl";
            this.logoutlbl.Size = new System.Drawing.Size(84, 30);
            this.logoutlbl.TabIndex = 36;
            this.logoutlbl.Text = "Logout";
            this.logoutlbl.Click += new System.EventHandler(this.logoutlbl_Click);
            this.logoutlbl.MouseEnter += new System.EventHandler(this.logoutlbl_MouseEnter);
            this.logoutlbl.MouseLeave += new System.EventHandler(this.logoutlbl_MouseLeave);
            // 
            // DataGridView_seller
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_seller.ColumnHeadersHeight = 29;
            this.DataGridView_seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_seller.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.Location = new System.Drawing.Point(267, 64);
            this.DataGridView_seller.Name = "DataGridView_seller";
            this.DataGridView_seller.RowHeadersVisible = false;
            this.DataGridView_seller.Size = new System.Drawing.Size(442, 257);
            this.DataGridView_seller.TabIndex = 18;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_seller.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_seller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_seller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_seller.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView_seller.ThemeStyle.ReadOnly = false;
            this.DataGridView_seller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_seller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_seller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_seller.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_seller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_seller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_seller_CellContentClick);
            this.DataGridView_seller.Click += new System.EventHandler(this.DataGridView_seller_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(263, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "MANAGE SELLER";
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(73, 296);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(82, 40);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(155, 296);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(82, 40);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(-7, 297);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 40);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // guna2TextBox_phone
            // 
            this.guna2TextBox_phone.BorderRadius = 18;
            this.guna2TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_phone.DefaultText = "";
            this.guna2TextBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_phone.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_phone.Location = new System.Drawing.Point(94, 193);
            this.guna2TextBox_phone.Name = "guna2TextBox_phone";
            this.guna2TextBox_phone.PasswordChar = '\0';
            this.guna2TextBox_phone.PlaceholderText = "";
            this.guna2TextBox_phone.SelectedText = "";
            this.guna2TextBox_phone.Size = new System.Drawing.Size(149, 36);
            this.guna2TextBox_phone.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BurlyWood;
            this.label8.Location = new System.Drawing.Point(902, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.BurlyWood;
            this.label_exit.Location = new System.Drawing.Point(1051, 5);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 37);
            this.label_exit.TabIndex = 31;
            this.label_exit.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // guna2TextBox_age
            // 
            this.guna2TextBox_age.BorderRadius = 18;
            this.guna2TextBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_age.DefaultText = "";
            this.guna2TextBox_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_age.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_age.Location = new System.Drawing.Point(94, 152);
            this.guna2TextBox_age.Name = "guna2TextBox_age";
            this.guna2TextBox_age.PasswordChar = '\0';
            this.guna2TextBox_age.PlaceholderText = "";
            this.guna2TextBox_age.SelectedText = "";
            this.guna2TextBox_age.Size = new System.Drawing.Size(149, 36);
            this.guna2TextBox_age.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No.";
            // 
            // guna2TextBox_name
            // 
            this.guna2TextBox_name.BorderRadius = 18;
            this.guna2TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_name.DefaultText = "";
            this.guna2TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_name.Location = new System.Drawing.Point(94, 111);
            this.guna2TextBox_name.Name = "guna2TextBox_name";
            this.guna2TextBox_name.PasswordChar = '\0';
            this.guna2TextBox_name.PlaceholderText = "";
            this.guna2TextBox_name.SelectedText = "";
            this.guna2TextBox_name.Size = new System.Drawing.Size(149, 36);
            this.guna2TextBox_name.TabIndex = 3;
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 18;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.ForeColor = System.Drawing.Color.Black;
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(94, 71);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(149, 36);
            this.TextBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.TextBox_pass);
            this.panel1.Controls.Add(this.passwordlbl);
            this.panel1.Controls.Add(this.DataGridView_seller);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.guna2TextBox_phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guna2TextBox_age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(156, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 358);
            this.panel1.TabIndex = 30;
            // 
            // TextBox_pass
            // 
            this.TextBox_pass.BorderRadius = 18;
            this.TextBox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_pass.DefaultText = "";
            this.TextBox_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_pass.ForeColor = System.Drawing.Color.Black;
            this.TextBox_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.Location = new System.Drawing.Point(94, 235);
            this.TextBox_pass.Name = "TextBox_pass";
            this.TextBox_pass.PasswordChar = '●';
            this.TextBox_pass.PlaceholderText = "";
            this.TextBox_pass.SelectedText = "";
            this.TextBox_pass.Size = new System.Drawing.Size(149, 36);
            this.TextBox_pass.TabIndex = 20;
            this.TextBox_pass.UseSystemPasswordChar = true;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.White;
            this.passwordlbl.Location = new System.Drawing.Point(4, 239);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(89, 28);
            this.passwordlbl.TabIndex = 19;
            this.passwordlbl.Text = "Password";
            // 
            // button_selling
            // 
            this.button_selling.FlatAppearance.BorderSize = 0;
            this.button_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selling.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_selling.Location = new System.Drawing.Point(41, 200);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(93, 45);
            this.button_selling.TabIndex = 35;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = true;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
            // 
            // button_category
            // 
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_category.Location = new System.Drawing.Point(25, 134);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(125, 45);
            this.button_category.TabIndex = 34;
            this.button_category.Text = "Category";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_product
            // 
            this.button_product.FlatAppearance.BorderSize = 0;
            this.button_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_product.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_product.Location = new System.Drawing.Point(32, 67);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(110, 45);
            this.button_product.TabIndex = 33;
            this.button_product.Text = "Product";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 517);
            this.Controls.Add(this.logoutlbl);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_seller)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoutlbl;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_seller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_age;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_pass;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_product;
    }
}