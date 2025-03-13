using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bill_calculator
{
    public partial class frm__gov__pur : Form
    {
        double total_charge;
        double fixed_charge = 360.00;
        double before_180_charge = 25.00;
        double before_180;
        public frm__gov__pur()
        {
            InitializeComponent();
        }

        private void frm__gov__pur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int unit_consumed = int.Parse(textBox1.Text);
            if (unit_consumed >= 0 && unit_consumed < 181)
            {
                before_180 = unit_consumed * before_180_charge;
                total_charge = before_180 + fixed_charge;
                lbl2.Text = before_180.ToString();
                lbl3.Text = fixed_charge.ToString();
                lbl4.Text = total_charge.ToString();
                label10.Text = fixed_charge.ToString();
            }
            else
            {
                MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
