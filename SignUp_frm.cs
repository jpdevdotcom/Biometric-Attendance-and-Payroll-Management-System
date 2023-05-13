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

namespace Attendance_and_Payroll_Management_System
{
    public partial class SignUp_frm : Form
    {
        CreateAccount1_frm createAccount1_frm = new CreateAccount1_frm();
        CreateAccount2_frm createAccount2_frm = new CreateAccount2_frm();
        RegisterAccount_frm registerAccount_frm = new RegisterAccount_frm();
        ConfirmRegistration_frm confirmRegistration_frm = new ConfirmRegistration_frm();
        int pageCount = 1;


        public SignUp_frm()
        {
            InitializeComponent();

            createAccount1_frm.TopLevel = false;
            PanelContainer.Controls.Add(createAccount1_frm);
            createAccount1_frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult exitApplication = MessageBox.Show("Do you want to cancel your registration?", "APMS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitApplication == DialogResult.Yes)
            {
                cancelRegistration();
            }
        }

        private void cancelRegistration()
        {
            Form1 login_frm = new Form1();
            this.Close();
            login_frm.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            cancelRegistration();
        }

        public void DisplayUserInformation()
        {
            //Registration 1
            String fname = createAccount1_frm.txtFname.Text;
            String mname = createAccount1_frm.txtMname.Text;
            String lname = createAccount1_frm.txtLname.Text;
            String contact = createAccount1_frm.txtContact.Text;
            String address = createAccount1_frm.txtAddress.Text;
            String age = createAccount1_frm.cboAge.Text;
            String gender = createAccount1_frm.cboGender.Text;
            String birthday = createAccount1_frm.dtBirthday.Text;

            //Registration 2
            String position = createAccount2_frm.cboPosition.Text;
            String position_description = createAccount2_frm.txtDescription.Text;
            String department = createAccount2_frm.cboDepartment.Text;
            String department_location = createAccount2_frm.txtLocation.Text;

            //Registration 3
            String username = registerAccount_frm.txtUsername.Text;
            String password = registerAccount_frm.txtPassword.Text;

            //Confirmation
            confirmRegistration_frm.txtFirstName.Text = fname;
            confirmRegistration_frm.txtMiddleName.Text = mname;
            confirmRegistration_frm.txtLastName.Text = lname;
            confirmRegistration_frm.txtAddress.Text = address;
            confirmRegistration_frm.dtBirthday.Text = birthday;
            confirmRegistration_frm.txtAge.Text = age;
            confirmRegistration_frm.txtGender.Text = gender;
            confirmRegistration_frm.txtContact.Text = contact;
            confirmRegistration_frm.txtPosition.Text = position;
            confirmRegistration_frm.txtDescription.Text = position_description;
            confirmRegistration_frm.txtDepartment.Text = department;
            confirmRegistration_frm.txtLocation.Text = department_location;
            confirmRegistration_frm.txtUsername.Text = username;
            confirmRegistration_frm.txtPassword.Text = password;

            this.Hide();
            confirmRegistration_frm.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            pageCount++;

            PageNumber.Text = pageCount.ToString();

            if (PageNumber.Text.Equals("2")) {
                createAccount1_frm.Hide();
                this.Height = 595;
                PanelContainer.Height = 324;

                createAccount2_frm.TopLevel = false;
                PanelContainer.Controls.Add(createAccount2_frm);

                createAccount2_frm.Show();
            }

            if (PageNumber.Text.Equals("3")) {
                createAccount2_frm.Hide();
                this.Height = 550;
                PanelContainer.Height = 280;

                btnNext.Text = "Register";
                registerAccount_frm.TopLevel = false;
                PanelContainer.Controls.Add(registerAccount_frm);

                registerAccount_frm.Show();
            } else if (pageCount == 4)
            {
                DisplayUserInformation();
            }

            if (pageCount > 3)
            {
                PageNumber.Text = "3";
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
