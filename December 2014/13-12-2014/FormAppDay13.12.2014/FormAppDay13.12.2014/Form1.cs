using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppDay13._12._2014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var myQueue=new Queue<int>();
            for(int i=10; i<=19; i++)
                myQueue.Enqueue(i);
            
            foreach (int num in myQueue)
            {
                viewListBox.Items.Add(num);
            }
            for (int i = 1; i <= 3; i++)
                myQueue.Dequeue();

            foreach (int num in myQueue)
            {
                listBox1.Items.Add(num);
            }
            
        }

    }
}
