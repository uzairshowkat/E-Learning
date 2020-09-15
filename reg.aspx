<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div runat="server" style="display:none;padding-top:60px;line-height:50px;text-align:center;height:200px;width:400px;margin:30px auto 0px auto;background:radial-gradient(white,#1e1e1e);color:white" id="otpdiv">
    <asp:label style="padding-right:30px;font-family:'Microsoft New Tai Lue';" runat="server" Text="Enter OTP"></asp:label>
    <asp:textbox  style="height:30px;width:70px;padding:0px 10px 0px 10px" runat="server" ID="txtotp" placeholder="Enter OTP"/><br/>
    <asp:button ID="btnotp" onclick="btnotp_Click" style="vertical-align:top;height:40px;width:70px;border:none;outline:none;color:white;font-family:'Microsoft New Tai Lue';background-color:#6fc47c" runat="server" text="Verify"/>
    <br/> <div id="show"  style="display:none;text-align:center;height:40px;width:99%" runat="server">
           <span>You may login now </span>
        <asp:button OnClick="ok_Click" runat="server" ID="ok" style="border:none;height:20px;width:50px;color:white;font-family:'Microsoft New Tai Lue';background-color:#6fc47c;margin-left:20px" Text="OK"/>
        </div>
</div> 
   
<div id="sign" class="sign" runat="server">
    <div style="background-color:black;height:50px;width:800px;line-height:50px;text-align:center;font-family:'Microsoft New Tai Lue';font-size:20pt;color:white;">
    <asp:label ID="Label6" runat="server">Join Us to Learn</asp:label><br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" Font-Size="1" ValidationExpression="^[a-zA-Z ]*" ControlToValidate="txtname" ErrorMessage="Enter Characters only" ForeColor="Red" runat="server" ></asp:RegularExpressionValidator>

        <div id="errormsg" runat="server" style="height:50px;width:700px;background-color:#a1b29d;margin:-50px 0px 0px 50px;display:none"></div>
    </div>
    <div style="height:600px;padding-top:70px;padding-left:100px">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" style="padding-left:278px" ForeColor="red" ControlToValidate="txtname" runat="server" ErrorMessage="Please Enter Name"></asp:RequiredFieldValidator><br/>
    <asp:label ID="Label5" style="padding-right:175px" CssClass="lbl" runat="server">Your Name</asp:label>
    <asp:textbox  CssClass="txtbox" placeholder="" runat="server" ID="txtname"/><br/>
    <asp:RegularExpressionValidator ForeColor="red" ControlToValidate="txtemail" style="padding-left:278px" ID="RegularExpressionValidator1" ValidationExpression="^[A-Za-z0-9_%.+]+@[A-Za-z]*.[A-Za-z]*" runat="server" ErrorMessage="Enter valid email"></asp:RegularExpressionValidator><br/>
    <asp:label ID="Label1" style="padding-right:130px" CssClass="lbl" runat="server">Enter Your Email</asp:label>
    <asp:textbox  CssClass="txtbox" placeholder="Enter Email" runat="server" ID="txtemail"/><br/>
    <asp:label ID="Label2" style="padding-right:106px" CssClass="lbl" runat="server">Confirm Your Email</asp:label>
    <asp:textbox  CssClass="txtbox" placeholder="Re-enter Email" runat="server" ID="txtecnfm"/><br/>
    <asp:label ID="Label3" style="padding-right:94px" CssClass="lbl" runat="server">Enter Your Password</asp:label>
    <asp:textbox  CssClass="txtbox" type="password" placeholder="Password" runat="server" ID="txtpwd"/><br/>
    <asp:label ID="Label4" style="padding-right:70px" CssClass="lbl" runat="server">Confirm Your Password</asp:label>
    <asp:textbox  CssClass="txtbox" type="password" placeholder="Re-enter Password" runat="server" ID="txtpwdc"/>
    <br/>
     <asp:label ID="Label7" CssClass="lbl" style="padding-right:230px" runat="server">I am</asp:label> 
     <asp:RadioButton ID="std" Style="font-family:'Microsoft New Tai Lue';font-size:12pt" GroupName="role" OnCheckedChanged="std_chkd" Text="Student" runat="server" AutoPostBack="True"></asp:RadioButton>
     <asp:RadioButton ID="tchr" Style="font-family:'Microsoft New Tai Lue';font-size:12pt" groupname="role" OnCheckedChanged="tchr_chkd" text="Teacher" AutoPostBack="True" runat="server"></asp:RadioButton><br/>
     <div id="radeg" runat="server" style="display:none">
        <br/> <asp:label ID="Label8" style="padding-right:210px" CssClass="lbl" runat="server">Degree</asp:label>
         <asp:dropdownlist ID="degree" CssClass="txtbox" runat="server"/>
     </div>
     <asp:button runat="server" OnClick="Button1_Click" text="Register" Style="margin-left:200px;margin-right:20px;background-color:#6fc47c;color:white;border:none;outline:none;height:40px;width:100px;margin-top:10px;cursor:pointer"  />
     <a href="login.aspx" style="text-decoration:none;color:#7c944e" class="reg">Already Registered?</a>
   </div>
</div>
        
</asp:Content>

