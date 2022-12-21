<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Dhmi.Web.en.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="tr-TR">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="Description" content="Republic of Turkey General Directorate Of State Airports Authority Call Center - 444 DHMI " />
    <meta name="robots" content="FOLLOW, INDEX" />
    <meta name="keywords" content="444 DHMI, 444 34 64, DHMİ Call Center, AssisTT, Karaman, Alo DHMİ" />
    <title>4443464 - 444DHMI</title>

    <!-- Bootstrap -->
    <link rel="stylesheet" type="text/css" href="../assets/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../assets/css/jasny-bootstrap.min.css" />
    <!-- Main Style -->
    <link rel="stylesheet" type="text/css" href="../assets/css/styles_SSS.css" />
    <link rel="stylesheet" type="text/css" href="../assets/css/main.css" />

    <!-- Responsive Style -->
    <link rel="stylesheet" type="text/css" href="../assets/css/responsive.css" />

    <!--Fonts-->
    <link rel="stylesheet" media="screen" href="../assets/fonts/font-awesome/font-awesome.min.css" />

    <!-- Extras -->
    <link rel="stylesheet" type="text/css" href="../assets/extras/animate.css" />
    <link rel="stylesheet" type="text/css" href="../assets/extras/lightbox.css" />
    <link rel="stylesheet" type="text/css" href="../assets/extras/owl/owl.carousel.css" />
    <link rel="stylesheet" type="text/css" href="../assets/extras/owl/owl.theme.css" />
    <link rel="stylesheet" type="text/css" href="../assets/extras/owl/owl.transitions.css" />


    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
                <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
                <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
              <![endif]-->

    <!-- Begin Inspectlet Embed Code -->
    <script type="text/javascript" id="inspectletjs">
        window.__insp = window.__insp || [];
        __insp.push(['wid', 278993838]);
        (function () {
            function __ldinsp() { var insp = document.createElement('script'); insp.type = 'text/javascript'; insp.async = true; insp.id = "inspsync"; insp.src = ('https:' == document.location.protocol ? 'https' : 'http') + '://cdn.inspectlet.com/inspectlet.js'; var x = document.getElementsByTagName('script')[0]; x.parentNode.insertBefore(insp, x); }
            if (window.attachEvent) {
                window.attachEvent('onload', __ldinsp);
            } else {
                window.addEventListener('load', __ldinsp, false);
            }
        })();
    </script>
    <!-- End Inspectlet Embed Code -->
</head>
<body>

    <!-- Header Section Start -->
    <div id="header">
        <div class="container">
            <div class="col-md-12 top-header">
                <div class="logo-menu">
                    <div class="logo pull-left wow fadeInDown animated" data-wow-delay=".2s">
                        <a href="index.aspx">
                            <img src="../assets/img/dhmi-logo.gif" alt="logo" width="60" /></a>
                    </div>
                    <div class="pull-right wow fadeInDown animated" data-wow-delay=".2">
                        <div id="menu" data-toggle="offcanvas" data-target=".navmenu" data-canvas="body">
                            <span>menu</span>
                        </div>
                    </div>
                </div>
                <div class="sidebar-nav">
                    <!-- navigation start -->
                    <div class="navmenu navmenu-default navmenu-fixed-right offcanvas" style="" id="navigation">
                        <a href="Index.aspx">
                            <img class="logo" src="../assets/img/airport.png" alt="logo" width="86"/></a>
                        <ul class="nav navmenu-nav">
                            <li class="active"><a href="#header">Home</a></li>
                            <li><a href="#works">APPLICATION INQUIRY</a></li>
                            <li><a href="#blog">FAQ</a></li>
                            <li><a href="#feedback">Contact Us</a></li>
                            <li><a href="../Account/Login.aspx">Contact Center</a></li>
                            <li><a href="../Index.aspx">Türkçe</a></li>
                        </ul>
                    </div>
                    <!-- navigation End -->
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="banner text-center">
                        <h1 class="wow fadeInDown animated" data-wow-delay=".8s">DHMI Call Center</h1>
                        <h2 class="wow fadeInDown animated" data-wow-delay=".6s">4443464 - 444DHMI</h2>
                        <a href="#works" class="btn btn-border lg wow fadeInLeft animated animated" data-wow-delay="1.0s" style="visibility: visible; -webkit-animation-delay: 1.0s; -moz-animation-delay: 1.0s; animation-delay: 1.0s;">Application Inquiry</a>
                        <a href="#blog" class="btn btn-common lg wow fadeInRight animated animated" data-wow-delay="1.0s" style="visibility: visible; -webkit-animation-delay: 1.0s; -moz-animation-delay: 1.0s; animation-delay: 1.0s;">FAQ</a>
                        <!--<a href="#" class="btn btn-border lg wow fadeInLeft animated" data-wow-delay="1.0s">Başvuru Sorgula</a>-->

                        <div class="scroll">
                            <a href="#works"><i class="fa fa-angle-down wow fadeInUp animated" data-wow-delay="1.2s"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Header Section End -->

    <!-- Work Section Start -->
    <section id="works">
        <div class="container">
            <div class="row">
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s">APPLICATION<br />
                    <span>INQUIRY</span></h1>
                <form id="basvuru" runat="server" name="basvuru">
                    <asp:ScriptManager ID="sm" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="uptBasvuru" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="btnSorgula" EventName="Click" />
                        </Triggers>
                        <ContentTemplate>
                            <div class="col-sm-6 col-md-6 wow fadeInLeft animated" data-wow-delay="1.4s">
                                <div class="input-group">
                                    <span class="input-group-addon"></span>
                                    <input type="text" class="form-control" placeholder="Passport Number" id="tckimlik" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div>
                                <div class="input-group">
                                    <span class="input-group-addon"></span>
                                    <input type="text" class="form-control" placeholder="Application Request Number" id="basvuruno" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div>

                                <div class="input-group">
                                    <span class="input-group-addon"></span>
                                    <input type="text" class="form-control" placeholder="Security Code" id="txtGuvenlik" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div>
                                <div class="input-group">
                                    <asp:Panel ID="Panel1" runat="server" BackImageUrl="../assets/img/sinav_arka.png" Height="60px" Enabled="False">
                                        <table>
                                            <tr>
                                                <td align="center" width="1000">
                                                    <label name="lblGuvenlik" id="lblGuvenlik" runat="server" title="123456" style="font-size: 32px; font-weight: bold; color: white;"></label>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </div>
                                <asp:Button ID="btnSorgula" runat="server" Text="Submit" CssClass="btn btn-green" OnClick="btnGonder_Click" />
                            </div>
                            <div id="divSonuc" runat="server" class="col-sm-4 col-md-4 col-md-offset-2 wow fadeInRight animated" data-wow-delay="1.4s">
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </form>
            </div>
        </div>
    </section>
    <!-- Work Section End  -->

    <!-- Skills Section Start -->
    <section id="skills">
        <div class="container">
            <div class="row">
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s">CALL CENTER<br/>
                    INCOMING<br/>
                    <span>APPLICATION</span></h1>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle one">
                            <div class="count-info">
                                <h3><span class="counter">98%</span></h3>
                                <h4>SATISFACTION</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle two">
                            <div class="count-info">
                                <h3><span class="counter">35%</span></h3>
                                <h4>SUGGESTION</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle three">
                            <div class="count-info">
                                <h3><span class="counter">10%</span></h3>
                                <h4>COMPLAINT</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle four">
                            <div class="count-info">
                                <h3><span class="counter">55%</span></h3>
                                <h4>REQUISITION</h4>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Skills Section End -->

    <!-- Blog Section Start-->
    <section id="blog">
        <div class="container">
            <div class="row">
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s">FREQUENTLY<br />
                    ASKED<br />
                    <span>QUESTION</span></h1>
                <div class="col-sm-12 col-md-12 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div id="faqSection">
                        <dl>
                            <dt class="opened"><span class="icon"></span>01 - What is 444 DHMI line? For what was it established?
                            </dt>
                            <dd style="display: block;">444 LINE all requests related to our Organization of the Airports Authority citizens, denunciations and complaints reach an easy way to relevant units to be directed from a single center of communication, citizens are established as soon as the return can be made and follow-up results. In this context, request from our citizens, denunciations and complaints are recorded by the field operator training organized by the General Directorate in this regard.
                            </dd>

                            <dt class="opened"><span class="icon"></span>02 - 444 DHMI line fee?
                            </dt>
                            <dd style="display: block;">444 DHMI line,  is charged against to the precarious denunciations and complaints and to busy outside its purpose. In this context, pricing agreements within the scope of the lowest rates is provided with Türk Telekom and GSM companies. You can also report your requests to the 444 DHMI line without payment by the ways of live support and mobile application in <b>iletisimmerkezi@dhmi.gov.tr, www.alo.dhmi.gov.tr</b> addresses.
                            </dd>

                            <dt class="opened"><span class="icon"></span>03 - How does 444 DHMI line work?
                            </dt>
                            <dd style="display: block;">Your records are created if you share the name and address informations about the corporation which you want to denounce- complain and the product informations you complain about.
                            </dd>

                            <dt class="opened"><span class="icon"></span>04 - How citizens informed about the results of the requests made to 444 DHMI line?
                            </dt>
                            <dd style="display: block;">The requests that are created by the way of e-mail are sent as e-mail. In the records you create via telephone your request number is transferred orally. In case of transferring Passport Number, you can follow your registration with your Passport Number and Request Number in the address of www.alo.dhmi.gov.tr. In addition, ın case you declare the e-mail address/GSM number, an information message sent to your e-mail address and/or GSM number about the result of your registration.
                            </dd>

                            <dt class="opened"><span class="icon"></span>05 - Can I register a complaint entry without forwarding my personal informations?
                            </dt>
                            <dd style="display: block;">No
                            </dd>

                            <dt class="opened"><span class="icon"></span>06 - Does my personal informations are shared with anyone else during I create a record?
                            </dt>
                            <dd style="display: block;">The personal informations you have given are not be shared with the third parties.
                            </dd>

                            <dt class="opened"><span class="icon"></span>07 - How long it takes to result my request?
                            </dt>
                            <dd style="display: block;">The time of termination of applications is an average of 5 days. However, this process can be prolonged in the case of taking sample about request or in the case of given time to company.
                            </dd>

                        </dl>

                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Blog Section End -->

    <!-- Feedback Section Start -->
    <section id="feedback">
        <div class="container">
            <div class="row">
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s"><span>Contact</span></h1>
                <div class="col-sm-6 col-md-6 wow fadeInLeft animated" data-wow-delay="1.4s">
                    <form action="" name="contact">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-user"></i></span>
                            <input type="text" name="name" id="name" class="form-control" placeholder="Name" />
                        </div>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-envelope-o"></i></span>
                            <input type="email" name="email" id="email" class="form-control" placeholder="Email" />
                        </div>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-fire"></i></span>
                            <input type="text" name="subject" id="subject" class="form-control" placeholder="Subject" />
                        </div>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-comments"></i></span>
                            <textarea name="message" id="message" class="form-control large" placeholder="Message"></textarea>
                        </div>
                        <button class="btn btn-green" onclick="mailGonder()"><i class="fa fa-envelope-o"></i>Send</button>
                    </form>
                </div>
                <div class="col-sm-4 col-md-4 col-md-offset-2 wow fadeInRight animated" data-wow-delay="1.4s">
                    <div class="address">
                        <h2>Contacts</h2>
                        <ul class="contact-info">
                            <li><i class="fa fa-mobile"></i>444 3464[DHMI] </li>
                            <li><i class="fa fa-envelope-o"></i>iletisimmerkezi@dhmi.gov.tr</li>
                        </ul>

                        <h2>Follow Us</h2>
                        <ul class="social-icon">
                            <li><a href="https://www.facebook.com/dhmi.gov.tr"><i class="fa fa-facebook"></i></a></li>
                            <li><a href="https://twitter.com/dhmikurumsal"><i class="fa fa-twitter"></i></a></li>
                            <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
                            <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                            <li><a href="#"><i class="fa fa-youtube"></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Feedback Section End -->

    <!-- Footer section Start -->
    <footer id="footer">
        <div class="container">
            <div class="row">
                <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
                    <div class="copyright wow fadeInUp animated" data-wow-delay=".8s">
                        <p>&copy; 2015 Republic of Turkey General Directorate Of State Airports Authority. All rights reserved.</p>
                    </div>
                </div>
                <div class="col-lg-2 col-md-2 col-sm-2 col-xs-12">
                    <div class="scroll-top text-center wow fadeInUp animated" data-wow-delay=".6s">
                        <a href="#header"><i class="fa fa-chevron-circle-up fa-2x"></i></a>
                    </div>
                </div>
                <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
                    <%--  <p class="text-center wow fadeInUp animated" data-wow-delay=".8s"><a href="http://www.assistt.com.tr">AssisTT</a> tarafından geliştirilmiştir.</p>--%>
                </div>
            </div>
        </div>
    </footer>
    <!-- Footer section End -->

    <!-- jQuery Load -->
    <script src="../assets/js/jquery-min.js"></script>
    <!-- Bootstrap JS -->
    <script src="../assets/js/bootstrap.min.js"></script>
    <!-- WOW JS plugin for animation -->
    <script src="../assets/js/wow.js"></script>
    <!-- All JS plugin Triggers -->
    <script src="../assets/js/main.js"></script>
    <!-- Smooth scroll -->
    <script src="../assets/js/smooth-scroll.js"></script>
    <!--  -->
    <script src="../assets/js/jasny-bootstrap.min.js"></script>
    <!-- Counterup -->
    <script src="../assets/js/jquery.counterup.min.js"></script>
    <!-- waypoints -->
    <script src="../assets/js/waypoints.min.js"></script>
    <!-- circle progress -->
    <script src="../assets/js/circle-progress.js"></script>
    <!-- owl carousel -->
    <script src="../assets/js/owl.carousel.js"></script>
    <!-- lightbox -->
    <script src="../assets/js/lightbox.min.js"></script>

    <script src="../assets/js/index-en.js"></script>
    <script src="../assets/js/SSS_script.js"></script>
    <script src="../assets/js/SSS_jquery.min.js"></script>

    <!-- Yandex.Metrika informer -->
    <a href="https://metrica.yandex.com.tr/stat/?id=28993135&amp;from=informer"
        target="_blank" rel="nofollow">
        <img src="//bs.yandex.ru/informer/28993135/3_1_FFFFFFFF_EFEFEFFF_0_pageviews"
            style="width: 1px; height: 1px; border: 0;" alt="Yandex.Metrica" title="Yandex.Metrica: bugünün verileri (gösterimler, ziyaretler ve tekil ziyaretçiler)" onclick="try{Ya.Metrika.informer({i:this,id:28993135,lang:'tr'});return false}catch(e){}" /></a>
    <!-- /Yandex.Metrika informer -->

    <!-- Yandex.Metrika counter -->
    <script type="text/javascript">
        (function (d, w, c) {
            (w[c] = w[c] || []).push(function () {
                try {
                    w.yaCounter28993135 = new Ya.Metrika({
                        id: 28993135,
                        webvisor: true,
                        clickmap: true,
                        trackLinks: true,
                        accurateTrackBounce: true
                    });
                } catch (e) { }
            });

            var n = d.getElementsByTagName("script")[0],
                s = d.createElement("script"),
                f = function () { n.parentNode.insertBefore(s, n); };
            s.type = "text/javascript";
            s.async = true;
            s.src = (d.location.protocol == "https:" ? "https:" : "http:") + "//mc.yandex.ru/metrika/watch.js";

            if (w.opera == "[object Opera]") {
                d.addEventListener("DOMContentLoaded", f, false);
            } else { f(); }
        })(document, window, "yandex_metrika_callbacks");
    </script>
    <noscript><div><img src="//mc.yandex.ru/watch/28993135" style="position:absolute; left:-9999px;" alt="" /></div></noscript>
    <!-- /Yandex.Metrika counter -->
</body>
</html>
