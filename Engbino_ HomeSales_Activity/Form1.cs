using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engbino__HomeSales_Activity
{
    public partial class Form1 : Form
    {
        private double danielleTotal = 0.0;
        private double edwardTotal = 0.0;
        private double fatimaTotal = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();

        }
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string initial = textBox2.Text;

            if (string.IsNullOrWhiteSpace(initial))
            {
                lblDisplay.Text = "Please enter a salesperson initial.";
                return;
            }

            if (double.TryParse(textBox3.Text, out double amount) && amount >= 0)
            {
                getSalesPerson_Amount(initial, amount);
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
            }
            else
            {
                lblDisplay.Text = "Please enter a valid numeric sale amount.";
            }
        }
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Form2 reportForm = new Form2();
            reportForm.SummaryForm(danielleTotal, edwardTotal, fatimaTotal);
            reportForm.ShowDialog();
        }


        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string formattedInitial = salesInitial.Trim().ToUpper();
            string salesPersonName = "";
            double updatedTotal = 0.0;

            switch (formattedInitial)
            {
                case "D":
                    danielleTotal += salesAmount;
                    salesPersonName = "Danielle";
                    updatedTotal = danielleTotal;
                    break;
                case "E":
                    edwardTotal += salesAmount;
                    salesPersonName = "Edward";
                    updatedTotal = edwardTotal;
                    break;
                case "F":
                    fatimaTotal += salesAmount;
                    salesPersonName = "Fatima";
                    updatedTotal = fatimaTotal;
                    break;
                default:
                    lblDisplay.Text = "Invalid Initial. Please enter D, E, or F.";
                    return;
            }

            lblDisplay.Text = $"Transaction Confirmed!\n" +
                              $"Salesperson: {salesPersonName}\n" +
                              $"Sale Recorded: {salesAmount:C2}\n" +
                              $"Running Total: {updatedTotal:C2}";
        }
        private void clearEntry()
        {
            textBox2.Clear();
            textBox3.Clear();
            lblDisplay.Text = string.Empty;
            textBox2.Focus();
        }

    }
}
