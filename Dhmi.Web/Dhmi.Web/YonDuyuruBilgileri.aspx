<%@ Page Title="DHMİ İletişim Merkezi - Duyuru Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonDuyuruBilgileri.aspx.cs" Inherits="Dhmi.Web.YonDuyuruBilgileri" %>

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
                                        <td width="970px" align="left">
                                            
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
                                                    <td width="1020px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                         <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                <Items>       
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                 
                                                    <dx:LayoutGroup Caption="Duyuru Bilgileri" Width="550px">
                                                        <Items>                                                                                                                                                                                                                                                                                             
                                                            <dx:LayoutItem Caption="Başlık:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_baslik" runat="server" MaxLength="250" Width="425">
                                                                            <ValidationSettings ValidationGroup="Group_Duy" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Başlık giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="İçerik:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxMemo ID="txt_icerik" runat="server" MaxLength="5000" Width="425" Height="40">
                                                                            <ValidationSettings ValidationGroup="Group_Duy" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="İçerik giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxMemo>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>    
                                                            <dx:LayoutItem Caption="Yayın Tarihi:" Width="285px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_yayintarihi" runat="server" Width="90">
                                                                            <ValidationSettings ValidationGroup="Group_Duy" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Yayın Tarihi giriniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                            <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata"/>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                     
                                                            <dx:LayoutItem Caption="Durum:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxComboBox ID="cb_durum" runat="server" ValueType="System.String" Width="90" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                            <ValidationSettings ValidationGroup="Group_Duy" ErrorDisplayMode="ImageWithTooltip">
	                                                            <RequiredField ErrorText="Durum seçiniz..." IsRequired="true"/>                                                                                
                                                            </ValidationSettings>
                                                        </dx:ASPxComboBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem> 
                                                            <dx:LayoutItem Caption=" " Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <table>
                                                                            <tr>
                                                                                <td>
                                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" ValidationGroup="Group_Duy" Width="90" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">                                                                       
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
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1310" Height="505">
                                <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_duyuru.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_duyuru.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_duyuru.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
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
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                              
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruBaslik" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="483px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruYayinTarih" Caption="Yayın Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="DuyuruDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="80px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>                                                                   
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="287" HorizontalScrollBarMode="Auto"/>
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
                <dx:TabPage Text="Kayıt Ara - Güncelle - Sil">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="505">
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
                                                                                <dx:ASPxButton ID="btn_guncelle" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_guncelle_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="50px">                                                                              
                                                                                <dx:ASPxButton ID="btn_sil" runat="server" Text="Sil" Width="80" Image-Url="~/Content/Images/sil.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_sil_Click" Paddings-PaddingLeft="5px" Enabled="false">
                                                                                    <ClientSideEvents Click="function(s,e) { e.processOnServer = confirm('Silmek istediğinizden emin misiniz?'); }" />
                                                                                    <Image Url="~/Content/Images/sil.png"></Image>
                                                                                    <Paddings PaddingLeft="5px"></Paddings>
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
                                                        <dx:ASPxGridView ID="grid_duyuru_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="DuyuruId" OnSelectionChanged="grid_duyuru_sil_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_duyuru_sil_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="işlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                              
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruBaslik" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="503px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="DuyuruYayinTarih" Caption="Yayın Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="110px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="DuyuruDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="80px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn> 
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="326" HorizontalScrollBarMode="Auto"/>
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