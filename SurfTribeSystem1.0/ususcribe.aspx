<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ususcribe.aspx.cs" Inherits="SurfTribeSystem1._0.ususcribe" %>


<!DOCTYPE html>
<html>
<head runat="server">


    <!-- SITE TITTLE -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Surf Tribe System</title>

    <!-- PLUGINS CSS STYLE -->
    <link href="ccss/star-1-3/Static HTML/plugins/jquery-ui/jquery-ui.css" rel="stylesheet">
    <link href="ccss/star-1-3/Static HTML/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="ccss/star-1-3/Static HTML/plugins/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static HTML/plugins/selectbox/select_option1.css">
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static HTML/plugins/datepicker/datepicker.css">
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static HTML/plugins/isotope/jquery.fancybox.css">
    <link rel="stylesheet" type="text/css" href="ccss/star-1-3/Static HTML/plugins/isotope/isotope.css">
    <link rel="stylesheet" href="ccss/star-1-3/Static HTML/plugins/slick/slick.css">
    <link rel="stylesheet" href="ccss/star-1-3/Static HTML/plugins/slick/slick-theme.css">
    <!-- REVOLUTION SLIDER -->
    <link rel="stylesheet" href="ccss/star-1-3/Static HTML/plugins/revolution/css/settings.css">
    <link rel="stylesheet" href="ccss/star-1-3/Static HTML/plugins/revolution/css/layers.css">
    <link rel="stylesheet" href="ccss/star-1-3/Static HTML/plugins/revolution/css/navigation.css">

    <!--esto es para los popup-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"></script>


    <!-- GOOGLE FONT -->
    <link href='https://fonts.googleapis.com/css?family=Montserrat:400,600,700' rel='stylesheet' type='text/css'>

    <!-- CUSTOM CSS -->
    <link href="ccss/star-1-3/Static HTML/css/style.css" rel="stylesheet">
    <link rel="stylesheet" href="ccss/star-1-3/Static HTML/css/colors/default.css" id="option_color">

    <!-- FAVICON -->
    <link rel="shortcut icon" type="image/png" href="ccss/star-1-3/Static%20HTML/img/favicon.png" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->



</head>
<body class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20171029-WA0010.jpeg); background-repeat: no-repeat; background-size: cover; position:relative">
    <header>
        <nav class="navbar navbar-default navbar-main navbar-fixed-top " role="navigation">
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
            </div>
        </nav>
    </header>

    <form runat="server">
        <div class="row" style="align-content: center; margin-left: 8%; margin-right: 8%">
            <div class=" col-xs-12 col-sm-12">
                <ul>
                    <li>
                        <h2 style="text-align: center">
                            <asp:Label runat="server" ID="tituloLabel" Text="Comentenos el motivo de su deseción de dejar nuestra página:" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>
                        <asp:TextBox class="form-control  bg-ashh" ID="correoText" runat="server" TextMode="Email" Width="30%" placeholder="Digite su correo" /><br />
                        <asp:TextBox ID="comentarioText" runat="server" class="form-control  bg-ashh" TextMode="MultiLine" Style="font-size: large"
                            Height="50%" Rows="6"></asp:TextBox>
                    </li>
                    <li>
                        <br />
                        <asp:Button runat="server" Text="Desinscribirme" class="btn btn-default" BackColor="DarkOrange"
                            ForeColor="White" Style="padding: 8px;" OnClick="Unnamed_Click" />

                        <asp:Button runat="server" Text="Salir" class="btn btn-default" BackColor="SaddleBrown"
                            ForeColor="White" Style="padding: 8px;" OnClick="Unnamed_Click1" />
                    </li>
                </ul>

            </div>
        </div>
    </form>
    <br />
    <br />


    <footer class="footer">
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
</body>
</html>
<script>
    $(document).ready(function () {
        function fix_height() {
            var h = $("#tray").height();
            $("#preview").attr("height", (($(window).height()) - h) + "px");
        }
        $(window).resize(function () { fix_height(); }).resize();
        //$("#preview").contentWindow.focus();
    });
</script>

<script async="" src="//widgets.getsitecontrol.com/46851/script.js"></script>
<script async="" src="https://www.google-analytics.com/analytics.js"></script>
<script src="plugins/jquery/jquery-2.2.4.min.js"></script>
<script src="plugins/jquery/jquery-migrate-1.2.1.min.js"></script>
<script src="plugins/jquery-ui/jquery-ui.min.js"></script>
<script src="plugins/bootstrap/js/bootstrap.min.js"></script>
<script src="plugins/revolution/js/jquery.themepunch.tools.min.js"></script>
<script src="plugins/revolution/js/jquery.themepunch.revolution.min.js"></script>
<script src="plugins/selectbox/jquery.selectbox-0.1.3.min.js"></script>
<script src="plugins/datepicker/bootstrap-datepicker.js"></script>
<script src="plugins/jquery/waypoints.min.js"></script>
<script src="plugins/counter-up/jquery.counterup.min.js"></script>
<script src="plugins/isotope/isotope.min.js"></script>
<script src="plugins/isotope/jquery.fancybox.pack.js"></script>
<script src="plugins/isotope/isotope-triger.js"></script>
<script src="plugins/countdown/jquery.syotimer.js"></script>
<script src="plugins/slick/slick.min.js"></script>
<script src="js/custom.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/jquery/jquery-2.2.4.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/jquery/jquery-migrate-1.2.1.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/jquery-ui/jquery-ui.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/bootstrap/js/bootstrap.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/revolution/js/jquery.themepunch.tools.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/revolution/js/jquery.themepunch.revolution.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/selectbox/jquery.selectbox-0.1.3.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/datepicker/bootstrap-datepicker.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/jquery/waypoints.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/counter-up/jquery.counterup.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/isotope/isotope.min.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/isotope/jquery.fancybox.pack.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/isotope/isotope-triger.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/countdown/jquery.syotimer.js"></script>
<script src="ccss/star-1-3/Static HTML/plugins/slick/slick.min.js"></script>
<script src="ccss/star-1-3/Static HTML/js/custom.js"></script>
