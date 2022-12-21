<%@ Page Title="DHMİ İletişim Merkezi - Mesaj Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="KulMeajBilgileri.aspx.cs" Inherits="Dhmi.Web.KulMeajBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Yeni Mesaj">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td width="1000px" align="left">
                                            
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
                                                        </td>
                                                       </tr>
                                                        <tr>                                                        
                                                    <td width="930px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                         <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                <Items>       
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                 
                                                    <dx:LayoutGroup Caption="Yeni Mesaj Gönder" Width="530px">
                                                        <Items>                                                                                                                                                                                                                                                                                             
                                                            <dx:LayoutItem Caption="Grup:" Width="530px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                        
                                                                            <dx:ASPxComboBox ID="cb_grup" runat="server" ValueType="System.String" Width="425" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_grup_SelectedIndexChanged" >
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Grup seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>                                                                            
                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                            Callback22.PerformCallback();
                                                                            LoadingPanel22.Show();
                                                                            }" />
                                                                        </dx:ASPxComboBox>
                                                                        <dx:ASPxCallback ID="ASPxCallback3" runat="server" ClientInstanceName="Callback22">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel22.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel22" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Personel:" Width="530px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <asp:Panel ID="pnkdsd" runat="server" Width="425" ScrollBars="Vertical" Height="133px">
                                                                            <dx:ASPxCheckBoxList ID="cb_per_list" runat="server" ValueType="System.String" Width="405">
                                                                            </dx:ASPxCheckBoxList> 
                                                                        </asp:Panel>
                                                                        <dx:ASPxCheckBox ID="cb_hepsi" runat="server" Text="Hepsini Seç" AutoPostBack="true" OnCheckedChanged="cb_hepsi_CheckedChanged">                                                                        
                                                                        <ClientSideEvents CheckedChanged="function(s, e) {
                                                                            Callback2.PerformCallback();
                                                                            LoadingPanel2.Show();
                                                                            }" />
                                                                        </dx:ASPxCheckBox>
                                                                        <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback2">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel2.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel2" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                            
                                                            <dx:LayoutItem Caption="Başlık:" Width="530px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <table>
                                                                            <tr>
                                                                                <td>
                                                                                    <dx:ASPxTextBox ID="txt_aciklama" runat="server" MaxLength="300" Width="425">
                                                                            <ValidationSettings ValidationGroup="Group_Mes" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Başlık giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                                </td>
                                                                            </tr>
                                                                        </table>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>      
                                                            <dx:LayoutItem Caption="İçerik:" Width="530px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                        
                                                                        <dx:ASPxMemo ID="txt_icerik" runat="server" MaxLength="1000" Width="425" Height="40">
                                                                            <ValidationSettings ValidationGroup="Group_Mes" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="İçerik giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxMemo>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
                                                            <dx:LayoutItem Caption=" " Width="530px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <table>
                                                                            <tr>
                                                                                <td>
                                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" ValidationGroup="Group_Mes" Width="90" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">                                                                       
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
                <dx:TabPage Text="Gelen Kutusu">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1310" Height="485">
                                <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAll" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_mesaj" runat="server" ClientInstanceName="grid_mesaj" Width="1305px" AutoGenerateColumns="false" KeyFieldName="MesajId" OnPageSizeChanged="grid_mesaj_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAdSoyad" Caption="Gönderen Personel" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="206px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="MesajTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                          
                                                                <dx:GridViewDataTextColumn FieldName="MesajBaslik" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="295px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="MesajIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="572px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                     
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="268" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_mesaj_export" runat="server" GridViewID="grid_mesaj" Landscape="true" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="40" RightMargin="40" MaxColumnWidth="500">
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
                <dx:TabPage Text="Giden Kutusu">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="485">
                                <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj_git.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj_git.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton3" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj_git.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="ASPxButton4" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_mesaj_git.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_mesaj_git" runat="server" ClientInstanceName="grid_mesaj_git" Width="1305px" AutoGenerateColumns="false" KeyFieldName="MesajId" OnPageSizeChanged="grid_mesaj_git_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>                                                                                                                                   
                                                                <dx:GridViewDataTextColumn FieldName="MesajHangiKullanici" Caption="Alıcı Personel" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="206px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="MesajTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                          
                                                                <dx:GridViewDataTextColumn FieldName="MesajBaslik" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="MesajIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="567px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                   
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="268" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="grid_mesaj_git_export" runat="server" GridViewID="grid_mesaj_git" Landscape="true" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="40" RightMargin="40" MaxColumnWidth="300">
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
                                                                                <dx:ASPxButton ID="btn_pdf_al" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="1px" OnClick="btn_pdf_al_Click">                                                                                                                                                                                                                      
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                              
                                                                                <dx:ASPxButton ID="btn_exc_al" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="5px" OnClick="btn_exc_al_Click">                                                                                
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="150px" align="center" height="80px">                                                                             
                                                                                <dx:ASPxButton ID="btn_doc_al" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="3px" OnClick="btn_doc_al_Click">                                                                                
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