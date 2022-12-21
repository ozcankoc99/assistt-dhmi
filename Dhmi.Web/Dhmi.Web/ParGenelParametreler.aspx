<%@ Page Title="DHMİ İletişim Merkezi - Genel Parametreler" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ParGenelParametreler.aspx.cs" Inherits="Dhmi.Web.ParGenelParametreler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Parametre Güncelleme">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td width="930px" align="left">                                            
                                            <table>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>
                                                                <td>
                                                                    <br />
                                                                </td>
                                                            </tr>                                                            
                                                        </table>                                                  
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
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                        </td>
                                                       </tr>
                                                        <tr>
                                                    <td width="1120px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <table>
                                                                <tr>
                                                                    <td width="300px" align="left" height="30px"</td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    Parametre Adı:
                                                                    </td>
                                                                    <td width="270px" align="left" height="30px">
                                                                        <dx:ASPxComboBox ID="cb_parametre" runat="server" ValueType="System.String" Width="290" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_parametre_SelectedIndexChanged">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Parametre Adı seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                            Callback.PerformCallback();
                                                                            LoadingPanel.Show();
                                                                            }" />
                                                                        </dx:ASPxComboBox>
                                                                        <dx:ASPxCallback ID="ASPxCallback3" runat="server" ClientInstanceName="Callback">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="300px" align="left" height="30px"</td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    Parametre Değeri:
                                                                    </td>
                                                                    <td width="270px" align="left" height="30px">
                                                                        <dx:ASPxTextBox ID="txt_deger" runat="server" MaxLength="99" Width="290">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Parametre Değeri giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </td>
                                                                </tr>
                                                                </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <table>
                                                                <tr>
                                                                    <td width="300px" align="left" height="30px"</td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    
                                                                    </td>
                                                                    <td width="150px" align="left" height="30px">
                                                                        <dx:ASPxButton ID="btn_guncelle" runat="server" Text="Değer Güncelle" ValidationGroup="Group_Egt" Width="140" UseSubmitBehavior="true" OnClick="btn_guncelle_Click"></dx:ASPxButton>
                                                                    </td>
                                                                    <td width="150px" align="left" height="30px">
                                                                        <dx:ASPxButton ID="btn_iptal" runat="server" Text="İptal Et" Width="140" UseSubmitBehavior="true" OnClick="btn_iptal_Click"></dx:ASPxButton>
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
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="230px" align="left">
                                        </td>
                                        <td width="530px" align="left">
                                           
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Parametre Raporları">
                <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="525">
                                <table>
                                    <tr>
                                        <td>
                                           <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_gen_param.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_gen_param.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_gen_param.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_gen_param.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_gen_param" runat="server" ClientInstanceName="grid_gen_param" Width="1305px" AutoGenerateColumns="false" KeyFieldName="ParametreGenelArsivId" OnPageSizeChanged="grid_gen_param_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>      
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivAd" Caption="Parametre Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="220px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                     
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivTarih" Caption="Tarih" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="186px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                       
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivKullanici" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="220px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivOld" Caption="Eski Değeri" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="310px" HeaderStyle-HorizontalAlign="Center">                                                                                                                                
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn PropertiesTextEdit-Password="true" FieldName="ParametreGenelArsivNew" Caption="Yeni Değeri" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="310px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />                                                            
                                                            <Settings VerticalScrollableHeight="308" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true" />
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                        
                                                        <dx:ASPxGridViewExporter ID="grid_gen_param_export" runat="server" GridViewID="grid_gen_param" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated">
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
                <dx:TabPage Text="Parametre Değer Sil">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <asp:Panel ID="Panel2" runat="server" Width="1310" Height="495">
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
                                                        <dx:ASPxGridView ID="grid_par_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="ParametreGenelArsivId" OnSelectionChanged="grid_par_sil_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_par_sil_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                  
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivAd" Caption="Parametre Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="251px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                     
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivTarih" Caption="Tarih" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                       
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivKullanici" Caption="İşlem Yapan Kullanıcı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="ParametreGenelArsivOld" Caption="Eski Değeri" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="327px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">                                                                                                                                
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn PropertiesTextEdit-Password="true" FieldName="ParametreGenelArsivNew" Caption="Yeni Değeri" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="327px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>  
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