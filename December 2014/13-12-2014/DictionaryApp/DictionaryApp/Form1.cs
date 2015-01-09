using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class StoresInfoUi : Form
    {
        public StoresInfoUi()
        {
            InitializeComponent();
        }

        Dictionary<int,string> myDictionary=new Dictionary<int, string>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == string.Empty)
            {
                IDTextBox.BackColor = Color.Yellow;
                MessageBox.Show(@"Please Enter an ID to save.");
            }
            else if (detailsTextBox.Text == string.Empty)
            {
                detailsTextBox.BackColor = Color.Yellow;
                MessageBox.Show(@"Please Enter Details for ID " + IDTextBox.Text);
            }
            else
            {
                int i=0;
                try
                {
                    i = int.Parse(IDTextBox.Text);
                    if(!myDictionary.ContainsKey(i))
                    {
                        myDictionary.Add(i, detailsTextBox.Text);
                        MessageBox.Show(@"Entry is successfully saved.");
                        IDTextBox.Clear();
                        detailsTextBox.Clear();
                    }
                    else
                    {
                        IDTextBox.BackColor = Color.Yellow;
                        MessageBox.Show(@"ID can not be duplicate.");
                    }
                }
                catch
                {
                    IDTextBox.BackColor = Color.Yellow;
                    MessageBox.Show(@"Invalid ID. Please Enter valid ID.");
                }
                
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(searchIDTextBox.Text);
            }
            catch
            {
                searchIDTextBox.BackColor = Color.Yellow;
                MessageBox.Show(@"Invalid ID. Enter valid ID to search.");
            }
            if(myDictionary.ContainsKey(id))
            {
                MessageBox.Show("ID: "+id+"\nDetails: \n"+myDictionary[id]);
            }
            else
            {
                MessageBox.Show(@"Wrong ID. There is no Details for ID " + id);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (myDictionary.Count == 0)
            {
                showAllListBox.Items.Add("There is no data to Display.");
                MessageBox.Show(@"There is no data to Display.");
            }
            else
            {
                showAllListBox.Items.Clear();
                foreach (var aValue in myDictionary)
                    showAllListBox.Items.Add(aValue.Key + " : " + aValue.Value);
            }
        }

        private void IDTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            IDTextBox.BackColor = Color.White;
        }

        private void detailsTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            detailsTextBox.BackColor = Color.White;
        }

        private void searchIDTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchIDTextBox.BackColor = Color.White;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            showAllListBox.Items.Clear();
        }

        private void StoresInfoUi_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
