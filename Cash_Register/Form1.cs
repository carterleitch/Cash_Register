using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        const double SHEETS_COST = 2.25;
        const double TEST_COSTS = 3.75;
        const double TAX_AMOUNT = 0.13;

        int tests, sheets;

        double price, taxAmount, totalWithTax;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sheets = Convert.ToInt32(gradeInput.Text);
            tests = Convert.ToInt32(amountInput.Text);

            price = SHEETS_COST * sheets + TEST_COSTS * tests; 
            taxAmount = TAX_AMOUNT * price;
            totalWithTax = taxAmount + price;

            costOutput.Text = price.ToString("C");
            taxOutput.Text = taxAmount.ToString("C");
            costWithTaxOutput.Text = totalWithTax.ToString("C");
        }
    }
}
