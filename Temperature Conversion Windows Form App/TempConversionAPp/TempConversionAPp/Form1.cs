using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversionAPp
{
    public partial class Form1 : Form
    {

        int tempType = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string description = "";

            description += "Welcome to the Temperature Conversion Application made by Zackery Crews!\n\n";
            description += "This application will convert any temperature entered into Fahrenheit, Celsius," +
                           "\nand/or Kelvin. Once a temperature is entered, chosing your starting temperature" +
                           "\ntype, and click the convert button to convert the temps!";

            MessageBox.Show(description, "Welcome!", MessageBoxButtons.OK);
        }

        private void tempInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void fahrenheitButton_CheckedChanged(object sender, EventArgs e)
        {
            tempType = 1;
        }

        private void kelvinButton_CheckedChanged(object sender, EventArgs e)
        {
            tempType = 2;
        }

        private void celsiusButton_CheckedChanged(object sender, EventArgs e)
        {
            tempType = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = 0,
                   c = 0,
                   k = 0;

            switch(tempType)
            {
                case 0: MessageBox.Show("Please choose the type of Temperature is being entered.");
                    break;
                case 1: ConvertFahrenheit(tempInput.Text, tempType, ref f, ref c, ref k);
                    fahOutput.Text = string.Concat(f);
                    kelOutput.Text = string.Concat(k);
                    celOutput.Text = string.Concat(c);
                    break;
                case 2: ConvertKelvin(tempInput.Text, tempType, ref f, ref c, ref k);
                    fahOutput.Text = string.Concat(f);
                    kelOutput.Text = string.Concat(k);
                    celOutput.Text = string.Concat(c);
                    break;
                case 3: ConvertCelsius(tempInput.Text, tempType, ref f, ref c, ref k);
                    fahOutput.Text = string.Concat(f);
                    kelOutput.Text = string.Concat(k);
                    celOutput.Text = string.Concat(c);
                    break;
                default: MessageBox.Show("Please choose the type of Temperature is being entered.");
                    break;
            }
        }

        public void ConvertFahrenheit(string input, int type, ref double f, ref double c, ref double k)
        {
            double output;

            if(double.TryParse(input, out output) == false)
            {
                MessageBox.Show("Please enter only numeric characters and a single decimal for the temperature.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f = output;
                c = (output - 32) * 5 / 9;
                k = c + 273.15;
            }
        }

        public void ConvertCelsius(string input, int type, ref double f, ref double c, ref double k)
        {
            double output;

            if (double.TryParse(input, out output) == false)
            {
                MessageBox.Show("Please enter only numeric characters and a single decimal for the temperature.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f = (output * 9 / 5) + 32;
                c = output;
                k = c + 273.15;
            }

        }

        public void ConvertKelvin(string input, int type, ref double f, ref double c, ref double k)
        {
            double output;

            if (double.TryParse(input, out output) == false)
            {
                MessageBox.Show("Please enter only numeric characters and a single decimal for the temperature.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                c = output - 273.15;
                f = (c * 9 / 5) + 32;
                k = output;
            }

        }

        private void celOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
