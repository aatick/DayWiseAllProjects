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
    public partial class EditStudentInfo : Form
    {
        static string myConnectionString = @"data source=(localdb)\v11.0; initial catalog=UniversityDB; integrated security=true;";
        SqlConnection mySqlConnection = new SqlConnection(myConnectionString);
        public EditStudentInfo(int id)
        {
            InitializeComponent();
            idTextBox.Text = id.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditStudentInfo_Load(object sender, EventArgs e)
        {
            string query = "select * from Students where id=" + int.Parse(idTextBox.Text);
            mySqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand(query,mySqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                nameTextBox.Text = sqlDataReader["name"].ToString();
                emailTextBox.Text = sqlDataReader["email"].ToString();
                addressTextBox.Text = sqlDataReader["addresses"].ToString();
                phoneTextBox.Text = sqlDataReader["phone"].ToString();
            }
            mySqlConnection.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "update Students set name='" + nameTextBox.Text + "',email='" + emailTextBox.Text +
                           "',addresses='" + addressTextBox.Text + "',phone='" + phoneTextBox.Text + "' where id=" +
                           int.Parse(idTextBox.Text);
            mySqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, mySqlConnection);
            int affectedRow = sqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            if (affectedRow == 1)
                MessageBox.Show("Successfully saved");
            else
            {
                MessageBox.Show("Error to Edit.");
            }
        }
    }
}
