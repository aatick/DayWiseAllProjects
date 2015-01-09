using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProfitCalculationApp
{
    public partial class CustomerProfitCalculationUI : Form
    {
        public CustomerProfitCalculationUI()
        {
            InitializeComponent();
        }

        private Customer aCustomer;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aCustomer=new Customer(idTextBox.Text,nameTextBox.Text,addressTextBox.Text);
            Account anAccount=new Account(double.Parse(capitalTextBox.Text),int.Parse(installmentPeriodTextBox.Text));
            aCustomer.CustomerAccount = anAccount;
            MessageBox.Show("Saved.");

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            profitTextBox.Text = aCustomer.CustomerAccount.GetProfit(double.Parse(rateTextBox.Text),
                int.Parse(nthInstallmentTextBox.Text)).ToString();
            profitPrincipalTextBox.Text = aCustomer.CustomerAccount.GetProfitPrincipal();
        }
    }
}
