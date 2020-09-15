<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="chngpwd.aspx.cs" Inherits="chngpwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="Div1" style="height:520px" class="logindiv" runat="server">
    <div style="background-color:black;margin-right:auto;margin-left:auto;height:50px;width:400px;line-height:50px;text-align:center;font-family:'Microsoft New Tai Lue';font-size:20pt;color:white;">
    <asp:label ID="Label6" runat="server" >Change Password</asp:label><br />
    </div>
    <div style="margin-top:40px">
    <asp:label  ID="Label1"  CssClass="lbl"  runat="server" Style="padding-right:205px">Old Password</asp:label><br />
    <asp:textbox  CssClass="txtbox" Type="password" placeholder="Enter Old Password" runat="server" ID="txt_oldpwd"/><br/>
    
    <asp:label ID="Label3" CssClass="lbl" runat="server" Style="padding-right:170px">New Password</asp:label><br />
    <asp:textbox  CssClass="txtbox" type="password" placeholder="New Password" runat="server" ID="txt_newpwd"/><br/>
    <br/>  
    <asp:label ID="Label2" CssClass="lbl" runat="server" Style="padding-right:170px">Confirm Password</asp:label><br />
    <asp:textbox  CssClass="txtbox" type="password" placeholder="New Password" runat="server" ID="txt_pwd"/><br/>
    <asp:button OnClick="Button1_Click" ID="Button1" text="Change Password" Style="font-size:12pt;font-family:'Microsoft New Tai Lue';border-radius:6px;background-color:hsl(180, 65%, 50%);color:white;border:none;outline:none;height:50px;width:180px;margin-top:10px; margin-left:10px" runat="server"/>
   </div>
</div>
</asp:Content>

