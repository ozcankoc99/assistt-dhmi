<%@ Page Title="DHMİ İletişim Merkezi - Rapor Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="SrpRaporBilgileri.aspx.cs" Inherits="Dhmi.Web.SrpRaporBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Yeni Kayıt">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1310" Height="465">
                                <table>
                                    <tr>
                                        <td width="1320" align="center" height="50px">
                                            <table>
                                                <tr>        
                                                    <td>
                                                        <asp:Panel ID="panel2" runat="server" Width="1305px" Height="44px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                            <table>
                                                                <tr>
                                                                    <td align="left" width="265">
                                                                    </td>
                                                                    <td align="left" width="80" height="12px">                                                                    
                                                                    </td>
                                                                    <td align="left" width="490">                                                            
                                                                    </td>
                                                                    <td align="left" width="200">                                                            
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" width="265">
                                                                    </td>
                                                                    <td align="left" width="80" height="12px">     
                                                                        Rapor Türü:                                                              
                                                                    </td>
                                                                    <td align="left" width="490">   
                                                                        <dx:ASPxComboBox ID="cb_tur" runat="server" ValueType="System.String" Width="603" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_tur_SelectedIndexChanged">
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
                                                                    <td align="left" width="200">                                                            
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                        <br />
                                                        <asp:Panel ID="panel3" runat="server" Width="1305px" Height="404px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted" Visible="false">
                                                            <table>
                                                    <tr>
                                                        <td>
                                                            <table>
                                                <tr>
                                                    
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <br />                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" width="950px"> 
                                                        <dx:ASPxGridView ID="grid_rapor" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="RaporYetkiId" OnSelectionChanged="grid_rapor_SelectionChanged" Width="850px" OnPageSizeChanged="grid_rapor_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="RaporYetkiTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="RaporTuruAd" Caption="Rapor Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="310px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
                                                                <dx:GridViewDataCheckColumn FieldName="RaporYetkiDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="260" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                    <td>
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="520px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="100px" align="center" height="50px">
                                                                            </td>                                                                                
                                                                            <td width="120px" align="center" height="50px">                                                                           
                                                                                <dx:ASPxButton ID="btn_guncelle2" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_guncelle2_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>                                                                                                                                                
                                                                            <td width="120px" align="center" height="50px">                                                                              
                                                                                <dx:ASPxButton ID="btn_sil2" runat="server" Text="Sil" Width="80" Image-Url="~/Content/Images/sil.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_sil2_Click" Paddings-PaddingLeft="5px" Enabled="false">
                                                                                    <ClientSideEvents Click="function(s,e) { e.processOnServer = confirm('Silmek istediğinizden emin misiniz?'); }" />
                                                                                    <Image Url="~/Content/Images/sil.png"></Image>
                                                                                    <Paddings PaddingLeft="5px"></Paddings>
                                                                                </dx:ASPxButton>                                                                                
                                                                            </td>                                                                            
                                                                        </tr>                                                                                                                                             
                                                                    </table>
                                                                    <br />
                                                                    <br />                                                                    
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <table>
                                                                        <tr>
                                                                            <td width="135px">
                                                                            </td>
                                                                            <td width="210px">
                                                                    Ad Soyad
                                                                </td>
                                                                <td width="100px" height="27px">
                                                                    <dx:ASPxComboBox ID="cb_kim" runat="server" ValueType="System.String" Width="200" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                            <ValidationSettings ValidationGroup="Group_Kim" ErrorDisplayMode="ImageWithTooltip">
	                                                            <RequiredField ErrorText="Ad Soyad seçiniz..." IsRequired="true"/>                                                                                
                                                            </ValidationSettings>
                                                        </dx:ASPxComboBox>
                                                                </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td width="135px">
                                                                            </td>
                                                                            <td width="210px">
                                                                    Durum
                                                                </td>
                                                                <td width="100px" height="27px">
                                                                    <dx:ASPxComboBox ID="cb_son_durum" runat="server" ValueType="System.String" Width="200" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                            <ValidationSettings ValidationGroup="Group_Kim" ErrorDisplayMode="ImageWithTooltip">
	                                                            <RequiredField ErrorText="Durum seçiniz..." IsRequired="true"/>                                                                                
                                                            </ValidationSettings>
                                                        </dx:ASPxComboBox>
                                                                </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td width="135px">
                                                                            </td>
                                                                            <td width="210px">
                                                                    
                                                                </td>
                                                                <td width="100px" height="45px">
                                                                   <dx:ASPxButton ID="btn_kayit_ekle" runat="server" Text="Kayıt Ekle" Width="200" ValidationGroup="Group_Kim" OnClick="btn_kayit_ekle_Click">
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
                                                        <asp:TextBox ID="txtUserName22" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>                                                
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Kayıt Ara - Güncelle - Sil">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1082" Height="425">
                                <table>
                                    <tr>
                                        <td width="1200" align="center" height="400px">
                                            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Size="14" ForeColor="Maroon" Text="Rapor Yönetimi Hazırlanmaktadır..."></dx:ASPxLabel>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
    </div>
</asp:Content>

