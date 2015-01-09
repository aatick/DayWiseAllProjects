using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementApp
{
    public partial class StockInUI : Form
    {
        private Stock aStock;
        public StockInUI(Stock itemStock)
        {
            InitializeComponent();
            aStock = itemStock;
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (itemIdTextBox.Text != string.Empty && itemQuantityTextBox.Text != string.Empty)
            {
                try
                {
                    StockItem aStockItem = new StockItem(itemIdTextBox.Text, int.Parse(itemQuantityTextBox.Text));
                    aStock.StockIn(aStockItem);
                    message = "Item Added.";
                }
                catch (FormatException)
                {
                    message = "Invalid Quantity!!";
                }
            }
            else
                message = "Please Fill up all Fields";
            MessageBox.Show(message);
        }
    }
}
