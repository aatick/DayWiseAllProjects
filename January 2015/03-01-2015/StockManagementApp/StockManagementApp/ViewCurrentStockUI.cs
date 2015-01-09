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
    public partial class ViewCurrentStockUI : Form
    {
        private Stock aStock;
        public ViewCurrentStockUI(Stock itemStock)
        {
            InitializeComponent();
            aStock = itemStock;
        }

        private void ViewCurrentStockUI_Load(object sender, EventArgs e)
        {
            try
            {
                currentStockListView.Items.Clear();
                foreach (StockItem item in aStock.GetAllStockItems())
                {
                    ListViewItem aListViewItem = new ListViewItem(item.Id);
                    aListViewItem.SubItems.Add(item.Quantity.ToString());
                    currentStockListView.Items.Add(aListViewItem);
                }
                if (currentStockListView.Items.Count == 0)
                    MessageBox.Show("There is no Items in Stock.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Add items first and try again.");
            }
        }
    }
}
