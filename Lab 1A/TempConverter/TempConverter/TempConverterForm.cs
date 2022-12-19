using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class TempConverterForm : Form
    {
        public TempConverterForm()
        {
            InitializeComponent();
        }


        // Converts the temperature given in *UnconvertedTemperature_Textbox* to FAHRENHEIT
        // and places the result in *ConvertedTemperature_Textbox*
        private void ConvertToFahrenheit_Button_Click(object sender, EventArgs e)
        {
            string inputText = UnconvertedTemperature_Textbox.Text;
            try
            {
                decimal celsius = Convert.ToDecimal(inputText);
                ConvertedTemperature_Textbox.Text = (ConvertCelsiusToFahrenheit(celsius).ToString("F2")) + "°F";
                ConvertedTemperature_Textbox.Focus();
            }
            catch(OverflowException)
            {
                MessageBox.Show("You entered too big of a number resulting in overflow.", "Overflow Error");
            }
            catch (FormatException)
            {
                MessageBox.Show("You entered an invalid number. Please fix it and try again.", "Formatting Error");
            }
        }

        // Converts the temperature given in *UnconvertedTemperature_Textbox* to CELSIUS
        // and places the result in *ConvertedTemperature_Textbox*
        private void ConvertToCelsius_Button_Click(object sender, EventArgs e)
        {
            string inputText = UnconvertedTemperature_Textbox.Text;
            try
            {
                decimal fahrenheit = Convert.ToDecimal(inputText);
                ConvertedTemperature_Textbox.Text = (ConvertFahrenheitToCelsius(fahrenheit).ToString("F2")) + "°C";
                ConvertedTemperature_Textbox.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("You entered too big of a number resulting in overflow.", "Overflow Error");
            }
            catch (FormatException)
            {
                MessageBox.Show("You entered an invalid number. Please fix it and try again.", "Formatting Error");
            }
        }

        // Closes the form
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Converts the temperature and returns it.
        private static decimal ConvertCelsiusToFahrenheit(decimal c)
        {
            return (9m / 5m) * c + 32m;
        }
        private static decimal ConvertFahrenheitToCelsius(decimal f)
        {
            return (5m / 9m) * (f - 32m);
        }


        // Resets the form output if the input has changed
        private void UnconvertedTemperature_Textbox_TextChanged(object sender, EventArgs e)
        {
            ConvertedTemperature_Textbox.Text = String.Empty;
        }

    }
}
