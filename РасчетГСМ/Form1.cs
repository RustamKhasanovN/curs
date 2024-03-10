using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РасчетГСМ
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }
        private void distance_TextChanged(object sender, EventArgs e)
        {

        }

        private void litersPer100Km_TextChanged(object sender, EventArgs e)
        {

        }

        private void fuelCostPerLiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void fuelConsumption_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalFuelCost_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculatebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                double distance;
                double litersPer100Km;
                double fuelCostPerLiter;


                distance = Convert.ToDouble(txtDistance.Text);
                litersPer100Km = Convert.ToDouble(txtLitersPer100KM.Text);
                fuelCostPerLiter = Convert.ToDouble(txtFuelCostPerLiter.Text);

                double fuelConsumption = (distance / 100) * litersPer100Km;
                double totalFuelCost = fuelCostPerLiter * (double)fuelConsumption;


                txtFuelConsumption.Text = fuelConsumption.ToString("N2");
                txtTotalFuelCost.Text = totalFuelCost.ToString("C");

                MessageBox.Show($"затрачено средств:{totalFuelCost}");


                MessageBox.Show($"Израсходовано топлива:{fuelConsumption}");




            }
            catch (FormatException)
            {
                MessageBox.Show("please");
            }


        }


    }
}
