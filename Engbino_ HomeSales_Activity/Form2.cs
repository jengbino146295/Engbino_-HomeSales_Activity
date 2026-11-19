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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void SummaryForm(double dTotal, double eTotal, double fTotal)
        {
      

            double grandTotal = dTotal + eTotal + fTotal;

            lblSummary.Text = "=== SALES SUMMARY REPORT ===\n\n" +
                              $"Danielle (D): {dTotal:C2}\n" +
                              $"Edward (E):   {eTotal:C2}\n" +
                              $"Fatima (F):   {fTotal:C2}\n" +
                              "----------------------------\n" +
                              $"Grand Total:  {grandTotal:C2}";
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
