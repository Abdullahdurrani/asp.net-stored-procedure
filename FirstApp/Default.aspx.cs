using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class Default : Page
    {
        readonly DbCon dbCon = new DbCon();
        //EmployeeProps employeeProps = new EmployeeProps();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.spEmployees_Insert");

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(TBId.Text);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = TBName.Text;
                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = TBEmail.Text;

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    LInfo.Text = "Data Inserted!";
                }
                else
                {
                    LInfo.Text = "Failed to Insert data!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.spEmployees_Update");

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(TBId.Text);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = TBName.Text;
                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = TBEmail.Text;

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    LInfo.Text = "Data Updated!";
                }
                else
                {
                    LInfo.Text = "Failed to Update data!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.spEmployees_Delete");

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(TBId.Text);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    LInfo.Text = "Data Deleted!";
                }
                else
                {
                    LInfo.Text = "Failed to Delete data!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = dbCon.UDI(storedProcedure: "dbo.spEmployees_Search");

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(TBId.Text);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        TBId.Text = (sqlDataReader["Id"].ToString());
                        TBName.Text = (sqlDataReader["Name"].ToString());
                        TBEmail.Text = (sqlDataReader["Email"].ToString());
                        LInfo.Text = "Data Found!";
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbCon.ConnectionClose();
            }

        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            TBEmail.Text = "";
            TBName.Text = "";
            TBId.Text = "";
        }
    }
}