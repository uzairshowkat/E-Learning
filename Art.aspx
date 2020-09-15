<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Art.aspx.cs" Inherits="Art" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="admin/jquery.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">'
    
    <div runat="server" class="article" id="art_gen">
    </div>
    


    <script>

        $(".arc").slideUp(0);
        $(".view").click(function () {
            $(this).siblings(".arc").slideToggle();
        });
       
    </script>

       
       
            
 </asp:Content>

