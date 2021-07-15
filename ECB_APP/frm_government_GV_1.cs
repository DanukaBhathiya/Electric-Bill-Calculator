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
    public partial class frm_government_GV_1 : Form
    {

        double charge = 14.65;
        double fixed_charge = 600;
        double max_demand_charge = 0;
        double chg_for_units;
        double total_charge;


        public frm_government_GV_1()
        {
            InitializeComponent();
        }

        private void frm_government_GV_1_Load(object sender, EventArgs e)
        {
            lbl_t_1.Text = charge.ToString();
            lbl_t_2.Text = fixed_charge.ToString();
            lbl_t_3.Text = max_demand_charge.ToString();
        }

        private void btn_cla_Click(object sender, EventArgs e)
        {
            string temp = txt_units.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(txt_units.Text);
                if (units_consumed >= 0)
                {
                    chg_for_units = units_consumed * charge;
                    lbl_1.Text = chg_for_units.ToString();
                    lbl_2.Text = fixed_charge.ToString();
                    total_charge = chg_for_units + fixed_charge;
                    lbl_3.Text = total_charge.ToString();
                    txt_units.Text = "";
                }

                else
                {
                    MessageBox.Show("Please enter a Positive number!", "Negative Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_units_Click(object sender, EventArgs e)
        {
            if (txt_units.Text == "0")
            {
                txt_units.Clear();
            }
            else
            {
                txt_units.Clear();
            }
        }
    }
}
