using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reg : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["student"] == null)
        {
            if (!IsPostBack)
            {
                Connectivity connect = new Connectivity();
                DataTable dt = new DataTable();
                dt = connect.GetData("select dep_name from tbl_dep");
                degree.DataSource = dt;
                degree.DataTextField = "dep_name";
                degree.DataBind();
                degree.Items.Insert(0, new ListItem("--Select degree--", "0"));
            }
        }
        else {
            Response.Redirect("default.aspx");
        }
   }
    protected void std_chkd(object sender, EventArgs e)
    {
        sign.Style["height"] = "800px";
        radeg.Style["display"] = "block";
    }
    protected void tchr_chkd(object sender, EventArgs e)
    {
        sign.Style["height"] = "700px";
        radeg.Style["display"] = "none";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      Connectivity conn = new Connectivity();
      DataTable dt = conn.GetData("select tbl_user.email,tbl_faculty.email from tbl_user,tbl_faculty where tbl_user.email='" + txtemail.Text + "' OR tbl_faculty.email='" + txtemail.Text + "'");
      if (dt.Rows.Count == 0)
      {
          if ((txtemail.Text.ToString() == txtecnfm.Text.ToString()) && (txtpwd.Text.ToString() == txtpwdc.Text.ToString()))
          {
              Connectivity connect = new Connectivity();
              if (std.Checked)
              {
                  string query = "insert into tbl_user(Name,email,password,degree,role) values('" + txtname.Text + "','" + txtemail.Text + "','" + txtpwd.Text + "','" + degree.SelectedItem.Text + "','student')";
                  string stat = connect.ExecData(query);
                  if (stat == "Success")
                  {
                      ViewState["otpmatch"] = otp_gen(txtemail.Text, "OTP for Account Activation");
                      sign.Style["display"] = "none";
                      otpdiv.Style["display"] = "block";
                      //Response.Redirect("login.aspx");
                  }
              }
              else
              {
                  string query = "insert into tbl_faculty(Name,email,password,role) values('" + txtname.Text + "','" + txtemail.Text + "','" + txtpwd.Text + "','teacher')";
                  string status = connect.ExecData(query);
                  if (status == "Success")
                  {
                      Response.Write("<script>alert('You have been registered Successfully')</script>");
                     
                  }
              }
          }
      }
      else
      {
          errormsg.Style["display"] = "block";
          errormsg.InnerHtml = "<span style='color:white;font-size:20px;font-family:Microsoft New Tai Lui;Text-align:center;line-height:50px'>Email Already registered.Try with some other Email</span>";
      }
    }
    public long otp_gen(string email, string subject)
    {
        Random rand = new Random();
        long otp = rand.Next(100000,1000000);
        string msg = "Your OTP is" + otp;
        MailMessage mail = new MailMessage("e.learning1321@gmail.com", email);
        mail.Subject = subject;
        mail.Body = msg;
        mail.IsBodyHtml = true;
        SmtpClient client = new SmtpClient();
        client.Credentials = new NetworkCredential("e.learning1321@gmail.com", "elearning1321");
        client.Host = "smtp.gmail.com";
        client.EnableSsl = true;
        client.Port = 587;
        client.Send(mail);
        return otp;
    }
    protected void btnotp_Click(object sender, EventArgs e)
    {
        otp_match();
    }
    public void otp_match()
    {
        if (Convert.ToInt64(txtotp.Text) == Convert.ToInt64(ViewState["otpmatch"]))
        {
             Connectivity connect = new Connectivity();
             connect.ExecData("update tbl_user SET status='active' where email='"+txtemail.Text+"'");
             DataTable dt = connect.GetData("select status from tbl_user where email='"+txtemail.Text+"'");
             if (dt.Rows[0]["status"].ToString() == "active")
             {
                 show.Style["display"] = "block";
                 
             }
        }
    }
    protected void ok_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}