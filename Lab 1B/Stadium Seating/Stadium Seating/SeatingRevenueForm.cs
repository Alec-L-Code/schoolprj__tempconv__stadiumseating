using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class StadiumRevenueForm : Form
    {
        public StadiumRevenueForm()
        {
            InitializeComponent();
        }

        private void CalculateRevenue_Button_Click(object sender, EventArgs e)
        {
            CalculateRevenue(TicketsSold_ClassA_Textbox.Text, TicketsSold_ClassB_Textbox.Text, 
                TicketsSold_ClassC_Textbox.Text);

            RevenueGenerated_Total_Textbox.Focus();
        }

        // Clears all text boxes on the form
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            foreach(Control c in TicketsSold_Panel.Controls)
            {
                if(c is TextBox) { c.Text = String.Empty; }
            }
            foreach (Control c in RevenueGenerated_Panel.Controls)
            {
                if (c is TextBox) { c.Text = String.Empty; }
            }
        }

        // Exits the Form
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }






        // Calculates the revenue from the tickets sold from class A, B, and C and sets the revenue textboxes
        private void CalculateRevenue(string classA, string classB, string classC)
        {
            // Validating the data in the input textboxes
            if (Decimal.TryParse(classA, out decimal a) &&
                Decimal.TryParse(classB, out decimal b) && 
                Decimal.TryParse(classC, out decimal c))
            {
                try
                {
                    // Total revenue for each class
                    decimal totalA = a * 15m;
                    decimal totalB = b * 12m;
                    decimal totalC = c * 9m;

                    // Setting the Revenue Textboxes to the results
                    RevenueGenerated_ClassA_Textbox.Text = totalA.ToString("C");
                    RevenueGenerated_ClassB_Textbox.Text = totalB.ToString("C");
                    RevenueGenerated_ClassC_Textbox.Text = totalC.ToString("C");
                    RevenueGenerated_Total_Textbox.Text = (totalA + totalB + totalC).ToString("C");
                }
                catch(OverflowException)
                {
                    MessageBox.Show("One of the results was too big of a number.", "Overflow Exception");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid inputs for the tickets sold.", "Invalid Inputs");
            }
        }
    }
}
