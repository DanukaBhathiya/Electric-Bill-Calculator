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
    public partial class frm_domestic_Cal : Form
    {

        double charge_0_30_if_below_60kwh = 2.50;
        double charge_31_60_if_below_60kwh = 4.85;

        double fixed_charge_0_30_if_below_60kwh = 30.00;
        double fixed_charge_31_60_if_below_60kwh = 60.00;

        double charge_0_60_if_above_60kwh = 7.85;
        double charge_61_90_if_above_60kwh = 10.00;
        double charge_91_120_if_above_60kwh = 27.75;
        double charge_121_180_if_above_60kwh = 32.00;
        double charge_180_infinity_if_above_60kwh = 45.00;

        double fixed_charge_0_60_if_above_60kwh = 0;
        double fixed_charge_61_90_if_above_60kwh = 90.00;
        double fixed_charge_91_120_if_above_60kwh = 480.00;
        double fixed_charge_121_180_if_above_60kwh = 480.00;
        double fixed_charge_180_infinity_if_above_60kwh = 540.00;

        double charge_0_30;
        double charge_0_60;
        double charge_31_60;
        double charge_61_90;
        double charge_91_120;
        double charge_121_180;
        double charge_above_180;
        double total_charge;


        public frm_domestic_Cal()
        {
            InitializeComponent();
        }

        private void myMethod1(double fixedCarge)
        {
            lbl_1.Text = charge_0_30.ToString();
            lbl_2.Text = charge_31_60.ToString();
            lbl_3.Text = charge_61_90.ToString();
            lbl_4.Text = charge_91_120.ToString();
            lbl_5.Text = charge_121_180.ToString();
            lbl_6.Text = charge_above_180.ToString();
            lbl_7.Text = fixedCarge.ToString();
            lbl_8.Text = total_charge.ToString();
        }

        private void mytext()
        {
            lbl_unit_limit_1.Visible = false;
            lbl_unit_limit_2.Text = "Charge for first 60 Units (Rs)";
            label16.Visible = false;
            lbl_1.Visible = false;
            lbl_2.Text = charge_0_60.ToString();
        }

        private void mytext2()
        {
            lbl_unit_limit_1.Visible = true;
            lbl_unit_limit_2.Text = "Charge between 31 - 60 Units (Rs)";
            label16.Visible = true;
            lbl_1.Visible = true;
            
        }


        private void btn_cla_Click(object sender, EventArgs e)
        {
            string temp = txt_units.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(txt_units.Text);
                if (units_consumed < 61 && units_consumed >= 0)
                {
                    if (units_consumed <= 30)
                    {
                        charge_0_30 = units_consumed * charge_0_30_if_below_60kwh;
                        total_charge = charge_0_30 + fixed_charge_0_30_if_below_60kwh;

                        myMethod1(fixed_charge_0_30_if_below_60kwh);
                    }
                    else
                    {
                        charge_0_30 = 30 * charge_0_30_if_below_60kwh;
                        charge_31_60 = (units_consumed - 30) * charge_31_60_if_below_60kwh;
                        total_charge = charge_0_30 + charge_31_60 + fixed_charge_31_60_if_below_60kwh;

                        myMethod1(fixed_charge_31_60_if_below_60kwh);
                    }

                    mytext2();

                }
                else if (units_consumed > 60)
                {
                    
                    if (units_consumed <= 90)
                    {
                        charge_0_60 = 60 * charge_0_60_if_above_60kwh;
                        charge_61_90 = (units_consumed - 60) * charge_61_90_if_above_60kwh;
                        total_charge = charge_0_60 + charge_61_90 + fixed_charge_61_90_if_above_60kwh;

                        myMethod1(fixed_charge_61_90_if_above_60kwh);
                    }
                    else if (units_consumed <= 120)
                    {
                        charge_0_60 = 60 * charge_0_60_if_above_60kwh;
                        charge_61_90 = 30 * charge_61_90_if_above_60kwh;
                        charge_91_120 = (units_consumed - 90) * charge_91_120_if_above_60kwh;
                        total_charge = charge_0_60 + charge_61_90 + charge_91_120 + fixed_charge_91_120_if_above_60kwh;

                        myMethod1(fixed_charge_91_120_if_above_60kwh);
                    }
                    else if (units_consumed <= 180)
                    {
                        charge_0_60 = 60 * charge_0_60_if_above_60kwh;
                        charge_61_90 = 30 * charge_61_90_if_above_60kwh;
                        charge_91_120 = 30 * charge_91_120_if_above_60kwh;
                        charge_121_180 = (units_consumed - 120) * charge_121_180_if_above_60kwh;
                        total_charge = charge_0_60 + charge_61_90 + charge_91_120 + charge_121_180 + fixed_charge_121_180_if_above_60kwh;

                        myMethod1(fixed_charge_121_180_if_above_60kwh);
                    }
                    else
                    {
                        charge_0_60 = 60 * charge_0_60_if_above_60kwh;
                        charge_61_90 = 30 * charge_61_90_if_above_60kwh;
                        charge_91_120 = 30 * charge_91_120_if_above_60kwh;
                        charge_121_180 = 60 * charge_121_180_if_above_60kwh;
                        charge_above_180 = (units_consumed - 180) * charge_180_infinity_if_above_60kwh;
                        total_charge = charge_0_60 + charge_61_90 + charge_91_120 + charge_121_180 + charge_above_180 + fixed_charge_180_infinity_if_above_60kwh;

                        myMethod1(fixed_charge_180_infinity_if_above_60kwh);
                    }


                    mytext();
                    
                    

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

        private void lbl_8_Click(object sender, EventArgs e)
        {

        }

        private void txt_units_TextChanged(object sender, EventArgs e)
        {
            
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
