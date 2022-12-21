<%@ Page Title="DHMİ İletişim Merkezi - Çağrı Kayıt Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="CkbCagriKayitBilgileri.aspx.cs" Inherits="Dhmi.Web.CkbCagriKayitBilgileri" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <script type="text/javascript">
        // <![CDATA[
        function ShowBDDKWindow() {
            pcKurum.Show();
        }

        function ShowGecmisWindow() {
            pcGecmis.Show();
        }

        function ShowDegistirWindow() {
            pcDegistir.Show();
        }

        function ShowVatandasWindow() {
            pcVatandas.Show();
        }
        // ]]> 
    </script>
    <style type="text/css">
        .linkMenu 
       {
           background: none!important;
           border: 0!important; 
           color: #162436!important;
           padding: 0!important;
           text-decoration: none!important;
           font-size:12px;                                
       }
       
       .linkMenu a:hover,
       .linkMenu a:hover *
       {
           text-decoration: underline!important;
       }
       .linkMenuItem,
       .linkMenuItem > div
       {
           padding: 0!important;
           font: 11px Tahoma!important;
       }
       .linkMenuSeparator
       {
           padding: 0 14px!important;
       }
       .linkMenuSeparator > *
       {
           background: #5386CB!important;
           margin: 4px 0!important;
           height: 10px!important;
           width: 1px!important;
       }
    </style>
    <asp:ToolkitScriptManager ID="asdsadasd" runat="server" CombineScripts="true" LoadScriptsBeforeUI="false"></asp:ToolkitScriptManager>
    <div style="float: left; width: 60%; margin-right: 2%">
        <br />
        <asp:UpdatePanel ID="asascsad" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Menu1" />
            </Triggers>
            <ContentTemplate>
                <dx:ASPxMenu ID="Menu1" runat="server" RenderMode="Lightweight" Width="100%" Paddings-PaddingTop="0" OnItemClick="Menu1_MenuItemClick" CssClass="linkMenu">                                    
                                    <BorderTop BorderWidth="1px" BorderColor="Black"/>
                                    <BorderBottom BorderWidth="1px" BorderColor="Black"/>
                                    <BorderLeft BorderWidth="1px" BorderColor="Black"/>
                                    <BorderRight BorderWidth="1px" BorderColor="Black"/>
                                    <ItemStyle ForeColor="#C0262A" />
                                    <LinkStyle Color="Red"></LinkStyle>
                                    <clientsideevents ItemClick="function(s, e) {                                                            
                                                            Callback1313.PerformCallback();
	                                                        LoadingPanel1313.Show();                                                                                          
                                                               }" />
               </dx:ASPxMenu>
               <dx:ASPxCallback ID="ASPxCallback14" runat="server" ClientInstanceName="Callback1313">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel1313.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel9" runat="server" ClientInstanceName="LoadingPanel1313" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
               <div class="tabcontents">
                <asp:MultiView ID="MultiView1" ActiveViewIndex="0" runat="server">
                    <asp:View ID="tab_panel_1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1320" Height="640">
                                <table>
                                    <tr>
                                        <td width="1350px" align="left">
                                            <table>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>
                                                                <td width="1300px" align="center">
                                                                    <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                                        <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                                            <Items>
                                                                                <dx:LayoutGroup Caption="Bildirim Bilgileri" Width="590px">
                                                                                    <Items>
                                                                                        <dx:LayoutItem Caption=" " Width="590px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <table>
                                                                                                        <tr>
                                                                                                            <td width="70px" align="left"></td>
                                                                                                            <td width="90px" align="left">Bildirim Türü:
                                                                                                            </td>
                                                                                                            <td width="220px" align="left" height="26px">
                                                                                                                <dx:ASPxComboBox ID="cb_tur" runat="server" ValueType="System.String" Width="203" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_tur_SelectedIndexChanged">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Bildirim Türü seçiniz..." IsRequired="false" />
                                                                                                                    </ValidationSettings>
                                                                                                                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                            Callback226.PerformCallback();
                                                                            LoadingPanel226.Show();
                                                                            }" />
                                                                                                                </dx:ASPxComboBox>
                                                                                                                <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback226">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel226.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel226" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
                                                                                                            </td>
                                                                                                            <td>
                                                                                                                <dx:ASPxButton ID="btn_bilgi" ForeColor="#D23131" runat="server" Text="Bilgi Bankası" ValidationGroup="Group_K" Width="139" UseSubmitBehavior="true" OnClick="btn_bilgi_Click">
                                                                                                                </dx:ASPxButton>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </dx:LayoutItemNestedControlContainer>
                                                                                            </LayoutItemNestedControlCollection>
                                                                                        </dx:LayoutItem>
                                                                                    </Items>
                                                                                </dx:LayoutGroup>
                                                                            </Items>
                                                                        </dx:ASPxFormLayout>
                                                                    </asp:Panel>
                                                                    <table>
                                                                        <tr>
                                                                            <td align="left" width="1900px"></td>
                                                                            <td align="left" width="1000px">
                                                                                <asp:Panel ID="Panel5" runat="server" Enabled="false">
                                                                                    <dx:ASPxFormLayout ID="ASPxFormLayout3" runat="server">
                                                                                        <Items>
                                                                                            <dx:LayoutGroup Caption="Vatandaş Bilgileri" Width="305px">
                                                                                                <Items>
                                                                                                    <dx:LayoutItem Caption="Kayıt Türü:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxComboBox ID="cb_kayit_tur" runat="server" ValueType="System.String" Width="180" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_kayit_tur_SelectedIndexChanged">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Kayıt Türü seçiniz..." IsRequired="true" />
                                                                                                                    </ValidationSettings>
                                                                                                                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback333.PerformCallback();
                                                                                            LoadingPanel333.Show();
                                                                                            }" />
                                                                                                                </dx:ASPxComboBox>
                                                                                                                <dx:ASPxCallback ID="ASPxCallback7" runat="server" ClientInstanceName="Callback333">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel333.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel7" runat="server" ClientInstanceName="LoadingPanel333" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="TC Kimlik No:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <asp:Panel ID="pnl_tc" runat="server">
                                                                                                                    <table>
                                                                                                                        <tr>
                                                                                                                            <td align="left" width="110">
                                                                                                                                <dx:ASPxTextBox ID="txt_tc_no" runat="server" MaxLength="11" Width="100">
                                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                                        <RequiredField ErrorText="TC Kimlik No giriniz..." />
                                                                                                                                    </ValidationSettings>
                                                                                                                                </dx:ASPxTextBox>
                                                                                                                            </td>
                                                                                                                            <td align="left" width="80">
                                                                                                                                <dx:ASPxButton ID="btn_kps" runat="server" Text="KPS" ValidationGroup="Group_Kps" Width="70" UseSubmitBehavior="true" OnClick="btn_kps_Click">
                                                                                                                                    <ClientSideEvents Click="function(s, e) {
                                                                                        Callback33.PerformCallback();
                                                                                        LoadingPanel33.Show();
                                                                                        }" />
                                                                                                                                </dx:ASPxButton>
                                                                                                                                <dx:ASPxCallback ID="ASPxCallback8" runat="server" ClientInstanceName="Callback33">
                                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel33.Hide(); }" />
                                                                                                                                </dx:ASPxCallback>
                                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel8" runat="server" ClientInstanceName="LoadingPanel33" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                                </dx:ASPxLoadingPanel>
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                    </table>
                                                                                                                </asp:Panel>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Pasaport No:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_pasaport" runat="server" MaxLength="50" Width="180">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Pasaport No giriniz..."/>
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxTextBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Vergi Kimlik No:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection >
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_vergi_no" runat="server" MaxLength="10" Width="180">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                                                                    <RequiredField ErrorText="Vergi Kimlik No giriniz..."/>                                                                                
	                                                                                                                </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Uyruk:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_uyruk" runat="server" MaxLength="50" Width="180">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Uyruk giriniz..."/>
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxTextBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Ad:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_ad" runat="server" MaxLength="50" Width="180">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Ad giriniz..." IsRequired="true" />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxTextBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Soyad:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_soyad" runat="server" MaxLength="50" Width="180">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Soyad giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxTextBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Cinsiyet:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxComboBox ID="cb_cinsiyet" runat="server" ValueType="System.String" Width="80" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Cinsiyet seçiniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxComboBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Doğum Tarihi:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_dogum_tarihi" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Doğum Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Telefon No:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_tel_no" runat="server" Width="120" Native="false" MaxLength="20" EnableDefaultAppearance="false">                                                                                                                    
                                                                                                                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Group_Vat">
                                                                                                                        <RequiredField ErrorText="Telefon No giriniz..."/>
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxTextBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Mail Adresi:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxTextBox ID="txt_mail" runat="server" MaxLength="150" Width="180">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Mail Adresi giriniz..." />
                                                                                                                        <RegularExpression ErrorText="Mail Adresi Geçersiz..." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxTextBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Adres:" Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxMemo ID="txt_adres" runat="server" MaxLength="1000" Width="180" Height="70">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Adres giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxMemo>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption=" " Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <table>
                                                                                                                    <tr>
                                                                                                                        <td align="left" width="90">
                                                                                                                            <dx:ASPxButton ID="btn_sorgula" runat="server" Text="Sorgula" ValidationGroup="Group_Cagklklk" Width="80" UseSubmitBehavior="true" OnClick="btn_sorgula_Click">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                            Callback22.PerformCallback();
                                                                            LoadingPanel22.Show();
                                                                            }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback10" runat="server" ClientInstanceName="Callback22">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel22.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel10" runat="server" ClientInstanceName="LoadingPanel22" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                                                                        </td>
                                                                                                                        <td align="left">
                                                                                                                            <dx:ASPxButton ID="btn_yukle" runat="server" Text="Yükle" ValidationGroup="Group_Cagkkkklklk" Width="90" UseSubmitBehavior="true" OnClick="btn_yukle_Click" Enabled="false">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                            Callback26.PerformCallback();
                                                                            LoadingPanel26.Show();
                                                                            }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback12" runat="server" ClientInstanceName="Callback26">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel26.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel12" runat="server" ClientInstanceName="LoadingPanel26" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption=" " Width="305px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxLabel ID="asdasda" runat="server" Text="TC Kimlik No, Pasaport No, Vergi Kimlik No, Telefon No ya da Mail Adresi ile sorgulama yapabilirsiniz..." Font-Size="7" Font-Italic="true" ForeColor="Red"></dx:ASPxLabel>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                </Items>
                                                                                            </dx:LayoutGroup>
                                                                                        </Items>
                                                                                    </dx:ASPxFormLayout>
                                                                                </asp:Panel>                                                                              
                                                                            </td>
                                                                            <td width="1800px">
                                                                                <asp:Panel ID="Panel4" runat="server" Enabled="false">
                                                                                    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                                                                                        <Items>
                                                                                            <dx:LayoutGroup Caption="Çağrı Bilgileri" Width="712px">
                                                                                                <Items>                                                                                                   
                                                                                                    <dx:LayoutItem Caption="Çağrı Sistemi:" Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <table>
                                                                                                                    <tr>
                                                                                                                        <td align="left" width="270">
                                                                                                                            <dx:ASPxComboBox ID="cb_sistem" runat="server" ValueType="System.String" Width="110" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                                                <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                                    <RequiredField ErrorText="Çağrı Sistemi seçiniz..." IsRequired="false" />
                                                                                                                                </ValidationSettings>
                                                                                                                            </dx:ASPxComboBox>
                                                                                                                        </td>
                                                                                                                        <td align="left" width="90">Çağrı Sayısı:
                                                                                                                        </td>
                                                                                                                        <td align="left" width="144">
                                                                                                                            <dx:ASPxTextBox ID="txt_cagri_sayisi" runat="server" Width="120" Native="false" EnableDefaultAppearance="false" Enabled="false"></dx:ASPxTextBox>
                                                                                                                        </td>
                                                                                                                        <td align="left" width="87">
                                                                                                                            <dx:ASPxButton ID="btn_gor" runat="server" Text="İncele" ValidationGroup="Group_K" Width="60" UseSubmitBehavior="true" OnClick="btn_gor_Click" Enabled="false">
                                                                                                                            </dx:ASPxButton>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Çağrı Tipi:" Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <table>
                                                                                                                    <tr>
                                                                                                                        <td align="left" width="270">
                                                                                                                            <dx:ASPxComboBox ID="cb_cag_tip" runat="server" ValueType="System.String" Width="110" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                                                <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                                    <RequiredField ErrorText="Çağrı Tipi seçiniz..." IsRequired="true" />
                                                                                                                                </ValidationSettings>
                                                                                                                            </dx:ASPxComboBox>                                                                                                                            
                                                                                                                        </td>                                                                                                                        
                                                                                                                        <td align="left" width="90">Bilgilendirme:
                                                                                                                        </td>
                                                                                                                        <td align="left" width="144">
                                                                                                                            <dx:ASPxComboBox ID="cb_sekil" runat="server" ValueType="System.String" Width="120" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                                                <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                                    <RequiredField ErrorText="Bilgilendirme Şekli seçiniz..." IsRequired="false" />
                                                                                                                                </ValidationSettings>
                                                                                                                            </dx:ASPxComboBox>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>                                                                                                                                                                                                        
                                                                                                    <dx:LayoutItem Caption="Konu:" Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxComboBox ID="cb_konu" runat="server" ValueType="System.String" Width="575" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Konu seçiniz..." IsRequired="true" />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxComboBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Şikayet:" Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxMemo ID="txt_not" runat="server" MaxLength="5000" Width="575" Height="100px">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Şikayet giriniz..." IsRequired="true" />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxMemo>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Havalimanı:" Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxComboBox ID="cb_havalimani" runat="server" ValueType="System.String" Width="575" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Havalimanı seçiniz..." IsRequired="true" />
                                                                                                                    </ValidationSettings>
                                                                                                                </dx:ASPxComboBox>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Not:" Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <table>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            <dx:ASPxTextBox ID="txt_kisisel_measj" runat="server" MaxLength="250" Width="575" BackColor="#F2EDED">
                                                                                                                                <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                                    <RequiredField ErrorText="Not giriniz..." />
                                                                                                                                </ValidationSettings>
                                                                                                                            </dx:ASPxTextBox>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            <asp:Panel ID="pnl_sorgu" runat="server" Visible="false">
                                                                                                                                <table>
                                                                                                                                    <tr>
                                                                                                                                        <td align="left" width="93px" height="30px">
                                                                                                                                            Ad Soyad:
                                                                                                                                        </td>
                                                                                                                                        <td align="left" width="235px">
                                                                                                                                            <dx:ASPxTextBox ID="txt_dava_ad_soyad" runat="server" MaxLength="100" Width="482"></dx:ASPxTextBox>
                                                                                                                                        </td>
                                                                                                                                    </tr>                                                                                                                                    
                                                                                                                                    <tr>
                                                                                                                                        <td align="left" width="93px" height="30px">
                                                                                                                                            Dosya No:
                                                                                                                                        </td>
                                                                                                                                        <td align="left" width="235px">
                                                                                                                                            <dx:ASPxTextBox ID="txt_dava_dosya_no" runat="server" MaxLength="20" Width="482"></dx:ASPxTextBox>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td align="left" width="93px" height="30px">
                                                                                                                                            Mahkeme Adı:
                                                                                                                                        </td>
                                                                                                                                        <td align="left" width="235px">
                                                                                                                                            <dx:ASPxTextBox ID="txt_dava_mahkeme_adi" runat="server" MaxLength="250" Width="482"></dx:ASPxTextBox>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td align="left" width="93px" height="30px">
                                                                                                                                            Konu:
                                                                                                                                        </td>
                                                                                                                                        <td align="left" width="235px">
                                                                                                                                            <dx:ASPxTextBox ID="txt_dava_konu" runat="server" MaxLength="4000" Width="482"></dx:ASPxTextBox>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                </table>
                                                                                                                            </asp:Panel>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption="Atama:" Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <dx:ASPxCheckBox ID="cb_kapat" runat="server" Text="Direkt Kapatılsın mı?" AutoPostBack="true" OnCheckedChanged="cb_kapat_CheckedChanged">
                                                                                                                    <ClientSideEvents CheckedChanged="function(s, e) {
                                                                            Callback130.PerformCallback();
                                                                            LoadingPanel130.Show();
                                                                            }" />
                                                                                                                </dx:ASPxCheckBox>
                                                                                                                <dx:ASPxCallback ID="ASPxCallback6" runat="server" ClientInstanceName="Callback130">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel130.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel6" runat="server" ClientInstanceName="LoadingPanel130" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
                                                                                                                <asp:Panel ID="pnl_ata" runat="server">
                                                                                                                    <table>
                                                                                                                        <tr>
                                                                                                                            <td>
                                                                                                                                <asp:Panel ID="Panel3" runat="server" Width="329" ScrollBars="Vertical" Height="130px">
                                                                                                                                    <dx:ASPxCheckBoxList ID="cb_grup_list" runat="server" ValueType="System.String" Width="312" OnSelectedIndexChanged="cb_grup_list_SelectedIndexChanged" AutoPostBack="true">
                                                                                                                                        <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                            Callback1.PerformCallback();
                                                                            LoadingPanel1.Show();
                                                                            }" />
                                                                                                                                    </dx:ASPxCheckBoxList>
                                                                                                                                    <dx:ASPxCallback ID="ASPxCallback4" runat="server" ClientInstanceName="Callback1">
                                                                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel1.Hide(); }" />
                                                                                                                                    </dx:ASPxCallback>
                                                                                                                                    <dx:ASPxLoadingPanel ID="ASPxLoadingPanel4" runat="server" ClientInstanceName="LoadingPanel1" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                                    </dx:ASPxLoadingPanel>
                                                                                                                                </asp:Panel>
                                                                                                                                <br />
                                                                                                                                <table>
                                                                                                                                    <tr>
                                                                                                                                        <td align="center" width="330px">
                                                                                                                                            <dx:ASPxCheckBox ID="cb_gr_hep" runat="server" Text="Hepsini Seç" AutoPostBack="true" OnCheckedChanged="cb_gr_hep_CheckedChanged">
                                                                                                                                                <ClientSideEvents CheckedChanged="function(s, e) {
                                                                            Callback23.PerformCallback();
                                                                            LoadingPanel23.Show();
                                                                            }" />
                                                                                                                                            </dx:ASPxCheckBox>
                                                                                                                                            <dx:ASPxCallback ID="ASPxCallback3" runat="server" ClientInstanceName="Callback23">
                                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel23.Hide(); }" />
                                                                                                                                            </dx:ASPxCallback>
                                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel23" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                                            </dx:ASPxLoadingPanel>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                </table>
                                                                                                                            </td>
                                                                                                                            <td width="18px"></td>
                                                                                                                            <td>
                                                                                                                                <asp:Panel ID="pnkdsd" runat="server" Width="228" ScrollBars="Vertical" Height="130px" Enabled="false">
                                                                                                                                    <dx:ASPxCheckBoxList ID="cb_per_list" runat="server" ValueType="System.String" Width="211">
                                                                                                                                    </dx:ASPxCheckBoxList>
                                                                                                                                </asp:Panel>
                                                                                                                                <br />
                                                                                                                                <table>
                                                                                                                                    <tr>
                                                                                                                                        <td align="center" width="200px">
                                                                                                                                            <dx:ASPxCheckBox ID="cb_hepsi" runat="server" Text="Hepsini Seç" AutoPostBack="true" OnCheckedChanged="cb_hepsi_CheckedChanged">
                                                                                                                                                <ClientSideEvents CheckedChanged="function(s, e) {
                                                                            Callback2.PerformCallback();
                                                                            LoadingPanel2.Show();
                                                                            }" />
                                                                                                                                            </dx:ASPxCheckBox>
                                                                                                                                            <dx:ASPxCallback ID="ASPxCallback2" runat="server" ClientInstanceName="Callback2">
                                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel2.Hide(); }" />
                                                                                                                                            </dx:ASPxCallback>
                                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel3" runat="server" ClientInstanceName="LoadingPanel2" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                                            </dx:ASPxLoadingPanel>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                </table>
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                    </table>
                                                                                                                </asp:Panel>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                    <dx:LayoutItem Caption=" " Width="712px">
                                                                                                        <LayoutItemNestedControlCollection>
                                                                                                            <dx:LayoutItemNestedControlContainer>
                                                                                                                <table>
                                                                                                                    <tr>
                                                                                                                        <td width="200" align="center">
                                                                                                                            <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" ValidationGroup="Group_Cag" Width="150" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                                        Callback43.PerformCallback();
                                                                                        LoadingPanel43.Show();
                                                                                        }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback11" runat="server" ClientInstanceName="Callback43">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel43.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel11" runat="server" ClientInstanceName="LoadingPanel43" Modal="True" Text="İşlem tamamlanıyor. Lütfen bekleyiniz..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                                                                        </td>                                                                                                                        
                                                                                                                        <td width="170" align="center">
                                                                                                                            <dx:ASPxButton ID="btn_temizle" runat="server" Text="Temizle" Width="150" UseSubmitBehavior="true" OnClick="btn_temizle_Click">
                                                                                                                            </dx:ASPxButton>
                                                                                                                        </td>
                                                                                                                        <td width="180" align="center">
                                                                                                                            <dx:ASPxButton ID="btn_dosya" runat="server" Text="Dosya Durumu" ValidationGroup="Group_Cagas" Width="150" UseSubmitBehavior="true" OnClick="btn_dosya_Click" EnableViewState="false">
                                                                                                                            </dx:ASPxButton>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </dx:LayoutItemNestedControlContainer>
                                                                                                        </LayoutItemNestedControlCollection>
                                                                                                    </dx:LayoutItem>
                                                                                                </Items>
                                                                                            </dx:LayoutGroup>
                                                                                        </Items>
                                                                                    </dx:ASPxFormLayout>
                                                                                </asp:Panel>                                                                                
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>

                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:View>
                    <asp:View ID="tab_panel_2" runat="server">
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1320" Height="520">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td width="250" align="center"></td>
                                                    <td width="1520" align="center">
                                                        <dx:ASPxGridView ID="grid_bildirim" runat="server" ClientInstanceName="grid_bildirim" Width="1305px" AutoGenerateColumns="false" KeyFieldName="BildirimId" OnPageSizeChanged="grid_bildirim_PageSizeChanged" OnProcessColumnAutoFilter="grid_bildirim_ProcessColumnAutoFilter" OnPageIndexChanged="grid_bildirim_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_bildirim_BeforeColumnSortingGrouping">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>       
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">                                                                    
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn>                                                                            
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                            
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGelenYer" Caption="Çağrı Sistemi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                            
                                                                <dx:GridViewDataTextColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonIslemTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimHavalimani" Caption="Havalimanı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaAdSoyad" Caption="Dava - Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaDosyaNo" Caption="Dava - Dosya No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaMahkeme" Caption="Dava - Mahkeme Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="185px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaKonu" Caption="Dava - Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="225px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimToplamSure" Caption="Toplam İşlem Süresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="BildirimVatandasKarar" Caption="Vatandaş Karar" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataCheckColumn FieldName="BildirimGeriYapildiMi" Caption="Geri Dönüş Yapıldı mı?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Evet" DisplayTextUnchecked="Hayır">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <Styles>
                                                                <AlternatingRow Enabled="True"></AlternatingRow>
                                                            </Styles>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1200px" Height="460px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="370" HorizontalScrollBarMode="Auto" />
                                                            <SettingsCookies Enabled="true"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager> 
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_bildirim_export" runat="server" GridViewID="grid_bildirim" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="225">
                                                            <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter>
                                                        <table>
                                                            <tr>
                                                                <td width="500px" align="center">
                                                                </td>
                                                                <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bas_tarihi" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Başlangıç Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>                                                                        
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bit_tarihi" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Bitiş Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_sorgula_ana" runat="server" Text="Sorgula" ValidationGroup="Group_Vat" Width="80" UseSubmitBehavior="true" OnClick="btn_sorgula_ana_Click">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                            Callback22.PerformCallback();
                                                                            LoadingPanel22.Show();
                                                                            }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback5" runat="server" ClientInstanceName="Callback22">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel22.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel5" runat="server" ClientInstanceName="LoadingPanel22" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                        </td>
                                                                <td width="820px" align="right">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="700px" align="right" height="60px">
                                                                                <dx:ASPxButton ID="btnPdfExport" runat="server" Text="  Rapor Al" Width="180" Font-Bold="true" Image-Url="~/Content/Images/report.png" ImagePosition="Left" UseSubmitBehavior="true" Paddings-PaddingLeft="7px" OnClick="btnPdfExport_Click" ForeColor="Maroon">
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <br />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:View>
                    <asp:View ID="tab_panel_3" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1069" Height="525">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td></td>
                                                    <td>
                                                        <table>
                                                            <tr>
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="150px" align="center" height="50px">
                                                                                <dx:ASPxButton ID="btn_guncelle" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_guncelle_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="50px">
                                                                                <dx:ASPxButton ID="btn_sil" runat="server" Text="Sil" Width="80" Image-Url="~/Content/Images/sil.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_sil_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <ClientSideEvents Click="function(s,e) { e.processOnServer = confirm('Silmek istediğinizden emin misiniz?'); }" />
                                                                                    <Image Url="~/Content/Images/sil.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="50px">
                                                                                <dx:ASPxButton ID="btn_ata" runat="server" Text="Yeniden Ata" Width="80" Image-Url="~/Content/Images/yeni_ata.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_ata_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/yeni_ata.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="300" align="center"></td>
                                                    <td width="1300" align="center">
                                                        <dx:ASPxGridView ID="grid_bildirim_sil" runat="server" ClientInstanceName="grid_bildirim_sil" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="BildirimId" Width="1340px" OnPageSizeChanged="grid_bildirim_sil_PageSizeChanged" OnProcessColumnAutoFilter="grid_bildirim_sil_ProcessColumnAutoFilter" OnCustomCallback="grid_bildirim_sil_CustomCollback" OnPageIndexChanged="grid_bildirim_sil_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_bildirim_sil_BeforeColumnSortingGrouping">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn> 
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn>          
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">                                                                    
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                        
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" VisibleIndex="1" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGelenYer" Caption="Çağrı Sistemi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                           
                                                                <dx:GridViewDataTextColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                    
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonIslemTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                           
                                                                <dx:GridViewDataTextColumn FieldName="BildirimHavalimani" Caption="Havalimanı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaAdSoyad" Caption="Dava - Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaDosyaNo" Caption="Dava - Dosya No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaMahkeme" Caption="Dava - Mahkeme Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="185px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaKonu" Caption="Dava - Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="225px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimToplamSure" Caption="Toplam İşlem Süresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimVatandasKarar" Caption="Vatandaş Karar" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataCheckColumn FieldName="BildirimGeriYapildiMi" Caption="Geri Dönüş Yapıldı mı?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Evet" DisplayTextUnchecked="Hayır">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <Styles>
                                                                <AlternatingRow Enabled="True"></AlternatingRow>
                                                            </Styles>
                                                            <SettingsBehavior AllowSelectByRowClick="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="320" HorizontalScrollBarMode="Auto" />
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1200px" Height="460px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                            <clientsideevents SelectionChanged="function(s, e) {                                                            
                                                            Callback99.PerformCallback();
	                                                        LoadingPanel99.Show();                              
                                                            grid_bildirim_sil.PerformCallback();                              
                                                               }" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxCallback ID="ASPxCallback9" runat="server" ClientInstanceName="Callback99">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel99.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="LoadingPanel99" runat="server" ClientInstanceName="LoadingPanel99" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
                                                                                                                <table>
                                                            <tr>
                                                                <td width="5px" align="center">
                                                                </td>
                                                                <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bas_tarihi_2" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat_2" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Başlangıç Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>                                                                        
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bit_tarihi_2" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Vat_2" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Bitiş Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_sorgula_2" runat="server" Text="Sorgula" ValidationGroup="Group_Vat_2" Width="80" UseSubmitBehavior="true" OnClick="btn_sorgula_2_Click">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                            Callback229.PerformCallback();
                                                                            LoadingPanel229.Show();
                                                                            }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback13" runat="server" ClientInstanceName="Callback229">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel229.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel100" runat="server" ClientInstanceName="LoadingPanel229" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                        </td>
                                                            </tr>
                                                         </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:textbox id="txtUserName" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:View>                                               
                </asp:MultiView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>


