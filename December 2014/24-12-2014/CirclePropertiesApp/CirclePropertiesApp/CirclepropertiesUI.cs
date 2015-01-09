using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirclePropertiesApp
{
    public partial class CirclepropertiesUI : Form
    {
        private Circle aCircle=new Circle();

        public CirclepropertiesUI()
        {
            InitializeComponent();
        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
            if (double.Parse(radiusTextBox.Text)>0)
            resultTextBox.Text = aCircle.GetDiameter(double.Parse(radiusTextBox.Text)).ToString();
               
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            if (double.Parse(radiusTextBox.Text) > 0)
            resultTextBox.Text = aCircle.GetArea(double.Parse(radiusTextBox.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.Parse(radiusTextBox.Text) > 0)
            resultTextBox.Text = aCircle.GetPerimeter(double.Parse(radiusTextBox.Text)).ToString();
        }
    }
}
