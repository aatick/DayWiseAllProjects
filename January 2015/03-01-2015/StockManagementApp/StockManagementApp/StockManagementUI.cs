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
    public partial class StockManagementUI : Form
    {
        public StockManagementUI()
        {
            InitializeComponent();
        }

        private Stock aStock=new Stock();
        private void stockInButton_Click(object sender, EventArgs e)
        {
            new StockInUI(aStock).Show();
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            new StockOutUI(aStock).Show();
        }

        private void viewCurrentStockButton_Click(object sender, EventArgs e)
        {
            new ViewCurrentStockUI(aStock).Show();
        }
    }
}
