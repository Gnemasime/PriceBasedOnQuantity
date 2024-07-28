using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceBasedOnQuantity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                try
                {
                    // Get the quantity and unit price from the textboxes
                    int quantity = int.Parse(textBox1.Text);
                    decimal unitPrice = decimal.Parse(textBox2.Text);

                    // Calculate the total price
                    decimal totalPrice = quantity * unitPrice;

                    // Display the total price
                    label3.Text = "Total Price: R" + totalPrice.ToString("0.00");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for quantity and unit price.");
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
