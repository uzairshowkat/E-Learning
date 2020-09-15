using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        if (Session["student"] != null)
        {
            Connectivity connect = new Connectivity();
            DataTable dt = connect.GetData("select s_name,s_id from tbl_user,tbl_sub,tbl_dep where tbl_user.id='" + Session["user_id"] + "' AND tbl_user.degree=dep_name AND tbl_sub.d_id = tbl_dep.dep_id");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sb.Append("<div style='display:inline-block;padding-top:10px;height:auto;width:200px;text-align:center;background-color:white;margin:20px;0px;0px;0px'>");
                    sb.Append("<a style='color:black;text-decoration:none;font-family:Microsoft new tai lue;font-size:12pt' href='subject.aspx?id="+dt.Rows[i]["s_id"]+"'>" + dt.Rows[i]["s_name"].ToString().ToUpper() + "</a>");
                    sb.Append("</div>");
                }
            }
            dataview.InnerHtml = sb.ToString();
        }
        else {
            Response.Redirect("default.aspx");
        }
    }
    protected void chng_pwd_Click(object sender, EventArgs e)
    {
        Response.Redirect("chngpwd.aspx?id=user");
    }
}