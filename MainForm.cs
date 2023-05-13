using Attendance_and_Payroll_Management_System.Shared_Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_and_Payroll_Management_System
{
    public partial class MainForm : Form
    {
        Dashboard_frm dashboard_frm = new Dashboard_frm();
        Employee_frm employee_frm = new Employee_frm();
        Position_frm position_frm = new Position_frm();
        Department_frm department_frm = new Department_frm();
        Payroll_frm payroll_frm = new Payroll_frm();

        public MainForm()
        {
            InitializeComponent();

            DisplayDashboard();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication()
        {
            Form1 login_frm = new Form1();

            DialogResult exitApplication = MessageBox.Show("Do you want to exit this application?", "APMS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitApplication == DialogResult.Yes)
            {
                this.Hide();
                login_frm.Show();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayDashboard()
        {
            dashboard_frm.TopLevel = false;
            //dashboard_frm.Dock = DockStyle.Top;
            MainPanel.Controls.Add(dashboard_frm);
            dashboard_frm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dashboard_frm.Hide();
            position_frm.Hide();
            department_frm.Hide();
            payroll_frm.Hide();

            employee_frm.Dock = DockStyle.Top;
            employee_frm.TopLevel = false;
            MainPanel.Controls.Add(employee_frm);
            employee_frm.Show();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            employee_frm.Hide();
            position_frm.Hide();
            department_frm.Hide();
            payroll_frm.Hide();

            DisplayDashboard();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            employee_frm.Hide();
            dashboard_frm.Hide();
            department_frm.Hide();
            payroll_frm.Hide();

            position_frm.TopLevel = false;
            position_frm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(position_frm);
            position_frm.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            employee_frm.Hide();
            position_frm.Hide();
            dashboard_frm.Hide();
            payroll_frm.Hide();

            department_frm.TopLevel = false;
            department_frm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(department_frm);
            department_frm.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            employee_frm.Hide();
            position_frm.Hide();
            dashboard_frm.Hide();
            department_frm.Hide();

            payroll_frm.TopLevel = false;
            payroll_frm.Dock = DockStyle.Top;
            MainPanel.Controls.Add(payroll_frm);
            payroll_frm.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            ExitApplication();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
