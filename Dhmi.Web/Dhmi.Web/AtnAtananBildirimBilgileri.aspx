<%@ Page Title="DHMİ İletişim Merkezi - Atanan Bildirim Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="AtnAtananBildirimBilgileri.aspx.cs" Inherits="Dhmi.Web.AtnAtananBildirimBilgileri" ViewStateMode="Inherit"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <script type="text/javascript">
        // <![CDATA[       
        function ShowNotWindow() {
            pcNot.Show();
        }

        function ShowYonWindow() {
            pcYon.Show();
        }

        function ShowEkSureWindow() {
            pcEkSure.Show();
        }

        function ShowSonucWindow() {
            pcSonuc.Show();
        }

        function ShowNotSonWindow() {
            pcNotSon.Show();
        }

        function ShowNotKulWindow() {
            pcNotKull.Show();
        }

        function ShowYonKulWindow() {
            pcYonKull.Show();
        }

        function ShowEkSureKulWindow() {
            pcEkSureKull.Show();
        }

        function ShowSonucKulWindow() {
            pcSonucKull.Show();
        }

        function ShowNotKulSonWindow() {
            pcNotSonKull.Show();
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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
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
                    <asp:View ID="tab_panel_1" runat="server">
                            <asp:Panel ID="Panel2" runat="server" Width="1325px" Height="440px">
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <table>
                                    <tr>
                                        <td align="center" width="1325px">
                                            <table>
                                                <tr>
                                                    <td align="center" width="450">
                                                        <table border="1" bordercolor="#928787" bgcolor="#276A91">
                                                            <tr>
                                                                <td align="center" width="450px" height="64px">
                                                                    <img src="Content/Images/chart-icon.png" alt=""/>&nbsp;
                                                                    <asp:Label ID="Label9" runat="server" ForeColor="White" Font-Names="Calibri" Font-Size="20pt" Text="BİLDİRİM İSTATİSTİKLERİ" EnableViewState="false"></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <br />
                                                        <table border="1" bordercolor="#928787" bgcolor="#D6E9F4">
                                                            <tr>
                                                                <td align="left" width="390px" height="34px">&nbsp;
                                                                    <asp:Label ID="asdasdas" runat="server" Font-Bold="True" ForeColor="Black" Font-Names="Calibri" Font-Size="12pt" Text="Yeni Bildirim Sayısı" EnableViewState="false"></asp:Label>
                                                                </td>
                                                                <td align="center" width="60px">
                                                                    <asp:LinkButton ID="lbl_atanmis" runat="server" Text="0" Font-Underline="False" Font-Bold="True" ForeColor="Black" Font-Names="Calibri" Font-Size="12pt" OnClick="lbl_atanmis_Click"></asp:LinkButton>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="left" width="370px" height="34px">&nbsp;
                                                                    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#93959C" Font-Names="Calibri" Font-Size="12pt" Text="Üzerimdeki Bildirim Sayısı" EnableViewState="false"></asp:Label>
                                                                </td>
                                                                <td align="center" width="40px">
                                                                    <asp:LinkButton ID="lbl_incelenen" runat="server" Text="0" Font-Underline="False" Font-Bold="True" ForeColor="#93959C" Font-Names="Calibri" Font-Size="12pt" OnClick="lbl_incelenen_Click"></asp:LinkButton>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="left" width="370px" height="34px">&nbsp;
                                                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Black" Font-Names="Calibri" Font-Size="12pt" Text="İşlem Yaptığım Bildirim Sayısı" EnableViewState="false"></asp:Label>
                                                                </td>
                                                                <td align="center" width="40px">
                                                                    <asp:LinkButton ID="lbl_kapatilan" runat="server" Text="0" Font-Underline="False" Font-Bold="True" ForeColor="Black" Font-Names="Calibri" Font-Size="12pt" OnClick="lbl_ek_sureli_Click"></asp:LinkButton>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="left" width="370px" height="34px">&nbsp;
                                                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#93959C" Font-Names="Calibri" Font-Size="12pt" Text="Atanan Toplam Bildirim Sayısı" EnableViewState="false"></asp:Label>
                                                                </td>
                                                                <td align="center" width="40px">
                                                                    <asp:LinkButton ID="lbl_sayi_ben" runat="server" Text="0" Font-Underline="False" Font-Bold="True" ForeColor="#93959C" Font-Names="Calibri" Font-Size="12pt" OnClick="lbl_sayi_ben_Click"></asp:LinkButton>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <table>
                                                            <tr>
                                                                <td align="left" height="30px">
                                                                    <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="Red" Font-Names="Calibri" Font-Size="10pt" Text="* Ayrıntılara ulaşabilmek için lütfen sayıların üzerine tıklayınız..." EnableViewState="false"></asp:Label>
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
                            <asp:Panel ID="Panel1" runat="server" Width="1340px" Height="535px">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                                            <ContentTemplate>
                                            <table>
                                                <tr>
                                                    <td align="center" width="1900px">
                                                                <dx:ASPxGridView ID="grid_bildirim_incele" EnableViewState="false" ClientInstanceName="grid_bildirim_incele" runat="server" AutoGenerateColumns="False" ClientIDMode="AutoID" EnableCallBacks="False" KeyFieldName="BildirimId" OnHtmlRowPrepared="grid_bildirim_incele_HtmlRowPrepared" OnPageSizeChanged="grid_bildirim_incele_PageSizeChanged" OnCustomCallback="grid_bildirim_incele_CustomCollback" Width="1180px" OnProcessColumnAutoFilter="grid_bildirim_incele_ProcessColumnAutoFilter" OnPageIndexChanged="grid_bildirim_incele_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_bildirim_incele_BeforeColumnSortingGrouping">
                                                            <Columns>  
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn Caption="Bildirim No" FieldName="BildirimId" ShowInCustomizationForm="True" Width="110px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="55"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn> 
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="75"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataTextColumn Caption="Sonuç" FieldName="BildirimSonucAd" ShowInCustomizationForm="True" Width="165px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Bildirim Türü" FieldName="BildirimTuruAd" ShowInCustomizationForm="True" Width="150px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Bilgilendirme Şekli" FieldName="BildirimGeriDonusAd" ShowInCustomizationForm="True" Width="165px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn Caption="Vatandaş Adı Soyadı/Firma Adı" FieldName="VatandasAdSoyad" ShowInCustomizationForm="True" Width="260px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Telefon" FieldName="VatandasTel1" ShowInCustomizationForm="True" Width="110px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn Caption="Çağrı Sistemi" FieldName="BildirimGelenYer" ShowInCustomizationForm="True" Width="125px" Visible="false">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataMemoColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="35"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>                                                                                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn Caption="Son İşlem Tarihi" FieldName="BildirimSonIslemTarih" ShowInCustomizationForm="True" Width="170px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaAdSoyad" Caption="Dava - Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaDosyaNo" Caption="Dava - Dosya No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaMahkeme" Caption="Dava - Mahkeme Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="185px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimDavaKonu" Caption="Dava - Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="225px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="40"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataTextColumn Caption="Toplam İşlem Süresi" FieldName="BildirimToplamSure" ShowInCustomizationForm="True" Width="205px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowSelectByRowClick="True"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1100px" Height="465px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <Settings HorizontalScrollBarMode="Auto" ShowFooter="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollableHeight="391" VerticalScrollBarMode="Auto" />
                                                            <clientsideevents SelectionChanged="function(s, e) {                                                            
                                                            Callback99.PerformCallback();
	                                                        LoadingPanel99.Show();                              
                                                            grid_bildirim_incele.PerformCallback();                              
                                                               }" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxCallback ID="ASPxCallback2" runat="server" ClientInstanceName="Callback99">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel99.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="LoadingPanel99" runat="server" ClientInstanceName="LoadingPanel99" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
                                                                <asp:Timer ID="Timer1" OnTick="Timer1_Tick" runat="server" Interval="1000000">
                                                                </asp:Timer>                                                                                                                      
                                                        <br />
                                                        <table>
                                                            <tr>
                                                                <td align="left" width="25">
                                                                    <img src="Content/Images/orange.png" alt="" />
                                                                </td>
                                                                <td align="left" width="70">Atandı </td>
                                                                <td align="left" width="1086"></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td align="center" width="20px"></td>
                                                    <td align="center" width="200px">
                                                        <table>
                                                            <tr>
                                                                <td align="center" width="100px">
                                                                    <table>
                                                                        <tr>
                                                                            <td align="center" height="67px" width="50px">
                                                                                <dx:ASPxPanel ID="pnl_ust_ana" runat="server" BackColor="#E7EAEE" Height="56px" Width="135px">
                                                                                    <PanelCollection>
                                                                                        <dx:PanelContent ID="PanelContent1" runat="server">
                                                                                            <table>
                                                                                                <tr>
                                                                                                    <td height="56px">
                                                                                                        <dx:ASPxLabel ID="lbl_secilen" runat="server" Font-Size="22pt" ForeColor="Red" Text="-">
                                                                                                        </dx:ASPxLabel>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </dx:PanelContent>
                                                                                    </PanelCollection>
                                                                                </dx:ASPxPanel>
                                                                            </td>
                                                                        </tr>                                                                        
                                                                        <tr>
                                                                            <td align="center" height="67px" width="50px">
                                                                                <dx:ASPxButton ID="btn_bilgi_bankasi" runat="server" ImagePosition="Top" OnClick="btn_bilgi_bankasi_Click" Text="Bilgi Bankası" Width="135px" EnableViewState="false">
                                                                                    <Image Url="~/Content/Images/bilgiss.png">
                                                                                    </Image>
                                                                                    <Paddings PaddingLeft="13px" />
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="67px" width="50px">
                                                                                <dx:ASPxButton ID="btn_bilgi_gecmis" runat="server" ImagePosition="Top" OnClick="btn_bilgi_gecmis_Click" Text="Çağrı Özeti" Width="135px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/genel_bilgi.png"></Image>
                                                                                    <Paddings PaddingLeft="13px"></Paddings>                                                                                    
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="67px" width="50px">
                                                                                <dx:ASPxButton ID="btn_dosyasi" runat="server" ImagePosition="Top" OnClick="btn_dosyasi_Click" Text="Dosya Durumu" Width="135px" Enabled="false">                                                                                
                                                                                    <Image Url="~/Content/Images/Document.png"></Image>
                                                                                    <Paddings PaddingLeft="5px"></Paddings>                                                                                    
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="67px" width="50px">
                                                                                <dx:ASPxButton ID="btn_incele" runat="server" Enabled="False" ImagePosition="Top" OnClick="btn_incele_Click" Text="İncelemeye Al" Width="135px">
                                                                                    <Image Url="~/Content/Images/incele.png">
                                                                                    </Image>
                                                                                    <Paddings PaddingLeft="9px" />
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <br />
                                                                    <br />
                                                                    <br />
                                                                    <br />
                                                                    <br />
                                                                    <br />
                                                                    <br />
                                                                    <br />
                                                                    <br />                                                                    
                                                                    <br />     
                                                                    <br />     
                                                                    <br />     
                                                                    <br />     
                                                                    <br />     
                                                                    <br />     
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>                                                    
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:textbox id="txtUserName" runat="server" visible="False" width="10px" xmlns:asp="#unknown"></asp:textbox>
                                                    </td>
                                                </tr>
                                            </table>                                            
                                            </ContentTemplate>
                                                            <Triggers>                      
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
                                                        </asp:UpdatePanel>                                            
                                            <table>
                                                <tr>
                                                    <td width="11" align="center"></td>
                                                    <td width="1040" align="center">                                                        
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:View>                    
                    <asp:View ID="tab_panel_3" runat="server">                        
                            <asp:Panel ID="Panel3" runat="server" Width="1340px" Height="525px">
                            <br />
                                <table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td align="center" width="1800px">
                                                        <dx:ASPxGridView ID="grid_bildirim_kul_incele" EnableViewState="false" runat="server" AutoGenerateColumns="False" ClientIDMode="AutoID" EnableCallBacks="False" KeyFieldName="BildirimId" OnHtmlRowPrepared="grid_bildirim_kul_incele_HtmlRowPrepared" OnPageSizeChanged="grid_bildirim_kul_incele_PageSizeChanged" ClientInstanceName="grid_bildirim_kul_incele" OnCustomCallback="grid_bildirim_kul_incele_CustomCollback" Width="1170px" OnProcessColumnAutoFilter="grid_bildirim_kul_incele_ProcessColumnAutoFilter" OnPageIndexChanged="grid_bildirim_kul_incele_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_bildirim_kul_incele_BeforeColumnSortingGrouping">
                                                            <Columns>                                                                
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn Caption="Bildirim No" FieldName="BildirimId" ShowInCustomizationForm="True" Width="110px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="55"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="75"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>  
                                                                <dx:GridViewDataTextColumn Caption="Sonuç" FieldName="BildirimSonucAd" ShowInCustomizationForm="True" Width="165px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Bildirim Türü" FieldName="BildirimTuruAd" ShowInCustomizationForm="True" Width="150px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Bilgilendirme Şekli" FieldName="BildirimGeriDonusAd" ShowInCustomizationForm="True" Width="165px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                              
                                                                <dx:GridViewDataTextColumn Caption="Vatandaş Adı Soyadı/Firma Adı" FieldName="VatandasAdSoyad" ShowInCustomizationForm="True" Width="260px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Telefon" FieldName="VatandasTel1" ShowInCustomizationForm="True" Width="110px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                 <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn Caption="Çağrı Sistemi" FieldName="BildirimGelenYer" ShowInCustomizationForm="True" Width="125px" Visible="false">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataMemoColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="35"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>                                                                                                                                                                                               
                                                                <dx:GridViewDataTextColumn Caption="Son İşlem Tarihi" FieldName="BildirimSonIslemTarih" ShowInCustomizationForm="True" Width="170px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaAdSoyad" Caption="Dava - Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaDosyaNo" Caption="Dava - Dosya No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaMahkeme" Caption="Dava - Mahkeme Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="185px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimDavaKonu" Caption="Dava - Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="225px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="40"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn> 
                                                                <dx:GridViewDataTextColumn Caption="Toplam İşlem Süresi" FieldName="BildirimToplamSure" ShowInCustomizationForm="True" Width="205px">
                                                                    <HeaderStyle Font-Bold="True" ForeColor="Maroon" HorizontalAlign="Center" />
                                                                    <CellStyle HorizontalAlign="Center">
                                                                    </CellStyle>
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowSelectByRowClick="True" />
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1100px" Height="465px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <Settings HorizontalScrollBarMode="Auto" ShowFooter="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollableHeight="420" VerticalScrollBarMode="Auto" />
                                                            <clientsideevents SelectionChanged="function(s, e) {                                                            
                                                            Callback991.PerformCallback();
	                                                        LoadingPanel991.Show();                              
                                                            grid_bildirim_kul_incele.PerformCallback();                              
                                                               }" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback991">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel991.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel991" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel> 
                                                        <br />
                                                        <table>
                                                            <tr>
                                                                <td align="left" width="25">
                                                                    <img src="Content/Images/blue.png" alt="" />
                                                                </td>
                                                                <td align="left" width="100">İnceleniyor </td>
                                                                <td align="left" width="25">
                                                                    <img src="Content/Images/pink.png" alt="" />
                                                                </td>
                                                                <td align="left" width="150">İnceleniyor - Ek Süre </td>
                                                                <td align="left" width="871"></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td align="center" width="20px"></td>
                                                    <td align="center" width="200px">
                                                        <table>
                                                            <tr>
                                                                <td align="center" width="300px">
                                                                    <table>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                <dx:ASPxPanel ID="ASPxPanel1" runat="server" BackColor="#E7EAEE" Height="53px" Width="135px">
                                                                                    <PanelCollection>
                                                                                        <dx:PanelContent ID="PanelContent2" runat="server">
                                                                                            <table>
                                                                                                <tr>
                                                                                                    <td height="56px">
                                                                                                        <dx:ASPxLabel ID="lbl_sec_ikinci" runat="server" Font-Size="22pt" ForeColor="Red" Text="-">
                                                                                                        </dx:ASPxLabel>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </dx:PanelContent>
                                                                                    </PanelCollection>
                                                                                </dx:ASPxPanel>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                <dx:ASPxButton ID="btn_bilgi_bankasi_kull" runat="server" ImagePosition="Top" OnClick="btn_bilgi_bankasi_kull_Click" Text="Bilgi Bankası" Width="135px" EnableViewState="false">
                                                                                    <Image Url="~/Content/Images/bilgiss.png">
                                                                                    </Image>
                                                                                    <Paddings PaddingLeft="6px" />
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                 <dx:ASPxButton ID="btn_bilgi_gecmis2" runat="server" ImagePosition="Top" OnClick="btn_bilgi_gecmis2_Click" Text="Çağrı Özeti" Width="135px" Enabled="false">                                                                                
                                                                                    <Image Url="~/Content/Images/genel_bilgi.png"></Image>
                                                                                    <Paddings PaddingLeft="13px"></Paddings>                                                                                    
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                 <dx:ASPxButton ID="btn_dosyasi2" runat="server" ImagePosition="Top" OnClick="btn_dosyasi2_Click" Text="Dosya Durumu" Width="135px" Enabled="false">                                                                                
                                                                                    <Image Url="~/Content/Images/Document.png"></Image>
                                                                                    <Paddings PaddingLeft="5px"></Paddings>                                                                                    
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                <dx:ASPxButton ID="btn_not_ekle_kull" runat="server" AutoPostBack="False" Enabled="False" ImagePosition="Top" Text="Not Ekle" UseSubmitBehavior="False" Width="135px">
                                                                                    <ClientSideEvents Click="function(s, e) { ShowNotKulWindow(); }" />
                                                                                    <Image Url="~/Content/Images/nottos.png">
                                                                                    </Image>
                                                                                    <Paddings PaddingLeft="8px" />
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                <dx:ASPxButton ID="btn_yonlendir_kull" runat="server" AutoPostBack="False" Enabled="False" ImagePosition="Top" Text="Yönlendir" UseSubmitBehavior="False" Width="135px">
                                                                                    <ClientSideEvents Click="function(s, e) { ShowYonKulWindow(); }" />
                                                                                    <Image Url="~/Content/Images/yonlendir.png">
                                                                                    </Image>
                                                                                    <Paddings PaddingLeft="5px" />
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                <dx:ASPxButton ID="btn_ek_sure_kull" runat="server" Enabled="False" ImagePosition="Top" Text="Ek Süre Talep Et" UseSubmitBehavior="False" Width="135px">
                                                                                    <ClientSideEvents Click="function(s, e) { ShowEkSureKulWindow(); }" />
                                                                                    <Image Url="~/Content/Images/eksure.png">
                                                                                    </Image>
                                                                                    <Paddings PaddingLeft="5px" />
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="center" height="63px" width="150px">
                                                                                <dx:ASPxButton ID="btn_sonuclandir_kull" runat="server" Enabled="False" ImagePosition="Top" Text="Sonuçlandır" UseSubmitBehavior="False" Width="135px">
                                                                                    <ClientSideEvents Click="function(s, e) { ShowSonucKulWindow(); }" />
                                                                                    <Image Url="~/Content/Images/sonuclandir.png">
                                                                                    </Image>
                                                                                    <Paddings PaddingLeft="10px" />
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                        </tr>                                                                        
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <br />
                                                                    <br />
                                                                    <br />                                                                    
                                                                    <br />                                                                    
                                                    </td>
                                                    <td align="center" width="30px"></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:textbox id="txtUserNamekul" runat="server" visible="False" width="10px" xmlns:asp="#unknown"></asp:textbox>
                                                    </td>
                                                </tr>
                                            </table>                                            
                                            <table>
                                                <tr>
                                                    <td width="11" align="center"></td>
                                                    <td width="1040" align="center">
                                                        <dx:ASPxPopupControl ID="pcYonKull" runat="server" CloseAction="CloseButton" Modal="True"
                                                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcYonKull"
                                                            HeaderText="YÖNLENDİR" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
                                                            <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); cb_yon_grupkul.Focus(); }" />
                                                            <ContentCollection>
                                                                <dx:PopupControlContentControl ID="PopupControlContentControl5" runat="server">
                                                                    <asp:Panel ID="Panel6" runat="server" Width="1048px" Height="112px" BorderColor="Maroon">
                                                                        <br />
                                                                        <table>
                                                                            <tr>
                                                                                <td>
                                                                                    <table>
                                                                                        <tr>
                                                                                            <td></td>
                                                                                            <td colspan="5"><label style="color:red; font-weight:bold">UYARI: İletmek istediğiniz grup ya da kullanıcıyı seçip, notunuzu da ekleyerek yönlendir butonuna basınız...</label></td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td width="12px"></td>
                                                                                            <td width="60px">
                                                                                                <br />
                                                                                                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Grup:" ForeColor="Maroon" Font-Bold="True"></dx:ASPxLabel>
                                                                                            </td>
                                                                                            <td width="300" align="left">
                                                                                                <br />
                                                                                                <dx:ASPxComboBox ID="cb_yon_grupkul" runat="server" Width="220px" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                </dx:ASPxComboBox>
                                                                                            </td>
                                                                                            <td>
                                                                                                <br />
                                                                                                <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Kullanıcı:" ForeColor="Maroon" Font-Bold="True"></dx:ASPxLabel>
                                                                                            </td>
                                                                                            <td width="250" align="center">
                                                                                                <br />
                                                                                                <dx:ASPxComboBox ID="cb_yon_kullanicikul" runat="server" Width="220px" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                </dx:ASPxComboBox>
                                                                                            </td>                                                                                                                                                                                        
                                                                                        </tr>
                                                                                    </table>                                                                                    
                                                                                    <table>
                                                                                        <tr>
                                                                                            <td width="12px"></td>
                                                                                            <td width="60px">
                                                                                                <br />
                                                                                                <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Not:" ForeColor="Maroon" Font-Bold="True"></dx:ASPxLabel>
                                                                                            </td>
                                                                                            <td width="482" align="left">
                                                                                                <br />                                                                                                
                                                                                                <dx:ASPxTextBox ID="txt_gerekcesi" runat="server" MaxLength="1000" Width="440">                                                                                                                                    
                                                                                                    <ValidationSettings ValidationGroup="Group_Cf" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                                        <RequiredField ErrorText="Kişisel Not giriniz..." IsRequired="true"/>
                                                                                                                                    </ValidationSettings>
                                                                                                </dx:ASPxTextBox>
                                                                                            </td>                                                                                                                                                                                       
                                                                                            <td>
                                                                                                <br />
                                                                                                <dx:ASPxButton ID="btn_yon_okkul" runat="server" Text="Yönlendir" ValidationGroup="Group_Cf" Width="120px" OnClick="btn_yon_okkul_Click">
                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                                        Callback43.PerformCallback();
                                                                                        LoadingPanel43.Show();
                                                                                        }" />
                                                                                                </dx:ASPxButton>
                                                                                                <dx:ASPxCallback ID="ASPxCallback11" runat="server" ClientInstanceName="Callback43">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel43.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel11" runat="server" ClientInstanceName="LoadingPanel43" Modal="True" Text="Yönlendirme yapılıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </asp:Panel>
                                                                </dx:PopupControlContentControl>
                                                            </ContentCollection>
                                                        </dx:ASPxPopupControl>
                                                        <dx:ASPxPopupControl ID="pcEkSureKull" runat="server" CloseAction="CloseButton" Modal="True"
                                                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcEkSureKull"
                                                            HeaderText="EK SÜRE TALEP ET" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
                                                            <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); cb_gunkul.Focus(); }" />
                                                            <ContentCollection>
                                                                <dx:PopupControlContentControl ID="PopupControlContentControl6" runat="server">
                                                                    <asp:Panel ID="Panel7" runat="server" Width="1048px" Height="76px" BorderColor="Maroon">
                                                                        <br />
                                                                        <table>
                                                                            <tr>
                                                                                <td align="center" width="1100px">
                                                                                    <dx:ASPxLabel ID="lbl_makskul" runat="server" Text=" (Maksimum süre talebi: 3 GÜN (72 SAAT))" ForeColor="Maroon" Font-Bold="True" Font-Size="9pt"></dx:ASPxLabel>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <br />
                                                                                    <table>
                                                                                        <tr>
                                                                                            <td width="310"></td>
                                                                                            <td width="40">
                                                                                                <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Gün:" ForeColor="Maroon" Font-Bold="True"></dx:ASPxLabel>
                                                                                            </td>
                                                                                            <td width="140" align="left">
                                                                                                <dx:ASPxComboBox ID="cb_gunkul" runat="server" Width="100px" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                    <Items>
                                                                                                        <dx:ListEditItem Text="1" Value="1"/>
                                                                                                    </Items>
                                                                                                    <ValidationSettings ValidationGroup="Group_Cagt" ErrorDisplayMode="ImageWithTooltip">
                                                                                                        <RequiredField ErrorText="Gün seçiniz..." IsRequired="True" />
                                                                                                    </ValidationSettings>
                                                                                                </dx:ASPxComboBox>
                                                                                            </td>
                                                                                            <td width="45">
                                                                                                <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Saat:" ForeColor="Maroon" Font-Bold="True"></dx:ASPxLabel>
                                                                                            </td>
                                                                                            <td width="120" align="left">
                                                                                                <dx:ASPxComboBox ID="cb_saatkul" runat="server" Width="100px" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                    <ValidationSettings ValidationGroup="Group_Cagt" ErrorDisplayMode="ImageWithTooltip">
                                                                                                        <RequiredField ErrorText="Saat seçiniz..." IsRequired="True" />
                                                                                                    </ValidationSettings>
                                                                                                </dx:ASPxComboBox>
                                                                                            </td>
                                                                                            <td>
                                                                                                <dx:ASPxButton ID="btn_onaylakul" runat="server" Text="Talep Et" ValidationGroup="Group_Cag" Width="90px" OnClick="btn_onaylakul_Click">
                                                                                                </dx:ASPxButton>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </asp:Panel>
                                                                </dx:PopupControlContentControl>
                                                            </ContentCollection>
                                                        </dx:ASPxPopupControl>
                                                        <dx:ASPxPopupControl ID="pcSonucKull" runat="server" CloseAction="CloseButton" Modal="True"
                                                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcSonucKull"
                                                            HeaderText="SONUÇLANDIR" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
                                                            <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); cb_sonuckul.Focus(); }" />
                                                            <ContentCollection>
                                                                <dx:PopupControlContentControl ID="PopupControlContentControl7" runat="server">
                                                                    <asp:Panel ID="Panel8" runat="server" Width="612px" BorderColor="Maroon">
                                                                        <br />
                                                                        <table>
                                                                             <tr>
                                                                                <td align="left" width="605">
                                                                                    <label style="color:red; font-weight:bold">UYARI: Bildirimin kullanıcılar tarafından sonlandırılması sonucu sisteme aktarılan içerik bilgisi Vatandaş tarafından görüntülenecektir. Bu hususta dikkatli olmanızı rica ederiz...</label>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <br />
                                                                        <table>
                                                                            <tr>
                                                                                <td width="24px">
                                                                                </td>
                                                                                <td>
                                                                                    <dx:ASPxComboBox ID="cb_sonuckul" runat="server" IncrementalFilteringMode="Contains" NullText="Seçiniz..." Width="500px">
                                                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Group_Css">
                                                                                <RequiredField ErrorText="Sonuç Seçiniz..." IsRequired="True" />
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>                                                                                                                                                
                                                                        <br />
                                                                        <table>
                                                                            <tr>
                                                                                <td width="24px">
                                                                                </td>
                                                                                <td>
                                                                                    <dx:ASPxMemo ID="txt_aciklamakul" runat="server" MaxLength="4000" Width="500px" Height="240px">
                                                                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Group_Css">
                                                                                <RequiredField ErrorText="Açıklama giriniz..." IsRequired="True" />
                                                                            </ValidationSettings>
                                                                        </dx:ASPxMemo>
                                                                                </td>
                                                                            </tr>
                                                                        </table>                                                                        
                                                                        <br />
                                                                        <dx:ASPxButton ID="btn_sonuc_okkul" runat="server" OnClick="btn_sonuc_okkul_Click" Text="Sonuçlandır - Reddet" ValidationGroup="Group_Css" Width="220px">
                                                                        <ClientSideEvents Click="function(s, e) {
                                                                                        Callback99.PerformCallback();
                                                                                        LoadingPanel99.Show();
                                                                                        }" />
                                                                        </dx:ASPxButton>
                                                                        <dx:ASPxCallback ID="ASPxCallback5" runat="server" ClientInstanceName="Callback99">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel99.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel4" runat="server" ClientInstanceName="LoadingPanel99" Modal="True" Text="İşlem sonuçlandırılıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel> 
                                                                    </asp:Panel>
                                                                </dx:PopupControlContentControl>
                                                            </ContentCollection>
                                                        </dx:ASPxPopupControl>
                                                        <dx:ASPxPopupControl ID="pcNotKull" runat="server" CloseAction="CloseButton" Modal="True"
                                                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcNotKull"
                                                            HeaderText="NOT EKLE" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
                                                            <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); txt_bgkul.Focus(); }" />
                                                            <ContentCollection>
                                                                <dx:PopupControlContentControl ID="PopupControlContentControl8" runat="server">
                                                                    <asp:Panel ID="Panel9" runat="server" Width="512px" BorderColor="Maroon">
                                                                        <br />
                                                                        <table>
                                                                             <tr>
                                                                                <td align="left" width="605">
                                                                                    <label style="color:red; font-weight:bold">UYARI: Bildirim için kullanıcılar tarafından eklenen notlar sadece sistem kullanıcıları tarafından görüntülenecek olup, Vatandaş tarafından görüntülenemeyecektir. Vatandaşımızın görebileceği bilgiler 'SONUÇLANDIR' bölümünde kayıt altına alınacaktır...</label>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <br />
                                                                        <table>                                                                           
                                                                            <tr>
                                                                                <td align="center" width="25">
                                                                                    
                                                                                </td>
                                                                                <td align="center" width="400">
                                                                                <dx:ASPxMemo ID="txt_bgkul" runat="server" Width="300px" MaxLength="2000" Height="100px">
                                                                            <ValidationSettings ValidationGroup="Group_Csp" ErrorDisplayMode="ImageWithTooltip">
                                                                                <RequiredField ErrorText="Not giriniz..." IsRequired="True" />
                                                                            </ValidationSettings>
                                                                        </dx:ASPxMemo>
                                                                                </td>
                                                                            </tr>
                                                                            </table>
                                                                            <br />
                                                                            <table>
                                                                            <tr>
                                                                                <td align="center" width="500">
                                                                                    <dx:ASPxButton ID="btn_not_ekle_ustunekul" runat="server" Text="Not Ekle" ValidationGroup="Group_Csp" Width="300px" OnClick="btn_not_ekle_ustunekul_Click">
                                                                                    </dx:ASPxButton>
                                                                                </td>
                                                                            </tr>
                                                                        </table>                                                                       
                                                                        <br />                                                                                                                                                
                                                                    </asp:Panel>
                                                                </dx:PopupControlContentControl>
                                                            </ContentCollection>
                                                        </dx:ASPxPopupControl>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:View>                    
                    <asp:View ID="tab_panel_4" runat="server">                        
                            <asp:Panel ID="Panel4" runat="server" Width="1320" Height="555">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>
                                                <tr>
                                                </tr>
                                                <tr>
                                                    <td width="500px" align="center"></td>
                                                    <td width="1000px" align="center">
                                                        <dx:ASPxGridView ID="grid_bildirim_yon_incele" EnableViewState="false" ClientInstanceName="grid_bildirim_yon_incele" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" KeyFieldName="BildirimId" Width="1300px" OnPageSizeChanged="grid_bildirim_yon_incele_PageSizeChanged" OnHtmlRowPrepared="grid_bildirim_yon_incele_HtmlRowPrepared" OnCustomCallback="grid_bildirim_yon_incele_CustomCollback" EnableCallBacks="False" OnProcessColumnAutoFilter="grid_bildirim_yon_incele_ProcessColumnAutoFilter" OnPageIndexChanged="grid_bildirim_yon_incele_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_bildirim_yon_incele_BeforeColumnSortingGrouping">
                                                            <Columns>      
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                    <PropertiesMemoEdit Height="100"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                    <PropertiesMemoEdit Height="55"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn> 
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                    <PropertiesMemoEdit Height="75"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                 <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>         
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGelenYer" Caption="Çağrı Sistemi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="True" Visible="false">
                                                                </dx:GridViewDataTextColumn>                                                                                                                        
                                                                <dx:GridViewDataMemoColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                    <PropertiesMemoEdit Height="35"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonIslemTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>         
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaAdSoyad" Caption="Dava - Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaDosyaNo" Caption="Dava - Dosya No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaMahkeme" Caption="Dava - Mahkeme Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="185px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimDavaKonu" Caption="Dava - Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="225px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                    <PropertiesMemoEdit Height="40"></PropertiesMemoEdit>
                                                                    <Settings FilterMode="Value" AutoFilterCondition="Contains" />
                                                                </dx:GridViewDataMemoColumn>                                                                                                                     
                                                                <dx:GridViewDataTextColumn FieldName="BildirimToplamSure" Caption="Toplam İşlem Süresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="True">
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowSelectByRowClick="True"/>
                                                            <Settings ShowFooter="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="388" HorizontalScrollBarMode="Auto" />
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1100px" Height="465px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <clientsideevents SelectionChanged="function(s, e) {                                                            
                                                            Callback999.PerformCallback();
	                                                        LoadingPanel999.Show();                              
                                                            grid_bildirim_yon_incele.PerformCallback();                              
                                                               }" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxCallback ID="ASPxCallback3" runat="server" ClientInstanceName="Callback999">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel999.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel999" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel> 
                                                        <br />
                                                        <table>
                                                            <tr>
                                                                <td width="25" align="left">
                                                                    <img src="Content/Images/red.png" alt="" />
                                                                </td>
                                                                <td width="90" align="left">Reddedildi
                                                                </td>
                                                                <td width="25" align="left">
                                                                    <img src="Content/Images/grey.png" alt="" />
                                                                </td>
                                                                <td width="120" align="left">Sonuçlandı
                                                                </td>
                                                                <td width="175" align="left">
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
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback4" runat="server" ClientInstanceName="Callback229">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel229.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel100" runat="server" ClientInstanceName="LoadingPanel229" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                        </td>
                                                                <td width="300" align="right"></td>
                                                                <td width="62" align="center">
                                                                    <dx:ASPxPanel ID="ASPxPanel2" runat="server" BackColor="#E7EAEE" Height="43px" Width="83px">
                                                                                    <PanelCollection>
                                                                                        <dx:PanelContent ID="PanelContent3" runat="server">
                                                                                            <table>
                                                                                                <tr>
                                                                                                    <td height="39px" width="center">
                                                                                                        <dx:ASPxLabel ID="lbl_ozet_adi" runat="server" Font-Size="16pt" ForeColor="Red" Text="-" EnableViewState="false">
                                                                                                        </dx:ASPxLabel>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </dx:PanelContent>
                                                                                    </PanelCollection>
                                                                                </dx:ASPxPanel>
                                                                </td>
                                                                <td width="190" align="right">                                                                    
                                                                    <dx:ASPxButton ID="btn_bilgi_gecmis4" runat="server" Text="  Çağrı Özeti" Width="180" Font-Bold="true" Image-Url="~/Content/Images/genel_bilgi_2.png" ImagePosition="Left" UseSubmitBehavior="true" Paddings-PaddingLeft="3px" OnClick="btn_bilgi_gecmis4_Click" ForeColor="Maroon" Enabled="false">
                                                                    </dx:ASPxButton>                                                                
                                                                </td>
                                                                <td width="190" align="right">                                                                    
                                                                    <dx:ASPxButton ID="btn_dosyasi3" runat="server" Text="  Dosya Durumu" Width="180" Font-Bold="true" Image-Url="~/Content/Images/Document2.png" ImagePosition="Left" UseSubmitBehavior="true" Paddings-PaddingLeft="11px" OnClick="btn_dosyasi3_Click" ForeColor="Maroon" Enabled="false">
                                                                    </dx:ASPxButton>                                                                
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:textbox id="txtUserNameyon" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
                                                    </td>
                                                </tr>
                                            </table>                                                                                        
                                        </td>
                                    </tr>
                                </table>
                                <dx:ASPxPopupControl ID="pcNotSon" runat="server" CloseAction="CloseButton" Modal="True"
                                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcNotSon"
                                    HeaderText="NOT EKLE" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
                                    <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); txt_bg_son.Focus(); }" />
                                    <ContentCollection>
                                        <dx:PopupControlContentControl ID="PopupControlContentControl9" runat="server">
                                            <asp:Panel ID="Panel5" runat="server" Width="1048px" Height="58px" BorderColor="Maroon">
                                                <br />
                                                <table>
                                                    <tr>
                                                        <td width="120" align="left"></td>
                                                        <td width="70" align="left">Notunuz:
                                                        </td>
                                                        <td width="620" align="left">
                                                            <dx:ASPxTextBox ID="txt_bg_son" runat="server" Width="590" MaxLength="250">
                                                                <ValidationSettings ValidationGroup="Group_Casp" ErrorDisplayMode="ImageWithTooltip">
                                                                    <RequiredField ErrorText="Not giriniz..." IsRequired="true" />
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td width="150" align="left">
                                                            <dx:ASPxButton ID="btn_not_ekle_sonda" runat="server" Text="Not Ekle" ValidationGroup="Group_Casp" Width="135" UseSubmitBehavior="true" OnClick="btn_not_ekle_sonda_Click">
                                                            </dx:ASPxButton>
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
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1320" Height="530">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td width="600px"></td>
                                                    <td width="1250px">
                                                        <dx:ASPxGridView ID="grid_bildirim" EnableViewState="false" ClientInstanceName="grid_bildirim" runat="server" Width="1290px" AutoGenerateColumns="false" KeyFieldName="BildirimId" OnPageSizeChanged="grid_bildirim_PageSizeChanged" OnHtmlRowPrepared="grid_bildirim_HtmlRowPrepared" OnProcessColumnAutoFilter="grid_bildirim_ProcessColumnAutoFilter" OnBeforeColumnSortingGrouping="grid_bildirim_BeforeColumnSortingGrouping" OnPageIndexChanged="grid_bildirim_PageIndexChanged">
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
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="55"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn> 
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="75"></PropertiesMemoEdit>
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
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGelenYer" Caption="Çağrı Sistemi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" Visible="false">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataMemoColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="35"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn>                                                                                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonIslemTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
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
                                                                <dx:GridViewDataMemoColumn FieldName="BildirimDavaKonu" Caption="Dava - Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="225px" HeaderStyle-HorizontalAlign="Center">
                                                                    <PropertiesMemoEdit Height="40"></PropertiesMemoEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataMemoColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimToplamSure" Caption="Toplam İşlem Süresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                            </Columns>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm" />
                                                            <SettingsPopup>
                                                                <EditForm Width="1100px" Height="465px" Modal="true" VerticalAlign="WindowCenter" />
                                                            </SettingsPopup>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="368" HorizontalScrollBarMode="Auto" />
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <br />
                                                        <table>
                                                            <tr>
                                                                <td width="25" align="left">
                                                                    <img src="Content/Images/orange.png" alt=""/>
                                                                </td>
                                                                <td width="70" align="left">Atandı
                                                                </td>
                                                                <td width="25" align="left">
                                                                    <img src="Content/Images/blue.png" alt="" />
                                                                </td>
                                                                <td width="100" align="left">İnceleniyor
                                                                </td>
                                                                <td width="25" align="left">
                                                                    <img src="Content/Images/pink.png" alt="" />
                                                                </td>
                                                                <td width="162" align="left">İnceleniyor - Ek Süre
                                                                </td>
                                                                <td width="25" align="left">
                                                                    <img src="Content/Images/red.png" alt="" />
                                                                </td>
                                                                <td width="85" align="left">Reddedildi
                                                                </td>
                                                                <td width="25" align="left">
                                                                    <img src="Content/Images/grey.png" alt="" />
                                                                </td>
                                                                <td width="100" align="left">Sonuçlandı
                                                                </td>       
                                                                <td width="150" align="left">
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
                                                                <td width="406" align="right">
                                                                    <dx:ASPxButton ID="btnPdfExport" runat="server" Text="  Rapor Al" Width="180" Font-Bold="true" Image-Url="~/Content/Images/report.png" ImagePosition="Left" UseSubmitBehavior="true" Paddings-PaddingLeft="3px" OnClick="btnPdfExport_Click" ForeColor="Maroon" EnableViewState="false">
                                                                    </dx:ASPxButton>
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
                </asp:MultiView>
                </div>  
                </ContentTemplate>                                
        </asp:UpdatePanel>          
    </div>
</asp:Content>