<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/user.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="logindiv" runat="server">
    <div style="background-color:black;margin-right:auto;margin-left:auto;height:50px;width:400px;line-height:50px;text-align:center;font-family:'Microsoft New Tai Lue';font-size:20pt;color:white;">
    <asp:label ID="Label6" runat="server" >Login</asp:label><br />
    </div>
    <asp:RegularExpressionValidator runat="server" ForeColor="Red" ID="r1" ErrorMessage="Invalid Email" ControlToValidate="txtemail" ValidationExpression="^[a-zA-Z0-9_]*\w[@]\w[a-zA-Z0-9]*\w[.]\w[a-zA-Z]*"></asp:RegularExpressionValidator>
    <div style="margin-top:40px">
    <asp:label  ID="Label1"  CssClass="lbl"  runat="server" Style="padding-right:205px">Email</asp:label><br />
    <asp:textbox  CssClass="txtbox" placeholder="Enter Email" runat="server" ID="txtemail"/><br/>
    
    <asp:label ID="Label3" CssClass="lbl" runat="server" Style="padding-right:170px">Password</asp:label><br />
    <asp:textbox  CssClass="txtbox" type="password" placeholder="Password" runat="server" ID="txtpwd"/><br/>
    
    <br/>  
     <asp:button OnClick="Button1_Click" ID="Button1" text="Login" Style="border-radius:8px;background-color:hsl(180, 65%, 50%);color:white;border:none;outline:none;height:40px;width:100px;margin-top:10px; margin-left:10px" runat="server"/>
     <a href="reg.aspx" style="color:#7c944e;text-decoration:none;padding-left:20px"> Register</a>
 </div>
</div>
</asp:Content>

