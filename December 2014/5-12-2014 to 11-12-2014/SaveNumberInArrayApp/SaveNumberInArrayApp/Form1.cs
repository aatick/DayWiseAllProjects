using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNumberInArrayApp
{
    public partial class SaveNumberApp : Form
    {
        public SaveNumberApp()
        {
            InitializeComponent();
        }

        List<string> str=new List<string>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty)
            {
                if (str.Count < 10)
                {
                    str.Add(nameTextBox.Text);
                    totalTextBox.Text = str.Count.ToString();
                    if (str.Count == 10)
                    {
                        foreach (string s in str)
                            viewBoxListBox.Items.Add(s);
                    }
                }
                else
                {
                    MessageBox.Show(@"Maximum names were saved. You can't save any more name.");
                }
            }
            else
            {
                nameTextBox.BackColor = Color.Yellow;
                MessageBox.Show(@"Enter any Name to Save.");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            viewBoxListBox.Items.Clear();
            if (str.Count != 0)
            {
                foreach (string s in str)
                    viewBoxListBox.Items.Add(s);
            }
            else
            {
                MessageBox.Show(@"There is no data to display.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            str.Clear();
            viewBoxListBox.Items.Clear();
            totalTextBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalTextBox.BackColor = Color.White;
        }

        private void nameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            nameTextBox.BackColor = Color.White;
        }
    }
}
