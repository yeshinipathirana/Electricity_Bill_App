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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_gov_GV_1_Click(object sender, EventArgs e)
        {
            openchildform(new frm__gov__pur());
        }

        private void btn_dom_cat_1_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_dom_subme);
        }

        private void btn_rel_cat_R1_Click(object sender, EventArgs e)
        {
            openchildform(new frm_rel());
        }

        private void btn_ind_per_Click(object sender, EventArgs e)
        {
            openchildform(new frm_ind_cat_1());
        }
        private void customdesign()
        {
            pnl_dom_subme.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
            
        }
        private void hidesubmenu()
        {
            if (pnl_dom_subme.Visible == true)
            {
                pnl_dom_subme.Visible = false;
            }
        
            
        }
        private Form activeform = null;
        private void openchildform( Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
                activeform = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                pnl_right.Controls.Add(childform);
                pnl_right.Tag = childform;
                childform.BringToFront();
                childform.Show();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            customdesign();
        }

        private void btn_gen_cat_GP_1_Click(object sender, EventArgs e)
        {
            openchildform(new frm_gen_pur());
        }

        private void btn_hot_cat_H_1_Click(object sender, EventArgs e)
        {
            openchildform(new frm_hot_cat());
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            openchildform(new frm_dom_pur());
        }

        private void btn_billrate_Click(object sender, EventArgs e)
        {
            openchildform(new frm_dom_billrate());
        }
    }
}
