using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Cognizant.Dotnet.Ems.DataLayer
{
    public class DataAddEmployee
    {

     static string conStr = ConfigurationManager.AppSettings["Connection"].ToString();

        SqlConnection objConnnection = new SqlConnection(conStr);
        SqlCommand objCommand = null;
        SqlDataAdapter objAdapter = null;
        DataSet objDataSet = new DataSet();

        public int DataAddEmployeeDetails(SqlParameter[] objParams)
        {
            int result = 0;
            objCommand = new SqlCommand("USPEmpDtls", objConnnection);
            objCommand.CommandType = CommandType.StoredProcedure;


            objCommand.Parameters.AddRange(objParams);
            objConnnection.Open();

            result = objCommand.ExecuteNonQuery();
            objConnnection.Close();
            return result;


        }
        public DataSet DataFillDeptDetails()
        {
            objCommand = new SqlCommand("USPDept", objConnnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                objConnnection.Open();
                objAdapter = new SqlDataAdapter(objCommand);
                objAdapter.Fill(objDataSet, "Department");
                objConnnection.Close();
            }
            catch (SqlException ex)
            {
                string message = ex.Message.ToString();
            }
            return objDataSet;

        }

        public DataSet DataFillLocationDetails()
        {
            objCommand = new SqlCommand("USPLocation", objConnnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            objConnnection.Open();
            objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet, "Location");
            objConnnection.Close();
            return objDataSet;

        }


    }
}
