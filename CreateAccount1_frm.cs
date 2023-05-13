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
    public partial class CreateAccount1_frm : Form
    {
        public CreateAccount1_frm()
        {
            InitializeComponent();
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void bunifuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CreateAccount1_frm_Load(object sender, EventArgs e)
        {
        }
    }
}
