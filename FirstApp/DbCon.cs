using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstApp
{
    public class DbCon
    {
        SqlConnection sqlConnection = null;

        public void ConnectionToDatabase()
        {
            string connection = "Data Source=DESKTOP-E4T9PG6;Initial Catalog=ITCON;Integrated Security=True";
            sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
        }

        public void ConnectionClose()
        {
            sqlConnection.Close();
        }

        public SqlCommand UDI(string storedProcedure)
        {
            try
            {
                ConnectionToDatabase();
                
                SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                return sqlCommand;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        //public DataTable Search(string storedProcedure, int id)
        //{
        //    string connection = "Data Source=DESKTOP-E4T9PG6;Initial Catalog=ITCON;Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(connection);
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;

        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //        DataTable dataTable = new DataTable();
        //        sqlDataAdapter.Fill(dataTable);

        //        return dataTable;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //}
    }
}
