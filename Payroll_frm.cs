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
    public partial class Payroll_frm : Form
    {
        static double HourlyRate = 102.74;
        double TotalDeduction;
        double TotalPayroll;
        double semiRate;

        public Payroll_frm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int NumberOfAbsences = Convert.ToInt32(txtNumberOfAbsences.Text);
            int Undertime = Convert.ToInt32(txtUndertime.Text);
            int Latest = Convert.ToInt32(txtLates.Text);
            double hourlyRate = Convert.ToDouble(lblHourlyRate.Text);

            TotalDeduction = (NumberOfAbsences + Undertime + Latest) * hourlyRate;
            TotalPayroll = (semiRate / 2) - TotalDeduction;

            lblTotal.Text = TotalPayroll.ToString();
        }

        private void Payroll_frm_Load(object sender, EventArgs e)
        {
        }

        private void txtSemiRate_Leave(object sender, EventArgs e)
        {
            if (txtSemiRate.Text == "")
            {
                txtSemiRate.Text = "";
            }
            else
            {
                semiRate = Convert.ToDouble(txtSemiRate.Text);

                decimal number = Convert.ToDecimal(txtSemiRate.Text);
                decimal hrRate = Convert.ToDecimal(semiRate * 12 / 365 / 8);
                decimal rounded = Math.Round(hrRate, 2);

                lblHourlyRate.Text = rounded.ToString();
            }
        }

        private void txtSemiRate_Enter(object sender, EventArgs e)
        {
            if (txtSemiRate.Text == "")
            {
                txtSemiRate.Text = "";
            }
        }
    }
}
