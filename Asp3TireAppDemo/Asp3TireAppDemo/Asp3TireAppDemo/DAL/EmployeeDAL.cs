using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
//architecture
namespace Asp3TireAppDemo.DAL
{
    public class EmployeeDAL
    {
        SqlConnection sqlcon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);



        public string insertitem(BAL.Business_Objects obj)
        {
            try
            {
                string strtest;
                sqlcon.Open();

                SqlCommand Sqlcmd = new SqlCommand("Ins_tblEmployee_SP", sqlcon);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@UserName", obj.UserName);
                Sqlcmd.Parameters.AddWithValue("@Password", obj.Password);
                Sqlcmd.Parameters.AddWithValue("@Emailid", obj.Emailid);
                Sqlcmd.Parameters.AddWithValue("@Address", obj.Address);
                Sqlcmd.Parameters.AddWithValue("@Age", obj.Age);
                Sqlcmd.Parameters.AddWithValue("@Gender", obj.Gender);
                Sqlcmd.Parameters.AddWithValue("@MobileNo", obj.MobileNo);
                Sqlcmd.Parameters.AddWithValue("@Salary", obj.Salary);
                Sqlcmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                strtest = Sqlcmd.CommandText;
                foreach (SqlParameter p in Sqlcmd.Parameters)
                {
                    strtest = strtest.Replace(p.ParameterName, p.Value.ToString());
                }
                return Sqlcmd.ExecuteNonQuery().ToString();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally { sqlcon.Close(); }
        }
        public DataTable selectitemProc()
        {


            try
            {
                sqlcon.Open();
                SqlCommand Sqlcmd = new SqlCommand("Select_tblEmployee_SP", sqlcon);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(Sqlcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)

            { throw ex; }

            finally { sqlcon.Close(); }
        }
        public DataTable selectitemidproc(BAL.Business_Objects obj)
        {

            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("SelectById_tblEmployee_SP", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empid", obj.EmpId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)

            { throw ex; }

            finally { sqlcon.Close(); }
        }
        public string UpdatedataProc(BAL.Business_Objects obj)
        {

            try
            {
                sqlcon.Open();
                SqlCommand Sqlcmd = new SqlCommand("Update_tblEmployee_SP", sqlcon);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@empid", obj.EmpId);
                Sqlcmd.Parameters.AddWithValue("@UserName", obj.UserName);
                Sqlcmd.Parameters.AddWithValue("@Password", obj.Password);
                Sqlcmd.Parameters.AddWithValue("@Emailid", obj.Emailid);
                Sqlcmd.Parameters.AddWithValue("@Address", obj.Address);
                Sqlcmd.Parameters.AddWithValue("@Age", obj.Age);
                Sqlcmd.Parameters.AddWithValue("@Gender", obj.Gender);
                Sqlcmd.Parameters.AddWithValue("@MobileNo", obj.MobileNo);
                Sqlcmd.Parameters.AddWithValue("@Salary", obj.Salary);
                Sqlcmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);


                return Sqlcmd.ExecuteNonQuery().ToString();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally { sqlcon.Close(); }

        }
        public void DeletedataProc(BAL.Business_Objects obj)
        {

            try
            {
                sqlcon.Open();
                SqlCommand Sqlcmd = new SqlCommand("Delete_tblEmployee_SP", sqlcon);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@empid", obj.EmpId);
                //SqlParameter p = new SqlParameter("@empid", obj.empidVal);
                //Sqlcmd.Parameters.Add(p);
                Sqlcmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally { sqlcon.Close(); }
        }
    }
}
