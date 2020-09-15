using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Connectivity connect = new Connectivity();
        StringBuilder sb = new StringBuilder();
        if (Session["student"] != null)
        {
            sb.Append("<li ><a  href='default.aspx'>Home</a></li><li ><a  href='#'>About</a></li>");
            sb.Append("<li><a href='sugg.aspx'>Suggestions</a></li>");
            sb.Append("<li><a href='art.aspx'>Articles</a></li>");
            sb.Append("<li><a href='user.aspx'>"+Session["s_name"]+"</a></li>");
            username.Style["display"] = "inline-block";
            logbtn.Style["display"] = "inline-block";
        }
        else
        {
            sb.Append("<li ><a  href='default.aspx'>Home</a></li><li ><a  href='default.aspx#about'>About</a></li>");
            sb.Append("<li ><a>Departments</a><ul>");
            DataTable dt = connect.GetData("select * from tbl_dep");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sb.Append("<li><a href='departments.aspx?ID=" + dt.Rows[i]["dep_id"] + "'>" + dt.Rows[i]["dep_name"] + "</a></li>");
                }
            }
            sb.Append("</ul>");
            sb.Append("<li class='li'><a style='margin-left:20px' href='reg.aspx'>Register</a></li><li><a  href='Login.aspx'>Login</a></li>");
            if (Session["username"] == null)
            {
                sb.Append("<li><a href='admin/access.aspx'>Faculty Login</a></li>");
            }
            else
            {
                sb.Append("<li><a href='admin/dashboard.aspx'>My Account</a></li>");
            }
        }
        menu.InnerHtml = sb.ToString();
        
    }

    protected void logbtn_Click(object sender, EventArgs e)
    {
        Session["student"] = null;
        Session["s_name"] = null;
        Session["user_id"] = null;
        Response.Redirect("default.aspx");
    }
}
