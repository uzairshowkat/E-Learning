using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Student"] != null)
        {
            Response.Redirect("default.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Connectivity connect = new Connectivity();
        DataTable dt = connect.GetData("select ID,name,email,password,status from tbl_user where email='" + txtemail.Text + "' AND password='" + txtpwd.Text + "'");
        if (dt.Rows.Count > 0)
        {
            if (dt.Rows[0]["status"].ToString() == "active")
            {
                if (txtemail.Text.ToString() == dt.Rows[0]["email"].ToString() && txtpwd.Text.ToString() == dt.Rows[0]["password"].ToString())
                {
                    Session["s_name"] = dt.Rows[0]["Name"];
                    Session["student"] = txtemail.Text;
                    Session["user_id"] = dt.Rows[0]["ID"];

                }
                else
                {
                    Response.Write("<script>alert('Your account is not verified')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Check Your Credentials')</script>");

            }
        }
    }
}