﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defaultSinLogeoUN.aspx.cs" Inherits="SurfTribeSystem1._0.defaultSinLogeo" %>

<!DOCTYPE html>

<html lang="en-us">


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

    <!--esto es para los popup-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"></script>

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


<body class="body-wrapper  changeHeader ">
    <form id="f1" runat="server">
        <div class="main-wrapper">

            <!-- HEADER -->
            <header>
                <nav class="navbar navbar-default navbar-main navbar-fixed-top    " role="navigation">
                    <div class="container">

                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>
                            <a class="navbar-brand" href="defaultSinLogeoUN.aspx"></a>
                        </div>

                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div class="collapse navbar-collapse navbar-ex1-collapse">
                            <ul class="nav navbar-nav navbar-right">
                                <li class="dropdown singleDrop active">
                                    <a href="defaultSinLogeoUN.aspx">Inicio </a>

                                </li>
                                <li class="dropdown megaDropMenu ">
                                    <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown" data-delay="300" data-close-others="true" aria-expanded="false">Escuelas</a>
                                    <ul class="row dropdown-menu">
                                        <li class="col-sm-4 col-xs-12">
                                            <ul class="list-unstyled">
                                                <li>Guanacaste</li>
                                                <asp:Repeater ID="GuanaRepeat" runat="server">
                                                    <ItemTemplate>
                                                        <li class="">
                                                            <a href='paginaEscuela.aspx?idEscuela=<%# Eval("Nombre") %>'>
                                                                <asp:Label runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                                            </a>

                                                        </li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </li>
                                        <li class="col-sm-4 col-xs-12">
                                            <ul class="list-unstyled">
                                                <li>Puntarenas</li>
                                                <asp:Repeater ID="PuertoRepeat" runat="server">
                                                    <ItemTemplate>
                                                        <li class="">
                                                            <a href='paginaEscuela.aspx?idEscuela=<%# Eval("Nombre") %>'>
                                                                <asp:Label runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                                            </a>

                                                        </li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </li>
                                        <li class="col-sm-4 col-xs-12">
                                            <ul class="list-unstyled">
                                                <li>Limón</li>
                                                <asp:Repeater ID="LimonRepeat" runat="server">
                                                    <ItemTemplate>
                                                        <li class="">
                                                            <a href='paginaEscuela.aspx?idEscuela=<%# Eval("Nombre") %>'>
                                                                <asp:Label runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                                            </a>

                                                        </li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                               
                                <li class="dropdown singleDrop ">
                                    <a href="javascript:void(0)" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Información</a>
                                    <ul class="dropdown-menu dropdown-menu-right">

                                       <li class=""><a href="eventos.aspx">Próximos eventos</a></li>
                                        <li class=""><a href="FAQlistado.aspx">Preguntas Frecuentes</a></li>
                                        <li class=""><a href="InformacionGeneral.aspx">Información General</a></li>
                                        <li class=""><a href="TérminosCondiciones.aspx">Términos y Condiciones</a></li>



                                    </ul>
                                </li>
                              
                               <li class="dropdown searchBox">
                                   <a id="tiro5" data-toggle="modal" data-target="#login" class="btn buttonTransparent"><span class="searchIcon">Reserva!!</span></a>
                                 
                                </li>

                                <li>
                                    <br />
                                    <div class="headerTopNav" style="cursor: pointer;">
                                        <ul class="headerTopNavbar">

                                            <li class="active"><a href="#"><i class="fa " aria-hidden="true"></i></a></li>
                                        </ul>
                                        <ul class="headerTopNavbar navbar-right">
                                            <li class="active"><a id="tiro" data-toggle="modal" data-target="#login"><i class="fa fa-user" aria-hidden="true">&nbsp;&nbsp;</i>Iniciar Sesión </a></li>

                                        </ul>
                                    </div>

                                </li>


                            </ul>
                        </div>

                    </div>
                </nav>
            </header>


            <!-- BANNER -->
            <section class="bannercontainer">

                <div id="rev_slider_wrapper1" class="rev_slider_wrapper fullscreen-container" data-alias="christmas-snow-scene" data-source="gallery" style="background-color: transparent; padding: 0px;">
                    <!-- START REVOLUTION SLIDER 5.4.1 fullscreen mode -->
                    <div id="rev_slider_container" class="rev_slider custom_rev_slider fullscreenbanner" style="display: none;" data-version="5.4.1">

                        <ul>
                            <asp:Repeater ID="galeria" runat="server">
                                <ItemTemplate>
                                    <li data-transition="parallaxvertical">

                                        <!-- SLIDE 2 -->

                                        <!-- MAIN IMAGE -->
                                        <img src='data:image/jpg;base64,<%# Eval("Imgs") %>' alt="slidebg1" data-bgparallax='<%# Eval("Num") %>' class="rev-slidebg" data-no-retina="" />

                                        <!-- LAYERS -->

                                        <!-- LAYER NR. 1 -->
                                        <div class="tp-caption tp-resizeme slide-layer-2" id="slide-layer-2"
                                            data-x="center" data-hoffset=""
                                            data-y="center" data-voffset="-50"
                                            data-width="['auto']"
                                            data-height="['auto']"
                                            data-type="text"
                                            data-responsive_offset="on"
                                            data-frames='[{"delay":1000,"speed":800,"frame":"0","from":"y:-50px;opacity:0;","to":"o:1;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"auto:auto;","ease":"Power3.easeInOut"}]'
                                            data-textalign="['center']"
                                            data-fontsize="['64', '54', '44', '34']"
                                            data-color="#fff"
                                            data-fontweight="bold"
                                            style="z-index: 1; text-transform: uppercase;">
                                            <asp:Label Text='<%# Eval("Titulo") %>' runat="server"></asp:Label>
                                        </div>

                                        <!-- LAYER NR. 2 -->

                                        <div class="tp-caption tp-resizeme slide-layer-2" id="slide-layer-2"
                                            data-x="center" data-hoffset="0"
                                            data-y="center" data-voffset="20"
                                            data-width="['auto']"
                                            data-height="['auto']"
                                            data-type="text"
                                            data-responsive_offset="on"
                                            data-frames='[{"delay":1200,"speed":1000,"frame":"0","from":"y:-50px;opacity:0;","to":"o:1;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"auto:auto;","ease":"Power3.easeInOut"}]'
                                            data-textalign="['center']"
                                            data-fontsize="['24', '24', '24', '24']"
                                            data-color="#fff"
                                            data-visibility="['on','on','off','off']"
                                            style="z-index: 1;">
                                            <asp:Label Text='<%# Eval("Leyenda") %>' runat="server"></asp:Label>

                                        </div>

                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <!-- END REVOLUTION SLIDER -->
                </div>
            </section>


            <!-- Titulo -->
            <section class="darkSection">
                <center>
                                <h1>
                                    <span style="color: darkorange;position:center">Bienvenidos a la comunidad SURF TRIBE Costa Rica</span>

                                </h1>
                            </center>
            </section>

            <!-- TOP DEALS -->
            <section class="mainContentSection packagesSection">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="sectionTitle">
                                <h2><span class="lightBg">Nuestras funciones</span></h2>
                                <p style="color:saddlebrown">Cada escuela posee las mismas funciones básicas.</p>
                            </div>
                        </div>
                    </div>
                    <div class="row">

                        <div class="col-sm-4 col-xs-12">
                            <div class="thumbnail deals">
                                <img src="Imagenes/20180603_160427.jpg" alt="deal-image" />
                                <a class="pageLink"></a>

                                <div class="caption">
                                    <h4><a href="reservaClases.aspx" class="captionTitle">Reserva de clases</a></h4>
                                    <p style="color:saddlebrown">Puedes reservar en la zona de su preferencia y escoger la escuela que guste.</p>
                                    <div class="detailsInfo">
                                        <ul class="list-inline detailsBtn">
                                            <li><a id="tiro2" data-toggle="modal" data-target="#login" class="btn buttonTransparent">Ir...</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-4 col-xs-12">
                            <div class="thumbnail deals">
                                <img src="Imagenes/20180610_135820.jpg" alt="deal-image" />
                                <a class="pageLink"></a>

                                <div class="caption">
                                    <h4><a href="ccss/star-1-3/Static HTML/single-package-fullwidth.html" class="captionTitle">Alquiler de tablas</a></h4>
                                    <p style="color:saddlebrown">Las escuelas tienen diferentes tipos de tablas, las cuales pueden ser alquiladas por cualquier persona.</p>
                                    <div class="detailsInfo">
                                        <ul class="list-inline detailsBtn">
                                            <li><a id="tiro3" data-toggle="modal" data-target="#login" class="btn buttonTransparent">Ir...</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-4 col-xs-12">
                            <div class="thumbnail deals">
                                <img src="Imagenes/20170423_095213.jpg" alt="deal-image" />
                                <a href="ccss/star-1-3/Static HTML/single-package-left-sidebar.html" class="pageLink"></a>

                                <div class="caption">
                                    <h4><a href="ccss/star-1-3/Static HTML/single-package-left-sidebar.html" class="captionTitle">Información</a></h4>
                                    <p style="color:saddlebrown">Le mostramos la informacion mas relevante de las escuelas.</p>
                                    <div class="detailsInfo">
                                        <ul class="list-inline detailsBtn">
                                            <li><a href="InformacionGeneral.aspx" class="btn buttonTransparent" style="color:saddlebrown">Ir...</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </section>

            <!-- PROMOTION PARALLAX -->
            <section class="promotionWrapper">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="promotionTable">
                                <div class="promotionTableInner">
                                    <div class="promotionInfo">
                                        <span>Preguntas frecuentes</span>
                                        <h2>Le mostramos las dudas más frecuentes en la página</h2>
                                        <a href="FAQlistado.aspx" class="btn buttonCustomPrimary">Ver preguntas</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

            <!-- DESTINATIONS -->
            <section class="whiteSection">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="sectionTitle">
                                <h2><span>Escuelas</span></h2>
                                <p style="color:saddlebrown">Informese de las diferentes escuelas de nuestra comunidad</p>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="media destinations">
                                <%-- <a class="media-left" href="ccss/star-1-3/Static HTML/destination-cities.html">
                                    <img class="media-object" src="Imagenes/PIC_20160827_140254.JPG" alt="Destination" />
                                </a>--%>
                                <div class="media-body">
                                    <h3 class="media-heading">Escoja
                                        <br />
                                        La escuela que desee</h3>
                                    <p >Visualize la información más relevante de cada escuela. Esta información es brindada por cada una de las escuelas. Puede ser de ayuda para la escongencia de la escuela que más se adecue a lo que ande buscando</p>
                                    <div class="clearfix">
                                        <ul class="list-unstyled">
                                            <li><i class="fa fa-minus" aria-hidden="true"></i>Guanacaste</li>
                                            <asp:Repeater ID="GuanaRepeat2" runat="server">
                                                <ItemTemplate>
                                                    <li class="">
                                                        <a href='paginaEscuela.aspx?idEscuela=<%# Eval("Nombre") %>'>
                                                            <asp:Label runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                                        </a>

                                                    </li>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </ul>

                                        <ul class="list-unstyled">
                                            <li><i class="fa fa-minus" aria-hidden="true"></i>Puntarenas</li>
                                            <asp:Repeater ID="PuertoRepeat2" runat="server">
                                                <ItemTemplate>
                                                    <li class="">
                                                        <a href='paginaEscuela.aspx?idEscuela=<%# Eval("Nombre") %>'>
                                                            <asp:Label runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                                        </a>

                                                    </li>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </ul>
                                        <ul class="list-unstyled">
                                            <li><i class="fa fa-minus" aria-hidden="true"></i>Limón</li>
                                            <asp:Repeater ID="LimonRepeat2" runat="server">
                                                <ItemTemplate>
                                                    <li class="">
                                                        <a href='paginaEscuela.aspx?idEscuela=<%# Eval("Nombre") %>'>
                                                            <asp:Label runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                                        </a>

                                                    </li>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </ul>

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

                                    <a class="hjk"></a>
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
                                <li><a href="TérminosCondiciones.aspx">Términos y condiciones</a></li>
                                <li><a href="InformacionGeneral.aspx">Información general</a></li>

                            </ul>
                        </div>
                        <div class="col-sm-6 col-sm-pull-6 col-xs-12">
                            <div class="copyRightText">
                                <p>Copyright © 2018. Todos los derechos reservados.</p>
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
                        <h4 class="modal-title" id="myModalLabel1">Create your account</h4>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <input type="text" class="form-control bg-ash" id="exampleInputEmail1" placeholder="Full Name" />
                        </div>
                        <div class="form-group">
                            <input type="email" class="form-control bg-ash" id="exampleInputPassword1" placeholder="Email" />
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control bg-ash" id="exampleInputPassword2" placeholder="Password" />
                        </div>
                        <div class="checkbox">
                            <label>
                                <input type="checkbox" />
                                I agree to the terms of use and privacy.
                            </label>
                        </div>
                        <button type="submit" class="btn btn-default">Login</button>
                        <div class="or">
                            or
                        </div>
                        <a class="btn btn-default btnSocial" href="#">Log in with facebook</a>
                    </div>

                    <div class="modal-footer">
                        <div class="dontHaveAccount">
                            <p>Don’t have an Account?<a href="registrarse.aspx"> Sign up</a></p>
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
                        <h4 class="modal-title" id="myModalLabel">INICIO DE SESIÓN</h4>
                    </div>
                    <div class="modal-body">
                        <asp:Panel ID="panelLogin" DefaultButton="ingresarButton" runat="server">
                            <div class="form-group">
                                <asp:TextBox TextMode="Email" ID="correoText" runat="server" class="form-control bg-ash" placeholder="Correo" />
                            </div>
                            <div class="form-group">
                                <asp:TextBox TextMode="Password" ID="claveText" runat="server" class="form-control bg-ash" placeholder="Clave" />
                            </div>
                        </asp:Panel>
                        <div class="checkbox">
                            <asp:Label ID="lblError" runat="server" Visible="false"></asp:Label>
                            <a class="forgotPass clerfix">Olvido su contraseña?</a><br />
                        </div>
                        <asp:Button ID="ingresarButton" class="btn btn-default" runat="server" Text="Ingresar" OnClick="ingresoButton_Click" />


                    </div>

                    <div class="modal-footer">
                        <div class="dontHaveAccount">
                            <p>Olvido su contraseña?<a href="registrarse.aspx"> Registrese</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>

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
