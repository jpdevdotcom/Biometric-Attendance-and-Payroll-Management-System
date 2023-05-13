using Attendance_and_Payroll_Management_System.Shared_Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_and_Payroll_Management_System
{
    public partial class Form1 : Form
    {
        SignUp_frm signUp_frm = new SignUp_frm();

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BI060IG8\SQLEXPRESS;Initial Catalog=BAPMS;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult exitApplication = MessageBox.Show("Do you really want to exit?", "APMS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitApplication == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Text = "";
            } 
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter Password";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp_frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT username, password from AccountUser where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", conn);

            SqlParameter usernameParam;
            usernameParam = new SqlParameter("@username", this.txtUsername.Text);
            SqlParameter passwordParam;
            passwordParam = new SqlParameter("@password", this.txtPassword.Text);

            cmd.Parameters.Add(usernameParam);
            cmd.Parameters.Add(passwordParam);

            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            MainForm main_frm = new MainForm();

            if (txtUsername.Text == "Enter Username" || txtPassword.Text == "Enter Password")
            {
                MessageBox.Show("Please enter a Username/Password!", "APMS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Text = "Enter Username";
                txtPassword.Text = "Enter Password";
            } else if (dr.HasRows)
            {
                MessageBox.Show("You Have Successfully Logged In!", "APMS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                main_frm.Show();
            } else
            {
                MessageBox.Show("Invalid Username/Password, try again!", "APMS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Text = "Enter Username";
                txtPassword.Text = "Enter Password";
            }

            cmd.Connection.Close();
        }
    }
}
