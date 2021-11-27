using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp3TireAppDemo
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        BAL.EmployeeBAL obj = new BAL.EmployeeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt=obj.getrecord();
                grdemp.DataSource = dt;
                grdemp.DataBind();
                btndelete.Attributes.Add("onclick", "javascript:return DeleteConfirm()");
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            BAL.Business_Objects obj = new BAL.Business_Objects();
            BAL.EmployeeBAL bl = new BAL.EmployeeBAL();
            for (int i = 0; i < grdemp.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)(grdemp.Rows[i].FindControl("chkDel"));
                if (chk.Checked)
                {
                    obj.EmpId = Convert.ToInt32(grdemp.DataKeys[grdemp.Rows[i].RowIndex].Value.ToString());
                    bl.Deleterec(obj);
                    Response.Redirect("EmployeeDetails.aspx");
                }
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}