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
    public partial class Department_frm : Form
    {
        public Department_frm()
        {
            InitializeComponent();
        }

        private void Department_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAPMSDataSet9.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.bAPMSDataSet9.Department);
            // TODO: This line of code loads data into the 'bAPMSDataSet8.Department' table. You can move, or remove it, as needed.
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
