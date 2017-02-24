using Cognizant.Dotnet.Ems.DataLayer;
using Cognizant.Dotnet.Ems.EntityLayer;
using System.Data;
using System.Data.SqlClient;


namespace Cognizant.Dotnet.EMS.BusinessLayer
{
    public class BusinessAddEmployee
    {
        DataTable objDatatable = new DataTable();
        DataTable objDatatable1 = new DataTable();
        DataAddEmployee objDataAddEmp = new DataAddEmployee();
        public int BusinessAddEmpDetails(EntityAddEmployee objEntityAddEmployee)
        {
            int result = 0;
            //objDatatable.Clear();

            SqlParameter[] objDataParams = new SqlParameter[5];
            objDataParams[0] = new SqlParameter("@EmpId", SqlDbType.Int);
            objDataParams[0].Value = objEntityAddEmployee.EmpID;

            objDataParams[1] = new SqlParameter("@EmpName", SqlDbType.VarChar, 25);
            objDataParams[1].Value = objEntityAddEmployee.EmpName;


            objDataParams[2] = new SqlParameter("@DepartmentName", SqlDbType.VarChar, 25);
            objDataParams[2].Value = objEntityAddEmployee.DepartmentName;

            objDataParams[3] = new SqlParameter("@Location", SqlDbType.VarChar, 25);
            objDataParams[3].Value = objEntityAddEmployee.Location;

            objDataParams[4] = new SqlParameter("@ContactNo", SqlDbType.BigInt);
            objDataParams[4].Value = objEntityAddEmployee.ContactNo;


            result = objDataAddEmp.DataAddEmployeeDetails(objDataParams);

            return result;

        }


        public DataTable BusinessFillDepartment()
        {

            objDatatable.Clear();
            objDatatable = objDataAddEmp.DataFillDeptDetails().Tables["Department"];
            return objDatatable;


        }
        public DataTable BusinessFillLocation()
        {
            objDatatable1.Clear();
            objDatatable1 = objDataAddEmp.DataFillLocationDetails().Tables["Location"]; ;
            return objDatatable1;
        }

    }
}
