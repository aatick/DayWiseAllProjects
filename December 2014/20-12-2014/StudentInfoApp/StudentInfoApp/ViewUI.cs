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
    public partial class ViewUI : Form
    {
        public ViewUI()
        {
            InitializeComponent();
        }
        static string myConnectionString = @"data source=(localdb)\v11.0; initial catalog=UniversityDB; integrated security=true;";
        SqlConnection mySqlConnection = new SqlConnection(myConnectionString);
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultListView.Items.Clear();
            string query = "select * from Students";
            SqlCommand sqlCommand;
            if (idTextBox.Text != string.Empty&&idTextBox.Text!=0.ToString())
            {
                query = "select * from Students where id=" + int.Parse(idTextBox.Text);
            }
            mySqlConnection.Open();
            sqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            
            ListViewItem listViewItem;
            while (sqlDataReader.Read())
            {
                listViewItem = new ListViewItem(sqlDataReader["id"].ToString());
                listViewItem.SubItems.Add(sqlDataReader["name"].ToString());
                listViewItem.SubItems.Add(sqlDataReader["email"].ToString());
                listViewItem.SubItems.Add(sqlDataReader["addresses"].ToString());
                listViewItem.SubItems.Add(sqlDataReader["phone"].ToString());
                resultListView.Items.Add(listViewItem);
            }

            mySqlConnection.Close();
        }

        private void ViewUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ViewUI_Load(object sender, EventArgs e)
        {

        }

        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void resultListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new EditStudentInfo(resultListView.SelectedIndices[0] + 1).Show();
        }
    }
}
