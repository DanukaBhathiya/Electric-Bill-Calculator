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
    public partial class frm_religious_R_1 : Form
    {

        double charge_0_30_unit = 1.90;
        double charge_31_90_unit = 2.80;
        double charge_91_120_unit = 6.75;
        double charge_121_180_unit = 7.50;
        double charge_above_180_unit = 9.40;

        double fixed_charge_0_30_unit = 30.00;
        double fixed_charge_31_90_unit = 60.00;
        double fixed_charge_91_120_unit = 180.00;
        double fixed_charge_121_180_unit = 180.00;
        double fixed_charge_above_180_unit = 240.00;

        double charge_0_30;
        double charge_31_90;
        double charge_91_120;
        double charge_121_180;
        double charge_above_180;
        double total_charge;


        public frm_religious_R_1()
        {
            InitializeComponent();
        }

        private void myMethod1(double fixedCarge)
        {
            
            lbl_1.Text = charge_0_30.ToString();
            lbl_2.Text = charge_31_90.ToString();
            lbl_3.Text = charge_91_120.ToString();
            lbl_4.Text = charge_121_180.ToString();
            lbl_5.Text = charge_above_180.ToString();
            lbl_6.Text = fixedCarge.ToString();
            lbl_7.Text = total_charge.ToString();
        }


        private void frm_religious_R_1_Load(object sender, EventArgs e)
        {

            lbl_t_1.Text = charge_0_30_unit.ToString();
            lbl_t_2.Text = charge_31_90_unit.ToString();
            lbl_t_3.Text = charge_91_120_unit.ToString();
            lbl_t_4.Text = charge_121_180_unit.ToString();
            lbl_t_5.Text = charge_above_180_unit.ToString();
            lbl_t_6.Text = fixed_charge_0_30_unit.ToString();
            lbl_t_7.Text = fixed_charge_31_90_unit.ToString();
            lbl_t_8.Text = fixed_charge_91_120_unit.ToString();
            lbl_t_9.Text = fixed_charge_121_180_unit.ToString();
            lbl_t_10.Text = fixed_charge_above_180_unit.ToString();
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
                    if (units_consumed <= 30)
                    {
                        charge_0_30 = units_consumed * charge_0_30_unit;
                        total_charge = charge_0_30 + fixed_charge_0_30_unit;

                        myMethod1(fixed_charge_0_30_unit);
                    }
                    else if (units_consumed <= 90)
                    {
                        charge_0_30 = 30 * charge_0_30_unit;
                        charge_31_90 = (units_consumed - 30) * charge_31_90_unit;
                        total_charge = charge_0_30 + charge_31_90 + fixed_charge_31_90_unit;

                        myMethod1(fixed_charge_31_90_unit);
                    }
                    else if (units_consumed <= 120)
                    {
                        charge_0_30 = 30 * charge_0_30_unit;
                        charge_31_90 = 60 * charge_31_90_unit;
                        charge_91_120 = (units_consumed - 90) * charge_91_120_unit;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + fixed_charge_91_120_unit;

                        myMethod1(fixed_charge_91_120_unit);
                    }
                    else if (units_consumed <= 180)
                    {
                        charge_0_30 = 30 * charge_0_30_unit;
                        charge_31_90 = 60 * charge_31_90_unit;
                        charge_91_120 = 30 * charge_91_120_unit;
                        charge_121_180 = (units_consumed - 120) * charge_121_180_unit;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + charge_121_180 + fixed_charge_121_180_unit;

                        myMethod1(fixed_charge_121_180_unit);
                    }
                    else
                    {
                        charge_0_30 = 30 * charge_0_30_unit;
                        charge_31_90 = 60 * charge_31_90_unit;
                        charge_91_120 = 30 * charge_91_120_unit;
                        charge_121_180 = 60 * charge_121_180_unit;
                        charge_above_180 = (units_consumed - 180) * charge_above_180_unit;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + charge_121_180 + charge_above_180 + fixed_charge_above_180_unit;

                        myMethod1(fixed_charge_above_180_unit);
                    }

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
