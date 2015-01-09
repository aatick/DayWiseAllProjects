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
    public partial class StockOutUI : Form
    {
        private Stock aStock;
        public StockOutUI(Stock itemStock)
        {
            InitializeComponent();
            aStock = itemStock;
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = string.Empty;
                if (itemIdTextBox.Text != string.Empty && itemQuantityTextBox.Text != string.Empty)
                {
                    try
                    {
                        StockItem aStockItem = new StockItem(itemIdTextBox.Text, int.Parse(itemQuantityTextBox.Text));
                        aStock.StockOut(aStockItem);
                        message = "Item Updated.";
                    }
                    catch (FormatException)
                    {
                        message = "Invalid Quantity!!";
                    }
                    catch (QuantityOutOfRangeException exception)
                    {
                        message = exception.Message;
                    }
                    catch (ItemNotFoundException exception)
                    {
                        message = exception.Message;
                    }
                }
                else
                    message = "Invalid Quantity!!";
                MessageBox.Show(message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Add items first and try again.");
            }
        }
    }
}
