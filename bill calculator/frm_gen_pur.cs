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
    public partial class frm_gen_pur : Form
    {
        double total_charge;
        double fixed_charge = 360.00;
        double before_180_charge = 25.00;
        double before_180;
        double fixed_charge_above180=1500.00 ;
        double after_180;
        double after_180_charge=32.00;
        public frm_gen_pur()
        {
            InitializeComponent();
        }

        private void frm_gen_pur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int unit_consumed = int.Parse(textBox1.Text);
            if (unit_consumed >= 0 && unit_consumed < 181)
            {
                before_180 = unit_consumed * before_180_charge;
                total_charge = before_180 + fixed_charge;
                lbl1.Text = before_180.ToString();
                lbl3.Text = fixed_charge.ToString();
                lbl4.Text = total_charge.ToString();
                label9.Text = before_180_charge.ToString();
                label13.Text = after_180_charge.ToString();
                label10.Text = fixed_charge.ToString();
                label14.Text = fixed_charge_above180.ToString();

            }
            else if (unit_consumed > 180)
            {
                before_180 = unit_consumed * before_180_charge;
                after_180 = (unit_consumed - 180) * after_180_charge;
                total_charge = after_180 + fixed_charge_above180 + before_180;
                label9.Text = before_180_charge.ToString();
                label13.Text = after_180_charge.ToString();
                label10.Text = fixed_charge.ToString();
                label14.Text = fixed_charge_above180.ToString();
                lbl1.Text = before_180.ToString();
                lbl2.Text = after_180.ToString();
                lbl3.Text = fixed_charge_above180.ToString();
                lbl4.Text = total_charge.ToString();


            }
            else
            {
                MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
        }
    }
}
