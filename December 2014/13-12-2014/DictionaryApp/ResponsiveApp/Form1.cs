using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiveApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            

        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            listBox1.Width = new Form1().Width - 20;
            listBox1.Height = new Form1().Height - 40;
        }
    }
}
