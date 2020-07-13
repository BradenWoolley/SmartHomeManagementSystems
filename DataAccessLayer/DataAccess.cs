using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess
    {
        private static string connectionString = @" Data Source = REACTOR-5\SQLEXPRESS;Initial Catalog = SMSManagementSystem; Integrated Security = True";
        private static DataAccess singleton;
        private static SqlConnection connection;

        public SqlConnection SqlConnectionFactory
        {
            get { return connection; }
        }

        public DataAccess() { }
        public static DataAccess Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = new DataAccess();

                connection = new SqlConnection(connectionString);
                return singleton;
            }
        }

        #region ReadMethods
        public DataSet ReadProc(string procedure)
       {
            SqlConnection conn = new SqlConnection(connectionString);
            DataSet rawData = new DataSet();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.FillSchema(rawData, SchemaType.Source);//sets structure
                adapter.Fill(rawData);//gets actual data from query result              
            }
            catch (SqlException se)
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    
                }
            }
            return rawData;
       }

        public DataSet ReadProc(string procedure, int customerID)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataSet rawData = new DataSet();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.FillSchema(rawData, SchemaType.Source);//sets structure
                adapter.Fill(rawData);//gets actual data from query result              
            }
            catch (SqlException se)
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rawData;
        }

        //BAD method
        public DataSet ReadComponent(string procedure, int productID, int componentType)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataSet rawData = new DataSet();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductID", productID);
                command.Parameters.AddWithValue("@ComponentType", componentType);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(rawData);//gets actual data from query result

            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();

                }
            }
            return rawData;
        }

        //Default Read All 
        public DataSet ReadData(string tableName)
        {
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string qry = string.Format("SELECT * FROM {0}", tableName);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }//Default Data Reader

        public DataSet ReadData(string procedure, int customerID, int componentType)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataSet rawData = new DataSet();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@ComponentType", componentType);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(rawData);//gets actual data from query result
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rawData;
        }

        public DataSet ReadTechnicianJobs(string procedure, int technicianID)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataSet rawData = new DataSet();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmpID", technicianID);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(rawData);//gets actual data from query result
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return rawData;
        }

        #endregion

        #region InsertMethods

        public void Insert(string procedure, string name, int componentType, double cost, int productGroup)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Type", componentType);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@ProductID", productGroup);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void NewCustomer(string fName, string sName, string email, string address, int telephone, string banking, double amountDue)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("InsertNewCustomer", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", fName);
                command.Parameters.AddWithValue("@Surname", sName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Telephone", telephone);
                command.Parameters.AddWithValue("@Banking", banking);
                command.Parameters.AddWithValue("@Amount", amountDue);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }//add new customer with full details

        public void AddOrder(string proc, int customerID, int productID, int componentID, string serial)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(proc, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Serial", serial);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@ComponentID", componentID);
                command.Parameters.AddWithValue("@ProductID", productID);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void NewCustomerOrder(int customerID, int productID, List<int> componentIDs)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                foreach (int componentID in componentIDs)
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("InsertNewCustomerOrder", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@ComponentID", componentID);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }   //adds new order 

        public void ScheduleSupport(int empID, string description, int customerID, int jobStatus, double cost, DateTime date)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("NewSupport", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmpID",empID);
                command.Parameters.AddWithValue("@Description",description);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Status", jobStatus);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Cost", cost);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }//schedule new maintainence

        public void LogCall(int custID, string[] callLogs, string proc)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(proc, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", custID);
                command.Parameters.AddWithValue("@CallInitiated", callLogs[0]);
                command.Parameters.AddWithValue("@CallEnded", callLogs[1]);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        #endregion

        #region UpdateMethods

        //UpdateCompoonents
        public void Update(string procedure, int id, string name, int componentType, double cost, int productGroup)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Type", componentType);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@ProductID", productGroup);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void Update(int id, string name, string surname, string email,
            string address, string phoneNumber, string bankingDetails)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string procedure = "UpdateCustomer";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Phone", phoneNumber);
                command.Parameters.AddWithValue("@Banking", bankingDetails);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void UpdateSupport(int jobID, int empID, string description, int jobStatus, double cost, DateTime date)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateSupport", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JobID", jobID);
                command.Parameters.AddWithValue("@EmpID", empID);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Status", jobStatus);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Cost", cost);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        #endregion

        #region DeleteMethods
        //TODO - Override or use switch statement to reuse for composite tables   
        public DataSet DeleteData(string tableName, string ID)
        {
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("DELETE * FROM {0} WHERE ID= {1}", tableName, ID);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }//Default Delete

        public void Delete(string procedure, int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                //TODO exception back to presentation layer

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        #endregion
    }
}
