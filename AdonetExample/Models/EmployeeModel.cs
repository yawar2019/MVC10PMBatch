using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AdonetExample.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class EmployeeDetail
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=MVC10PMBatchDb;Integrated Security=true");

        public List<EmployeeModel> GetEmployees()
        {

            List<EmployeeModel> listemp = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("spr_EmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                listemp.Add(emp);
            }
            return listemp;
        }
        public int SaveEmployee(EmployeeModel obj)
        {

            SqlCommand cmd = new SqlCommand("spr_insertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }



        public EmployeeModel GetEmployeeById(int? id)
        {

            EmployeeModel   emp = new  EmployeeModel ();
            SqlCommand cmd = new SqlCommand("spr_employeebyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Eid", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                 
            }
            return emp;
        }
    }
}