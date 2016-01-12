using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Double Celsius, Fahrenheit, Kelvin;

            if (cmbTemperatures.Text == "Celsius")
            {
                lblTemp1.Text = "Farenheit";
                lblTemp2.Text = "Kelvin";
                Celsius = Convert.ToDouble(txtTemperature.Text);
                Fahrenheit = Celsius * (9 / 5) + 32;
                Kelvin = Celsius + 273.15;
                lblConverted1.Text = Fahrenheit.ToString();
                lblConverted2.Text = Kelvin.ToString();
            }
            else if (cmbTemperatures.Text == "Kelvin")
            {
                lblTemp1.Text = "Farenheit";
                lblTemp2.Text = "Celsius";
                Kelvin = Convert.ToDouble(txtTemperature.Text);
                Fahrenheit = (Kelvin - 273.15) * 9 / 5 + 32;
                Celsius = Kelvin - 273.15;
                lblConverted1.Text = Fahrenheit.ToString();
                lblConverted2.Text = Celsius.ToString();

            }
            else if (cmbTemperatures.Text == "Farenheit")
            {

                lblTemp1.Text = "Kelvin";
                lblTemp2.Text = "Celsius";
                Fahrenheit = Convert.ToDouble(txtTemperature.Text);
                Kelvin = (Fahrenheit - 32) * 5 / 9 + 273.15;
                Celsius = (Fahrenheit - 32) * 5 / 9;
                lblConverted1.Text = Kelvin.ToString();
                lblConverted2.Text = Celsius.ToString();

            }
            if(cmbTemperatures.SelectedIndex==-1)
            {
                MessageBox.Show("Please select the temperature to convert");
            }
            else if(txtTemperature.Text=="")
            {
                MessageBox.Show("Please provide the temperature to convert");
                txtTemperature.BackColor = Color.Red;
            }
            else
            {
                pnlTemperature.Visible = true;
            }
        }

        private void txtTemperature_MouseClick(object sender, MouseEventArgs e)
        {
            txtTemperature.BackColor = Color.White;
        }

        private void cmbTemperatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double Celsius, Fahrenheit, Kelvin;

            if (cmbTemperatures.Text == "Celsius")
            {
                lblTemp1.Text = "Farenheit";
                lblTemp2.Text = "Kelvin";
                Celsius = Convert.ToDouble(txtTemperature.Text);
                Fahrenheit = Celsius * (9 / 5) + 32;
                Kelvin = Celsius + 273.15;
                lblConverted1.Text = Fahrenheit.ToString();
                lblConverted2.Text = Kelvin.ToString();
            }
            else if (cmbTemperatures.Text == "Kelvin")
            {
                lblTemp1.Text = "Farenheit";
                lblTemp2.Text = "Celsius";
                Kelvin = Convert.ToDouble(txtTemperature.Text);
                Fahrenheit = (Kelvin - 273.15) * 9 / 5 + 32;
                Celsius = Kelvin - 273.15;
                lblConverted1.Text = Fahrenheit.ToString();
                lblConverted2.Text = Celsius.ToString();

            }
            else if (cmbTemperatures.Text == "Farenheit")
            {

                lblTemp1.Text = "Kelvin";
                lblTemp2.Text = "Celsius";
                Fahrenheit = Convert.ToDouble(txtTemperature.Text);
                Kelvin=(Fahrenheit - 32) * 5/9 + 273.15;
                Celsius = (Fahrenheit - 32) * 5 / 9;
                lblConverted1.Text = Kelvin.ToString();
                lblConverted2.Text = Celsius.ToString();

 


            }
            if (cmbTemperatures.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the temperature to convert");
            }
            else if (txtTemperature.Text == "")
            {
                MessageBox.Show("Please provide the temperature to convert");
                txtTemperature.BackColor = Color.Red;
            }
            else
            {
                pnlTemperature.Visible = true;
            }
        }
    }
}
