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
    public partial class RegisterAccount_frm : Form
    {
        public RegisterAccount_frm()
        {
            InitializeComponent();

            InputText();
        }

        private void RegisterAccount_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void InputText()
        {
            if (!txtUsername.Text.Equals(""))
            {
                txtConfirmUser.Enabled = true;
            }
            else
            {
                txtConfirmUser.Enabled = false;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputText();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
