<%@ Page Title="DHMİ İletişim Merkezi - Çağrı İşlemleri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="CkbCagriIslemleri.aspx.cs" Inherits="Dhmi.Web.CkbCagriIslemleri" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
               <dx:ASPxCallback ID="ASPxCallback6" runat="server" ClientInstanceName="Callback1313">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel1313.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel3" runat="server" ClientInstanceName="LoadingPanel1313" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
               <div class="tabcontents">
                <asp:MultiView ID="MultiView1" ActiveViewIndex="0" runat="server">                                                          
                        <asp:View ID="tab_panel_4" runat="server">
                            <asp:Panel ID="Panel2" runat="server" Width="1340" Height="525">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td width="80" align="center"></td>
                                                    <td width="1200" align="center">
                                                        <dx:ASPxGridView ID="grid_gecmis" ClientInstanceName="grid_gecmis" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="BildirimId" Width="1300px" OnPageSizeChanged="grid_gecmis_PageSizeChanged" OnProcessColumnAutoFilter="grid_gecmis_ProcessColumnAutoFilter" OnCustomCallback="grid_gecmis_CustomCollback" OnPageIndexChanged="grid_gecmis_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_gecmis_BeforeColumnSortingGrouping">
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
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="155px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="145px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                             
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="255px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
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
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" VisibleIndex="1">
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
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
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
                                                            <SettingsBehavior AllowSelectByRowClick="True"/>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="322" HorizontalScrollBarMode="Auto" />
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1200px" Height="460px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                            <clientsideevents SelectionChanged="function(s, e) {                                                            
                                                            Callback999.PerformCallback();
	                                                        LoadingPanel999.Show();                              
                                                            grid_gecmis.PerformCallback();                              
                                                               }" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxCallback ID="ASPxCallback13" runat="server" ClientInstanceName="Callback999">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel999.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel9" runat="server" ClientInstanceName="LoadingPanel999" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
                                                    </td>
                                                </tr>
                                                <td width="80" align="center"></td>
                                                <td width="1320px" align="center">
                                                    <br />
                                                    <table>
                                                        <tr>
                                                            <td width="1300px" align="center">
                                                                <table>
                                                                    <tr>
                                                                        <td width="350px" align="center" height="50px"></td>
                                                                        <td width="200px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_bilgi_gecmis" runat="server" Text="Geçmiş" Width="105" Image-Url="~/Content/Images/gecmis.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="6px" Enabled="false" AutoPostBack="true">
                                                                                <Image Url="~/Content/Images/gecmis.png"></Image>
                                                                                <Paddings PaddingLeft="6px"></Paddings>
                                                                                <ClientSideEvents Click="function(s, e) { ShowGecmisWindow(); }" />
                                                                            </dx:ASPxButton>
                                                                        </td>
                                                                        <td width="200px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_bilgi_gecmis2" runat="server" ImagePosition="Top" OnClick="btn_bilgi_gecmis2_Click" Text="Çağrı Özeti" Width="105px" Enabled="false">                                                                                
                                                                                    <Image Url="~/Content/Images/genel_bilgi.png"></Image>
                                                                                    <Paddings PaddingLeft="8px"></Paddings>                                                                                    
                                                                                </dx:ASPxButton>
                                                                        </td>
                                                                        <td width="250px" align="center" height="50px">
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
                                                                            <dx:ASPxButton ID="btn_sorgula" runat="server" Text="Sorgula" ValidationGroup="Group_Vat" Width="80" UseSubmitBehavior="true" OnClick="btn_sorgula_Click">
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
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <tr>
                                                    <td>
                                                        <asp:textbox id="txtUserName2" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                <dx:ASPxPopupControl ID="pcGecmis" runat="server" CloseAction="CloseButton" Modal="True"
                                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcGecmis"
                                    HeaderText="GEÇMİŞ BİLGİLERİ" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
                                    <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); cb_yon_grup.Focus(); }" />
                                    <ContentCollection>
                                        <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">
                                            <asp:Panel ID="pnl_g_gor" runat="server" Width="685px" Height="435px" BorderColor="Maroon">
                                                <table>
                                                    <tr>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <dx:ASPxListBox ID="lb_gecmis" runat="server" Width="682" Height="432">
                                                                <ItemStyle Wrap="True" />
                                                            </dx:ASPxListBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </dx:PopupControlContentControl>
                                    </ContentCollection>
                                </dx:ASPxPopupControl>
                            </asp:Panel>
                        </asp:View>
                        <asp:View ID="tab_panel_5" runat="server">
                            <asp:Panel ID="Panel22" runat="server" Width="1340" Height="525">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td width="80" align="center"></td>
                                                    <td width="1300" align="center">
                                                        <dx:ASPxGridView ID="grid_sonuc" runat="server" ClientInstanceName="grid_sonuc" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="BildirimId" Width="1300px" OnPageSizeChanged="grid_sonuc_PageSizeChanged" OnProcessColumnAutoFilter="grid_sonuc_ProcessColumnAutoFilter" OnCustomCallback="grid_sonuc_CustomCollback" OnPageIndexChanged="grid_sonuc_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_sonuc_BeforeColumnSortingGrouping">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn>             
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">                                                                    
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimVatandasKarar" Caption="Vatandaş Karar" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="155px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>        
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="145px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="255px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
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
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" VisibleIndex="1">
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
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
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
                                                                <dx:GridViewDataCheckColumn FieldName="BildirimGeriYapildiMi" Caption="Geri Dönüş Yapıldı mı?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Evet" DisplayTextUnchecked="Hayır">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <Styles>
                                                                <AlternatingRow Enabled="True"></AlternatingRow>
                                                            </Styles>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1200px" Height="460px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <SettingsBehavior AllowSelectByRowClick="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="325" HorizontalScrollBarMode="Auto" />
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                            <clientsideevents SelectionChanged="function(s, e) {                                                            
                                                            Callback991.PerformCallback();
	                                                        LoadingPanel991.Show();                              
                                                            grid_sonuc.PerformCallback();                              
                                                               }" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxCallback ID="ASPxCallback14" runat="server" ClientInstanceName="Callback991">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel991.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel13" runat="server" ClientInstanceName="LoadingPanel991" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
                                                    </td>
                                                </tr>
                                                <td width="80" align="center"></td>
                                                <td width="1320px" align="center">
                                                    <br />
                                                    <table>
                                                        <tr>
                                                            <td width="1300px" align="center">
                                                                <table>
                                                                    <tr>
                                                                        <td width="350px" align="center" height="50px">
                                                                        </td>
                                                                        <td width="200px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_sonuc_degistir" runat="server" Text="Sonuç Güncelle" Width="145" Image-Url="~/Content/Images/guncel_ek.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="4px" Enabled="false" AutoPostBack="true">
                                                                                <Image Url="~/Content/Images/guncel_ek.png"></Image>
                                                                                <Paddings PaddingLeft="1px"></Paddings>
                                                                                <ClientSideEvents Click="function(s, e) { ShowDegistirWindow(); }" />
                                                                            </dx:ASPxButton>
                                                                        </td>
                                                                        <td width="200px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_bilgi_gecmis3" runat="server" ImagePosition="Top" OnClick="btn_bilgi_gecmis3_Click" Text="Çağrı Özeti" Width="145px" Enabled="false">                                                                                
                                                                                    <Image Url="~/Content/Images/genel_bilgi.png"></Image>
                                                                                    <Paddings PaddingLeft="9px"></Paddings>                                                                                    
                                                                                </dx:ASPxButton>
                                                                        </td>
                                                                        <td width="250px" align="center" height="50px">
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
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback229">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel229.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel100" runat="server" ClientInstanceName="LoadingPanel229" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <tr>
                                                    <td>
                                                        <asp:textbox id="txtUserName33" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                <dx:ASPxPopupControl ID="pcDegistir" runat="server" CloseAction="CloseButton" Modal="True"
                                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcDegistir"
                                    HeaderText="ÇAĞRI SONUÇ BİLGİLERİ" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
                                    <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); txt_vatandas_sonuc.Focus(); }" />
                                    <ContentCollection>
                                        <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                                            <asp:Panel ID="pnl_g_gossasas" runat="server" Width="685px" Height="190px" BorderColor="Maroon">
                                                <table>
                                                    <tr>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        <td height="150px">
                                                            <dx:ASPxMemo ID="txt_vatandas_sonuc" runat="server" Width="686px" MaxLength="4000" Height="120">
                                                                                        <ValidationSettings ValidationGroup="Group_Cagtt" ErrorDisplayMode="ImageWithTooltip">
                                                                                            <RequiredField ErrorText="Bildirim Sonucu giriniz..." IsRequired="True" />
                                                                                        </ValidationSettings>
                                                                                    </dx:ASPxMemo>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <dx:ASPxButton ID="btn_son_guncel" runat="server" Text="İçerik Güncelle" ValidationGroup="Group_Cagtt" Width="686" UseSubmitBehavior="true" OnClick="btn_son_guncel_Click">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                                        Callback431.PerformCallback();
                                                                                        LoadingPanel431.Show();
                                                                                        }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback5" runat="server" ClientInstanceName="Callback431">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel431.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel5" runat="server" ClientInstanceName="LoadingPanel431" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </dx:PopupControlContentControl>
                                    </ContentCollection>
                                </dx:ASPxPopupControl>
                            </asp:Panel>
                        </asp:View>
                </asp:MultiView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

