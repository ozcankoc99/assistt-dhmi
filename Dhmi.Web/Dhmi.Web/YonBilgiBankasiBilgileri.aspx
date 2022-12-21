<%@ Page Title="DHMİ İletişim Merkezi - Bilgi Bankası Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonBilgiBankasiBilgileri.aspx.cs" Inherits="Dhmi.Web.YonBilgiBankasiBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
        <br />
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Yeni Kayıt">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

                                <table>
                                    <tr>
                                        <td width="1000px" align="left">

                                            <table>
                                                <tr>
                                                    <td></td>
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
                                                                <td width="1055px" align="right">
                                                                    <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                                        <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                                            <Items>
                                                                                <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                                                                                <dx:LayoutGroup Caption="Bilgi Bankası Bilgileri" Width="650px">
                                                                                    <Items>
                                                                                        <dx:LayoutItem Caption="Bilgi Bankası Türü:" Width="650px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <dx:ASPxComboBox ID="cb_bilgi" runat="server" ValueType="System.String" Width="485" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." OnSelectedIndexChanged="cb_bilgi_SelectedIndexChanged" AutoPostBack="true">
                                                                                                        <ValidationSettings ValidationGroup="Group_Bilgi" ErrorDisplayMode="ImageWithTooltip">
                                                                                                            <RequiredField ErrorText="Bilgi Bankası Türü seçiniz..." IsRequired="true" />
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
                                                                                                </dx:LayoutItemNestedControlContainer>
                                                                                            </LayoutItemNestedControlCollection>
                                                                                        </dx:LayoutItem>
                                                                                        <dx:LayoutItem Caption="Başlık:" Width="650px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <dx:ASPxTextBox ID="txt_baslik" runat="server" MaxLength="250" Width="485">
                                                                                                        <ValidationSettings ValidationGroup="Group_Bilgi" ErrorDisplayMode="ImageWithTooltip">
                                                                                                            <RequiredField ErrorText="Başlık giriniz..." IsRequired="true" />
                                                                                                        </ValidationSettings>
                                                                                                    </dx:ASPxTextBox>
                                                                                                </dx:LayoutItemNestedControlContainer>
                                                                                            </LayoutItemNestedControlCollection>
                                                                                        </dx:LayoutItem>
                                                                                        <dx:LayoutItem Caption="İçerik:" Width="650px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <dx:ASPxMemo ID="txt_icerik" runat="server" MaxLength="4000" Width="485" Height="40">
                                                                                                        <ValidationSettings ValidationGroup="Group_Bilgi" ErrorDisplayMode="ImageWithTooltip">
                                                                                                            <RequiredField ErrorText="İçerik giriniz..." IsRequired="true" />
                                                                                                        </ValidationSettings>
                                                                                                    </dx:ASPxMemo>
                                                                                                </dx:LayoutItemNestedControlContainer>
                                                                                            </LayoutItemNestedControlCollection>
                                                                                        </dx:LayoutItem>
                                                                                        <dx:LayoutItem Caption="Etiket:" Width="650px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <dx:ASPxTextBox ID="txt_etiket" runat="server" MaxLength="150" Width="485" BackColor="#F2EDED">
                                                                                                        <ValidationSettings ValidationGroup="Group_Bilgi" ErrorDisplayMode="ImageWithTooltip">
                                                                                                            <RequiredField ErrorText="Etiket giriniz..." />
                                                                                                        </ValidationSettings>
                                                                                                    </dx:ASPxTextBox>
                                                                                                </dx:LayoutItemNestedControlContainer>
                                                                                            </LayoutItemNestedControlCollection>
                                                                                        </dx:LayoutItem>
                                                                                        <dx:LayoutItem Caption="Belge:" Width="650px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <table>
                                                                                                        <tr>
                                                                                                            <td width="95" align="left">
                                                                                                                <asp:FileUpload ID="upload_foto" runat="server" Width="83" />
                                                                                                            </td>
                                                                                                            <td width="100" align="left">
                                                                                                                <dx:ASPxButton ID="btn_yukle" runat="server" Text="Yükle" Width="90" OnClick="btn_yukle_Click">
                                                                                                                </dx:ASPxButton>
                                                                                                            </td>
                                                                                                            <td width="100" align="left">
                                                                                                                <dx:ASPxButton ID="btn_goster" runat="server" Text="Göster" Width="90" OnClick="btn_goster_Click" Enabled="false">
                                                                                                                </dx:ASPxButton>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </dx:LayoutItemNestedControlContainer>
                                                                                            </LayoutItemNestedControlCollection>
                                                                                        </dx:LayoutItem>
                                                                                        <dx:LayoutItem Caption="Sıra:" Width="650px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <%--<asp:UpdatePanel ID="uptYeniKayit" runat="server">
                                                                                                        <Triggers>
                                                                                                            <asp:AsyncPostBackTrigger ControlID="cb_bilgi" EventName="SelectedIndexChanged" />
                                                                                                        </Triggers>
                                                                                                        <ContentTemplate>--%>
                                                                                                            <dx:ASPxTextBox ID="txt_sira" runat="server" MaxLength="4" Width="90">
                                                                                                                <ValidationSettings ValidationGroup="Group_Bilgi" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                    <RequiredField ErrorText="Sıra giriniz..." IsRequired="true" />
                                                                                                                </ValidationSettings>
                                                                                                            </dx:ASPxTextBox>
                                                                                                       <%-- </ContentTemplate>
                                                                                                    </asp:UpdatePanel>--%>
                                                                                                </dx:LayoutItemNestedControlContainer>
                                                                                            </LayoutItemNestedControlCollection>
                                                                                        </dx:LayoutItem>
                                                                                        <dx:LayoutItem Caption=" " Width="650px">
                                                                                            <LayoutItemNestedControlCollection>
                                                                                                <dx:LayoutItemNestedControlContainer>
                                                                                                    <table>
                                                                                                        <tr>
                                                                                                            <td>
                                                                                                                <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" ValidationGroup="Group_Bilgi" Width="90" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">
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
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1310" Height="555">
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
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiAd" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiDosya" Caption="Dosya" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiEtiket" Caption="Etiket" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiSira" Caption="Sıra" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="60px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="310" HorizontalScrollBarMode="Auto" />
                                                            <SettingsPager Mode="EndlessPaging" PageSize="20" />
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
                                                        <dx:ASPxGridView ID="grid_bilgi_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="BilgiBankasiId" OnSelectionChanged="grid_bilgi_sil_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_bilgi_sil_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiTurAd" Caption="Bilgi Bankası Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiAd" Caption="Başlık" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiIcerik" Caption="İçerik" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiDosya" Caption="Dosya" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="234px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiEtiket" Caption="Etiket" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="230px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiSira" Caption="Sıra" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="60px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="BilgiBankasiTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                                AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="326" HorizontalScrollBarMode="Auto" />
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:textbox id="txtUserName" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
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