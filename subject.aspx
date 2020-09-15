<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="subject.aspx.cs" Inherits="subject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="display:inline-block;background-color:#4EB1BA;height:auto;width:30%;text-align:center;vertical-align:top">
        <div style="line-height:50px;text-align:center;background-color:#00D0AF;height:50px;width:100%;">
            <span id="subname" style="font-family:'Microsoft New Tai Lue';font-size:15pt;color:white" runat="server"></span>
            <ul runat="server" style="padding-left:0px;margin-top:0px;" id="topic_gen"></ul>
        </div>
    </div>
    <div style="display:inline-block;height:500px;width:69%;">
     <div style="border:1px solid white;background-color:white;height:50px;padding-left:0px">
       <ul class="menuuser">
        <li><a href="subject.aspx?id=<%Response.Write(Request.QueryString["id"]); %>&format=file">Files</a></li>
        <li><a href="subject.aspx?id=<%Response.Write(Request.QueryString["id"]);%>&format=ved">Vedios</a></li>
      </ul>
     </div>
 <div runat="server" id="dis_sub" style="height:510px;width:100%;float:right">
        <iframe runat="server" id="ifr" style="height:510px;width:100%;"></iframe>
    </div>
    </div>
<script>
        function myfunc(val)
        {
            val = "a" + val;
            document.getElementById("ContentPlaceHolder1_ifr").src = document.getElementById(val).target;
        }

    </script>
</asp:Content>
  
