using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class subject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["student"] != null)
        {
            StringBuilder sb = new StringBuilder();
            Connectivity connect = new Connectivity();
            DataTable dt = connect.GetData("select s_name from tbl_sub where s_id = '" + Request.QueryString["id"] + "'");
           if (dt.Rows.Count > 0)
                {
                    subname.InnerText = dt.Rows[0]["s_name"].ToString().ToUpper();
                    Get_mat(Request.QueryString["format"]);
                }
        }
         else
        {
            Response.Redirect("default.aspx");
        }
    }
    public void Get_mat(string frmt)
    {
        StringBuilder sb = new StringBuilder();
        Connectivity connect = new Connectivity();
        if (frmt == null || frmt == "file")
        {
            DataTable tbl = connect.GetData("select topic,filepath from tbl_mat where sub_id ='" + Request.QueryString["id"] + "' AND ext IN('.pdf','.docx','.pptx')");
            if (tbl.Rows.Count > 0)
            {
                ifr.Attributes["src"] = "admin/" + tbl.Rows[0]["filepath"].ToString();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    sb.Append("<li class='topicli'><a id='a" + i + "' target='admin/" + tbl.Rows[i]["filepath"] + "'   onclick='myfunc(" + i + ")'>" + tbl.Rows[i]["topic"] + "</a></li>");
                }
                topic_gen.InnerHtml = sb.ToString();
            }
        }
        else if(frmt=="ved")
        {
            DataTable tbl = connect.GetData("select topic,filepath from tbl_mat where sub_id ='" + Request.QueryString["id"] + "' AND ext IN('.mp4')");
            if (tbl.Rows.Count > 0)
            {
                ifr.Attributes["src"] = "admin/" + tbl.Rows[0]["filepath"].ToString();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    sb.Append("<li class='topicli'><a id='a" + i + "' target='admin/" + tbl.Rows[i]["filepath"] + "'   onclick='myfunc(" + i + ")'>" + tbl.Rows[i]["topic"] + "</a></li>");
                }
                topic_gen.InnerHtml = sb.ToString();
            }
        }
    }
}