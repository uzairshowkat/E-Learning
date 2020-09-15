<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Sugg.aspx.cs" Inherits="Sugg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="sugg">
    <asp:Label runat="server">Your Name</asp:Label><br />
    <asp:TextBox ID="txt_user" runat="server" Style="width:250px;height:30px;border-radius:5px;padding-left:10px"></asp:TextBox><br />
    <span >Department</span><br />
    <asp:dropdownlist ID="drop" AutoPostBack="true" CssClass="drop" Style="width:250px;height:35px;border-radius:5px;padding-left:10px" runat="server"/><br />
    <asp:Label ID="Label2" runat="server">Your Email</asp:Label><br />
    <asp:TextBox ID="Txt_uemail" runat="server" Style="width:250px;height:30px;border-radius:5px;padding-left:10px"></asp:TextBox><br />
    <asp:Label runat="server">Your Suggestion</asp:Label><br/>
    <textarea runat="server" id="TextArea"></textarea><br/>
    <asp:Button OnClick="Unnamed_Click" runat="server" Text="Submit" Style="width:100px;height:30px;border:none;background-color:hsl(180, 65%, 50%);font-family:'Microsoft New Tai Lue';color:white;text-align:center;border-radius:5px;cursor:pointer"/>
    </div>
    <div runat="server" id="sugg_box" class="rep"></div>
    <script>
        function view_div(n,index)
        {
            var i = 0;
            document.getElementById(n).style.height = "150px";
            while (i < parseInt(index)) {
                if (n != ("r" + i)) {
                    document.getElementById("r" + i).style.height = "0px";

                }
                i++;
            }
        }
</script>
</asp:Content>

