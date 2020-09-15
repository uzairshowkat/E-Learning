using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class chngpwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"].ToString() == "user")
        {
            if (Session["s_name"] == null)
            {
                Response.Redirect("default.aspx");
            }
        }
        else if (Request.QueryString["ID"].ToString() == "admin")
        {
            if (Session["username"] == null)
            {
                Response.Redirect("admin/access.aspx");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s,t_name;
        Connectivity connect = new Connectivity();
        DataTable dt = new DataTable();
        if (Request.QueryString["ID"].ToString() == "user")
        {
            dt = connect.GetData("select password from tbl_user where id='" + Session["user_id"] + "'");
            t_name = "tbl_user";
        }
        else
        {
            dt = connect.GetData("select password from tbl_faculty where id='" + Session["f_id"] + "'");
            t_name = "tbl_faculty";
        }
        if (dt.Rows.Count > 0)
        {
            if (dt.Rows[0]["password"].ToString() == txt_oldpwd.Text.ToString() && txt_newpwd.Text.ToString() == txt_pwd.Text.ToString())
            {
                string query;
                if (t_name == "tbl_user")
                {
                    query = "update " + t_name + " SET password='" + txt_newpwd.Text + "' where id='" + Session["user_id"] + "'";
                }
                else {
                    query = "update " + t_name + " SET password='" + txt_newpwd.Text + "' where id='" + Session["f_id"] + "'";
                }
                
                s = connect.ExecData(query);
                if (s == "Success")
                {
                    Response.Write("<script>alert('Password Changed Successfully')</script>");
                   
                }
               
            }
            else
            {
                Response.Write("<script>alert('Cannot Change Please Fill Details Carefully')</script>");
            }
        }
    }
}