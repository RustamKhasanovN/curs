﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace РасчетГСМ
{
    public partial class Calculate : Form
    {
      

        public Calculate()
        {
            InitializeComponent();
        }
        
       

       //кнопка расчета
        private void calculatebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                double a;  //distance
                double b;  //comboBox2consumption
                double c;  //fuelCostPerLiter


                a = Convert.ToDouble(distance.Text);
                b = Convert.ToDouble(comboBox2consumption.Text);
                c = Convert.ToDouble(fuelCostPerLiter.Text);



                double fc = (a / 100) * b;  //Израсходовано топлива
                double tfc = c * (double)fc;  //Потрачено средств

                fuelConsumption.Text = Convert.ToString(fc);
                totalFuelCost.Text = Convert.ToString(tfc);
            }
            catch (FormatException)
            {
                MessageBox.Show("Поля не заполнены или заполнены неправильно");
            }


        }

      
        //кнопка очистки
        private void clear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            distance.Text = "";
            comboBox2consumption.Text = "";
            fuelCostPerLiter.Text = "";
            fuelConsumption.Text = "";
            totalFuelCost.Text = "";
        }

        //кнопка выхода

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
    }
}
