using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace РасчетГСМ
{
    public partial class Calculate : Form
    {
      

        public Calculate()
        {
            InitializeComponent();
        }
        public string StringConn = @"Data Source=GREYBOX;Initial Catalog=Cardatabase;Integrated Security=True";
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
        private void calculatebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                double a;  //distance
                double b;  //litersPer100Km
                double c;  //fuelCostPerLiter


                a = Convert.ToDouble(distance.Text);
                b = Convert.ToDouble(litersPer100Km.Text);
                c = Convert.ToDouble(fuelCostPerLiter.Text);



                double fc = (a / 100) * b;  //Израсходовано топлива
                double tfc = c * (double)fc;  //Потрачено средств

                fuelConsumption.Text = Convert.ToString(fc);
                totalFuelCost.Text = Convert.ToString(tfc);
            }
            catch (FormatException)
            {
                MessageBox.Show("Поля не заполнены");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void fuelConsumption_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalFuelCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            distance.Text = "";
            litersPer100Km.Text = "";
            fuelCostPerLiter.Text = "";
            fuelConsumption.Text = "";
            totalFuelCost.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cardatabaseDataSet.auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.cardatabaseDataSet.auto);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.autoTableAdapter.FillBy(this.cardatabaseDataSet.auto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
