using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }
        static string myConnectionString = @"data source=(localdb)\v11.0; initial catalog=UniversityDB; integrated security=true;";
        SqlConnection mySqlConnection=new SqlConnection(myConnectionString);
        private void saveButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = "insert into Students values('" + nameTExtBox.Text + "','" + emailTextBox.Text + "','" +
                              addressTextBox.Text + "','" + phoneTextBox.Text + "')";
            mySqlConnection.Open();
            SqlCommand mySqlCommand=new SqlCommand(sqlQuery,mySqlConnection);
            int affectedRows = mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            if (affectedRows == 0)
            {
                MessageBox.Show("Can not save Data. There is Error.");
            }
            else
            {
                MessageBox.Show("Data are successfully saved to database.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuExampleUI().Show();
        }
    }
}
