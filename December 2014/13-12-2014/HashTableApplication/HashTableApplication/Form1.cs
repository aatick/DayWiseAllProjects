using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable mytable=new Hashtable();
        private void Form1_Load(object sender, EventArgs e)
        {
            findDetailsTextBox.BackColor = Color.White;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ISBNTextBox.Text == string.Empty)
            {
                ISBNTextBox.BackColor = Color.Yellow;
                MessageBox.Show("Please Enter ISBN of a Book.");
            }
            else if(detailsTextBox.Text==string.Empty)
            {
                detailsTextBox.BackColor = Color.Yellow;
                MessageBox.Show("Please Enter Book details.");
            }
            else
            {
                if(!mytable.ContainsKey(ISBNTextBox.Text))
                {
                    mytable.Add(ISBNTextBox.Text, detailsTextBox.Text);
                    MessageBox.Show("Entry is succesfully added.");
                    ISBNTextBox.Clear();
                    detailsTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("ISBN can not be duplicate. Already have details for ISBN " + ISBNTextBox.Text);
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (findISBNTextBox.Text == string.Empty)
            {
                findISBNTextBox.BackColor = Color.Yellow;
                MessageBox.Show("Please Enter ISBN to find details.");
            }
            else
            {
                if(mytable.ContainsKey(findISBNTextBox.Text))
                {
                    findDetailsTextBox.Text = mytable[findISBNTextBox.Text].ToString();

                }
                else
                {
                    MessageBox.Show("Wrong ISBN. There is no details for this ISBN. Please Enter right ISBN.");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            findISBNTextBox.Clear();
            findDetailsTextBox.Clear();
        }

        private void ISBNTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ISBNTextBox.BackColor = Color.White;
        }

        private void detailsTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            detailsTextBox.BackColor = Color.White;
        }

        private void findISBNTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            findISBNTextBox.BackColor = Color.White;
        }
    }
}
