using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess
    {
        //TODO ~ Research whether it's best for all DataAccess() Methods to be static or non-static

        //Data Source=REACTOR-5\SQLEXPRESS;Initial Catalog=SMSManagementSystem;Integrated Security=True

        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

        public DataAccess()
        {
            connection.DataSource = @"REACTOR-5\SQLEXPRESS";
            connection.InitialCatalog = "SMSManagementSystem";
            connection.IntegratedSecurity = true;
        }

        /// <summary>
        /// Reading Data
        /// </summary>
        //Universal Methods
       public DataSet ReadProc(string procedure)
       {
            SqlConnection conn = new SqlConnection(connection.ToString());
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

        //BAD method
        public DataSet ReadComponent(string procedure, int productID, int componentType)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
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
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM {0}", tableName);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }//Default Data Reader

        public DataSet ReadData(string tableName, string componentType)
        {
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM {0} WHERE ComponentType = {1}", tableName, componentType);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        } //Reads all from Components

        public DataSet ReadProductData(string tableName, string ID)
        {
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM {0} WHERE ID = {1}", tableName, ID);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }

        //Currently unused, but being performed within ProductCatalogue.cs
        public DataSet ReadAllProducts()
        {
            //TODO switch to stored procedure
            string tableName = "AllProducts;";
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT tblProductCatalogue.ProductID, tblProductCatalogue.ProductSuite, tblComponent.ComponentID tblComponent.Name, tblComponent.ComponentType "
                    + "FROM((tblProductCatalogue INNER JOIN tblProductComponents ON tblProductCatalogue.ProductID = tblProductComponents.ProductID)"
                    + "INNER JOIN tblComponent ON tblProductComponents.ComponentID = tblComponent.ComponentID);");

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);

                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }

        public DataSet ReadAllCustomers()
        {
            //TODO switch to stored procedure and fix db naming changes
            string tableName = "tblCustomer";
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT tblCustomer.ID, tblCustomer.Name, tblCustomer.Surname, " +
                    "tblCustomerDetails.Email, tblCustomerDetails.Email, tblCustomerDetails.Address, tblCustomerDetails.Telephone, tblCustomerPayment.BankingDetails, tblCustomerPayment.AmountDue," +
                    " tblProductCatalogue.ID, tblProductCatalogue.ProductSuite, tblComponent.ID tblComponent.Name, tblComponent.ComponentType "
                    + "FROM((((tblCustomer INNER JOIN tblCustomerDetails ON tblCustomer.ID = tblCustomerDetails.CustomerID)"
                    + "INNER JOIN tblCustomerProduct ON tblCustomer.ID = tblCustomerProduct.CustomerID)"
                    + "INNER JOIN tblProductComponents ON tblProductCatalogue.ID = tblProductComponents.ProductID)"
                    + "INNER JOIN tblCustomerProduct ON tblProductCatalogue.ID = tblCustomerProduct.ProductID)"
                    + "INNER JOIN tblComponent ON tblProductComponents.ComponentID = tblComponent.ID) "
                    + "ORDER BY tblCustomer.ID;");


                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }

        public DataSet ReadAllTechSupport()
        {
            //TODO change SQL
            string tableName = "tblTechSupport";
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT tblProductCatalogue.ProductID, tblProductCatalogue.ProductSuite, tblComponent.ComponentID tblComponent.Name, tblComponent.ComponentType "
                    + "FROM((tblProductCatalogueINNER JOIN tblProductComponents ON tblProductCatalogue.ProductID = tblProductComponents.ProductID)"
                    + "INNER JOIN tblComponent ON tblProductComponents.ComponentID = tblComponent.ComponentID);");

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }

        /// <summary>
        /// Inserts
        /// </summary>

        public void NewProduct(string productSuite)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("InsertNewProductSuite", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductSuite", productSuite);
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
        }//Inserts a new product type

        public void NewComponent(string componentName, int componentType)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("InsertNewComponent", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", componentName);
                command.Parameters.AddWithValue("@Type", componentType);
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
        }//Inserts a new component with predetermined type

        public void NewComponent(string componentName, int componentType, double cost)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("InsertNewComponentWithCost", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", componentName);
                command.Parameters.AddWithValue("@Type", componentType);
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
        }//inserts a new component with a custom price

        /*public DataSet SearchProduct(string name)
        {
            string tableName = "tblProductCatalogue";
            DataSet rawData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT tblProductCatalogue.ProductID, tblProductCatalogue.ProductSuite, tblComponent.ComponentID tblComponent.Name, tblComponent.ComponentType "
                    + "FROM((tblProductCatalogueINNER JOIN tblProductComponents ON tblProductCatalogue.ProductID = tblProductComponents.ProductID)"
                    + "INNER JOIN tblComponent ON tblProductComponents.ComponentID = tblComponent.ComponentID);");

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);//sets structure
                adapter.Fill(rawData, tableName);//gets actual data from query result
            }
            return rawData;
        }*/

        public void NewCustomer(string fName, string sName)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("InsertNewCustomer", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", fName);
                command.Parameters.AddWithValue("@Surname", sName);
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
        }//add new customer basic details

        public void NewCustomer(string fName, string sName, string email, string address, string telephone)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("InsertNewCustomerWithDetails", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", fName);
                command.Parameters.AddWithValue("@Surname", sName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Telephone", telephone);
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
        }//add new customer and contact

        public void NewCustomer(string fName, string sName, string email, string address, string telephone, string banking, double amountDue)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("InsertNewCustomerWithDetailsAndBank", conn);
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

        public void ScheduleSupport(int customerProductID, int customerID, DateTime date, double cost)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ScheduleSupport", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@customerProductID", customerProductID);
                command.Parameters.AddWithValue("@customerID", customerID);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@cost", cost);
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

        /// <summary>
        /// Updates
        /// </summary>

        //TODO - edit method
        public void EditCustomer(int id, string fName, string sName)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateCustomerName", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", id);
                command.Parameters.AddWithValue("@Name", fName);
                command.Parameters.AddWithValue("@Surname", sName);
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
        }//Updates customer name and surname only ~ basic information

        public void EditCustomer(int id, string email)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateCustomerName", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", id);
                command.Parameters.AddWithValue("@Email", email);
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
        }//Updates email of customer only

        public void EditCustomer(string address, int id)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateCustomerName", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", id);
                command.Parameters.AddWithValue("@Email", address);
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
        }//updates customer address only

        public void EditCustomer(int id, string email, string address, string tableName)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            tableName = "tblCustomerDetails";
            try
            {
                string qry = string.Format("UPDATE {0} SET Email = {1}, Address = {2} WHERE CustomerID = {3}", tableName, email, address, id);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }//update both email and address of customer

        public void EditProduct(int id, string name)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                string qry = string.Format("UPDATE tblProductSuite SET ProductSuite = {0}, WHERE ID = {1}", name, id);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }//update product name

        public void EditComponent(int id, string name)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                string qry = string.Format("UPDATE tblComponent SET Name = {0}, WHERE ID = {1}", name, id);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }//update component name

        public void EditComponent(int id, int type)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                string qry = string.Format("UPDATE tblComponent SET ComponentType = {0}, WHERE ID = {1}", type, id);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }//update component type

        public void EditComponent(int id, double cost)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                string qry = string.Format("UPDATE tblComponent SET Cost = {0} WHERE ID = {1}", cost, id);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }//update component cost

        public void EditComponent(int id, string name, int type)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                string qry = string.Format("UPDATE tblComponent SET Name = {0}, ComponentType = {1} WHERE ID = {2}, ", name, type, id);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }//update component name and type

        public void EditComponent(int id, string name, int type, double cost)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                string qry = string.Format("UPDATE tblComponent SET Name = {0}, ComponentType = {1}, Cost = {2} WHERE ID = {3}, ", name, type, cost, id);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }//update all component attributes

        /// <summary>
        /// DELETE DATA No deleting entire tables will be implemented
        /// </summary>
        /// 

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
    }
}
