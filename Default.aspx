 <%@ Page Title="e-learning" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="slider/themes/3/js-image-slider.css" rel="stylesheet" type="text/css" />
    <script src="slider/themes/3/js-image-slider.js" type="text/javascript"></script>
    <link href="slider/generic.css" rel="stylesheet" type="text/css" />
    <link href="css/user.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
  <div id="sliderFrame" style="" >
        <div id="slider" style="width:100%;background-repeat:no-repeat;background-size:cover;">
            
                <img src="images/img4.png" style="border:1px solid black;"alt="" />

            
            <a class="lazyImage" href="images/img2.jpg" ></a>
            <a href="#">
                <b data-src="images/img3.jpg" data-alt=""></b>
            </a>
            <a class="lazyImage" href="images/img1.jpg" ></a>
        </div>
    </div>
    
    <hr/>
    <div style="margin-bottom:10px">
    <span id="about" style="font-family:Microsoft New Tai Lue;font-size:35px;padding-left:10px">About</span>
        <div style="border:1px solid black;background-color:white;margin:10px;padding:10px;text-align:justify;font-family:'Microsoft New Tai Lue';font-size:12pt">
            <p>
              E-Learning, also referred to as Web-based training, is available anywhere, anytime. It is self-paced interactive instruction, 
              presented over the Internet to browser-equipped learners.E-Learning courses span the spectrum from desktop applications to technical
              certification meeting the needs of today’s life-long learners. The e-Learning solution is empowering, engaging, effective and economical.
              It is the answer to today's training challenges.E-Learning is easy and engaging. It is available to everyone at any time - all you need is
              a standard browser like Internet Explorer or Netscape Navigator. You do not have to install programs, there are no CDs, it is all done 
              over the Internet and the courses are interactive. You learn by doing, not by just watching a computer screen. Simulations and questions 
              about key concepts and facts will keep you engaged in the course.

            </p>
        </div>
    </div>
</asp:Content>

