using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPriceCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int  ticketNumber=0;
        public string customerName = string.Empty;
        public int unitPrice = 10;
        
        private void CalculatePriceButton_Click(object sender, EventArgs e)
        {
            
            
            if (customerNameTextBox.Text == string.Empty)
            {
                customerNameTextBox.BackColor = Color.Yellow;
                MessageBox.Show(@"Please Enter Customer Name.");
            }
            else if (noOfTicketTextBox.Text == string.Empty)
            {
                noOfTicketTextBox.BackColor = Color.Yellow;
                MessageBox.Show(@"Enter No. Of Tickets.");
            }
            else
            {
                try
                {

                    ticketNumber = Convert.ToInt32(noOfTicketTextBox.Text);
                    if (ticketNumber == 0)
                    {
                        MessageBox.Show("Please Enter at least 1 ticket.");
                    }
                    else
                    {
                        customerName = customerNameTextBox.Text;
                        MessageBox.Show("Customer Name = " + customerName + "\n" + "Please Pay BDT " +
                                        ticketNumber*unitPrice + " .");
                        noOfTicketTextBox.Text = customerNameTextBox.Text = string.Empty;
                        DetailsButton.Enabled = true;
                    }
                }
                catch
                {
                    noOfTicketTextBox.BackColor = Color.Yellow;
                    MessageBox.Show("Please Enter number in ticket no. textBox.");
                }
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {  
            MessageBox.Show("Customer Name = "+"\n" + customerName + "\nTotal Price = BDT " + ticketNumber * unitPrice + ".\nUnit Price = "+"BDT "+unitPrice+"."/*,"Purchasing Information :\n",MessageBoxButtons.OK,MessageBoxIcon.Information*/);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DetailsButton.Enabled = false;
        }

        private void customerNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            customerNameTextBox.BackColor = Color.White;
        }

        private void noOfTicketTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            noOfTicketTextBox.BackColor = Color.White;
        }
    }
}
