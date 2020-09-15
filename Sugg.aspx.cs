using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sugg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["student"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            Connectivity connect = new Connectivity();
            if (!IsPostBack)
            {
                DataTable dt = connect.GetData("select * from tbl_dep");
                drop.DataSource = dt;
                drop.DataTextField = "dep_name";
                drop.DataBind();
                get_answer();
            }
        }
    }
 protected void Unnamed_Click(object sender, EventArgs e)
       {
           Connectivity connect = new Connectivity();
           string query = "insert into tbl_feed(user_id,query) values((select ID from tbl_user where email='"+Txt_uemail.Text+"' AND name = '"+Session["s_name"]+"'),'"+TextArea.InnerText+"')";
           string str = connect.ExecData(query);
            if (str == "Success")
            {
                Response.Write("<script>alert('Your query successfully sent')</script>");
            }
            else
            {
                Response.Write("<script>alert('Something went wrong')</script>");
            }
       }
 public void get_answer()
 {
     StringBuilder sb = new StringBuilder();
     Connectivity connect = new Connectivity();
     DataTable dt = connect.GetData("select * from tbl_ans,tbl_feed,tbl_faculty where q_id = f_id AND stat = 'ACK' AND id=replied_by");
     if (dt.Rows.Count > 0)
     {
         for (int i = 0; i < dt.Rows.Count; i++)
         {
             string id = "r" + i;
             sb.Append("<div style='width:100%;overflow:hidden'>");
             sb.Append("<div style='width:98%;background-color:#4EB1BA;padding:10px;font-family:Microsoft New Tai Lue;color:white'>Replied By: " + dt.Rows[i]["name"] + "</div>");
             sb.Append("<div style='background-color:aliceblue;width:98%;padding:10px'><span>Query:</span><br/>"+dt.Rows[i]["query"]+"<br/>");
             sb.Append("<input onclick=view_div('"+id+"','"+dt.Rows.Count+"') class='button' type='button' value='Answers'/>");
             sb.Append("</div>");
             sb.Append("<div id=" + id + " style='transition:all 1s;background-color:white ;width:98%;padding:0 10px 0px 10px;height:0px;'>");
             sb.Append( dt.Rows[i]["answer"] + "</div>");
             sb.Append("</div><br/>");
         }
         sugg_box.InnerHtml = sb.ToString();
     }
 }
}

   