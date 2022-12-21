<%@ Page Title="Devlet Hava Meydanları İşletmesi Genel Müdürlüğü - İletişim Merkezi" Language="C#" MasterPageFile="~/Light.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Dhmi.Web.Login" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="tum_header"><asp:Panel ID="asdsaxsa" runat="server" Height="500px">
    <div class="accountHeader">    
    <h2>
        Sisteme Giriş</h2>
    <p>
        Lütfen 'Kullanıcı Adı' ve 'Şifre' bilgilerinizi giriniz.
		Şifrenizi hatırlamıyorsanız lütfen '<a href="Register.aspx">Şifremi Unuttum</a>'  linkine tıklayınız...</p>
</div>


<dx:ASPxLabel ID="lblUserName" runat="server" AssociatedControlID="tbUserName" Text="Kullanıcı Adı:" />
<div class="form-field">   
	<dx:ASPxTextBox AutoCompleteType="None" ID="tbUserName" runat="server" Width="140px" MaxLength="50">
	    <ValidationSettings ValidationGroup="LoginUserValidationGroup" ErrorDisplayMode="ImageWithTooltip">
	        <RequiredField ErrorText="Kullanıcı adınızı giriniz..." IsRequired="true" />
	    </ValidationSettings>        
	</dx:ASPxTextBox>
</div>
<dx:ASPxLabel ID="lblPassword" runat="server" AssociatedControlID="tbPassword" Text="Şifre:" />
<div class="form-field" autocomplete="off">
    <input style="display: none" type="password" id="TextBox1">
	<dx:ASPxTextBox ID="tbPassword" AutoCompleteType="Disabled" runat="server" Password="true" Width="140px" MaxLength="99999">
	    <ValidationSettings ValidationGroup="LoginUserValidationGroup" ErrorDisplayMode="ImageWithTooltip">
	        <RequiredField ErrorText="Şifrenizi giriniz..." IsRequired="true" />
	    </ValidationSettings>
	</dx:ASPxTextBox>
    <dx:ASPxCheckBox ID="cb_goster" runat="server" Text="Şifre Göster" OnCheckedChanged="cb_goster_CheckedChanged" AutoPostBack="true"></dx:ASPxCheckBox>
</div>
<dx:ASPxLabel ID="ASPxLabel7" runat="server" AssociatedControlID="tbGuvenlik" Text="Güvenlik Kodu:" />
<div class="form-field">    
	<dx:ASPxTextBox ID="tbGuvenlik" runat="server" Width="140px" MaxLength="6">
	    <ValidationSettings ValidationGroup="LoginUserValidationGroup" ErrorDisplayMode="ImageWithTooltip">
	        <RequiredField ErrorText="Güvenlik kodunu giriniz..." IsRequired="true" />
	    </ValidationSettings>
	</dx:ASPxTextBox>
    <dx:ASPxCaptcha ID="Captcha" runat="server" RefreshButton-Text=" " TextBox-Visible="false" ChallengeImage-Height="65" ChallengeImage-Width="138" CodeLength="6" RefreshButton-Position="Right" CharacterSet="0123456789">
        <ValidationSettings SetFocusOnError="true" ErrorDisplayMode="Text"/> 
    </dx:ASPxCaptcha>
</div>
<dx:ASPxButton ID="btnLogin" runat="server" Text="Giriş" ValidationGroup="LoginUserValidationGroup"
    OnClick="btnLogin_Click" Width="140px" AutoPostBack="false">
    <ClientSideEvents Click="function(s, e) {
    Callback.PerformCallback();
    LoadingPanel.Show();
}" />
</dx:ASPxButton>
<br />
<br />
<br />
<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="İletişim Merkezi Sistemi Amaçları" ForeColor="Maroon" Font-Bold="true" />
<br />
<dx:ASPxLabel ID="ASPxLabel9" runat="server" Text=" - " ForeColor="Maroon" Font-Bold="true" /><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="İzleme ve geri dönüş mekanizmalarının doğru bir şekilde işletilmesi ile hizmet kalitesini yükseltmek."/><br />
<dx:ASPxLabel ID="ASPxLabel8" runat="server" Text=" - " ForeColor="Maroon" Font-Bold="true" /><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Vatandaşın kurumlardan beklediği memnuniyeti arttırmak."/><br />
<dx:ASPxLabel ID="ASPxLabel6" runat="server" Text=" - " ForeColor="Maroon" Font-Bold="true" /><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Kontrol edilebilir bir ekip yönetimi meydana getirmek."/><br />
<dx:ASPxLabel ID="ASPxLabel10" runat="server" Text=" - " ForeColor="Maroon" Font-Bold="true" /><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Kalıcı ve sağlıklı bir sistem veritabanı oluşturmak."/><br />
<dx:ASPxLabel ID="ASPxLabel13" runat="server" Text=" - " ForeColor="Maroon" Font-Bold="true" /><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Personel verimliliğini maksimum seviyeye çıkarmak."/><br />
<dx:ASPxLabel ID="ASPxLabel12" runat="server" Text=" - " ForeColor="Maroon" Font-Bold="true" /><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Kurumsal bir iş takip mekanizması oluşturmak."/><br />
    <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
     <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
    </dx:ASPxCallback>
    <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
    </dx:ASPxLoadingPanel>  
</asp:Panel>
</div>
</asp:Content>
