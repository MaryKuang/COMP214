<%@ Page Title="" Language="C#" MasterPageFile="~/MaryCookBook.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Indicators -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
		<li data-target="#myCarousel" data-slide-to="0" class="active"></li>
		<li data-target="#myCarousel" data-slide-to="1"></li>
		<li data-target="#myCarousel" data-slide-to="2"></li>
	    </ol>   
	   <!-- Carousel -->
	  <div class="carousel-inner">
		<div class="item active">
             <img src="Pictures/food-516044_640.jpg" alt="First slide" width="460" height="345"/>
			<div class="carousel-caption">Recipe 1</div>
		</div>
		<div class="item">
             <img src="Pictures/kung-pao-chicken-1024x681.jpg" alt="Second slide" width="460" height="345"/>
			<div class="carousel-caption">Recipe 2</div>
		</div>
		<div class="item">
             <img src="Pictures/img_0113ed.jpg" alt="Third slide" width="460" height="345"/>
            <div class="carousel-caption">Recipe 3</div>
		</div>
        <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
    </div>
  </div>
    <!-- columns -->
    <div class="col-md-4">
         <div class="thumbnail">
         <h2></h2>
        <asp:Image ID="Image1" runat="server" class="img-thumbnail" src="Pictures/ChangeTheme.JPG" width="304" Height="236"/>
        <asp:button ID="btnStart" runat="server" text="Setup Style" class="btn btn-default btn-lg" OnClick="btnStart_Click" />
      </div>
    </div>
     <div class="col-md-4">
          <div class="thumbnail">
          <h2></h2>
         <asp:Image ID="Image2" runat="server" class="img-thumbnail" src="Pictures/AddRecipe.JPG" width="304" Height="236" />
         <asp:button ID="btnList" runat="server" text="Add recipe" class="btn btn-default btn-lg" OnClick="btnList_Click" />
              </div>
    </div>
     <div class="col-md-4">
          <div class="thumbnail">
          <h2></h2>
         <asp:Image ID="Image3" runat="server" class="img-thumbnail" src="Pictures/serach.jpeg" width="304" Height="236"/>
         <asp:button ID="btnSignUP" runat="server" text="Search recipe" class="btn btn-default btn-lg" OnClick="btnSignUP_Click" />
         
              </div>
    </div>
</asp:Content>

