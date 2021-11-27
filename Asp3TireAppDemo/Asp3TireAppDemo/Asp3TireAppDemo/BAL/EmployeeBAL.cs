using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Asp3TireAppDemo.BAL
{
    public class EmployeeBAL
    {
        public string insertrecord(BAL.Business_Objects obj)
        {
             DAL.EmployeeDAL dalaccess = new DAL.EmployeeDAL();
            try
            {
                return dalaccess.insertitem(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { dalaccess = null; }
        }
        public string UpdateRec(BAL.Business_Objects obj)
        {
            DAL.EmployeeDAL dalaccess = new DAL.EmployeeDAL();
            try
            {
                return dalaccess.UpdatedataProc(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { dalaccess = null; }
        }
        public void Deleterec(BAL.Business_Objects obj)
        {

            DAL.EmployeeDAL dalaccess = new DAL.EmployeeDAL();
            try
            {
                dalaccess.DeletedataProc(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { dalaccess = null; }
        }
        public DataTable getrecord()
        {
            DAL.EmployeeDAL dalaccess = new DAL.EmployeeDAL();
            try
            {
                return dalaccess.selectitemProc();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalaccess = null;
            }
        }
        public DataTable getrecordid(BAL.Business_Objects obj)
        {
            DAL.EmployeeDAL dalaccess = new DAL.EmployeeDAL();
            try
            {

                return dalaccess.selectitemidproc(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalaccess = null;
            }
        }
    }
}