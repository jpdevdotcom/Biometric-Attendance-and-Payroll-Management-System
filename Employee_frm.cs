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
    public partial class Employee_frm : Form
    {
        public Employee_frm()
        {
            InitializeComponent();
        }

        private void Employee_frm_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.bAPMSDataSet6.Employee);
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
