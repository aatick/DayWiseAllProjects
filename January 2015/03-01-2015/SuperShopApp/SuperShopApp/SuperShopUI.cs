using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        private Shop aShop;
        public SuperShopUI()
        {
            InitializeComponent();
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop=new Shop(nameTextBox.Text,addressTextBox.Text);
            MessageBox.Show(@"Shop Created");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            try
            {
                Product aProduct = new Product(idTextBox.Text, int.Parse(quantityTextBox.Text));
                aShop.AddItem(aProduct);
                message = @"Items are successfully added.";
            }
            catch (FormatException)
            {
                message = "Invalid Item to add!!";
            }
            MessageBox.Show(message);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            try
            {
                message = "Shop Name: " + aShop.Name + "\tAddress: " + aShop.Addresss +
                          "\nProduct Info:\nProduct Id\t\tQuantity\n";
                foreach (Product aProduct in aShop.GetAllProducts())
                    message += aProduct.Id + "\t\t" + aProduct.Quantity + "\n";
            }
            catch (NullReferenceException)
            {
                message = "Create A shop first.";
            }
            MessageBox.Show(message);
        }
    }
}
