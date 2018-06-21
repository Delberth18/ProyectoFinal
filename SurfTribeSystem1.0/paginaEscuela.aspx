﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paginaEscuela.aspx.cs" Inherits="SurfTribeSystem1._0.paginaEscuela" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">

    <!-- SITE TITTLE -->
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Surf Tribe System</title>

    <!-- PLUGINS CSS STYLE -->
    <link href="ccss/star-1-3/Static%20HTML/plugins/jquery-ui/jquery-ui.min.css" rel="stylesheet" />
    <link href="ccss/star-1-3/Static%20HTML/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="ccss/star-1-3/Static%20HTML/plugins/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static%20HTML/plugins/selectbox/select_option1.css" />
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static%20HTML/plugins/datepicker/datepicker.css" />
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static%20HTML/plugins/isotope/jquery.fancybox.css" />
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static%20HTML/plugins/isotope/isotope.css" />
    <!-- REVOLUTION SLIDER -->
    <link rel="stylesheet" href="ccss/star-1-3/Static%20HTML/plugins/revolution/css/settings.css" />
    <link rel="stylesheet" href="ccss/star-1-3/Static%20HTML/plugins/revolution/css/layers.css" />
    <link rel="stylesheet" href="ccss/star-1-3/Static%20HTML/plugins/revolution/css/navigation.css" />


    <!-- GOOGLE FONT -->
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,600,700' rel='stylesheet' type='text/css' />

    <!-- CUSTOM CSS -->
    <link href="ccss/star-1-3/Static HTML/css/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="ccss/star-1-3/Static%20HTML/css/colors/default.css" id="option_color" />

    <!-- FAVICON -->
    <link rel="shortcut icon" type="image/png" href="ccss/star-1-3/Static%20HTML/img/favicon.png" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

</head>


<body class="body-wrapper ">
  <div class="main-wrapper">

    <!-- HEADER -->
    <header>
      <nav class="navbar navbar-default navbar-main navbar-fixed-top   lightHeader " role="navigation">
        <div class="container">

          <!-- Brand and toggle get grouped for better mobile display -->
          <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
              <span class="sr-only">Toggle navigation</span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="index.html"></a>
          </div>

          <!-- Collect the nav links, forms, and other content for toggling -->
          <div class="collapse navbar-collapse navbar-ex1-collapse">
            <ul class="nav navbar-nav navbar-right">
              <li class="dropdown singleDrop ">
                <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown">Home </a>
                <ul class="dropdown-menu dropdown-menu-left">
                  <li class="dropdown singleDrop  "><a href="index.html">Home Main</a></li>
                  <li class="dropdown singleDrop  "><a href="index-v2.html">Home City</a></li>
                  <li class="dropdown singleDrop  "><a href="index-v3.html">Home Destination</a></li>
                </ul>
              </li>
              <li class="dropdown megaDropMenu ">
                <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown" data-delay="300" data-close-others="true" aria-expanded="false">Tours</a>
                <ul class="row dropdown-menu">
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Tour Packages Grid View</li>
                      <li class=""><a href="packages-grid-left-sidebar.html">Packages Sidebar Left</a></li>
                      <li class=""><a href="packages-grid-right-sidebar.html">Packages Sidebar Right</a></li>
                      <li class=""><a href="packages-grid.html">Packages 3 Columns</a></li>
                    </ul>
                  </li>
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Tour Packages List View</li>
                      <li class=""><a href="packages-list-left-sidebar.html">Packages Sidebar Left</a></li>
                      <li class=""><a href="packages-list-right-sidebar.html">Packages Sidebar Right</a></li>
                      <li class=""><a href="packages-list.html">Packages List</a></li>
                    </ul>
                  </li>
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Single Package</li>
                      <li class=""><a href="single-package-left-sidebar.html">Packages Sidebar Left</a></li>
                      <li class=""><a href="single-package-right-sidebar.html">Packages Sidebar Right</a></li>
                      <li class=""><a href="single-package-fullwidth.html">Package Fullwidth</a></li>
                    </ul>
                  </li>
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Booking Steps</li>
                      <li class=""><a href="booking-1.html">Step 1 - Personal Info</a></li>
                      <li class=""><a href="booking-2.html">Step 2 - Payment Info</a></li>
                      <li class=""><a href="booking-3.html">Step 3 - Confirmation</a></li>
                    </ul>
                  </li>
                </ul>
              </li>
              <li class="dropdown megaDropMenu active">
                <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown" data-delay="300" data-close-others="true" aria-expanded="false">Hotels</a>
                <ul class="row dropdown-menu">
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Hotels Grid View</li>
                      <li class=""><a href="hotels-grid-left-sidebar.html">Hotels Sidebar Left</a></li>
                      <li class=""><a href="hotels-grid-right-sidebar.html">Hotels Sidebar Right</a></li>
                      <li class=""><a href="hotels-grid.html">Hotels 3 Columns</a></li>
                    </ul>
                  </li>
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Hotels List View</li>
                      <li class=""><a href="hotels-list-left-sidebar.html">Hotels Sidebar Left</a></li>
                      <li class=""><a href="hotels-list-right-sidebar.html">Hotels Sidebar Right</a></li>
                      <li class=""><a href="hotels-list.html">Hotels List</a></li>
                    </ul>
                  </li>
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Single Hotel</li>
                      <li class=""><a href="single-hotel-left-sidebar.html">Hotels Sidebar Left</a></li>
                      <li class=""><a href="single-hotel-right-sidebar.html">Hotels Sidebar Right</a></li>
                      <li class="active"><a href="single-hotel-fullwidth.html">Hotels Fullwidth</a></li>
                    </ul>
                  </li>
                  <li class="col-sm-3 col-xs-12">
                    <ul class="list-unstyled">
                      <li>Booking Steps</li>
                      <li class=""><a href="booking-1.html">Step 1 - Personal Info</a></li>
                      <li class=""><a href="booking-2.html">Step 2 - Payment Info</a></li>
                      <li class=""><a href="booking-3.html">Step 3 - Confirmation</a></li>
                    </ul>
                  </li>
                </ul>
              </li>
              <li class="dropdown singleDrop ">
                <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">PAGES</a>
                <ul class="dropdown-menu dropdown-menu-right">
                  <li class=""><a href="about-us.html">About Us</a></li>
                  <li class=""><a href="contact.html">Contact Us</a></li>
                  <li class="dropdown dropdown-submenu ">
                    <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown">Gallery <i class="fa fa-chevron-right" aria-hidden="true"></i></a>
                    <ul class="dropdown-menu ">
                      <li class=""><a href="gallery-grid.html">Gallery Grid</a></li>
                      <li class=""><a href="gallery-masonry.html">Gallery Masonry</a></li>
                      <li class=""><a href="gallery-photo-slider.html">Photo Slider</a></li>
                    </ul>
                  </li>
                  <li class="dropdown dropdown-submenu ">
                    <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown">Destinations <i class="fa fa-chevron-right" aria-hidden="true"></i></a>
                    <ul class="dropdown-menu dropdown-menu-left">
                      <li class=""><a href="destination-cities.html">Destination Cities</a></li>
                      <li class=""><a href="destination-single-city.html">Single Destination</a></li>
                    </ul>
                  </li>
                  <li><a href="404.html">404 Not Found</a></li>
                  <li><a href="coming-soon.html">Coming Soon</a></li>
                </ul>
              </li>
              <li class="dropdown singleDrop ">
                <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Blog</a>
                <ul class="dropdown-menu dropdown-menu-right">
                  <li class="dropdown dropdown-submenu">
                    <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown">Blog Grid View <i class="fa fa-chevron-right" aria-hidden="true"></i></a>
                    <ul class="dropdown-menu">
                      <li class=""><a href="blog-grid-three-col.html">Blog Grid 3 Col</a></li>
                      <li class=""><a href="blog-grid-two-col.html">Blog Grid 2 Col</a></li>
                    </ul>
                  </li>
                  <li class="dropdown dropdown-submenu">
                    <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown">Blog List View <i class="fa fa-chevron-right" aria-hidden="true"></i></a>
                    <ul class="dropdown-menu">
                      <li class=""><a href="blog-list-right-sidebar.html">Blog List Right Sidebar</a></li>
                      <li class=""><a href="blog-list-left-sidebar.html">blog-list-left-sidebar.html</a></li>
                      <li class=""><a href="blog-list-fullwidth.html">Blog List Fullwidth</a></li>
                    </ul>
                  </li>
                  <li class="dropdown dropdown-submenu">
                    <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown">Single Blog Post <i class="fa fa-chevron-right" aria-hidden="true"></i></a>
                    <ul class="dropdown-menu">
                      <li class=""><a href="blog-single-right-sidebar.html">Right Sidebar</a></li>
                      <li class=""><a href="blog-single-left-sidebar.html">Left Sidebar</a></li>
                    </ul>
                  </li>
                </ul>
              </li>
              <li class="dropdown singleDrop ">
                <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Admin</a>
                <ul class="dropdown-menu dropdown-menu-right">
                  <li class=""><a href="dashboard.html">Dashboard</a></li>
                  <li class=""><a href="booking.html">Booking</a></li>
                  <li class=""><a href="profile.html">Profile</a></li>
                  <li class=""><a href="setting.html">Settings</a></li>
                  <li class=""><a href="" data-toggle="modal" data-target="#signup">Signup</a></li>
                  <li class=""><a href="" data-toggle="modal" data-target="#login">Login</a></li>
                </ul>
              </li>
              <li class="dropdown singleDrop ">
                <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Shortcodes</a>
                <ul class="dropdown-menu dropdown-menu-right">
                  <li class=""><a href="accordion-and-toggles.html">Accordions &amp; Toggles</a></li>
                  <li class=""><a href="tabs-and-dropdown.html">Tabs &amp; Dropdowns</a></li>
                  <li class=""><a href="pricing-table.html">Pricing Tables</a></li>
                </ul>
              </li>
              <li class="dropdown searchBox">
              <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="searchIcon"><i class="fa fa-search" aria-hidden="true"></i></span></a>
                <ul class="dropdown-menu dropdown-menu-right">
                  <li>
                    <span class="input-group">
                      <input type="text" class="form-control" placeholder="Search..." aria-describedby="basic-addon2">
                      <span class="input-group-addon" id="basic-addon2">Search</span>
                    </span>
                  </li>
                </ul>
              </li>
            </ul>
          </div>

        </div>
      </nav>
    </header>


<!-- PAGE TITLE -->
<section class="pageTitle" style="background-image:url(img/pages/page-title-bg12.jpg);">
  <div class="container">
    <div class="row">
      <div class="col-xs-12">
        <div class="titleTable">
          <div class="titleTableInner">
            <div class="pageTitleInfo">
              <h1>Marriott Hotel</h1>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

<!-- PAGE CONTENT -->
<section class="mainContentSection singleHotel">
  <div class="container">
    <div class="row">
      <div class="col-xs-12">
        <div id="package-carousel" class="carousel slide" data-ride="carousel">
          <ol class="carousel-indicators">
            <li data-target="#package-carousel" data-slide-to="0" class=""></li>
            <li data-target="#package-carousel" data-slide-to="1" class=""></li>
            <li data-target="#package-carousel" data-slide-to="2" class="active"></li>
          </ol>
          <div class="carousel-inner">
            <div class="item">
              <img alt="First slide" src="img/holets/hotel-slider-01.jpg">
            </div>
            <div class="item">
              <img alt="Second slide" src="img/holets/hotel-slider-02.jpg">
            </div>
            <div class="item active">
              <img alt="Third slide" src="img/holets/hotel-slider-03.jpg">
            </div>
          </div>
          <a class="left carousel-control" href="#package-carousel" data-slide="prev"><span class="glyphicon glyphicon-menu-left"></span></a>
          <a class="right carousel-control" href="#package-carousel" data-slide="next"><span class="glyphicon glyphicon-menu-right"></span></a>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-xs-12">
        <div class="description-aria">
          <div class="sectionTitle2">
            <h2>description</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip  commodo consequat. Duis aute irure dolor in reprehenderit</p>
          </div>
          <div class="row">
            <div class="col-xs-12 col-sm-6">
              <ul class="descriptionList">
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Cras tincidunt mi a sodales pulvinar.</li>
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Mauris in libero sodales ultrices purus</li>
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Quisque vulputate enim eu fringilla.</li>
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Eleifend mi vel nisl lobortis nec tincidunt</li>
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Mauris in libero sodales ultrices purus</li>
              </ul>
            </div>
            <div class="col-xs-12 col-sm-6">
              <ul class="descriptionList">
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Praesent nec nisl iaculis, pulvinar nunc.</li>
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Sed at erat lacinia, condimentum eros non</li>
                <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Mauris in libero sodales ultrices purus at</li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-xs-12">
        <div class="rooms-types-aria">
          <div class="sectionTitle2">
            <h2>rooms types</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
          </div>
          <div class="roomCategory">
            <div class="sub-title">
              <h4>Double Room</h4>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip  commodo consequat. Duis aute irure dolor in reprehenderit</p>
            </div>
            <div class="row">
              <div class="col-xs-12 col-sm-9">
                <ul class="roomAdvantage">
                  <li><a href="#"><img src="img/packages/shape-icon-1.png" alt="Image">Breakfast</a></li>
                  <li><a href="#"><img src="img/packages/shape-icon-2.png" alt="Image">Plasma TV</a></li>
                  <li><a href="#"><img src="img/packages/shape-icon-3.png" alt="Image">Free wifi</a></li>
                </ul>
              </div>
              <div class="col-xs-12 col-sm-3">
                <div class="roomRate">
                  Per Night: <span>$150</span>
                </div>
              </div>
            </div>
            <div class="roomGellary">
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-01.jpg">
                  <img src="img/holets/hotel-list-01.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-02.jpg">
                  <img src="img/holets/hotel-list-02.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-03.jpg">
                  <img src="img/holets/hotel-list-03.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-04.jpg">
                  <img src="img/holets/hotel-list-04.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-05.jpg">
                  <img src="img/holets/hotel-list-05.jpg" alt="Double Room">
                </a>
              </div>
            </div>
          </div>
          <hr>
          <div class="roomCategory">
            <div class="sub-title">
              <h4>Single Room</h4>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip  commodo consequat. Duis aute irure dolor in reprehenderit</p>
            </div>
            <div class="row">
              <div class="col-xs-12 col-sm-9">
                <ul class="roomAdvantage">
                  <li><a href="#"><img src="img/packages/shape-icon-1.png" alt="Image">Breakfast</a></li>
                  <li><a href="#"><img src="img/packages/shape-icon-2.png" alt="Image">Plasma TV</a></li>
                  <li><a href="#"><img src="img/packages/shape-icon-3.png" alt="Image">Free wifi</a></li>
                </ul>
              </div>
              <div class="col-xs-12 col-sm-3">
                <div class="roomRate">
                  Per Night: <span>$150</span>
                </div>
              </div>
            </div>
            <div class="roomGellary">
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-03.jpg">
                  <img src="img/holets/hotel-list-03.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-06.jpg">
                  <img src="img/holets/hotel-list-06.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-07.jpg">
                  <img src="img/holets/hotel-list-07.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-08.jpg">
                  <img src="img/holets/hotel-list-08.jpg" alt="Double Room">
                </a>
              </div>
              <div class="single-item">
                <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-09.jpg">
                  <img src="img/holets/hotel-list-09.jpg" alt="Double Room">
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-xs-12">
        <div class="location-aria">
          <div class="sectionTitle2">
            <h2>Location</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
          </div>
          <div class="google-maps">
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12097.002861286059!2d-74.01154310416635!3d40.71249695811257!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew+York%2C+NY!5e0!3m2!1sen!2s!4v1502716241862" width="100%" height="400px" scrolling="no" frameborder="0" style="border:0" allowfullscreen></iframe>
          </div>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-xs-12">
        <div class="review-aria">
          <div class="sectionTitle2">
            <h2>Reviews</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
          </div>
          <div class="reviewContent">
            <h3 class="reviewTitle">
              Reviews (3)
              <span>
                <i class="fa fa-star" aria-hidden="true"></i>
                <i class="fa fa-star" aria-hidden="true"></i>
                <i class="fa fa-star" aria-hidden="true"></i>
                <i class="fa fa-star" aria-hidden="true"></i>
                <i class="fa fa-star-o" aria-hidden="true"></i>
              </span>
            </h3>

            <div class="reviewMedia">
              <ul class="media-list">
                <li class="media">
                  <div class="media-left">
                    <a href="#">
                      <img class="media-object" src="img/blog/comments-02.jpg" alt="Image">
                    </a>
                  </div>
                  <div class="media-body">
                    <h5 class="media-heading">Jessica Brown</h5>
                    <span>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star" aria-hidden="true"></i>
                    </span>
                    <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudan totam rem ape riam</p>
                  </div>
                </li>
                <li class="media">
                  <div class="media-left">
                    <a href="#">
                      <img class="media-object" src="img/blog/comments-01.jpg" alt="Image">
                    </a>
                  </div>
                  <div class="media-body">
                    <h5 class="media-heading">Jessica Brown</h5>
                    <span>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star-o" aria-hidden="true"></i>
                      <i class="fa fa-star-o" aria-hidden="true"></i>
                    </span>
                    <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudan totam rem ape riam</p>
                  </div>
                </li>
                <li class="media">
                  <div class="media-left">
                    <a href="#">
                      <img class="media-object" src="img/blog/comments-03.jpg" alt="Image">
                    </a>
                  </div>
                  <div class="media-body">
                    <h5 class="media-heading">Jessica Brown</h5>
                    <span>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star" aria-hidden="true"></i>
                      <i class="fa fa-star-o" aria-hidden="true"></i>
                      <i class="fa fa-star-0" aria-hidden="true"></i>
                      <i class="fa fa-star-o" aria-hidden="true"></i>
                    </span>
                    <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudan totam rem ape riam</p>
                  </div>
                </li>
              </ul>
            </div>
            <form action="" method="POST" role="form" class="commentsForm">
              <h3 class="reviewTitle">Leave your review</h3>
              <p>Want to Rate it? <span>
                <i class="fa fa-star" aria-hidden="true"></i>
                <i class="fa fa-star" aria-hidden="true"></i>
                <i class="fa fa-star-o" aria-hidden="true"></i>
                <i class="fa fa-star-0" aria-hidden="true"></i>
                <i class="fa fa-star-o" aria-hidden="true"></i>
              </span></p>
              <div class="row">
                <div class="col-xs-12">
                  <div class="form-group">
                    <textarea class="form-control" rows="3" placeholder="Comment"></textarea>
                  </div>
                </div>
              </div>
              <button type="submit" class="btn buttonCustomPrimary">submit</button>
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

<!-- RELATED SECTION -->
<section class="relatedSection">
  <div class="container">
    <div class="row">
      <div class="col-xs-12">
        <div class="sectionTitle2">
          <h2>you may also like</h2>
        </div>
      </div>
      <div class="row">
        <div class="col-sm-6 col-lg-4 col-xs-12">
          <div class="thumbnail deals hotelgrid">
            <img src="img/holets/hotel-list-01.jpg" alt="deal-image">
            <a href="single-hotel-right-sidebar.html" class="pageLink"></a>
            <div class="discountInfo discountCol-3">
              <ul class="list-inline rating homePage">
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
              </ul>
              <ul class="list-inline dates">
                <li>4 review</li>
              </ul>
            </div>
            <div class="caption">
              <h4><a href="single-hotel-right-sidebar.html" class="captionTitle">The Rookery Hotel</a></h4>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
              <div class="detailsInfo">
                <h5>
                  <span>Start From</span>
                  $40
                </h5>
                <ul class="list-inline detailsBtn">
                  <li><a href='booking-1.html' class="btn buttonTransparent">Book now</a></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
        <div class="col-sm-6 col-lg-4 col-xs-12">
          <div class="thumbnail deals hotelgrid">
            <img src="img/holets/hotel-list-02.jpg" alt="deal-image">
            <a href="single-hotel-right-sidebar.html" class="pageLink"></a>
            <div class="discountInfo discountCol-3">
              <ul class="list-inline rating homePage">
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
              </ul>
              <ul class="list-inline dates">
                <li>3 review</li>
              </ul>
            </div>
            <div class="caption">
              <h4><a href="single-hotel-right-sidebar.html" class="captionTitle">The Rookery Hotel</a></h4>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
              <div class="detailsInfo">
                <h5>
                  <span>Start From</span>
                  $35
                </h5>
                <ul class="list-inline detailsBtn">
                  <li><a href='booking-1.html' class="btn buttonTransparent">Book now</a></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
        <div class="col-sm-6 col-lg-4 col-xs-12">
          <div class="thumbnail deals hotelgrid">
            <img src="img/holets/hotel-list-03.jpg" alt="deal-image">
            <a href="single-hotel-right-sidebar.html" class="pageLink"></a>
            <div class="discountInfo discountCol-3">
              <ul class="list-inline rating homePage">
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                <li><i class="fa fa-star" aria-hidden="true"></i></li>
              </ul>
              <ul class="list-inline dates">
                <li>5 review</li>
              </ul>
            </div>
            <div class="caption">
              <h4><a href="single-hotel-right-sidebar.html" class="captionTitle">The Rookery Hotel</a></h4>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
              <div class="detailsInfo">
                <h5>
                  <span>Start From</span>
                  $40
                </h5>
                <ul class="list-inline detailsBtn">
                  <li><a href='booking-1.html' class="btn buttonTransparent">Book now</a></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

<!-- FOOTER -->
<footer>
  <div class="footer clearfix">
    <div class="container">
      <div class="row">
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent">
            <a href="index.html" class="footer-logo"><img src="img/logo-color-sm.png" alt="footer-logo"></a>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute </p>
          </div>
        </div>
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent">
            <h5>contact us</h5>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do eiusmod.</p>
            <ul class="list-unstyled">
              <li><i class="fa fa-home" aria-hidden="true"></i>61 Park Street, Fifth Avenue, NY</li>
              <li><i class="fa fa-phone" aria-hidden="true"></i>[88] 657 524 332</li>
              <li><i class="fa fa-envelope-o" aria-hidden="true"></i><a href="mailTo:info@star-travel.com">info@star-travel.com</a></li>
            </ul>
          </div>
        </div>
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent imgGallery">
            <h5>Gallery</h5>
            <div class="row">
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-1.jpg"><img src="img/home/gallery/thumb-gallery-1.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-2.jpg"><img src="img/home/gallery/thumb-gallery-2.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-3.jpg"><img src="img/home/gallery/thumb-gallery-3.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-4.jpg"><img src="img/home/gallery/thumb-gallery-4.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-5.jpg"><img src="img/home/gallery/thumb-gallery-5.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-6.jpg"><img src="img/home/gallery/thumb-gallery-6.jpg" alt="image"></a>
              </div>
            </div>
          </div>
        </div>
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent">
            <h5>newsletter</h5>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do. </p>
            <div class="input-group">
              <input type="text" class="form-control" placeholder="Enter your email" aria-describedby="basic-addon21">
              <span class="input-group-addon" id="basic-addon21"><i class="fa fa-long-arrow-right" aria-hidden="true"></i></span>
            </div>
            <ul class="list-inline">
              <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-pinterest-p" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-vimeo" aria-hidden="true"></i></a></li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class="copyRight clearfix">
    <div class="container">
      <div class="row">
        <div class="col-sm-6 col-sm-push-6 col-xs-12">
          <ul class="list-inline">
            <li><a href="#">Privacy Policy</a></li>
            <li><a href="#">About Us</a></li>
            <li><a href="#">Support</a></li>
            <li><a href="#">Blog</a></li>
          </ul>
        </div>
        <div class="col-sm-6 col-sm-pull-6 col-xs-12">
          <div class="copyRightText">
            <p>Copyright © 2016. All Rights Reserved by <a target="_blank" href="http://www.iamabdus.com/">Abdus</a>.</p>
          </div>
        </div>
      </div>
    </div>
  </div>
</footer>
</div>

<!-- Signup Modal -->
<div class="modal fade signupLoging" id="signup" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content modalContentCustom">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Create your account</h4>
      </div>
      <div class="modal-body">
        <form method="post" action="">
          <div class="form-group">
            <input type="text" class="form-control bg-ash" id="exampleInputEmail1" placeholder="Full Name">
          </div>
          <div class="form-group">
            <input type="email" class="form-control bg-ash" id="exampleInputPassword1" placeholder="Email">
          </div>
          <div class="form-group">
            <input type="password" class="form-control bg-ash" id="exampleInputPassword1" placeholder="Password">
          </div>
          <div class="checkbox">
            <label>
              <input type="checkbox"> I agree to the terms of use and privacy.
            </label>
          </div>
          <button type="submit" class="btn btn-default">Login</button>
        </form>
        <div class="or">
          or
        </div>
        <a class="btn btn-default btnSocial"  href="#">Log in with facebook</a>
      </div>

      <div class="modal-footer">
          <div class="dontHaveAccount">
            <p>Don’t have an Account?<a href=""> Sign up</a></p>
          </div>
      </div>
    </div>
  </div>
</div>

<!-- Login Modal -->
<div class="modal fade signupLoging" id="login" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content modalContentCustom">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Log in to your account</h4>
      </div>
      <div class="modal-body">
        <form method="post" action="">
          <div class="form-group">
            <input type="email" class="form-control bg-ash" id="exampleInputPassword1" placeholder="Email">
          </div>
          <div class="form-group">
            <input type="password" class="form-control bg-ash" id="exampleInputPassword1" placeholder="Password">
          </div>
          <div class="checkbox">
            <label>
              <input type="checkbox"> Remember me
            </label>
            <a class="forgotPass clerfix" href="">Fogot Password?</a>
          </div>
          <button type="submit" class="btn btn-default">Login</button>
        </form>
        <div class="or">
          or
        </div>
        <a class="btn btn-default btnSocial"  href="#">Log in with facebook</a>
      </div>

      <div class="modal-footer">
          <div class="dontHaveAccount">
            <p>Don’t have an Account?<a href=""> Sign up</a></p>
          </div>
      </div>
    </div>
  </div>
</div>

<!-- JAVASCRIPTS -->
 <script src="ccss/star-1-3/Static%20HTML/plugins/jquery/jquery-2.2.4.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/jquery/jquery-migrate-1.2.1.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/jquery-ui/jquery-ui.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/bootstrap/js/bootstrap.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/revolution/js/jquery.themepunch.tools.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/revolution/js/jquery.themepunch.revolution.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/selectbox/jquery.selectbox-0.1.3.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/datepicker/bootstrap-datepicker.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/jquery/waypoints.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/counter-up/jquery.counterup.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/isotope/isotope.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/isotope/jquery.fancybox.pack.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/isotope/isotope-triger.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/countdown/jquery.syotimer.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/plugins/slick/slick.min.js"></script>
    <script src="ccss/star-1-3/Static%20HTML/js/custom.js"></script>

</body>

</html>