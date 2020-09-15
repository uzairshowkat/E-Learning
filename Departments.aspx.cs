using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Departments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        Connectivity connet = new Connectivity();
        DataTable dt = connet.GetData("select s_name,dep_name,s_id from tbl_sub,tbl_dep where d_id ='" + Request.QueryString["ID"] + "' AND d_id=dep_id");
        if (dt.Rows.Count > 0)
        {

            sb.Append("<div style='text-align:center;margin-bottom:10px;height:50px;padding-top:23.5px;font-family:Microsoft new tai lui;font-size:20pt;text-align:center;color:white;width:100%;background-color:black'>");
            sb.Append("<span style='margin-left:auto;margin-right:auto'>");
            sb.Append(dt.Rows[0]["dep_name"]);
            sb.Append("</span></div>");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Append("<div style='display:inline-block;margin-top:100px;padding-top:10px;height:auto;width:200px;text-align:center;background-color:white;margin:20px;0px;0px;0px'>");
                sb.Append("<a style='color:black;text-decoration:none;font-family:Microsoft new tai lue;font-size:12pt' href='login.aspx'>");
                sb.Append(dt.Rows[i]["s_name"].ToString().ToUpper());
                sb.Append(" </a>");
                sb.Append("</div>");
            }
            subjects.InnerHtml = sb.ToString();
       }
    }
}