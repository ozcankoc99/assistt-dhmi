<%@ Page Title="DHMİ İletişim Merkezi - Vatandaş Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="VtnVatandasBilgileri.aspx.cs" Inherits="Dhmi.Web.VtnVatandasBilgileri" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">                                                
<script type="text/javascript">
    // <![CDATA[
    function ShowGecmisWindow() {
        pcGecmis.Show();
    }
    // ]]> 
        </script>
        <style type="text/css">              
        .TabStyle .ajax__tab_header
        {               	
            cursor: pointer;
            background-color: #ffffff;            
            font-size: 12px;
            font-weight: bold;
            font-family: Arial, Helvetica, sans-serif;            
            height: 36px;
            border-bottom: 1px solid #bebebe;
            width:%100;   
        }
      
        .TabStyle .ajax__tab_active .ajax__tab_tab
        {
            border: 1px solid;
            border-color: #bebebe #bebebe #e1e1e1 #bebebe;
            background-color: #ffffff;
            padding: 10px;
            border-bottom: none;
        }
        .TabStyle .ajax__tab_active .ajax__tab_tab:hover
        {
            border: 1px solid;
            border-color: #bebebe #bebebe #e1e1e1 #bebebe;
            background-color: #e1e1e1;
            padding: 10px;
            border-bottom: none;
        }
      
        .TabStyle .ajax__tab_tab
        {
            border: 1px solid;
            border-color: #e1e1e1 #e1e1e1 #bebebe #e1e1e1;
            background-color: #f1f1f1;
            color: #777777;
            cursor: pointer;
            text-decoration: none;
            padding: 10px;
        }
        .TabStyle .ajax__tab_tab:hover
        {
            border: 1px solid;
            border-color: #bebebe #bebebe #e1e1e1 #bebebe;
            background-color: #e1e1e1;
            color: #777777;
            cursor: pointer;
            text-decoration: none;
            padding: 10px;
            border-bottom: none;
        }
        .TabStyle .ajax__tab_active .ajax__tab_tab, .TabStyle .ajax__tab_tab, .TabStyle .ajax__tab_header .ajax__tab_tab
        {
            margin: 0px 0px 0px 0px;
        }
      
        .TabStyle .ajax__tab_body
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 10pt;
            border-top: 0;
            border: 1px solid #bebebe;
            border-top: none;
            padding: 5px;
            background-color: #ffffff;
            width:1318px;
        }
    </style>
    <asp:ToolkitScriptManager ID="asdsadasd" runat="server" ScriptMode="Release" CombineScripts="true" LoadScriptsBeforeUI="false"></asp:ToolkitScriptManager>    
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> 
            <asp:TabContainer ID="tab_bas" runat="server" ActiveTabIndex="0" Width="1330px" CssClass="TabStyle" AutoPostBack="true" OnDemand="false">
                <asp:TabPanel ID="tab_panel_1" runat="server" HeaderText="İşlem Özeti">
                    <ContentTemplate>
                        <asp:Panel ID="Panel3" runat="server" Width="1069" Height="500">                                        
                                                            <table>
                                    <tr>
                                        <td>                                                                                        
                                                    <table>
                                                <tr>
                                                    <td align="center" width="100">
                                                    </td>
                                                    <td>
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1325px" align="center">
                                                                    <table>
                                                                        <tr>                                                                                                                                                                                                                                    
                                                                            <td width="190px" align="center" height="70px">                                                                                                                                                         
                                                                                        <dx:ASPxButton ID="btn_cagri" runat="server" Text="Çağrı Oluştur" Width="120" Image-Url="~/Content/Images/cagri.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_cagri_Click" Paddings-PaddingLeft="6px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/cagri.png"></Image>
                                                                                    <Paddings PaddingLeft="6px"></Paddings>
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
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" width="300">
                                                    </td>
                                                    <td align="center" width="1320">                                                                    
                                                                <dx:ASPxGridView ID="grid_liste" runat="server" ClientIDMode="AutoID" AutoGenerateColumns="false" EnableCallBacks="false" KeyFieldName="VatandasId" OnSelectionChanged="grid_liste_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_liste_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="VatandasId" Caption="Kayıt No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">                                                                    
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTur" Caption="Kayıt Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>   
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasUyruk" Caption="Uyruk" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon Numarası (1)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel2" Caption="Telefon Numarası (2)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasNotes" Caption="Not (Açıklama)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdres" Caption="Adres" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                            </Columns>                                                            
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="310" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>                                                        
                                                        </dx:ASPxGridView>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>                                                           
                                                                <asp:TextBox ID="txtUserName3" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>                                                                                                                                                                    
                                                                                                                                                                                                                                      
                                                    </td>
                                                </tr>
                                            </table>                                                                                                                                     
                                        </td>
                                    </tr>
                                </table>                                                                                          
                            </asp:Panel>  
                    </ContentTemplate>                      
                </asp:TabPanel>
                <asp:TabPanel ID="tab_panel_2" runat="server" HeaderText="İşlem Özeti">
                    <ContentTemplate>
                        <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1069" Height="485">
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
                                                        </td>
                                                       </tr>
                                                        <tr>                                                        
                                                    <td width="1230px" align="right">                                                         
                                                                                <asp:Panel ID="pnl_alt_taraf" runat="server">                                                                                                                                                        
                                                         <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                <Items>       
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                                                                    
                                                    <dx:LayoutGroup Caption="Vatandaş Bilgileri" Width="550px">
                                                        <Items>                                                                                                                                                                              
                                                            <dx:LayoutItem Caption="Kayıt Türü:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                                  
                                                                            <dx:ASPxComboBox ID="cb_kayit_tur" runat="server" ValueType="System.String" Width="170" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_kayit_tur_SelectedIndexChanged">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Kayıt Türü seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>                                                                                                                                                                                    
                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback333.PerformCallback();
                                                                                            LoadingPanel333.Show();
                                                                                            }" />   
                                                                        </dx:ASPxComboBox>                                                                      
                                                                        <dx:ASPxCallback ID="ASPxCallback3" runat="server" ClientInstanceName="Callback333">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel333.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel333" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel>                                                                                                                                                                                                                                                                                                                                                                      
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                         
                                                            <dx:LayoutItem Caption="TC Kimlik No:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                        
                                                                                <asp:Panel ID="pnl_tc" runat="server">
                                                                        <table>
                                                                            <tr>
                                                                                <td align="left" width="100">
                                                                                    <dx:ASPxTextBox ID="txt_tc_no" runat="server" MaxLength="11" Width="90">
                                                                                        <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                                        <RequiredField ErrorText="TC Kimlik No giriniz..."/>                                                                                
	                                                                                    </ValidationSettings>                                                                            
                                                                                    </dx:ASPxTextBox>
                                                                                </td>                                                                                
                                                                                <td align="left" width="80">
                                                                                    <dx:ASPxButton ID="btn_kps" runat="server" Text="KPS" ValidationGroup="Group_Kps" Width="70" UseSubmitBehavior="true" OnClick="btn_kps_Click">
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
                                                                            </tr>
                                                                        </table>                              
                                                                        </asp:Panel>                                                                                                                                                                                           
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Pasaport No:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_pasaport" runat="server" MaxLength="50" Width="170">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Pasaport No giriniz..."/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Vergi Kimlik No:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_vergi_no" runat="server" MaxLength="10" Width="170">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Vergi Kimlik No giriniz..."/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Uyruk:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_uyruk" runat="server" MaxLength="50" Width="170">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Uyruk giriniz..."/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Ad:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_ad" runat="server" MaxLength="50" Width="260">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Ad giriniz..." IsRequired="true" />                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>  
                                                            <dx:LayoutItem Caption="Soyad:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_soyad" runat="server" MaxLength="50" Width="260">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Soyad giriniz..."/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Cinsiyet:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxComboBox ID="cb_cinsiyet" runat="server" ValueType="System.String" Width="80" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Cinsiyet seçiniz..."/>                                                                                
                                                                            </ValidationSettings>                                                                                                                                                                                    
                                                                        </dx:ASPxComboBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Doğum Tarihi:" Width="285px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_dogum_tarihi" runat="server" Width="80">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Doğum Tarihi giriniz..."/>                                                                                
                                                                            </ValidationSettings>
                                                                            <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata"/>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                               
                                                            <dx:LayoutItem Caption="Telefon Numarası (1):" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                    
                                                                                    <dx:ASPxTextBox ID="txt_tel_no" runat="server" Width="120" MaxLength="20" Native="false" EnableDefaultAppearance="false">                                                                                        
                                                                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Group_Vat">
                                                                                            <RequiredField ErrorText="Telefon Numarası giriniz..."/>
                                                                                        </ValidationSettings>
                                                                                    </dx:ASPxTextBox>                                                                                                                                                                                                                              
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem> 
                                                            <dx:LayoutItem Caption="Telefon Numarası (2):" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                    
                                                                                    <dx:ASPxTextBox ID="txt_tel_no2" runat="server" Width="120" MaxLength="20" Native="false" EnableDefaultAppearance="false">
                                                                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Group_Va9t">
                                                                                            <RequiredField ErrorText="Telefon Numarası giriniz..."/>
                                                                                        </ValidationSettings>
                                                                                    </dx:ASPxTextBox>                                                                                                                                                                                                                              
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Mail Adresi:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_mail" runat="server" MaxLength="150" Width="260">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Mail Adresi giriniz..."/>
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                            <dx:LayoutItem Caption="Adres:" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                        
                                                                        <dx:ASPxMemo ID="txt_adres" runat="server" MaxLength="1000" Width="370" Height="40">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Adres giriniz..."/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxMemo>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>     
                                                            <dx:LayoutItem Caption="Not (Açıklama):" Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_not" runat="server" MaxLength="150" Width="370">
                                                                            <ValidationSettings ValidationGroup="Group_Vat" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Not (Açıklama) giriniz..." />
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                        
                                                            <dx:LayoutItem Caption=" " Width="550px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <table>
                                                                            <tr>
                                                                                <td>
                                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" ValidationGroup="Group_Vat" Width="90" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">
                                                                                    <ClientSideEvents Click="function(s, e) {
                                                                                        Callback43.PerformCallback();
                                                                                        LoadingPanel43.Show();
                                                                                        }" />
                                                                                    </dx:ASPxButton>
                                                                                    <dx:ASPxCallback ID="ASPxCallback11" runat="server" ClientInstanceName="Callback43">
                                                                                                                                <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel43.Hide(); }" />
                                                                                                                            </dx:ASPxCallback>
                                                                                                                            <dx:ASPxLoadingPanel ID="ASPxLoadingPanel11" runat="server" ClientInstanceName="LoadingPanel43" Modal="True" Text="İşlem tamamlanıyor. Lütfen bekleyiniz..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                            </dx:ASPxLoadingPanel>
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
                    </ContentTemplate>                      
                </asp:TabPanel>
                <asp:TabPanel ID="tab_panel_3" runat="server" HeaderText="İşlem Özeti">
                    <ContentTemplate>
                        <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1069" Height="520">
                                <table>
                                    <tr>
                                        <td>                                                                                                                               
                                            <br />
                                            <table>
                                                <tr>
                                                    <td align="center" width="13">
                                                    </td>
                                                    <td align="center" width="1300">
                                                        <dx:ASPxGridView ID="grid_vatandas" runat="server" ClientInstanceName="grid_vatandas" Width="1305px" AutoGenerateColumns="false" KeyFieldName="VatandasId" OnPageSizeChanged="grid_vatandas_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
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
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasUyruk" Caption="Uyruk" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
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
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                  
                                                            </Columns>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm"/>
                                                            <SettingsPopup>                                                                
                                                                <EditForm Width="1300px" Height="220px" Modal="true" VerticalAlign="WindowCenter"/>
                                                            </SettingsPopup>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="371" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="20" />                                                          
                                                        </dx:ASPxGridView>                                                        
                                                        <dx:ASPxGridViewExporter ID="grid_vatandas_export" runat="server" GridViewID="grid_vatandas" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="70" RightMargin="70" MaxColumnWidth="225">
                                                             <Styles>
                                                                <Cell VerticalAlign="Middle" HorizontalAlign="Center"></Cell>
                                                                <Header BackColor="LightBlue" Font-Bold="true" ForeColor="Maroon"></Header>                                                                
                                                            </Styles>
                                                        </dx:ASPxGridViewExporter>  
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1100px" align="center">
                                                                    <table>
                                                                        <tr>
                                                                            <td width="1100px" align="center" height="60px">                                                                                                                                                           
                                                                                <dx:ASPxButton ID="btnPdfExport" runat="server" Text="  Rapor Al" Width="180" Font-Bold="true" Image-Url="~/Content/Images/report.png" ImagePosition="Left" UseSubmitBehavior="true" Paddings-PaddingLeft="5px" OnClick="btnPdfExport_Click" ForeColor="Maroon">
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
                    </ContentTemplate>                      
                </asp:TabPanel>
                <asp:TabPanel ID="tab_panel_4" runat="server" HeaderText="İşlem Özeti">
                    <ContentTemplate>
                        <asp:Panel ID="Panel1" runat="server" Width="1069" Height="495">
                        <br />
                                <table>
                                    <tr>
                                        <td>                                            
                                            <table>
                                                <tr>
                                                    <td>                                                        
                                                    </td>
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
                                                                                <dx:ASPxButton ID="btn_sil" runat="server" Text="Sil" Width="80" Image-Url="~/Content/Images/sil.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_sil_Click" Paddings-PaddingLeft="2px" Enabled="false">
                                                                                    <ClientSideEvents Click="function(s,e) { e.processOnServer = confirm('Silmek istediğinizden emin misiniz?'); }" />
                                                                                    <Image Url="~/Content/Images/sil.png"></Image>
                                                                                    <Paddings PaddingLeft="2px"></Paddings>
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
                                                    <td align="center" width="303">
                                                    </td>
                                                    <td align="center" width="1303">
                                                        <dx:ASPxGridView ID="grid_vatandas_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="VatandasId" OnSelectionChanged="grid_vatandas_sil_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_vatandas_sil_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="VatandasId" Caption="Kayıt No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTur" Caption="Kayıt Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasUyruk" Caption="Uyruk" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon Numarası (1)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel2" Caption="Telefon Numarası (2)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasNotes" Caption="Not (Açıklama)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdres" Caption="Adres" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="291" HorizontalScrollBarMode="Auto"/>
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
                    </ContentTemplate>                      
                </asp:TabPanel>
                <asp:TabPanel ID="tab_panel_5" runat="server" HeaderText="İşlem Özeti">
                    <ContentTemplate>
                        <asp:Panel ID="Panel4" runat="server" Width="1069" Height="495">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td width="200" align="center"
                                                    </td>
                                                    <td width="1000" align="center">
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>                                                                                                                                                                                                                                                                                                               
                                                                            <td width="190px" align="center" height="50px">                                                                           
                                                                                <dx:ASPxButton ID="btn_white" runat="server" Text="VIP Listeye Al" Width="120" Image-Url="~/Content/Images/white.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_white_Click" Paddings-PaddingLeft="2px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/white.png"></Image>
                                                                                    <Paddings PaddingLeft="2px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td width="190px" align="center" height="50px">                                                                           
                                                                                <dx:ASPxButton ID="btn_black" runat="server" Text="Kara Listeye Al" Width="120" Image-Url="~/Content/Images/black.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_black_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/black.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
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
                                                    <td width="250" align="center"
                                                    </td>
                                                    <td width="1320" align="center">
                                                        <dx:ASPxGridView ID="grid_v_k" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="VatandasId" OnSelectionChanged="grid_v_k_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_v_k_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasId" Caption="Kayıt No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTur" Caption="Kayıt Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasUyruk" Caption="Uyruk" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                          
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon Numarası (1)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel2" Caption="Telefon Numarası (2)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasNotes" Caption="Not (Açıklama)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdres" Caption="Adres" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="291" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="txtUserName5" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>                                            
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                    </ContentTemplate>                      
                </asp:TabPanel>
                <asp:TabPanel ID="tab_panel_6" runat="server" HeaderText="İşlem Özeti">
                    <ContentTemplate>
                        <asp:Panel ID="Panel2" runat="server" Width="1069" Height="545">
                                <table>
                                    <tr>
                                        <td>
                                            <br />
                                            <table>                                                
                                                <tr>
                                                    <td>                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="200" align="center">
                                                    </td>
                                                    <td width="1320" align="center">    
                                                        <dx:ASPxGridView ID="grid_gecmis" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="VatandasId" OnSelectionChanged="grid_gecmis_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_gecmis_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="VatandasId" Caption="Kayıt No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTur" Caption="Kayıt Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTcNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>                                                                                                                               
                                                                <dx:GridViewDataTextColumn FieldName="VatandasPasaportNo" Caption="Pasaport No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasVergiNo" Caption="Vergi Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasUyruk" Caption="Uyruk" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdSoyad" Caption="Vatandaş Adı Soyadı/Firma Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="240px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                            
                                                                <dx:GridViewDataTextColumn FieldName="VatandasCinsiyet" Caption="Cinsiyet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasDogumTarihi" Caption="Doğum Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" PropertiesTextEdit-DisplayFormatString="dd/MM/yyyy">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel1" Caption="Telefon Numarası (1)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasTel2" Caption="Telefon Numarası (2)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasNotes" Caption="Not (Açıklama)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="175px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasAdres" Caption="Adres" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="400px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="VatandasIslemTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" />
                                                                </dx:GridViewDataTextColumn>  
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="342" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>                                                    
                                                </tr>
                                                <tr>
                                                    <td width="200" align="center">
                                                    </td>
                                                    <td width="1000" align="center">
                                                        <br />
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="300px" align="center">
                                                                    <table>
                                                                        <tr>                                                                                                                                                                                                                                    
                                                                            <td width="150px" align="center" height="50px">                                                                           
                                                                                <dx:ASPxButton ID="btn_bilgi_gecmis" runat="server" Text="Geçmiş" Width="95" Image-Url="~/Content/Images/gecmis.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="4px" Enabled="false" AutoPostBack="true">
                                                                                    <Image Url="~/Content/Images/gecmis.png"></Image>
                                                                                    <Paddings PaddingLeft="4px"></Paddings>
                                                                                    <ClientSideEvents Click="function(s, e) { ShowGecmisWindow(); }" />
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
                                                        <asp:TextBox ID="txtUserName2" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>                                            
                                        </td>
                                    </tr>
                                </table>
                                <dx:ASPxPopupControl ID="pcGecmis" runat="server" CloseAction="CloseButton" Modal="True"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcGecmis"
        HeaderText="GEÇMİŞ BİLGİLERİ" AllowDragging="True" PopupAnimationType="Fade" EnableViewState="False">
        <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('entryGroup'); cb_yon_grup.Focus(); }" />
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">
                <asp:Panel ID="pnl_g_gor" runat="server" Width="685px" Height="435px" BorderColor="Maroon">
                                                        <table>
                                                            <tr>
                                                                <td >                                                                    
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <dx:ASPxListBox ID="lb_gecmis" runat="server" Width="682" Height="432"><ItemStyle Wrap="True"/></dx:ASPxListBox>
                                                                </td>
                                                            </tr>
                                                        </table> 
                                                        </asp:Panel>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
                            </asp:Panel>
                    </ContentTemplate>                      
                </asp:TabPanel>
            </asp:TabContainer>                
    </div>
        </ContentTemplate>
    </asp:UpdatePanel>   
    </div>                                                                     
    <br />    
</asp:Content>