using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECB_APP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private Form activeFrom = null;

        private void openChildForm(Form childForm)
        {
            if (activeFrom != null)
            {
                activeFrom.Close();
            }
            
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_right.Controls.Add(childForm);
            pnl_right.Tag = childForm;
            childForm.BringToFront();
            childForm.BackColor = pnl_right.BackColor;
            childForm.Show();
        }


        

        private void pnl_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_catergory_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_submenu);
        }

        private void btn_domestic_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_domesticSub);
        }

        private void btn_industrial_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_industrial_I_1());
        }

        private void btn_general_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_general_GP_1());
        }

        private void btn_hotel_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_hotel_H_1());
        }

        private void btn_government_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_government_GV_1());
        }

        private void btn_dome_cal_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_domestic_Cal());
        }

        private void btn_dome_billrate_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_domestic_Billrate());
        }

        private void btn_religious_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_religious_R_1());
        }
    }
}
