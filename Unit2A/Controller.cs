using System;
using System.Data.SqlClient;


namespace Unit3A
{
    class Controller
    {
        string connectionString;
        SqlConnection cnn;             
       
        public Controller()
        {
            connectionString = "Server = REINOSOMSIRIG;" +
                "Trusted_Connection=true;" + 
                "Database=Northwind;" + 
                "User Instance=false;" + 
                "Connection timeout=30";
        }
        public Controller(string conn)
        {
            connectionString = conn;
        }
        public string getCustomerCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        public string getCompanyNames()
        {
            string names = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select companyname from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return names;
        }
        public string getEmployeeCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from employees;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }
        public string getEmployeeNames()
        {
           string names = "";
           SqlDataReader dataReader;

           cnn = new SqlConnection(connectionString);
           cnn.Open();
           string countQuery = "select FirstName + ' ' + LastName from employees;";
           SqlCommand cmd = new SqlCommand(countQuery, cnn);
           dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            return names;
        }
        public string getOrderCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }
        public string getShipNames()
        {
            string names = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select shipname from orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            return names;
        }
        
    }
}
