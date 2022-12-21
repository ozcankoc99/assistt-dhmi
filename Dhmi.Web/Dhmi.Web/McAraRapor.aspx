<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="McAraRapor.aspx.cs" Inherits="Dhmi.Web.McAraRapor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="pnl_vatandas_bilgileri" runat="server" Width="1069" Height="552" Visible="true">
                                <table>
                                    <tr>
                                        <td> 
                                            <table>
                                                <tr>
                                                    <td>                                                                                                           
                                                        <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_k_no" runat="server" Text="Kayıt No"  OnCheckedChanged="k_k_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="280px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_kay_tur" runat="server" Text="Kayıt Türü"  OnCheckedChanged="k_kay_tur_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td>                                                                
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tc_no" runat="server" Text="TC Kimlik No"  OnCheckedChanged="k_tc_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>    
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_pasaport" runat="server" Text="Pasaport No"  OnCheckedChanged="k_pasaport_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                                          
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_vergi" runat="server" Text="Vergi Kimlik No"  OnCheckedChanged="k_vergi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_uyruk" runat="server" Text="Uyruk"  OnCheckedChanged="k_uyruk_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_ad" runat="server" Text="Vatandaş Adı Soyadı/Firma Adı"  OnCheckedChanged="k_ad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_cinsiyet" runat="server" Text="Cinsiyet"  OnCheckedChanged="k_cinsiyet_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_d_tarih" runat="server" Text="Doğum Tarihi"  OnCheckedChanged="k_d_tarih_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_mail" runat="server" Text="Mail Adres"  OnCheckedChanged="k_mail_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tel" runat="server" Text="Telefon Numarası (1)"  OnCheckedChanged="k_tel_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tel_2" runat="server" Text="Telefon Numarası (2)"  OnCheckedChanged="k_tel_2_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_not" runat="server" Text="Not (Açıklama)"  OnCheckedChanged="k_not_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_adres" runat="server" Text="Adres"  OnCheckedChanged="k_adres_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_i_tarih" runat="server" Text="İşlem Tarihi"  OnCheckedChanged="k_i_tarih_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    
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
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vatandas.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_vatandas" runat="server" ClientInstanceName="grid_vatandas" Width="1070px" AutoGenerateColumns="false" KeyFieldName="VatandasId">
                                                            <Columns>                                                                
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="VatandasId" Caption="Kayıt No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTur" Caption="Kayıt Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasUyruk" Caption="Uyruk" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                              
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon Numarası (1)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel2" Caption="Telefon Numarası (2)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasNotes" Caption="Not (Açıklama)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdres" Caption="Adres" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                  
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="322" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                        
                                                        <dx:ASPxGridViewExporter ID="grid_vatandas_export" runat="server" GridViewID="grid_vatandas" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="225">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter>  
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1200px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="50px" align="center" height="70px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                           
                                                                                <dx:ASPxButton ID="btnPdfExport" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="true" Paddings-PaddingLeft="1px" OnClick="btnPdfExport_Click">
                                                                                </dx:ASPxButton>                                                                                                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                              
                                                                                <dx:ASPxButton ID="btnXlsExport" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btnXlsExport_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="70px">                                                                             
                                                                                <dx:ASPxButton ID="btnRtfExport" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btnRtfExport_Click">
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
                            <asp:Panel ID="pnl_cagri_bilgileri" runat="server" Width="1069" Height="552">
                                <table>
                                    <tr>
                                        <td> 
                                            <table>
                                                <tr>
                                                    <td>                                                        
                                                                <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bil_no" runat="server" Text="Bildirim No"  OnCheckedChanged="k_bil_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                                <td width="280px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_ad222" runat="server" Text="Vatandaş Adı Soyadı/Firma Adı"  OnCheckedChanged="k_ad222_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                                                                                                                                                            
                                                                </td>                                                                
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tcsi" runat="server" Text="TC Kimlik No"  OnCheckedChanged="k_tcsi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                                                                                                                                                            
                                                                </td>    
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="kk_pasaport" runat="server" Text="Pasaport No"  OnCheckedChanged="kk_pasaport_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                                                                                                                                                           
                                                                </td>                                                                                                                          
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="kk_vergisi" runat="server" Text="Vergi Kimlik No"  OnCheckedChanged="kk_vergisi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tel22" runat="server" Text="Telefon"  OnCheckedChanged="k_tel22_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>    
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_cag_sis" runat="server" Text="Çağrı Tipi"  OnCheckedChanged="k_cag_sis_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bil_tur" runat="server" Text="Bildirim Türü"  OnCheckedChanged="k_bil_tur_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_bil_sekil" runat="server" Text="Bilgilendirme Şekli"  OnCheckedChanged="k_bil_sekil_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_konu" runat="server" Text="Konu"  OnCheckedChanged="k_konu_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_aciklama" runat="server" Text="Açıklama/Şikayet"  OnCheckedChanged="k_aciklama_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_notte" runat="server" Text="Not"  OnCheckedChanged="k_notte_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>   
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_son_tar" runat="server" Text="Son İşlem Tarihi"  OnCheckedChanged="k_son_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>  
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_sonuc" runat="server" Text="Sonuç"  OnCheckedChanged="k_sonuc_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_atanma" runat="server" Text="Atanma Durumu"  OnCheckedChanged="k_atanma_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_hav_1" runat="server" Text="Havalimanı"  OnCheckedChanged="k_hav_1_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr> 
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dava_ad_soyad" runat="server" Text="Dava - Ad Soyad"  OnCheckedChanged="k_dava_ad_soyad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dava_dosya_no" runat="server" Text="Dava - Dosya No"  OnCheckedChanged="k_dava_mahkeme_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                                <td width="280px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_dava_mahkeme" runat="server" Text="Dava - Mahkeme Adı"  OnCheckedChanged="k_dava_dosya_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_dava_konu" runat="server" Text="Dava - Konu"  OnCheckedChanged="k_dava_konu_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                   
                                                            </tr>
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_sure" runat="server" Text="Toplam İşlem Süresi"  OnCheckedChanged="k_sure_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td>                                                                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_kar_vatd" runat="server" Text="Vatandaş Karar"  OnCheckedChanged="k_kar_vatd_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                                <td width="280px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_k_geri" runat="server" Text="Geri Dönüş Yapıldı mı?"  OnCheckedChanged="k_k_geri_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td> 
                                                                <td width="280px" align="left">
                                                                    
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
                                                                <dx:ASPxGridView ID="grid_bildirim" runat="server" ClientInstanceName="grid_bildirim" Width="1070px" AutoGenerateColumns="false" KeyFieldName="BildirimId">
                                                            <Columns>                                                               
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
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
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                              
                                                                <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonIslemTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
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
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="256" HorizontalScrollBarMode="Auto"/>
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
                                                                <td width="1200px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="100px" align="center">
                                                                </td>
                                                                <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bas_tarihi_cagri" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Cagri" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Başlangıç Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>                                                                        
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bit_tarihi_cagri" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Cagri" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Bitiş Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_sorgula_cagri" runat="server" Text="Sorgula" ValidationGroup="Group_Cagri" Width="80" UseSubmitBehavior="true" OnClick="btn_sorgula_cagri_Click">
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
                            <asp:Panel ID="pnl_kopuk_cagri" runat="server" Width="1069" Height="430">
                            <br />
                                <table>
                                    <tr>
                                        <td>                                                                                        
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton5" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton6" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton7" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton8" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kopuk.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_kopuk" runat="server" ClientInstanceName="grid_kopuk" Width="1070px" AutoGenerateColumns="false" KeyFieldName="KopukCagriId">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriTuruAd" Caption="Köpük Çağrı Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriTelNo" Caption="Telefon Numarası" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="145px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="160px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KopukCagriAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="325px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="380" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_kopuk_export" runat="server" GridViewID="grid_kopuk" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="120" RightMargin="120" MaxColumnWidth="505">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1200px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="100px" align="center">
                                                                </td>
                                                                <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bas_tarihi_kopuk" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Kopuk" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Başlangıç Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>                                                                        
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bit_tarihi_kopuk" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Kopuk" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Bitiş Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_sorgula_kopuk" runat="server" Text="Sorgula" ValidationGroup="Group_Kopuk" Width="80" UseSubmitBehavior="true" OnClick="btn_sorgula_kopuk_Click">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                            Callback2200.PerformCallback();
                                                                            LoadingPanel2200.Show();
                                                                            }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback2200">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel2200.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
	                                                                                                                           <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel2200" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                        </td>
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
                            <asp:Panel ID="pnl_acik_cagri" runat="server" Width="1069" Height="430">                            
                                <table>
                                    <tr>
                                        <td>                                                                                        
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton13" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_acik.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton14" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_acik.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton15" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_acik.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton16" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_acik.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_acik" runat="server" ClientInstanceName="grid_acik" Width="1070px" AutoGenerateColumns="false" KeyFieldName="AcikBildirimId">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="AcikBildirimBirim" Caption="Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="340px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="AcikBildirimAtandiSayi" Caption="Atanan Bildirim Sayısı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="215px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="AcikBildirimInceleniyorSayi" Caption="İncelenen Bildirim Sayısı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="215px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn FieldName="AcikBildirimInceleniyorEkSureSayi" Caption="Ek Süre İstenen Bildirim Sayısı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="412" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="gr_acik" runat="server" GridViewID="grid_acik" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="120" RightMargin="120" MaxColumnWidth="505">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1200px" align="center">
                                                                    <table>
                                                                        <tr>                                                                            
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="acik_pdf" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="acik_pdf_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="acik_xls" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="acik_xls_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="acik_doc" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="acik_doc_Click">                                                                                
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
                            <asp:Panel ID="pnl_atama_bilgileri" runat="server" Width="1069" Height="430">
                                <table>
                                    <tr>
                                        <td> 
                                            <table>
                                                <tr>
                                                    <td>                                                                                                         
                                                        <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_bil_no" runat="server" Text="Bildirim No"  OnCheckedChanged="ak_bil_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="280px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="ak_ad" runat="server" Text="Vatandaş Adı Soyadı/Firma Adı"  OnCheckedChanged="ak_ad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                                                                                        
                                                                </td>                                                                
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_tel" runat="server" Text="Telefon"  OnCheckedChanged="ak_tel_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>    
                                                                </td>    
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_cag_sis" runat="server" Text="Çağrı Tipi"  OnCheckedChanged="ak_cag_sis_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                                          
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_bil_tur" runat="server" Text="Bildirim Türü"  OnCheckedChanged="ak_bil_tur_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_bil_sekil" runat="server" Text="Bilgilendirme Şekli"  OnCheckedChanged="ak_bil_sekil_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_konu" runat="server" Text="Konu"  OnCheckedChanged="ak_konu_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_aciklama" runat="server" Text="Açıklama/Şikayet"  OnCheckedChanged="ak_aciklama_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="280px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_notbak" runat="server" Text="Not"  OnCheckedChanged="k_notbak_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_son_tar" runat="server" Text="Son İşlem Tarihi"  OnCheckedChanged="ak_son_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_sonuc" runat="server" Text="Sonuç"  OnCheckedChanged="ak_sonuc_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_atanma" runat="server" Text="Atanma Durumu"  OnCheckedChanged="ak_atanma_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>   
                                                            <tr>
                                                                <td width="280px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_hav_2" runat="server" Text="Havalimanı" OnCheckedChanged="k_hav_2_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="kb_dava_ad" runat="server" Text="Dava - Ad Soyad" OnCheckedChanged="kb_dava_ad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="kb_dava_no" runat="server" Text="Dava - Dosya No" OnCheckedChanged="kb_dava_no_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="kb_dava_mahkene" runat="server" Text="Dava - Mahkeme Adı" OnCheckedChanged="kb_dava_mahkene_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="kb_dava_konu" runat="server" Text="Dava - Konu" OnCheckedChanged="kb_dava_konu_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>    
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="ak_sure" runat="server" Text="Toplam İşlem Süresi"  OnCheckedChanged="ak_sure_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                            
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_kar_vat" runat="server" Text="Vatandaş Karar"  OnCheckedChanged="k_kar_vat_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="280px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_geri_don" runat="server" Text="Geri Dönüş Yapılmı mı?"  OnCheckedChanged="k_geri_don_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
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
                                                        <dx:ASPxButton ID="ASPxButton9" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_atanan.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton10" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_atanan.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton11" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_atanan.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton12" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_atanan.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_atanan" runat="server" ClientInstanceName="grid_atanan" Width="1070px" AutoGenerateColumns="false" KeyFieldName="BildirimId">
                                                            <Columns>                                                                
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="BildirimId" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" VisibleIndex="1">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="CagriTipiAd" Caption="Çağrı Tipi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimGeriDonusAd" Caption="Bilgilendirme Şekli" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="AltKonuAd" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="350px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="BildirimMetin" Caption="Açıklama/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="450px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAciklama" Caption="Not" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="275px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTarih" Caption="Son İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimSonucAd" Caption="Sonuç" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="165px" HeaderStyle-HorizontalAlign="Center" VisibleIndex="2">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BildirimAtanmaDurumu" Caption="Atanma Durumu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="375px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
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
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm"/>
                                                            <SettingsPopup>
                                                                <EditForm Width="1000px" Height="230px" Modal="true" VerticalAlign="WindowCenter"/>
                                                            </SettingsPopup>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="290" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_atama_export" runat="server" GridViewID="grid_atanan" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="225">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1000px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            
<td width="100px" align="center">
                                                                </td>
                                                                <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bas_tarihi_atama" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Ataman" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Başlangıç Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>                                                                        
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxTextBox ID="txt_bit_tarihi_atama" runat="server" Width="80">
                                                                                                                    <ValidationSettings ValidationGroup="Group_Ataman" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="Bitiş Tarihi giriniz..." />
                                                                                                                    </ValidationSettings>
                                                                                                                    <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata" />
                                                                                                                </dx:ASPxTextBox>
                                                                        </td>
                                                                        <td width="100px" align="center" height="50px">
                                                                            <dx:ASPxButton ID="btn_sorgula_atama" runat="server" Text="Sorgula" ValidationGroup="Group_Ataman" Width="80" UseSubmitBehavior="true" OnClick="btn_sorgula_atama_Click">
                                                                                                                                <ClientSideEvents Click="function(s, e) {
                                                                            Callback2202.PerformCallback();
                                                                            LoadingPanel2202.Show();
                                                                            }" />
                                                                                                                            </dx:ASPxButton>
                                                                                                                            <dx:ASPxCallback ID="ASPxCallback2" runat="server" ClientInstanceName="Callback2202">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel2202.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
	                                                                                                                           <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel2202" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="160" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
                                                                        </td>
                                                                            <td width="50px" align="center" height="80px">                                                                                                                                                           
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="at_pdf" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="at_pdf_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="at_xls" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="at_xls_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="at_doc" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="at_doc_Click">                                                                                
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
                            <asp:Panel ID="pnl_vat_sec" runat="server" Width="1069" Height="430">   
                                <table>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1060px" align="center">
                                                                    
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <br />
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_vatandas_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="VatandasId" OnSelectionChanged="grid_vatandas_sil_SelectionChanged" Width="1073px">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="VatandasId" Caption="Kayıt No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTur" Caption="Kayıt Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon Numarası" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="144px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasNotes" Caption="Not (Açıklama)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdres" Caption="Adres" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False"/>
                                                                </dx:GridViewDataTextColumn>  
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="444" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="txtUserNameVat" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                            </asp:Panel>
                            <asp:Panel ID="pnl_ayrinti" runat="server" Width="1069" Height="430">
                            <br />
                                <table>
                                    <tr>
                                        <td>                                                                                        
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton17" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ayrinti.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton18" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ayrinti.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton19" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ayrinti.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton20" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ayrinti.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_ayrinti" runat="server" ClientInstanceName="grid_ayrinti" Width="1070px" AutoGenerateColumns="false" KeyFieldName="AcikBildirimAyrintiId">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiNo" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiSure" Caption="Süre" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiBirim" Caption="Atanan Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiIcerik" Caption="Talep/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="420px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiSonDurum" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="420px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="380" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_ayrinti_export" runat="server" GridViewID="grid_ayrinti" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="120" RightMargin="120" MaxColumnWidth="505">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter> 
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1200px" align="center">
                                                                    <table>
                                                                        <tr>                                                                                                                                                                                                                                                                                                                                                             
                                                                            <td width="150px" align="center" height="80px">                                                                           
                                                                                <dx:ASPxButton ID="ayrinti_pdf" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="ayrinti_pdf_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="ayrinti_xls" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="ayrinti_xls_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="ayrinti_doc" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="ayrinti_doc_Click">                                                                                
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
    </div>
    </form>
</body>
</html>
