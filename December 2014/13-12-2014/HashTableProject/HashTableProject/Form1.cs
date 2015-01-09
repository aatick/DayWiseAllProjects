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

namespace HashTableProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var mytable = new Hashtable();
            for (int i = 0; i <= 25; i++)
            {
                mytable.Add(i+65,Convert.ToChar(i+65));
            }
            foreach (var alphabet in mytable.Values)
            {
                firstView.Items.Add(alphabet);
            }
            foreach (var ascii in mytable.Keys)
            {
                secondView.Items.Add(ascii);
            }
            
        }
    }
}
