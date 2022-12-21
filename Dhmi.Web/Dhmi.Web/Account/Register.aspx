<%@ Page Title="Devlet Hava Meydanları İşletmesi Genel Müdürlüğü - İletişim Merkezi" Language="C#" MasterPageFile="~/Light.master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Dhmi.Web.Register" %>
<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">
<div class="tum_header"><asp:Panel ID="asdsaxsa" runat="server" Height="500px">
    <div class="accountHeader">
    <br />        
    <br />       
    <h2>
        Şifremi Unuttum</h2>
    <p>Şifrenizin sistemde tanımlı mail adresinize gönderilebilmesi için lütfen 'Kullanıcı Adı' ve sistemde tanımlı 'Mail Adresi' bilgilerini giriniz. Şifrenizi sıfırlamak için ise 'Kullanıcı Adı', 'Gizli Soru' ve 'Cavap' bilgilerini giriniz. Her iki işlem için de 'Güvenlik Kodu' alanını doğru olarak sistemem girmeniz gerekmektedir...</p>        
</div>
<br />
<br />
    <table>
        <tr>
            <td width="370px">
                <dx:ASPxLabel ID="lblUserName" runat="server" AssociatedControlID="tbUserName" Text="Kullanıcı Adı:" />
	<div class="form-field">
	    <dx:ASPxTextBox ID="tbUserName" runat="server" Width="180px" MaxLength="11">
	        <ValidationSettings ValidationGroup="RegisterUserValidationGroup">
	            <RequiredField ErrorText="Kullanıcı adınızı giriniz..." IsRequired="true" />
	        </ValidationSettings>
	    </dx:ASPxTextBox>
    </div>
    <dx:ASPxLabel ID="lblEmail" runat="server" AssociatedControlID="tbEmail" Text="Mail:" />
    <div class="form-field">
		<dx:ASPxTextBox ID="tbEmail" runat="server" Width="180px" MaxLength="50">
	        <ValidationSettings ValidationGroup="RegisterUserValidationGroup">
	            <RequiredField ErrorText="Mail adresinizi giriniz..." IsRequired="true" />
	            <RegularExpression ErrorText="Mail adresinizi kontrol ediniz..." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
	        </ValidationSettings>
	    </dx:ASPxTextBox>
    </div> 
    <dx:ASPxLabel ID="ASPxLabel7" runat="server" AssociatedControlID="tbGuvenlik" Text="Güvenlik Kodu:" />
<div class="form-field">    
	<dx:ASPxTextBox ID="tbGuvenlik" runat="server" Width="180px" MaxLength="6">
	    <ValidationSettings ValidationGroup="RegisterUserValidationGroup">
	        <RequiredField ErrorText="Güvenlik kodunu giriniz..." IsRequired="true" />
	    </ValidationSettings>
	</dx:ASPxTextBox>
    <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/Content/Images/sinav_arka.png" Width="180px" Height="24px">
    <table>
        <tr>
            <td align="center" width="1000">
                <asp:Label ID="lbl_guvenlik_no" runat="server" Text="123456" Font-Bold="true" Font-Size="16" Font-Names="Arial"></asp:Label>
            </td>
        </tr>
    </table>
    </asp:Panel>
</div>        
    <dx:ASPxButton ID="btnCreateUser" runat="server" Text="Mail Gönder" ValidationGroup="RegisterUserValidationGroup"
        OnClick="btnCreateUser_Click" Width="180px" AutoPostBack="false">
        <ClientSideEvents Click="function(s, e) {
    Callback.PerformCallback();
    LoadingPanel.Show();
}" />
    </dx:ASPxButton>  
    <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
     <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
    </dx:ASPxCallback>
    <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Modal="True" Text="Gönderiliyor..." Theme="BlackGlass" Width="150" Height="80">
    </dx:ASPxLoadingPanel> 
            </td>
            <td>
                <dx:ASPxLabel ID="lblUserName2" runat="server" AssociatedControlID="tbUserName2" Text="Kullanıcı Adı:" />
	<div class="form-field">
	    <dx:ASPxTextBox ID="tbUserName2" runat="server" Width="280px" MaxLength="11">
	        <ValidationSettings ValidationGroup="RegisterUserValidationGroup2">
	            <RequiredField ErrorText="Kullanıcı adınızı giriniz..." IsRequired="true" />
	        </ValidationSettings>
	    </dx:ASPxTextBox>
    </div>
    <dx:ASPxLabel ID="lblGizliSoru" runat="server" AssociatedControlID="cb_soru" Text="Gizli Soru:" />
    <div class="form-field">
		<dx:ASPxComboBox ID="cb_soru" runat="server" ValueType="System.String" Width="280" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="RegisterUserValidationGroup2">
	                                                                            <RequiredField ErrorText="Gizli sorunuzu seçiniz..." IsRequired="true"/>
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
    </div> 
    <dx:ASPxLabel ID="lblcevap" runat="server" AssociatedControlID="txt_cevap" Text="Cevap:" />
	<div class="form-field">
	    <dx:ASPxTextBox ID="txt_cevap" runat="server" Width="280px" MaxLength="11">
	        <ValidationSettings ValidationGroup="RegisterUserValidationGroup2">
	            <RequiredField ErrorText="Cevabınızı giriniz..." IsRequired="true" />
	        </ValidationSettings>
	    </dx:ASPxTextBox>
    </div>
    <dx:ASPxLabel ID="ASPxLabel72" runat="server" AssociatedControlID="tbGuvenlik2" Text="Güvenlik Kodu:" />
<div class="form-field">    
	<dx:ASPxTextBox ID="tbGuvenlik2" runat="server" Width="280px" MaxLength="6">
	    <ValidationSettings ValidationGroup="RegisterUserValidationGroup2">
	        <RequiredField ErrorText="Güvenlik kodunuzu giriniz..." IsRequired="true" />
	    </ValidationSettings>
	</dx:ASPxTextBox>
    <asp:Panel ID="Panel11" runat="server" BackImageUrl="~/Content/Images/sinav_arka.png" Width="280px" Height="24px"> 
    <table>
        <tr>
            <td align="center" width="1000">
                <asp:Label ID="lbl_guvenlik_no2" runat="server" Text="123456" Font-Bold="true" Font-Size="16" Font-Names="Arial"></asp:Label>
            </td>
        </tr>
    </table>
            </asp:Panel>
</div>        
    <dx:ASPxButton ID="btnCreateUser2" runat="server" Text="Şifre Sıfırla" ValidationGroup="RegisterUserValidationGroup2"
        OnClick="btnCreateUser2_Click" Width="280px" AutoPostBack="false">
        <ClientSideEvents Click="function(s, e) {
    Callback.PerformCallback();
    LoadingPanel.Show();
}" />
    </dx:ASPxButton>  
    <dx:ASPxCallback ID="ASPxCallback11" runat="server" ClientInstanceName="Callback1">
     <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel1.Hide(); }" />
    </dx:ASPxCallback>
    <dx:ASPxLoadingPanel ID="LoadingPanel1" runat="server" ClientInstanceName="LoadingPanel1" Modal="True" Text="İşlem Gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
    </dx:ASPxLoadingPanel>
            </td>
        </tr>
    </table>     
    </asp:Panel>
    </div>
</asp:content>
