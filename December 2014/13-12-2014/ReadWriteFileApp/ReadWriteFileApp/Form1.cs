using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadWriteFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        string path = "D:\\info.txt";
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (customerInfoTextBox.Text != string.Empty)
            {
                if (!File.Exists(path))
                    File.Create(path).Dispose();
                StreamWriter textFile = File.AppendText(path);
                textFile.WriteLine(customerInfoTextBox.Text);
                textFile.Close();
            }
            else
            {
                MessageBox.Show("Enter name & phone no.");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if(File.Exists(path))
            { 
            StreamReader textReader=new StreamReader(path);
            string str=textReader.ReadLine();
            try
            {
                while (str != string.Empty)
                {
                    viewBoxListBox.Items.Add(str);
                    str = textReader.ReadLine();
                }
            }
            catch
            {
                
            }
        }
    }
}
