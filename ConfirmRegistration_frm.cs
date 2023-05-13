using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_and_Payroll_Management_System
{
    public partial class ConfirmRegistration_frm : Form
    {
        MainForm mainForm = new MainForm();
        CreateAccount1_frm account_frm1 = new CreateAccount1_frm();

        SqlCommand cmd;

        public ConfirmRegistration_frm()
        {
            InitializeComponent();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BI060IG8\SQLEXPRESS;Initial Catalog=BAPMS;Integrated Security=True"))
                {
                    conn.Open();

                    String INSERT_EMPLOYEE = @"INSERT INTO BAPMS.dbo.Employee OUTPUT INSERTED.employee_id VALUES (@fname, @lname, @mname, @contact, @birthdate, @age, @gender, @address)";
                    String INSERT_POSITION = "INSERT INTO BAPMS.dbo.Position (position, description) VALUES (@position, @description)";
                    String INSERT_DEPARTMENT = "INSERT INTO BAPMS.dbo.Department (department, location) VALUES (@department, @location)";
                    String INSERT_ACCOUNT = "INSERT INTO BAPMS.dbo.AccountUser (employee_id, username, password) VALUES (@employee_id, @username, @password)";

                    using (cmd = new SqlCommand(INSERT_POSITION, conn))
                    {
                        cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);

                        ExecuteNonQuery();
                    }

                    using (cmd = new SqlCommand(INSERT_DEPARTMENT, conn))
                    {
                        cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                        cmd.Parameters.AddWithValue("@location", txtLocation.Text);

                        ExecuteNonQuery();
                    }

                    cmd = new SqlCommand(INSERT_EMPLOYEE, conn);
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dtBirthday.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                    //ExecuteNonQuery();

                    var res = (int)cmd.ExecuteScalar();

                    using (cmd = new SqlCommand(INSERT_ACCOUNT, conn))
                    {
                        cmd.Parameters.AddWithValue("@employee_id", res);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        ExecuteNonQuery();
                    }

                    conn.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Hide();
            mainForm.ShowDialog();
        }

        private void ExecuteNonQuery()
        {
            int result = cmd.ExecuteNonQuery();

            if (result < 0)
            {
                MessageBox.Show("Error inserting data into Database!");
            }

        }

        private void ConfirmRegistration_frm_Load(object sender, EventArgs e)
        {

        }

        private void chckTermsAndConditions_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chckTermsAndConditions.Checked)
            {
                btnConfirm.Enabled = true;
            } else
            {
                btnConfirm.Enabled = false;
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 Login_frm = new Form1();

            DialogResult close = MessageBox.Show("Do you want Cancel your registration?", "APMS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (close == DialogResult.Yes)
            {
                this.Close();
                Login_frm.Show();
            }
        }
    }
}
