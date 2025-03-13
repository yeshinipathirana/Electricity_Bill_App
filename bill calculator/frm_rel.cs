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
    public partial class frm_rel : Form
    {
        double total_charge;
        double fixed_charge_30 = 90.0;
        double fixed_charge_120 = 120.00;
        double fixed_charge_180 = 450.00;
        double fixed_charge_90 = 120.00;
        double before_charge_30 = 8.0;
        double before_charge_120 = 20.00;
        double before_charge_180 = 30.00;
        double before_charge_90 = 15.00;
        double after_180_charge = 65.00;
        double before_30;
        double before_90;
        double before_120;
        double before_180;
        double fixed_charge_above180 = 1500.00;
        double after_180;

        public frm_rel()
        {
            InitializeComponent();
        }

        private void frm_rel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int unit_consumed = int.Parse(textBox1.Text);
            if (unit_consumed >= 0 && unit_consumed < 30)
            {
                before_30 = unit_consumed * before_charge_30;
                total_charge = before_charge_30 + fixed_charge_30;
                lbl1.Text = before_30.ToString();
                lbl6.Text = fixed_charge_30.ToString();
                lbl7.Text = total_charge.ToString();
                label24.Text = before_charge_30.ToString();
                label28.Text = fixed_charge_30.ToString();
            }
            else if (unit_consumed >= 30 && unit_consumed < 91)
            { before_90 = (unit_consumed - 30) * before_charge_90;
                before_30 = 30 * before_charge_30;
                total_charge = before_90 + fixed_charge_90 + before_30;
                lbl1.Text = before_30.ToString();
                lbl2.Text = before_90.ToString();
                lbl6.Text = fixed_charge_90.ToString();
                lbl7.Text = total_charge.ToString();
                label24.Text = before_charge_30.ToString();
                label28.Text = fixed_charge_30.ToString();
                label22.Text = before_charge_90.ToString();
                label29.Text = fixed_charge_90.ToString();

            }
            else if(unit_consumed >= 90 && unit_consumed < 121) {
                before_120 = (unit_consumed - 90) * before_charge_120;
                before_90 = 60 * before_charge_90;
                before_30 = 30 * before_charge_30;
                total_charge = before_120+fixed_charge_120+before_90 + before_30;
                lbl1.Text = before_30.ToString();
                lbl2.Text = before_90.ToString();
                lbl3.Text = before_120.ToString();
                lbl6.Text = fixed_charge_120.ToString();
                lbl7.Text = total_charge.ToString();
                label24.Text = before_charge_30.ToString();
                label28.Text = fixed_charge_30.ToString();
                label22.Text = before_charge_90.ToString();
                label29.Text = fixed_charge_90.ToString();
                label25.Text = before_charge_120.ToString();
                label30.Text = fixed_charge_120.ToString();
            }
            else if (unit_consumed >= 120 && unit_consumed < 181)
            {
                before_180 = (unit_consumed - 120) * before_charge_180;
                before_120 = 120 * before_charge_120;
                before_90 = 60 * before_charge_90;
                before_30 = 30 * before_charge_30;
                total_charge = before_180 + fixed_charge_180 + before_90 + before_30+before_120;
                lbl1.Text = before_30.ToString();
                lbl2.Text = before_90.ToString();
                lbl3.Text = before_120.ToString();
                lbl4.Text = before_180.ToString();
                lbl6.Text = fixed_charge_180.ToString();
                lbl7.Text = total_charge.ToString();
                label24.Text = before_charge_30.ToString();
                label28.Text = fixed_charge_30.ToString();
                label22.Text = before_charge_90.ToString();
                label29.Text = fixed_charge_90.ToString();
                label25.Text = before_charge_120.ToString();
                label30.Text = fixed_charge_120.ToString();
                label26.Text = before_charge_180.ToString();
                label31.Text = fixed_charge_180.ToString();
            }
            else if ( unit_consumed > 181)
            {
                after_180 = (unit_consumed - 180) * after_180_charge;
                before_180 = 180 * before_charge_180;
                before_120 = 120 * before_charge_120;
                before_90 = 60 * before_charge_90;
                before_30 = 30 * before_charge_30;
                total_charge = after_180 + fixed_charge_above180 + before_90 + before_30 + before_120+before_180;
                lbl1.Text = before_30.ToString();
                lbl2.Text = before_90.ToString();
                lbl3.Text = before_120.ToString();
                lbl4.Text = before_180.ToString();
                lbl5.Text = after_180.ToString();
                lbl6.Text = fixed_charge_180.ToString();
                lbl7.Text = total_charge.ToString();
                label24.Text = before_charge_30.ToString();
                label28.Text = fixed_charge_30.ToString();
                label22.Text = before_charge_90.ToString();
                label29.Text = fixed_charge_90.ToString();
                label25.Text = before_charge_120.ToString();
                label30.Text = fixed_charge_120.ToString();
                label26.Text = before_charge_180.ToString();
                label31.Text = fixed_charge_180.ToString();
                label15.Text = after_180_charge.ToString();
                label16.Text = fixed_charge_above180.ToString();
            }
            else
            {
                MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }
    }
}
