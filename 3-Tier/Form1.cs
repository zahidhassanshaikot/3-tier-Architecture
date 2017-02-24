using Cognizant.Dotnet.Ems.EntityLayer;
using Cognizant.Dotnet.EMS.BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;




namespace _3_Tier
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        BusinessAddEmployee Businessobj = new BusinessAddEmployee();
        EntityAddEmployee Entityobj = new EntityAddEmployee();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            int result = 0;
            Entityobj.EmpID = Convert.ToInt16(txtEid.Text);
            Entityobj.EmpName = txtEname.Text;
            Entityobj.DepartmentName = cmbDept.Text;
            Entityobj.Location = Cmbloc.Text;
            Entityobj.ContactNo = Convert.ToDouble(txtContactno.Text);
            result = Businessobj.BusinessAddEmpDetails(Entityobj);

            if (result == 1)
            {
                MessageBox.Show("You have Registered successfully");
            }
            else
            {
                MessageBox.Show("You have Not Registered successfully"); ;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // FillDepartment();

            FillData();


        }

        /*private void FillDepartment()
        {
            cmbDept.DisplayMember = Businessobj.BusinessFillDepartment().Columns[0].ToString();
            //cmbDept.ValueMember = Businessobj.BusinessFillDepartment().Columns[0].ToString();
            dt = Businessobj.BusinessFillDepartment();
            cmbDept.DataSource = dt;
           

        }*/



        private void FillData()
        {
            cmbDept.DisplayMember = Businessobj.BusinessFillDepartment().Columns[0].ToString();
            //cmbDept.ValueMember = Businessobj.BusinessFillDepartment().Columns[0].ToString();
            dt = Businessobj.BusinessFillDepartment();
            cmbDept.DataSource = dt;


            Cmbloc.DisplayMember = Businessobj.BusinessFillLocation().Columns[0].ToString();
            //cmbDept.ValueMember = Businessobj.BusinessFillDepartment().Columns[0].ToString();
            dt1 = Businessobj.BusinessFillLocation();
            Cmbloc.DataSource = dt1;

        }

    }
}