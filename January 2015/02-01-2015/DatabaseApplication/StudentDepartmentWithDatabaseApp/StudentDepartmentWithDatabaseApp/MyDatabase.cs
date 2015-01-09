using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentDepartmentWithDatabaseApp
{
    public class MyDatabase
    {
        private const string myConnectionString =
            @"data source=(localdb)\v11.0; initial catalog=UniversityDB; integrated security=true;";
        private SqlConnection mySqlConnection = new SqlConnection(myConnectionString);
        public void FillComboBox(string databaseTableName,ComboBox aComboBox)
        {
            aComboBox.Items.Clear();
            string query = "select * from " + databaseTableName;
            mySqlConnection.Open();
            SqlCommand aSqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {
                ComboBoxItem aComboBoxItem = new ComboBoxItem();
                aComboBoxItem.AddItem(int.Parse(aSqlDataReader["id"].ToString()),aSqlDataReader["name"].ToString());
                aComboBox.Items.Add(aComboBoxItem);
            }
            mySqlConnection.Close();
        }

        public void ExecuteQuery(string query)
        {
            mySqlConnection.Open();
            SqlCommand aSqlCommand = new SqlCommand(query, mySqlConnection);
            aSqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }
        public void FillListView(string query, ListView aListView)
        {
            aListView.Items.Clear();
            mySqlConnection.Open();
            SqlCommand aSqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            while (aSqlDataReader.Read())
            {
                ListViewItem aListViewItem = new ListViewItem(aSqlDataReader[0].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[1].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[2].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[3].ToString());
                aListViewItem.SubItems.Add(aSqlDataReader[4].ToString());
                aListView.Items.Add(aListViewItem);
            }
            mySqlConnection.Close();
        }
    }
}