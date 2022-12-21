<%@ Page Title="DHMİ İletişim Merkezi - Sorun Bildir" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YarSorunBildir.aspx.cs" Inherits="Dhmi.Web.YarSorunBildir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Sorun Bildir">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td width="950px" align="left">                                            
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
                                                        </td>
                                                       </tr>
                                                        <tr>
                                                    <td width="1280px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <table>
                                                                <tr>
                                                                    <td width="70px" align="left" height="30px">
                                                                    </td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    Sorun Türü:
                                                                    </td>
                                                                    <td width="330px" align="left" height="30px">
                                                                        <dx:ASPxComboBox ID="cb_sorun" runat="server" ValueType="System.String" Width="300" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Sorun Türü seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>                                                                            
                                                                        </dx:ASPxComboBox>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="70px" align="left" height="30px">
                                                                    </td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    Sorun Açıklama:
                                                                    </td>
                                                                    <td width="270px" align="left" height="30px">
                                                                        <dx:ASPxMemo ID="txt_aciklama" runat="server" MaxLength="500" Width="300" Height="80">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Sorun Açıklama giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>  
                                                                        </dx:ASPxMemo>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="70px" align="left" height="30px">
                                                                    </td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    Öneriniz:
                                                                    </td>
                                                                    <td width="330px" align="left" height="30px">
                                                                        <dx:ASPxTextBox ID="txt_öneri" runat="server" MaxLength="100" Width="300">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Öneri giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="70px" align="left" height="30px">
                                                                    </td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    İrtibat:
                                                                    </td>
                                                                    <td width="330px" align="left" height="30px">
                                                                        <dx:ASPxTextBox ID="txt_irtibat" runat="server" MaxLength="100" Width="300" NullText="Mail adresi ya da telefon numarası giriniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="İrtibat giriniz..." IsRequired="true"/>                                                                                
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
                                                                    <td width="70px" align="left" height="30px">
                                                                    </td>
                                                                    <td width="120px" align="left" height="30px">
                                                                    
                                                                    </td>
                                                                    <td width="160px" align="left" height="30px">
                                                                        <dx:ASPxButton ID="btn_gonder" runat="server" Text="Gönder" ValidationGroup="Group_Egt" Width="141" UseSubmitBehavior="true" OnClick="btn_gonder_Click">
                                                                        <ClientSideEvents Click="function(s, e) {
                                                                            Callback33.PerformCallback();
                                                                            LoadingPanel33.Show();
                                                                            }" />
                                                                        </dx:ASPxButton>
                                                                        <dx:ASPxCallback ID="ASPxCallback5" runat="server" ClientInstanceName="Callback33">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel33.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel4" runat="server" ClientInstanceName="LoadingPanel33" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel> 
                                                                    </td>
                                                                    <td width="160px" align="left" height="30px">
                                                                        <dx:ASPxButton ID="btn_iptal" runat="server" Text="İptal Et" ValidationGroup="Group_Egt" Width="141" UseSubmitBehavior="true" OnClick="btn_iptal_Click"></dx:ASPxButton>
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
                <dx:TabPage Text="Önceki Sorunlar ve Çözümleri">
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
                                                            <ClientSideEvents Click="function(s, e) { grid_sorun.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_sorun.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_sorun.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_sorun.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_sorun" runat="server" ClientInstanceName="grid_sorun" Width="1305px" AutoGenerateColumns="false" KeyFieldName="SorunId" OnPageSizeChanged="grid_sorun_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>      
                                                                <dx:GridViewDataTextColumn FieldName="SorunTarih" Caption="Tarih" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="85px" HeaderStyle-HorizontalAlign="Center" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                            
                                                                <dx:GridViewDataTextColumn FieldName="SorunTuruAd" Caption="Sorun Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="SorunOneri" Caption="Öneri" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="250px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="SorunAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="250px" HeaderStyle-HorizontalAlign="Center">                                                                                                                                
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="SorunIrtibat" Caption="İrtibat" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="SorunCevaplandiMi" Caption="Cevaplandı mı?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="115px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="SorunCozum" Caption="Çözüm" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="310px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                  
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="306" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                        
                                                        <dx:ASPxGridViewExporter  ID="grid_sorun_export"  runat="server" GridViewID="grid_sorun" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated"  LeftMargin="45" RightMargin="45" MaxColumnWidth="200">
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
            </TabPages>      
        </dx:ASPxPageControl>
    </div>
</asp:Content>
