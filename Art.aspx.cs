using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Art : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["s_name"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else 
        {
              Get_articles();
        }
           
     }
   
    public void Get_articles()
    {
        Connectivity connect = new Connectivity();
        DataTable dt = connect.GetData("select * from tbl_art,tbl_faculty,tbl_user where tbl_user.ID='"+Session["user_id"]+"' AND art_by=tbl_faculty.id AND (dep=degree OR dep like '%ALL%')");
        StringBuilder sb = new StringBuilder();
        if (dt.Rows.Count > 0)
        { 
            string cls;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
              string bid="b"+i;
                string id = "r" + i;
                cls = (i % 2 == 0) ? "white" : "aliceblue";
                sb.Append("<div class='even' style='background-color:" + cls + "'>");
                sb.Append("<div style='height:30px;line-height:30px;background-color:hsl(180, 65%, 50%);padding:10px;font-family:Microsoft New Tai Lue;color:white'>Title:&nbsp;<i>" + dt.Rows[i]["title"]+"</i>");
                sb.Append("<span style=float:right>Uploaded 0n:&nbsp;<i>" + dt.Rows[i]["added_on"] + "</i></span>");
                sb.Append("<span style=float:right>Author:&nbsp;<i>" + dt.Rows[i]["name"] + "</i>&nbsp;|&nbsp;</span></div>");
                sb.Append("<div class='arc' style='overflow:hidden;background-color:" + cls + ";height:auto;text-align:justify;padding:20px;'>" + dt.Rows[i]["body"].ToString() + "</div>");
                sb.Append("<input  class='view' value='View' type='button'/>");
                sb.Append("</div>");
            }
        }
        art_gen.InnerHtml = sb.ToString();
 }
}