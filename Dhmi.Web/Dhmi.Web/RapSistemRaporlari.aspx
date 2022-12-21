<%@ Page Title="DHMİ İletişim Merkezi - Sistem Raporları" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="RapSistemRaporlari.aspx.cs" Inherits="Dhmi.Web.RapSistemRaporlari" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Belge Oluşturma">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1310" Height="672">
                                <table>
                                    <tr>
                                        <td width="1320" align="center">
                                            <asp:Panel ID="panel2" runat="server" Width="850px" Height="44px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                            <table>
                                                                <tr>
                                                                    <td align="left" width="70">
                                                                    </td>
                                                                    <td align="left" width="90" height="12px">                                                                    
                                                                    </td>
                                                                    <td align="left" width="490">                                                            
                                                                    </td>
                                                                    <td align="left" width="80">                                                            
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" width="70">
                                                                    </td>
                                                                    <td align="left" width="90" height="12px">     
                                                                        Rapor Türü:                                                              
                                                                    </td>
                                                                    <td align="left" width="490">   
                                                                        <dx:ASPxComboBox ID="cb_tur" runat="server" ValueType="System.String" Width="603" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_tur_SelectedIndexChanged">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Cag" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Bildirim Türü seçiniz..." IsRequired="false" />
                                                                                                                    </ValidationSettings>
                                                                                                                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                            Callback33.PerformCallback();
                                                                            LoadingPanel33.Show();
                                                                            }" />
                                                                                                                </dx:ASPxComboBox>
                                                                                                                <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback33">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel33.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel33" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>                                                                                                                                 
                                                                    </td>
                                                                    <td align="left" width="80">                                                            
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                        <br />
                                                        <asp:Panel ID="pnl_bildirim" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td> 
                                            <table>
                                                <tr>
                                                    <td>                                                        
                                                                <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bil_no" runat="server" Text="Bildirim No"  OnCheckedChanged="k_bil_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                                <td width="260px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_ad222" runat="server" Text="Vatandaş Adı Soyadı/Firma Adı"  OnCheckedChanged="k_ad222_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                                                                                                                                                            
                                                                </td>                                                                
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tcsi" runat="server" Text="TC Kimlik No"  OnCheckedChanged="k_tcsi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                                                                                                                                                            
                                                                </td>    
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="kk_pasaport" runat="server" Text="Pasaport No"  OnCheckedChanged="kk_pasaport_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                                                                                                                                                           
                                                                </td>                                                                                                                          
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tel22" runat="server" Text="Telefon"  OnCheckedChanged="k_tel22_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>    
                                                                </td> 
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_cag_sis" runat="server" Text="Çağrı Sistemi"  OnCheckedChanged="k_cag_sis_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bil_tur" runat="server" Text="Bildirim Türü"  OnCheckedChanged="k_bil_tur_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bil_sekil" runat="server" Text="Bilgilendirme Şekli"  OnCheckedChanged="k_bil_sekil_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_konu" runat="server" Text="Konu"  OnCheckedChanged="k_konu_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_aciklama" runat="server" Text="Açıklama/Şikayet"  OnCheckedChanged="k_aciklama_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_notte" runat="server" Text="Not"  OnCheckedChanged="k_notte_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_son_tar" runat="server" Text="Son İşlem Tarihi"  OnCheckedChanged="k_son_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_sonuc" runat="server" Text="Sonuç"  OnCheckedChanged="k_sonuc_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_atanma" runat="server" Text="Atanma Durumu"  OnCheckedChanged="k_atanma_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_hav_1" runat="server" Text="Havalimanı"  OnCheckedChanged="k_hav_1_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>   
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dava_ad_soyad" runat="server" Text="Dava - Ad Soyad"  OnCheckedChanged="k_dava_ad_soyad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>  
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dava_dosya_no" runat="server" Text="Dava - Dosya No"  OnCheckedChanged="k_dava_mahkeme_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dava_mahkeme" runat="server" Text="Dava - Mahkeme Adı"  OnCheckedChanged="k_dava_dosya_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dava_konu" runat="server" Text="Dava - Konu"  OnCheckedChanged="k_dava_konu_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_sure" runat="server" Text="Toplam İşlem Süresi"  OnCheckedChanged="k_sure_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td>
                                                            </tr> 
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_kar_vatd" runat="server" Text="Vatandaş Kara"  OnCheckedChanged="k_kar_vatd_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_k_geri" runat="server" Text="Geri Dönüş Yapıldı mı?"  OnCheckedChanged="k_k_geri_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                                <td width="260px" align="left">                                                                    
                                                                    
                                                                </td> 
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>                                                                   
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>   
                                                            </tr>                                                           
                                                        </table>                                                                                                                                                                                              
                                                        <br />                                                        
                                                    </td>
                                                </tr>
                                            </table>                                           
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bildirim.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bildirim.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton3" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bildirim.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton4" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bildirim.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>                                                    
                                                                <dx:ASPxGridView ID="grid_bildirim" runat="server" ClientInstanceName="grid_bildirim" Width="1305px" AutoGenerateColumns="false" KeyFieldName="BildirimId">
                                                            <Columns>                                                               
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                              
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGelenYer" Caption="Çağrı Sistemi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonIslemTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>    
                                                                <dx:GridViewDataTextColumn FieldName="BildirimHavalimani" Caption="Havalimanı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaAdSoyad" Caption="Dava - Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">    
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaDosyaNo" Caption="Dava - Dosya No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="135px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaMahkeme" Caption="Dava - Mahkeme Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="185px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimDavaKonu" Caption="Dava - Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="225px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                                                                <dx:GridViewDataTextColumn FieldName="BildirimToplamSure" Caption="Toplam İşlem Süresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimVatandasKarar" Caption="Vatandaş Karar" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataCheckColumn FieldName="BildirimGeriYapildiMi" Caption="Geri Dönüş Yapıldı mı?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="205px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Evet" DisplayTextUnchecked="Hayır">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="283" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="100" />                                                                                                                      
                                                            <Settings ShowFilterBar="Visible" />
                                                        </dx:ASPxGridView>                                                                                                                  
                                                        <dx:ASPxGridViewExporter ID="grid_bildirim_export" runat="server" GridViewID="grid_bildirim" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="225">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="70px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                           
                                                                                <dx:ASPxButton ID="btn_pdf_cagri" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="btn_pdf_cagri_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                              
                                                                                <dx:ASPxButton ID="btn_xls_cagri" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btn_xls_cagri_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                             
                                                                                <dx:ASPxButton ID="btn_doc_cagri" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btn_doc_cagri_Click">                                                                                
                                                                                </dx:ASPxButton>
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
                                                        <asp:Panel ID="pnl_bilgi_bankasi" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td>                                                       
                                                        <table border="2px" bordercolor="blue">
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bilgi_tur" runat="server" Text="Bilgi Bankası Türü" OnCheckedChanged="k_bilgi_tur_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_baslik" runat="server" Text="Başlık" OnCheckedChanged="k_baslik_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_icerik" runat="server" Text="İçerik" OnCheckedChanged="k_icerik_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dosya" runat="server" Text="Dosya" OnCheckedChanged="k_dosya_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_etiket" runat="server" Text="Etiket" OnCheckedChanged="k_etiket_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_sira" runat="server" Text="Sıra" OnCheckedChanged="k_sira_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tarih" runat="server" Text="İşlem Tarihi" OnCheckedChanged="k_tarih_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>
                                                                <td width="260px" align="left">

                                                                </td>
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>
                                                            </tr>
                                                        </table>                                                        
                                                        <br />
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bilgi.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bilgi.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bilgi.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_bilgi.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_bilgi" runat="server" ClientInstanceName="grid_bilgi" Width="1305px" AutoGenerateColumns="false" KeyFieldName="BilgiBankasiId" OnPageSizeChanged="grid_bilgi_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiTurAd" Caption="Bilgi Bankası Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiAd" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiDosya" Caption="Dosya" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiEtiket" Caption="Etiket" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiSira" Caption="Sıra" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="60px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="344" HorizontalScrollBarMode="Auto" ShowFilterBar="Visible"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="100" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_bilgi_export" runat="server" GridViewID="grid_bilgi" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="230">
                                                            <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter>
                                                        <table>
                                                            <tr>
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="80px"></td>
                                                                            <td width="150px" align="center" height="80px">
                                                                                <dx:ASPxButton ID="btnPdfExport" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="btnPdfExport_Click">
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">
                                                                                <dx:ASPxButton ID="btnXlsExport" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnXlsExport_Click">
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">
                                                                                <dx:ASPxButton ID="btnRtfExport" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btnRtfExport_Click">
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
                                                        <asp:Panel ID="pnl_duyuru" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton5" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_duyuru.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton6" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_duyuru.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton7" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_duyuru.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton8" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_duyuru.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_duyuru" runat="server" ClientInstanceName="grid_duyuru" Width="1305px" AutoGenerateColumns="false" KeyFieldName="DuyuruId" OnPageSizeChanged="grid_duyuru_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="185px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />    
                                                                </dx:GridViewDataTextColumn>                                                              
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruBaslik" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="280px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="458px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruYayinTarih" Caption="Yayın Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="DuyuruDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="70px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataCheckColumn>                                                                   
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="367" HorizontalScrollBarMode="Auto"/>
                                                            <Settings ShowFilterBar="Visible"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_duyuru_export" runat="server" GridViewID="grid_duyuru" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="270">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="80px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="ASPxButton9" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="btnPdfExport_d_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="ASPxButton10" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnXlsExport_d_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="ASPxButton11" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btnRtfExport_d_Click">                                                                                
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
                                                        <asp:Panel ID="pnl_grup_kullanici" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton12" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_rapor.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton13" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_rapor.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton14" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_rapor.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton15" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_rapor.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_rapor" runat="server" ClientInstanceName="grid_rapor" Width="1305px" AutoGenerateColumns="false" KeyFieldName="GrupAtamaId" OnPageSizeChanged="grid_rapor_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="GrupAd" Caption="Grup Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="295px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="GrupAmir" Caption="Grup Amiri" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                              
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="Kullanıcı Ad Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="290px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciMail" Caption="Kullanıcı Mail" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                             
                                                                <dx:GridViewDataCheckColumn FieldName="KullaniciDurum" Caption="Kullanıcı Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="160px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataCheckColumn>                                                                   
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="400" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="20" />
                                                            <Settings ShowFilterBar="Visible"/>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_rapor_export" runat="server" GridViewID="grid_rapor" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="350">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="80px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="btn_rap_pdf" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="btn_rap_pdf_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="btn_rap_exc" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btn_rap_exc_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="btn_rap_doc" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btn_rap_doc_Click">                                                                                
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
                                                        <asp:Panel ID="pnl_kara_liste" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td>                                                        
                                                        <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_ad_soyad" runat="server" Text="Vatandaş Adı Soyadı/Firma Adı"  OnCheckedChanged="k_ad_soyad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="260px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_telefon" runat="server" Text="Telefon"  OnCheckedChanged="k_telefon_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_is_kul" runat="server" Text="İşlem Yapan Kullanıcı"  OnCheckedChanged="k_is_kul_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>    
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_islem_tar" runat="server" Text="İşlem Tarihi"  OnCheckedChanged="k_islem_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                                          
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bas_tar" runat="server" Text="Başlangıç Tarihi - Saati"  OnCheckedChanged="k_bas_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bit_tar" runat="server" Text="Bitiş Tarihi - Saati"  OnCheckedChanged="k_bit_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_aciklama_k" runat="server" Text="Açıklama"  OnCheckedChanged="k_aciklama_k_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_durum" runat="server" Text="Durum"  OnCheckedChanged="k_durum_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_iptal_tar" runat="server" Text="İptal Tarihi"  OnCheckedChanged="k_iptal_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_iptal_kul" runat="server" Text="İptal Eden Kullanıcı"  OnCheckedChanged="k_iptal_kul_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                            </tr>
                                                        </table>                                                  
                                                        <br />                                                        
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton16" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton17" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton18" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton19" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_vip" runat="server" ClientInstanceName="grid_vip" Width="1305px" AutoGenerateColumns="false" KeyFieldName="KaraListeId" OnPageSizeChanged="grid_vip_PageSizeChanged">
                                                            <Columns>                                                                
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="235px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                              
                                                                <dx:GridViewDataTextColumn FieldName="KaraListeIslemYapan" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KaraListeIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KaraListeBslTarihSaat" Caption="Başlangıç Tarihi - Saati" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KaraListeBtsTarihSaat" Caption="Bitiş Tarihi - Saati" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KaraListeAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="KaraListeDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="95px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="İptal">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataCheckColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="KaraListeIptalTarihi" Caption="İptal Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KaraListeIptalEdenKullanici" Caption="İptal Eden Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                            
                                                            </Columns>                                                                                                                        
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="344" HorizontalScrollBarMode="Auto"/>
                                                            <Settings ShowFilterBar="Visible"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="20" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_vip_export" runat="server" GridViewID="grid_vip" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="300">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="80px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="ASPxButton20" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="btnPdfExport_ka_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="ASPxButton21" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnXlsExport_ka_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="ASPxButton22" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btnRtfExport_ka_Click">                                                                                
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
                                                        <asp:Panel ID="pnl_kopuk" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td>                                                                                        
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton23" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton24" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton25" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton26" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_kopuk" runat="server" ClientInstanceName="grid_kopuk" Width="1305px" AutoGenerateColumns="false" KeyFieldName="KopukCagriId">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriTuruAd" Caption="Köpük Çağrı Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="210px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="220px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriTelNo" Caption="Telefon Numarası" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="155px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="511px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="400" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="100" />     
                                                            <Settings ShowFilterBar="Visible"/>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_kopuk_export" runat="server" GridViewID="grid_kopuk" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="120" RightMargin="120" MaxColumnWidth="505">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="80px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="kopuk_pdf" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="kopuk_pdf_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="kopuk_xls" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="kopuk_xls_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="kopuk_doc" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="kopuk_doc_Click">                                                                                
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
                                                        <asp:Panel ID="pnl_kullanici" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td>                                                                                                           
                                                        <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_ad" runat="server" Text="Ad"  OnCheckedChanged="k_ad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="260px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_soyad" runat="server" Text="Soyad"  OnCheckedChanged="k_soyad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_birt" runat="server" Text="Birim"  OnCheckedChanged="k_birt_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>    
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_gorev" runat="server" Text="Görev"  OnCheckedChanged="k_gorev_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>            
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_yetki" runat="server" Text="Yetki"  OnCheckedChanged="k_yetki_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                              
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_hiyerarsi" runat="server" Text="Hiyerarşi Tür"  OnCheckedChanged="k_hiyerarsi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_kadi" runat="server" Text="Kullanıcı Adı"  OnCheckedChanged="k_kadi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_mail" runat="server" Text="Mail Adresi"  OnCheckedChanged="k_mail_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_aciklama_j" runat="server" Text="Açıklama"  OnCheckedChanged="k_aciklama_j_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tar" runat="server" Text="Kayıt Tarihi"  OnCheckedChanged="k_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td>
                                                            </tr>                                                                                                                                                                                                                                                                                                        
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_durum_j" runat="server" Text="Durum"  OnCheckedChanged="k_durum_j_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>
                                                            </tr>                                                           
                                                        </table>                                                  
                                                        <br />                                                        
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton27" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton28" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton29" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton30" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_kul" runat="server" ClientInstanceName="grid_kul" Width="1305px" AutoGenerateColumns="false" KeyFieldName="KullaniciId" OnPageSizeChanged="grid_kul_PageSizeChanged">
                                                            <Columns>                                                               
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAd" Caption="Ad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciSoyad" Caption="Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciBirim" Caption="Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="GorevAd" Caption="Görev" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="YetkiAd" Caption="Yetki" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="HiyerarsiTurAd" Caption="Hiyerarşi Tür" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciUsername" Caption="Kullanıcı Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="220px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="210px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciTarih" Caption="Kayıt Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataCheckColumn FieldName="KullaniciDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="90px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>                                                                                                                        
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="320" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="100" />
                                                            <Settings ShowFilterBar="Visible"/>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="gr_kul_export" runat="server" GridViewID="grid_kul" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="100" RightMargin="100" MaxColumnWidth="250">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter>
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="80px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="ASPxButton31" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="btnPdfExport_kul_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="ASPxButton32" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnXlsExport_kul_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="ASPxButton33" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btnRtfExport_kul_Click">                                                                                
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
                                                        <asp:Panel ID="pnl_vatandas" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td> 
                                            <table>
                                                <tr>
                                                    <td>                                                                                                           
                                                        <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_k_no" runat="server" Text="Kayıt No"  OnCheckedChanged="k_k_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="260px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_kay_tur" runat="server" Text="Kayıt Türü"  OnCheckedChanged="k_kay_tur_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td>                                                                
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tc_no" runat="server" Text="TC Kimlik No"  OnCheckedChanged="k_tc_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>    
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_pasaport" runat="server" Text="Pasaport No"  OnCheckedChanged="k_pasaport_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>  
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_uyruk" runat="server" Text="Uyruk"  OnCheckedChanged="k_uyruk_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_ad_vt" runat="server" Text="Vatandaş Adı Soyadı/Firma Adı"  OnCheckedChanged="k_ad_vt_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_cinsiyet" runat="server" Text="Cinsiyet"  OnCheckedChanged="k_cinsiyet_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_d_tarih" runat="server" Text="Doğum Tarihi"  OnCheckedChanged="k_d_tarih_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_mail_vt" runat="server" Text="Mail Adres"  OnCheckedChanged="k_mail_vt_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tel" runat="server" Text="Telefon Numarası (1)"  OnCheckedChanged="k_tel_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tel_2" runat="server" Text="Telefon Numarası (2)"  OnCheckedChanged="k_tel_2_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_not" runat="server" Text="Not (Açıklama)"  OnCheckedChanged="k_not_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_adres" runat="server" Text="Adres"  OnCheckedChanged="k_adres_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_i_tarih" runat="server" Text="İşlem Tarihi"  OnCheckedChanged="k_i_tarih_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    
                                                                </td>
                                                            </tr>                                                           
                                                        </table>                                                  
                                                        <br />                                                        
                                                    </td>
                                                </tr>
                                            </table>                                           
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton34" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton35" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton36" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton37" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_vatandas" runat="server" ClientInstanceName="grid_vatandas" Width="1305px" AutoGenerateColumns="false" KeyFieldName="VatandasId">
                                                            <Columns>                                                                
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="VatandasId" Caption="Kayıt No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTur" Caption="Kayıt Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasUyruk" Caption="Uyruk" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                              
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon Numarası (1)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel2" Caption="Telefon Numarası (2)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasNotes" Caption="Not (Açıklama)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdres" Caption="Adres" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                  
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="329" HorizontalScrollBarMode="Auto"/>
                                                            <Settings ShowFilterBar="Visible"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="100" />                                                              
                                                        </dx:ASPxGridView>                                                        
                                                        <dx:ASPxGridViewExporter ID="grid_vatandas_export" runat="server" GridViewID="grid_vatandas" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="225">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter>  
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="70px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                           
                                                                                <dx:ASPxButton ID="ASPxButton38" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="true" Paddings-PaddingLeft="12px" OnClick="btnPdfExport_vat_Click">
                                                                                </dx:ASPxButton>                                                                                                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                              
                                                                                <dx:ASPxButton ID="ASPxButton39" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnXlsExport_vat_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                             
                                                                                <dx:ASPxButton ID="ASPxButton40" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnRtfExport_vat_Click">
                                                                                </dx:ASPxButton>
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
                                                        <asp:Panel ID="pnl_vip" runat="server" Visible="false">
                                                            <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td>                                                                                                            
                                                        <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_ad_soyadss" runat="server" Text="Vatandaş Adı Soyadı/Firma Adı"  OnCheckedChanged="k_ad_soyadss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="260px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_telefonss" runat="server" Text="Telefon"  OnCheckedChanged="k_telefonss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_is_kulss" runat="server" Text="İşlem Yapan Kullanıcı"  OnCheckedChanged="k_is_kulss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>    
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_islem_tarss" runat="server" Text="İşlem Tarihi"  OnCheckedChanged="k_islem_tarss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>  
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bas_tarss" runat="server" Text="Başlangıç Tarihi - Saati"  OnCheckedChanged="k_bas_tarss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                                        
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bit_tarss" runat="server" Text="Bitiş Tarihi - Saati"  OnCheckedChanged="k_bit_tarss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_aciklamass" runat="server" Text="Açıklama"  OnCheckedChanged="k_aciklamass_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_durumss" runat="server" Text="Durum"  OnCheckedChanged="k_durumss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_iptal_tarss" runat="server" Text="İptal Tarihi"  OnCheckedChanged="k_iptal_tarss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_iptal_kulss" runat="server" Text="İptal Eden Kullanıcı"  OnCheckedChanged="k_iptal_kulss_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                        </table>                                                  
                                                        <br />
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton41" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vips.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton42" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vips.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton43" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vips.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton44" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vips.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_vips" runat="server" ClientInstanceName="grid_vips" Width="1305px" AutoGenerateColumns="false" KeyFieldName="VipListeId" OnPageSizeChanged="grid_vips_PageSizeChanged">
                                                            <Columns>                                                                
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="235px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                              
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIslemYapan" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeBslTarihSaat" Caption="Başlangıç Tarihi - Saati" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeBtsTarihSaat" Caption="Bitiş Tarihi - Saati" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="VipListeDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="95px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="İptal">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataCheckColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIptalTarihi" Caption="İptal Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIptalEdenKullanici" Caption="İptal Eden Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AutoFilterCondition="Contains" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                            
                                                            </Columns>                                                            
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="347" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="100" />      
                                                            <Settings ShowFilterBar="Visible"/>                                                        
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_vips_export" runat="server" GridViewID="grid_vips" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="300">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="80px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="ASPxButton45" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="4px" OnClick="btnPdfExport_vi_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="ASPxButton46" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnXlsExport_vi_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="ASPxButton47" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btnRtfExport_vi_Click">                                                                                
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