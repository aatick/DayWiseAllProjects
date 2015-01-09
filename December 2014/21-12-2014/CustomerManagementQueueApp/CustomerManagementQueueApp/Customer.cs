using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagementQueueApp
{
    class Customer
    {
        private int id;
        private string name;
        private string complain;
        private string status;

        private const string connectionString = @"data source=(localdb)\v11.0; initial catalog=CustomerDB; integrated security=true;";
        private SqlConnection sqlConnection = new SqlConnection(connectionString);

        public Customer()
        {
        }

        public Customer(int customerId, string customerName, string customerComplain, string customerStatus)
        {
            id = customerId;
            name = customerName;
            complain = customerComplain;
            status = customerStatus;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Complain
        {
            get { return complain; }
            set { complain = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public void AddNewCustomer(string name, string complain, string status)
        {
            string insertQuery = "insert into t_Customer_Complain values('" + name + "','" + complain +"','" + status + "')";
            sqlConnection.Open();
            SqlCommand insertSqlCommand = new SqlCommand(insertQuery, sqlConnection);
            insertSqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<Customer> GetAllCustomersByStatus(string searchingStatus)
        {
            return GetAllCustomersByStatus(searchingStatus, string.Empty);
        }
        public List<Customer> GetAllCustomersByStatus(string searchingStatus1, string searchingStatus2)
        {
            List<Customer> customerList=new List<Customer>();
            string selectquery =
               @"select * from t_Customer_Complain where customer_status='" + searchingStatus1 + "' or customer_status='" + searchingStatus2 + "'";
            sqlConnection.Open();
            SqlCommand selectSqlCommand = new SqlCommand(selectquery, sqlConnection);
            SqlDataReader sqlDataReader = selectSqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                customerList.Add(new Customer(Convert.ToInt32(sqlDataReader["Id"]),
                    sqlDataReader["customer_name"].ToString(), sqlDataReader["customer_complain"].ToString(),
                    sqlDataReader["customer_status"].ToString()));
            }
            sqlConnection.Close();
            return customerList;
        }
        public void ChangeCustomerStatus(int customerId, string newStatus)
        {
            string updateQuery = @"update t_Customer_Complain set customer_status='" + newStatus + "' where Id=" + customerId;
            sqlConnection.Open();
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public bool FindCustomerByStatus(string customerStatus)
        {
            return FindCustomerByStatus(customerStatus, string.Empty);
        }

        public bool FindCustomerByStatus(string customerStatus1,string customerStatus2)
        {
            if (GetMinimumIdByStatus(customerStatus1, customerStatus2) == 0)
                return false;
            return true;
        }
        public int GetMinimumIdByStatus(string customerStatus)
        {
            return GetMinimumIdByStatus(customerStatus, string.Empty);
        }

        public int GetMinimumIdByStatus(string customerStatus1, string customerStatus2)
        {
            int cusId = 0;
            string selectQuery =
                @"select MIN(Id) from t_Customer_Complain where customer_status='" + customerStatus1 +
                "' or customer_status='" + customerStatus2 + "'";
            sqlConnection.Open();
            SqlCommand selectSqlCommand = new SqlCommand(selectQuery, sqlConnection);
            SqlDataReader sqlDataReader = selectSqlCommand.ExecuteReader();
            sqlDataReader.Read();
            if (sqlDataReader[0] == DBNull.Value)
            {
                sqlConnection.Close();
                return cusId;
            }
            cusId = Convert.ToInt32(sqlDataReader[0]);
            sqlConnection.Close();
            return cusId;
        }

        public Customer GetCustomerById(int customerId)
        {
            string query = @"select * from t_Customer_Complain where Id=" + customerId;
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            Customer newCustomer = new Customer(Convert.ToInt32(dataReader["Id"]), dataReader["customer_name"].ToString(), dataReader["customer_complain"].ToString(), dataReader["customer_status"].ToString());
            sqlConnection.Close();
            return newCustomer;
        }
    }
}
