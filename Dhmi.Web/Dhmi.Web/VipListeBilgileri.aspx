<%@ Page Title="DHMİ İletişim Merkezi - VIP Liste Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="VipListeBilgileri.aspx.cs" Inherits="Dhmi.Web.VipListeBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Yeni Kayıt">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td width="1095px" align="left">
                                            
                                            <table>
                                                <tr>
                                                    <td>                                                                                                          
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                       <table>
                                                       <tr>
                                                        <td>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />                                                            
                                                        </td>
                                                       </tr>
                                                        <tr>                                                        
                                                    <td width="1185px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                         <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                <Items>       
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                 
                                                    <dx:LayoutGroup Caption="Vatandaş Bilgileri" Width="750px">
                                                        <Items>                                                                                                                                                                                                                                                                                                                                                         
                                                            <dx:LayoutItem Caption="Vatandaş Adı Soyadı/Firma Adı:" Width="750px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_ad" runat="server" MaxLength="150" Width="515" Enabled="false">
                                                                            <ValidationSettings ValidationGroup="Group_Vip" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Vatandaş Adı Soyadı/Firma Adı giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>    
                                                            <dx:LayoutItem Caption="Telefon Numarası:" Width="750px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_tel_no" runat="server" Width="110" Native="false" EnableDefaultAppearance="false" Enabled="false">
                                                                                        <MaskSettings Mask="0 (999) 000-0000" IncludeLiterals="None" ErrorText="Telefon Numarası hatalıdır..." />
                                                                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Group_Vip">
                                                                                            <RequiredField ErrorText="Telefon Numarası giriniz..." IsRequired="true" />
                                                                                        </ValidationSettings>
                                                                                    </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Başlangıç Tarihi ve Saati:" Width="750px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <table>
                                                                            <tr>
                                                                                <td align="left" width="85">
                                                                                    <dx:ASPxTextBox ID="txt_bas_tarihi" runat="server" Width="80">
                                                                                        <ValidationSettings ValidationGroup="Group_Vip" ErrorDisplayMode="ImageWithTooltip">
	                                                                                        <RequiredField ErrorText="Başlangıç Tarihi giriniz..."/>                                                                                
                                                                                        </ValidationSettings>
                                                                                        <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata"/>                                                                            
                                                                                    </dx:ASPxTextBox>
                                                                                </td>
                                                                                <td align="left" width="105">
                                                                                    <dx:ASPxComboBox ID="cb_bas_saat" runat="server" ValueType="System.String" Width="100" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Vip" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Başlangıç Saati seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Bitiş Tarihi ve Saati:" Width="750px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <table>
                                                                            <tr>
                                                                                <td align="left" width="85">
                                                                                    <dx:ASPxTextBox ID="txt_bit_tarihi" runat="server" Width="80">
                                                                                        <ValidationSettings ValidationGroup="Group_Vip" ErrorDisplayMode="ImageWithTooltip">
	                                                                                        <RequiredField ErrorText="Bitiş Tarihi giriniz..."/>                                                                                
                                                                                        </ValidationSettings>
                                                                                        <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata"/>                                                                            
                                                                                    </dx:ASPxTextBox>
                                                                                </td>
                                                                                <td align="left" width="105"> 
                                                                                    <dx:ASPxComboBox ID="cb_bit_saat" runat="server" ValueType="System.String" Width="100" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Vip" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Bitiş Saati seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Açıklama:" Width="750px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxMemo ID="txt_aciklama" runat="server" MaxLength="5000" Width="515" Height="40">
                                                                            <ValidationSettings ValidationGroup="Group_Vip" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Açıklama giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxMemo>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                             
                                                            <dx:LayoutItem Caption=" " Width="750px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <table>
                                                                            <tr>
                                                                                <td>
                                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" ValidationGroup="Group_Vip" Width="90" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">
                                                                                    </dx:ASPxButton>
                                                                                </td>
                                                                                <td width="110" align="center">
                                                                                    <dx:ASPxButton ID="btn_temizle" runat="server" Text="Temizle" Width="90" UseSubmitBehavior="true" OnClick="btn_temizle_Click">                                                                       
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
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>   
                <dx:TabPage Text="Kayıt Listele - Raporla">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1310" Height="580">
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
                                                                    <dx:ASPxCheckBox ID="k_aciklama" runat="server" Text="Açıklama"  OnCheckedChanged="k_aciklama_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
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
                                                        <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_vip.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_vip" runat="server" ClientInstanceName="grid_vip" Width="1305px" AutoGenerateColumns="false" KeyFieldName="VipListeId" OnPageSizeChanged="grid_vip_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="235px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                              
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIslemYapan" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
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
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
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
                                                                <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                            
                                                            </Columns>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm"/>
                                                            <SettingsPopup>
                                                                <EditForm Width="1300px" Height="180px" Modal="true" VerticalAlign="WindowCenter"/>
                                                            </SettingsPopup>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="303" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
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
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Kayıt Güncelle - İptal Et">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="485">
                                <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>                                                                                                                                                       
                                                                            <td width="150px" align="center" height="50px">                                                                              
                                                                                <dx:ASPxButton ID="btn_iptal_et" runat="server" Text="İptal Et" Width="100" Image-Url="~/Content/Images/iptal_et.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_iptal_et_Click" Paddings-PaddingLeft="3px" Enabled="false">
                                                                                    <ClientSideEvents Click="function(s,e) { e.processOnServer = confirm('İptal etmek istediğinizden emin misiniz?'); }" />
                                                                                    <Image Url="~/Content/Images/iptal_et.png"></Image>
                                                                                    <Paddings PaddingLeft="3px"></Paddings>
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
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_vip_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="VipListeId" OnSelectionChanged="grid_vip_sil_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_vip_sil_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="235px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>          
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIslemYapan" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                    
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="123px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeBslTarihSaat" Caption="Başlangıç Tarihi - Saati" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeBtsTarihSaat" Caption="Bitiş Tarihi - Saati" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="VipListeDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="95px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="İptal">
                                                                    </PropertiesCheckEdit>
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataCheckColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIptalTarihi" Caption="İptal Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VipListeIptalEdenKullanici" Caption="İptal Eden Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>    
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="305" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="txtUserName" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
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
            </TabPages>      
        </dx:ASPxPageControl>
    </div>
</asp:Content>

