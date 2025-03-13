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
    public partial class frm_ind_cat_1 : Form
    {
        double total_charge;
        double fixed_charge = 960.00;
        double before_300_charge = 20.00;
        double before_300;
        double fixed_charge_above300 = 1500.00;
        double after_300;
        double after_300_charge = 20.00;
        public frm_ind_cat_1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_ind_cat_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int unit_consumed = int.Parse(textBox1.Text);
            if (unit_consumed >= 0 && unit_consumed < 301)
            {
                before_300 = unit_consumed* before_300_charge;
                total_charge = before_300 + fixed_charge;
                lbl1.Text = before_300.ToString();
                lbl3.Text = fixed_charge.ToString();
                lbl4.Text = total_charge.ToString();
                label9.Text = before_300_charge.ToString();
                label13.Text = after_300_charge.ToString();
                label10.Text = fixed_charge.ToString();
                label14.Text = fixed_charge_above300.ToString();

            }
            else if (unit_consumed > 300)
            {
                before_300 = unit_consumed * before_300_charge;
                after_300 = (unit_consumed - 180) * after_300_charge;
                total_charge = after_300 + fixed_charge_above300 + before_300;
                label9.Text = before_300_charge.ToString();
                label13.Text = after_300_charge.ToString();
                label10.Text = fixed_charge.ToString();
                label14.Text = fixed_charge_above300.ToString();
                lbl1.Text = before_300.ToString();
                lbl2.Text = after_300.ToString();
                lbl3.Text = fixed_charge_above300.ToString();
                lbl4.Text = total_charge.ToString();


            }
            else
            {
                MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
            
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}
