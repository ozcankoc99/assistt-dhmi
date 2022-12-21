<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Dhmi.Web.Index" ValidateRequest="true" %>

<%@ Register TagPrefix="aspx" Namespace="Recaptcha" Assembly="Recaptcha" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="tr-TR">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="Description" content="Devlet Hava Meydanları İşletmesi Genel Müdürlüğü İletişim Merkezi - 444 DHMI " />
    <meta name="robots" content="FOLLOW, INDEX" />
    <meta name="keywords" content="444 DHMI, 444 34 64, DHMİ İletişim Merkezi, AssisTT, Karaman, Alo DHMİ" />
    <title>4443464 - 444DHMI</title>

    <!-- Bootstrap -->
    <link rel="stylesheet" type="text/css" href="assets/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/css/jasny-bootstrap.min.css" />
    <!-- Main Style -->
    <link rel="stylesheet" type="text/css" href="assets/css/styles_SSS.css" />
    <link rel="stylesheet" type="text/css" href="assets/css/main.css" />

    <!-- Responsive Style -->
    <link rel="stylesheet" type="text/css" href="assets/css/responsive.css" />

    <!--Fonts-->
    <link rel="stylesheet" media="screen" href="assets/fonts/font-awesome/font-awesome.min.css" />

    <!-- Extras -->
    <link rel="stylesheet" type="text/css" href="assets/extras/animate.css" />
    <link rel="stylesheet" type="text/css" href="assets/extras/lightbox.css" />
    <link rel="stylesheet" type="text/css" href="assets/extras/owl/owl.carousel.css" />
    <link rel="stylesheet" type="text/css" href="assets/extras/owl/owl.theme.css" />
    <link rel="stylesheet" type="text/css" href="assets/extras/owl/owl.transitions.css" />


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

    <style>
        .guvenlikLabel {
            font-size: 32px;
            font-weight: bold;
            color: #0099FF;
        }
    </style>
</head>
<body>

    <!-- Header Section Start -->
    <div id="header">
        <div class="container">
            <div class="col-md-12 top-header">
                <div class="logo-menu">
                    <div class="logo pull-left wow fadeInDown animated" data-wow-delay=".2s">
                        <a href="index.aspx">
                            <img src="assets/img/dhmi-logo.gif" alt="logo" width="60" /></a>
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
                        <a href="index.aspx">
                            <img class="logo" src="assets/img/airport.png" alt="logo" width="86" /></a>
                        <ul class="nav navmenu-nav">
                            <li class="active"><a href="#header">Anasayfa</a></li>
                            <li><a href="#works">Başvuru Sorgula</a></li>
                            <li><a href="#blog">Sıkça Sorulan Sorular</a></li>
                            <li><a href="#feedback">İletişim</a></li>
                            <li><a href="Account/Login.aspx">İletişim Merkezi</a></li>
                            <li><a href="en/Index.aspx">ENGLISH</a></li>
                        </ul>
                        <!-- KKVK -->
                        <a class="btn btn-link btn-sm" style="color: white" data-toggle="modal" data-target="#kkvkmetni">KVKK Aydınlatma Metni</a>
                    </div>
                    <!-- navigation End -->
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="banner text-center">
                        <h1 class="wow fadeInDown animated" data-wow-delay=".8s">DHMİ İletişim Merkezi</h1>
                        <h2 class="wow fadeInDown animated" data-wow-delay=".6s">444 3464 <br />444 DHMI</h2>
                        <a href="#works" class="btn btn-border lg wow fadeInLeft animated animated" data-wow-delay="1.0s" style="visibility: visible; -webkit-animation-delay: 1.0s; -moz-animation-delay: 1.0s; animation-delay: 1.0s;">Başvuru Sorgula</a>
                        <a href="#blog" class="btn btn-common lg wow fadeInRight animated animated" data-wow-delay="1.0s" style="visibility: visible; -webkit-animation-delay: 1.0s; -moz-animation-delay: 1.0s; animation-delay: 1.0s;">Sıkça Sorulan Sorular</a>
                        <!--<a href="#" class="btn btn-border lg wow fadeInLeft animated" data-wow-delay="1.0s">Başvuru Sorgula</a>-->

                        <div class="scroll">
                            <a href="#works"><i class="fa fa-angle-down wow fadeInUp animated" data-wow-delay="1.2s"></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <!-- KKVK -->
        </div>
        <a href="#" style="position: absolute; right: 10px;" class="btn btn-link btn-sm" data-toggle="modal" data-target="#kkvkmetni">KVKK Aydınlatma Metni</a>
    </div>
    <!-- Header Section End -->

    <!-- Work Section Start -->
    <section id="works">
        <div class="container">
            <div class="row">
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s">Başvuru<br />
                    <span>Sorgula</span></h1>
                <form id="basvuru" runat="server">
                    <asp:ScriptManager ID="sm" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="uptBasvuru" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="btnSorgula" EventName="Click" />
                        </Triggers>
                        <ContentTemplate>
                            <div class="col-sm-6 col-md-6 wow fadeInLeft animated" data-wow-delay="1.4s">
                                <h4>Tc Kimlik Numarası veya Eposta Adresi bildirimi zorunludur.</h4>
                                <div class="input-group">
                                    <span class="input-group-addon"></span>
                                    <input type="text" class="form-control" placeholder="Tc Kimlik Numarası" id="tckimlik" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div>
                                <div class="input-group">
                                    <span class="input-group-addon"></span>
                                    <input type="text" class="form-control" placeholder="Eposta Adresi" id="eposta" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div>
                                <div class="input-group">
                                    <span class="input-group-addon"></span>
                                    <input type="text" class="form-control" placeholder="Başvuru Numarası" id="basvuruno" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div>
                                <div class="input-group">
                                    <span class="input-group-addon"></span>
                                    <input type="text" class="form-control" placeholder="Güvenlik Kodu" id="txtGuvenlik" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </div>
                                <div class="input-group">
                                    <%--<aspx:RecaptchaControl id="recaptcha" runat="server" theme="clean" CssClass="form-control"
                                        publickey="6LfbsgMTAAAAALoj_Zdvi2zmX1EzGZH9aSb7Qm1G"
                                        privatekey="6LfbsgMTAAAAAP3A11V3vVhLeP88US7UJ6JfCbnG" />--%>
                                    <asp:Panel ID="Panel1" runat="server" BackImageUrl="assets/img/sinav_arka.png" Height="60px" Enabled="False">
                                        <table>
                                            <tr>
                                                <td style="width: 1000px; text-align: center;">
                                                    <asp:Label ID="lblGuvenlik" runat="server" Text="123456" CssClass="guvenlikLabel"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </div>
                                <asp:Button ID="btnSorgula" runat="server" Text="Sorgula" CssClass="btn btn-green" OnClick="btnGonder_Click" />
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
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s">İletişim Merkezine<br />
                    Gelen<br />
                    <span>Başvurular</span></h1>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle one">
                            <div class="count-info">
                                <h3><span class="counter">98%</span></h3>
                                <h4>Memnuniyet</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle two">
                            <div class="count-info">
                                <h3><span class="counter">35%</span></h3>
                                <h4>Öneri</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle three">
                            <div class="count-info">
                                <h3><span class="counter">10%</span></h3>
                                <h4>Şikayet</h4>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div class="fact-block">
                        <div class="circle four">
                            <div class="count-info">
                                <h3><span class="counter">55%</span></h3>
                                <h4>Talep</h4>
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
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s">Sıkça<br />
                    Sorulan<br />
                    <span>Sorular</span></h1>
                <div class="col-sm-12 col-md-12 wow fadeInUp animated" data-wow-delay="1.2s">
                    <div id="faqSection">
                        <dl>
                            <dt class="opened"><span class="icon"></span>01 - 444 DHMI hattı nedir? Ne amaçla kurulmuştur?
                            </dt>
                            <dd style="display: block;">444 DHMI HATTI vatandaşların Teşkilatımız ile ilgili her türlü istek, ihbar ve şikâyetler ilgili birimlere kolay bir şekilde ulaşabilmesi, iletişimin tek merkezden yönlendirilmesi, vatandaşlarımıza en kısa zamanda dönüş yapılabilmesi ve sonucun takibi amacıyla kurulmuştur. Bu kapsamda; vatandaşlarımızdan gelen istek, ihbar ve şikâyetler bu konularda Genel Müdürlüğümüzce düzenlenmiş eğitimleri alan operatörler tarafından kaydedilmektedir.
                            </dd>

                            <dt class="opened"><span class="icon"></span>02 - 444 DHMI hattı ücretli midir? 
                            </dt>
                            <dd style="display: block;">444 DHMI hattı, asılsız ihbar ve şikâyetlere ve hattın amacı dışında meşgul edilmesine karşı ücretlendirilmektedir. Bu kapsamda Türk Telekom ve GSM firmalarıyla en düşük tarifeden ücretlendirme kapsamında anlaşma sağlanmıştır. Ayrıca <b>iletisimmerkezi@dhmi.gov.tr</b> adresinden şikâyetlerinizi ücretsiz olarak 444 DHMI hattına bildirebilirsiniz.
                            </dd>

                            <dt class="opened"><span class="icon"></span>03 - 444 DHMI hattı nasıl çalışıyor?
                            </dt>
                            <dd style="display: block;">İstek, ihbar ve şikayette bulunmak istediğiniz konuları paylaşmanız durumunda kayıtlarınız oluşturulmaktadır.
                            </dd>

                            <dt class="opened"><span class="icon"></span>04 - 444 DHMI hattına yapılan başvuruların sonuçları vatandaşa nasıl bildiriliyor?
                            </dt>
                            <dd style="display: block;">E-posta yoluyla oluşturulan kayıtlarınız için başvuru numaranız mail olarak gönderiliyor. Telefon yoluyla oluşturduğunuz kayıtlarda ise sözlü olarak başvuru numaranız aktarılır.TC Kimlik numaranızı aktarmanız durumunda başvuru numaranız ve TC Kimlik numaranızla kaydınızı <b>alo.dhmi.gov.tr</b> adresinden takip edebilirsiniz. Ayrıca e-posta adresi bildirmeniz durumunda belirtilen mail adresinize başvurunuzun sonuçlandığına dair mail gönderilmektedir. 
                            </dd>

                            <dt class="opened"><span class="icon"></span>05 - Kişisel bilgilerimi iletmeden şikâyet kaydında bulanabilir miyim?
                            </dt>
                            <dd style="display: block;">Hayır
                            </dd>

                            <dt class="opened"><span class="icon"></span>06 - Kayıt oluştururken sizinle paylaştığımız kişisel bilgiler başkası ile paylaşılıyor mu?
                            </dt>
                            <dd style="display: block;">Bildirmiş olduğunuz kişisel bilgiler 3. Şahıslarla kesinlikle paylaşılmamaktadır.
                            </dd>

                            <dt class="opened"><span class="icon"></span>07 - Başvurum ne kadar sürede sonuçlanıyor?
                            </dt>
                            <dd style="display: block;">Tarafımıza iletilen şikâyetlerin sonuçlandırılma süresi bağlı ilettiğiniz şikayetinizin risk durumuna göre değişiklik göstermektedir. Bu süre  Türkiye genelinde ortalama 120 saattir.
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
                <h1 class="section-title wow fadeInLeft animated" data-wow-delay=".6s"><span>İletişim</span></h1>
                <div class="col-sm-6 col-md-6 wow fadeInLeft animated" data-wow-delay="1.4s">
                    <form name="contact">
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-user"></i></span>
                            <input type="text" name="name" id="name" class="form-control" placeholder="Adınız Soyadınız" />
                        </div>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-envelope-o"></i></span>
                            <input type="email" name="email" id="email" class="form-control" placeholder="Email" />
                        </div>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-fire"></i></span>
                            <input type="text" name="subject" id="subject" class="form-control" placeholder="Konu" />
                        </div>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="fa fa-comments"></i></span>
                            <textarea name="message" id="message" class="form-control large" placeholder="Mesajınız"></textarea>
                        </div>
                        <button class="btn btn-green" onclick="mailGonder()"><i class="fa fa-envelope-o"></i>Gönder</button>
                    </form>
                </div>
                <div class="col-sm-4 col-md-4 col-md-offset-2 wow fadeInRight animated" data-wow-delay="1.4s">
                    <div class="address">
                        <h2>İletişim Bilgileri</h2>
                        <ul class="contact-info">
                            <li><i class="fa fa-mobile"></i>444 3464[DHMI] </li>
                            <li><i class="fa fa-envelope-o"></i>iletisimmerkezi@dhmi.gov.tr</li>
                        </ul>

                        <h2>Takipteyiz</h2>
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

    <div class="modal fade" id="kkvkmetni">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title">Kişisel Verilerin Korunması Kanunu Aydınlatma Metni</h4>
                </div>
                <div class="modal-body">
                    <p>6698 Sayılı Kişisel Verilerin Korunması Kanunu’nun (“<strong>KVKK</strong>”) 10. maddesi “Veri Sorumlusunun Aydınlatma Yükümlülüğü” madde başlığı altında veri sorumlusu olan <span style="color: red">Devlet Hava Meydanları İşletmesi Genel Müdürlüğü’nün</span>, adres ve bilgileri, kişisel verilerin hangi amaçla işleneceği, işlenen kişisel verilerin kimlere ve hangi amaçla aktarılabileceği, kişisel veri toplamanın yöntemi ve hukuki sebebi, kişisel veri sahibinin veri sorumlusuna yöneltebileceği ve KVKK’nın 11. Maddesinde yer verilen hakları konusunda bilgilendirme yükümlülüğü getirmiştir.</p>

                    <p>İşbu Aydınlatma Metni KVKK ve ilgili mevzuat uyarınca veri sahiplerini bilgilendirmek ve aydınlatmak amacı ile hazırlanmıştır.</p>

                    <h3>1. Veri Sorumlusunun Kimliği</h3>

                    <p>Veri Sorumlusu Emniyet Mahallesi Mevlana Bulvarı No: 32 Etiler 0650 Yenimahalle / Ankara adresindeki Devlet Hava Meydanları İşletmesi Genel Müdürlüğü’dür.</p>

                    <h3>2. Kişisel Verilerin İşlenme Amaçları</h3>

                    <p>Kişisel verileriniz aşağıdaki amaçlarla işlenebilecektir:</p>
                    <ul>
                        <li><span style="color: red">Kuruluşumuzun</span> görev alanına giren hizmetlerden vatandaşlarımızı faydalandırmak için gerekli çalışmaların iş birimlerimiz ve/veya ortaklarımız tarafından yapılması,</li>
                        <li>Vatandaşların kayıtlarının oluşturulması ve yönetilmesi, </li>
                        <li>Vatandaşlar ile ilgili olarak yasal sınırlar içerisinde değerlendirme, analiz çalışmalarının yapılması,</li>
                        <li>Hizmet şartlarımızda ve elektronik hizmetlerimizde meydana gelebilecek değişiklikler hakkında bilgilendirme yapılması,</li>
                        <li><span style="color: red">Kuruluşumuzun</span> insan kaynakları politikalarının yürütülmesinin temini,</li>
                        <li><span style="color: red">Kuruluşumuzun</span> ve <span style="color: red">Kuruluşumuz</span> ile hizmet temini ilişkisi içerisinde olan kurumların hukuki güvenliğinin temini,</li>
                        <li>Hizmet temini süresince çözüm ortaklarıyla yürütülen işlerin planlanması,</li>
                        <li><span style="color: red">Kuruluşumuzun</span> iş stratejilerinin belirlenmesi ve uygulanması,</li>
                        <li>Vatandaşların sunulan hizmetten memnuniyetlerini ölçmek amaçlı olan anketler de dâhil olmak üzere, araştırma çalışmaları ve analizinin yürütülmesi,</li>
                        <li>Vatandaşların sunulan hizmete ilişkin şikâyetlerinin çözülmesi ve veri erişim veya düzeltme taleplerinin işleme alınması,</li>
                        <li>Sunulan hizmette vatandaşlar ile ilişkili gelişmeler hakkında bilgi alınarak verim raporlarının oluşturulması ve güncellenmesi,</li>
                        <li>Hukuki süreçlerin ve diğer resmi kurumlarla iletişim süreçlerinin takibi ve icrası,</li>
                        <li>Bilgi güvenliği süreçlerinin planlanması, bilgi teknolojileri alt yapısının oluşturulması ve yönetilmesi,</li>
                        <li>Risk yönetiminin yapılması, iş sürekliliğinin sağlanması, sözleşme süreçlerinin veya hukuki taleplerin takibi,</li>
                        <li>Hizmet ve projelerin sürdürülmesi, Kuruluşumuz faaliyetlerinin ve politikalarının yürütülebilmesi,</li>
                        <li>Vatandaşlar ve Kuruluşumuz ilişkilerinin yürütülmesi ve kurumsal yönetim faaliyetlerinin takibi,</li>
                        <li>Kuruluşumuzun görev alanına giren hizmet alanına bağlı faturalandırma da dâhil olmak üzere mali, muhasebesel ve finansal işlemlerin yürütülmesi, risk yönetiminin gerçekleştirilmesi,</li>
                    </ul>
                    <h3>3. Kişisel Verilerin Üçüncü Kişilere Aktarılması</h3>

                    <p>Kişisel Verileriniz yukarıda sayılan amaçların gerçekleştirilmesini sağlamak amacı ile Devlet Hava Meydanları İşletmesi Genel Müdürlüğü’nün direkt ve dolaylı hizmet temini sağladığı kurumlar başta olmak üzere yurt içindeki tedarikçilerimizle, lojistik firmalarıyla, etkinlik şirketleriyle, dijital ajanslarla, iletişim merkezi hizmet sunucularıyla, denetim şirketleriyle, bankalarla, finans kuruluşları, hukuk, vergi vb. alanlarda destek alınan danışmanlık firmalarıyla, sigorta şirketleri ile ve yurtiçinde bulunan depolama, arşivleme, bilişim teknolojileri desteği (sunucu, hosting, program, bulut bilişim), güvenlik, iletişim merkezi, satış, pazarlama gibi alanlarda dışarıdan hizmet alınan üçüncü kişilerle, hukuken yetkili kamu kurumları ve özel kişi ve kurumlar ile KVKK’nın 8. ve 9. maddelerinde belirtilen kişisel veri işleme şartları ve amaçları çerçevesinde paylaşılabilecek ve aktarılabilecektir.</p>


                    <h3>4. Kişisel Verilerin Toplanma Yöntemi ve Hukuki Sebebi</h3>

                    <p>Kişisel verileriniz  <span style="color: red">Devlet Hava Meydanları İşletmesi Genel Müdürlüğü</span> tarafından; başvuru formları, web siteleri üyelik ve iletişim formları, web siteleri e-bülten kayıt formları, çerezler, iş başvuru formları gibi kanallarla; ilgili internet siteleri ve farklı hukuki sebeplere dayanarak <span style="color: red">Kuruluşumuz</span> faaliyetlerini sürdürebilmesi için KVKK ve ilgili sair mevzuat tarafından öngörülen esas ve usuller doğrultusunda işbu Aydınlatma Metni’nde belirtilen amaçların sağlanması ve hukuki yükümlülüklerimizi yerine getirmeye yönelik hukuki sebeplerle işlenmektedir.</p>

                    <h3>5. Kişisel Verilere Erişim ve KVKK Kapsamında Haklarınız</h3>

                    <p>KVKK’nın 11. maddesi uyarınca Kuruluşumuza başvurarak; kişisel verilerinizin işlenip işlenmediğini öğrenme, işlenmişse buna ilişkin bilgi talep etme, kişisel verilerinizin işlenme amacını ve bunların amacına uygun kullanılıp kullanılmadığını öğrenme, yurt içinde kişisel verilerinizin aktarıldığı üçüncü kişileri bilme, kişisel verilerinizin eksik veya yanlış işlenmiş olması halinde bunların düzeltilmesini isteme ve bu kapsamda yapılan işlemin kişisel verilerin aktarıldığı üçüncü kişilere bildirilmesini isteme, amaç, süre ve meşruiyet prensipleri dâhilinde değerlendirilmek üzere kişisel verilerinizin işlenmesini gerektiren sebeplerin ortadan kalkması halinde silinmesini veya yok edilmesini isteme ve bu kapsamda yapılan işlemin kişisel verilerin aktarıldığı üçüncü kişilere bildirilmesini isteme, işlenen kişisel verilerinizin münhasıran otomatik sistemler vasıtasıyla analiz edilmesi durumunda aleyhinize bir sonucun ortaya çıkması halinde bu sonuca itiraz etme, kişisel verilerinizin kanuna aykırı olarak işlenmesi ve bu sebeple zarara uğramanız halinde zararın giderilmesini talep etme haklarına sahipsiniz.</p>
                    <p>Bu kapsamda, yukarıdaki haklarınıza ilişkin talebinizi <a style="color:blue" href="mailto:iletisimmerkezi@dhmi.gov.tr">iletisimmerkezi@dhmi.gov.tr</a> e-posta adresimize güvenli elektronik imzalı olarak veya kimliğinizi tespit edici belgeler ile ıslak imzalı bir dilekçe ile elden teslim edebilir ya da noter aracılığıyla gönderebilirsiniz.</p>

                    <p><span style="color: red">Devlet Hava Meydanları İşletmesi Genel Müdürlüğü</span> haklarınıza ilişkin taleplerinizi, talebin niteliğine göre talebi en kısa sürede ve en geç 30 (otuz) gün içerisinde sonuçlandıracaktır. Kişisel verilerinizin açık rıza ile işlendiği hallerde söz konusu açık rızanızı geri almanız durumunda söz konusu açık rızaya dayalı işlemenin gerekli olduğu üyelik/sadakat programından çıkarılacağınızı ve söz konusu işlemeler sayesinde yararlandığınız avantajlardan ilgili tarih itibariyle yararlandırılamayacağınızı önemle belirtmek isteriz.</p>

                    <p>Başvurunuzun açık, anlaşılır bir şekilde ve kimlik ile adres bilgilerini tespit edici belgeleri de ekleyerek yazılı ve ıslak imzalı olarak elden, postayla ya da noter kanalıyla Emniyet Mahallesi Mevlana Bulvarı No: 32 Etiler 06560 Yenimahalle / Ankara adresine ulaştırmanız gerekmektedir.</p>

                    <p>Kişisel Verilere ilişkin mevzuat ve uygulamamız kapsamındaki değişiklikleri internet sitemizin ilgili sayfasından her zaman takip edebilirsiniz.</p>

                </div>
            </div>
        </div>
    </div>
    <!-- Footer section Start -->
    <footer id="footer">
        <div class="container">
            <div class="row">
                <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
                    <div class="copyright wow fadeInUp animated" data-wow-delay=".8s">
                        <p>&copy; 2015 Devlet Hava Meydanları İşletmesi Genel Müdürlüğü. Tüm hakları saklıdır</p>
                    </div>
                </div>
                <div class="col-lg-2 col-md-2 col-sm-2 col-xs-12">
                    <div class="scroll-top text-center wow fadeInUp animated" data-wow-delay=".6s">
                        <a href="#header"><i class="fa fa-chevron-circle-up fa-2x"></i></a>
                    </div>
                </div>
                <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
                    <%--  <p class="text-center wow fadeInUp animated" data-wow-delay=".8s"><a href="http://www.assistt.com.tr">AssisTT</a> tarafından geliştirilmiştir.</p>--%>
                    <a href="#" style="position: absolute; right: 10px; color: white" class="btn btn-link btn-sm" data-toggle="modal" data-target="#kkvkmetni">KVKK Aydınlatma Metni</a>
                </div>
            </div>
        </div>
    </footer>
    <!-- Footer section End -->
    <!-- KKVK Modal -->
    <!-- Modal -->




    <!-- jQuery Load -->
    <script src="assets/js/jquery-3.6.0.min.js"></script>
    <!-- Bootstrap JS -->
    <script src="assets/js/bootstrap.min.js"></script>
    <!-- WOW JS plugin for animation -->
    <script src="assets/js/wow.js"></script>
    <!-- All JS plugin Triggers -->
    <script src="assets/js/main.js"></script>
    <!-- Smooth scroll -->
    <script src="assets/js/smooth-scroll.js"></script>
    <!--  -->
    <script src="assets/js/jasny-bootstrap.min.js"></script>
    <!-- Counterup -->
    <script src="assets/js/jquery.counterup.min.js"></script>
    <!-- waypoints -->
    <script src="assets/js/waypoints.min.js"></script>
    <!-- circle progress -->
    <script src="assets/js/circle-progress.js"></script>
    <!-- owl carousel -->
    <script src="assets/js/owl.carousel.js"></script>
    <!-- lightbox -->
    <script src="assets/js/lightbox.min.js"></script>

    <script src="assets/js/index.js"></script>
    <script src="assets/js/SSS_script.js"></script>
    <script src="assets/js/SSS_jquery.min.js"></script>

    <!-- Yandex.Metrika informer -->
    <a href="https://metrica.yandex.com.tr/stat/?id=28993135&amp;from=informer"
        target="_blank" rel="nofollow">
        <img src="//bs.yandex.ru/informer/28993135/3_1_FFFFFFFF_EFEFEFFF_0_pageviews"
            style="width: 1px; height: 1px; border: 0;" alt="Yandex.Metrica" title="Yandex.Metrica: bugünün verileri (gösterimler, ziyaretler ve tekil ziyaretçiler)" onclick="try{Ya.Metrika.informer({i:this,id:28993135,lang:'tr'});return false}catch(e){}" /></a>
    <!-- /Yandex.Metrika informer -->

    <!-- Yandex.Metrika counter -->
    <script type="text/javascript">
        $('#kkvk').modal('toggle')
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

