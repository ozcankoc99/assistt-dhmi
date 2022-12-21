<%@ Page Title="DHMİ İletişim Merkezi - IP Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonIpBilgileri.aspx.cs" Inherits="Dhmi.Web.YonIpBilgileri" %>
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
                                                            <br />
                                                        </td>
                                                       </tr>
                                                        <tr>                                                        
                                                    <td width="950px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                         <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                <Items>       
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                 
                                                    <dx:LayoutGroup Caption="IP Bilgileri" Width="550px">
                                                        <Items>                                                                                                                                                                                                                                                                                             
                                                            <dx:LayoutItem Caption="IP Adresi:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_ip_adres" runat="server" MaxLength="30" Width="440">
                                                                            <ValidationSettings ValidationGroup="Group_Bas" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="IP Adresi giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Açıklama:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_aciklama" runat="server" MaxLength="300" Width="440">
                                                                            <ValidationSettings ValidationGroup="Group_Bas" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Açıklama giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                         
                                                            <dx:LayoutItem Caption="Durum:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxComboBox ID="cb_durum" runat="server" ValueType="System.String" Width="90" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                            <ValidationSettings ValidationGroup="Group_Bas" ErrorDisplayMode="ImageWithTooltip">
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
                                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" ValidationGroup="Group_Bas" Width="90" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">                                                                       
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
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1310" Height="525">
                                <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ipler.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ipler.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ipler.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_ipler.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_ipler" runat="server" ClientInstanceName="grid_ipler" Width="1305px" AutoGenerateColumns="false" KeyFieldName="IpBanksId" OnPageSizeChanged="grid_ipler_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="IpBanksTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="IpBanksAd" Caption="IP Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="210px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="IpBanksAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="458px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="IpBanksDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>                                                                   
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="304" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_ipler_export" runat="server" GridViewID="grid_ipler" Landscape="true" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="300">
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
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="495">
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
                                                        <dx:ASPxGridView ID="grid_ipler_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="IpBanksId" OnSelectionChanged="grid_ipler_sil_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_ipler_sil_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="IpBanksTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>        
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="220px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                         
                                                                <dx:GridViewDataTextColumn FieldName="IpBanksAd" Caption="IP Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="210px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="IpBanksAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="483px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataCheckColumn FieldName="IpBanksDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn> 
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="315" HorizontalScrollBarMode="Auto"/>
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