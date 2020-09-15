<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/user.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="background-color:#4EB1BA;height:520px;width:30%;display:inline-block;">
        <div id="u_name">
            <span class="log_txt"><% Response.Write(Session["s_name"].ToString().ToUpper().Substring(0,1)); %></span>
        </div>
        <div style="text-align:center"><span class="log_txt" style="font-size:15pt;"><%Response.Write(Session["s_name"]); %></span></div>
        <div style="text-align:center;margin-top:30px"><asp:button OnClick="chng_pwd_Click" CssClass="log_txt" style="height:40px;width:200px;font-size:15pt;outline:none;background-color:#4EB1BA;border:2px solid white;cursor:pointer" ID="chng_pwd" text="Change Password" runat="server"/></div>
    </div>
   <div class="dataview" id="dataview" runat="server">
      </div>
</asp:Content>

