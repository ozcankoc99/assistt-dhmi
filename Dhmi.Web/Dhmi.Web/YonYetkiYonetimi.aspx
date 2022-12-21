<%@ Page Title="DHMİ İletişim Merkezi - Yetki Yönetimi" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonYetkiYonetimi.aspx.cs" Inherits="Dhmi.Web.YonYetkiYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />           
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>                
            <dx:TabPage Text="Yeni Kayıt - Kayıt Sil">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel2" runat="server" Width="1320px" Height="70px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                <table>                                                    
                                                    <tr>
                                                        <td align="left" width="400" height="35">
                                                        </td>
                                                        <td align="left" width="170">
                                                            Yetki Adı(Rol):*
                                                        </td>
                                                        <td align="left" width="220">
                                                            <dx:ASPxTextBox ID="txt_yetki_adi" runat="server" Width="210" MaxLength="50">
                                                                <ValidationSettings ValidationGroup="Group_TC" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Yetki Adı(Rol) giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="400">
                                                        </td>
                                                        <td align="left" width="170">
                                                            İçerik Görüntülensin mi?*
                                                        </td>
                                                        <td align="left" width="220">
                                                            <dx:ASPxComboBox ID="cb_icerik" runat="server" ValueType="System.String" Width="210" DropDownStyle="DropDownList" IncrementalFilteringMode="Contains" NullText="Seçiniz...">
                                                                                                                    <ValidationSettings ValidationGroup="Group_TC" ErrorDisplayMode="ImageWithTooltip">
                                                                                                                        <RequiredField ErrorText="İçerik seçiniz..." IsRequired="true"/>
                                                                                                                    </ValidationSettings>
                                                            </dx:ASPxComboBox>
                                                        </td>
                                                        <td>
                                                            <dx:ASPxButton ID="btn_kayit" runat="server" Text="Kaydet" Width="100" ValidationGroup="Group_TC" OnClick="btn_kayit_Click">
                                                            </dx:ASPxButton>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>                                                                                     
                                <br />
                                <asp:Panel ID="panel3" runat="server" Width="1320px" Height="356px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                <br />
                                <table>
                                                <tr>
                                                    <td width="1328px" align="center">
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>                                                                                                                                                       
                                                                            <td width="350px" align="center" height="50px">                                                                              
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
                                                    <td width="1078px" align="center">
                                                        <dx:ASPxGridView ID="grid_yetki" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="YetkiId" OnSelectionChanged="grid_yetki_SelectionChanged" Width="652px" OnPageSizeChanged="grid_yetki_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="YetkiAd" Caption="Yetki Adı(Rol)" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="260px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Left">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="YetkiAciklama" Caption="İçerik Görüntülensin mi?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="YetkiTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="156" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager PageSize="5">
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="1078px" align="center">
                                                        <asp:TextBox ID="txtUserName" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
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
                <dx:TabPage Text="Yetki İşlemleri">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1310" Height="685">
                                <table>
                                    <tr>
                                        <td align="center">                                       
                                            <table>
                                                <tr>
                                                    <td align="left" width="342">
                                                    </td>
                                                    <td align="left" width="72">
                                                        Yetki Türü:
                                                    </td>
                                                    <td align="left" width="400" height="30">
                                                        <dx:ASPxComboBox ID="cb_yetki" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_yetki_SelectedIndexChanged">
                                                                                            <ValidationSettings ValidationGroup="Group_Sicil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Ana Menü seçiniz..." IsRequired="true" />                                                                                
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
                                                    </td>
                                                    <td align="center" width="60" height="30">
                                                        <dx:ASPxButton ID="btn_temizle" runat="server" Text="Temizle" ValidationGroup="Group_Sicil" Width="100" UseSubmitBehavior="true" OnClick="btn_temizle_Click">
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" width="342">
                                                    </td>
                                                    <td align="left" width="72">
                                                        Ana Modül:
                                                    </td>
                                                    <td align="left" width="400" height="30">
                                                        <dx:ASPxComboBox ID="cb_ana_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_ana_menu_SelectedIndexChanged" Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_Sicil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Ana Menü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>   
                                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback33.PerformCallback();
                                                                                            LoadingPanel33.Show();
                                                                                            }" />                                                                                         
                                                                                        </dx:ASPxComboBox>
                                                                                        <dx:ASPxCallback ID="ASPxCallback2" runat="server" ClientInstanceName="Callback33">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel33.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel3" runat="server" ClientInstanceName="LoadingPanel33" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel>
                                                    </td>
                                                    <td align="center" width="60" height="30">
                                                        <dx:ASPxButton ID="btn_temizle_2" runat="server" Text="Temizle" ValidationGroup="Group_Sicil" Width="100" UseSubmitBehavior="true" OnClick="btn_temizle_Click">
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="left" width="342">
                                                    </td>
                                                    <td align="left" width="72">
                                                        Alt Modül:
                                                    </td>
                                                    <td align="left" width="400" height="30">
                                                        <dx:ASPxComboBox ID="cb_alt_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_alt_menu_SelectedIndexChanged" Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_Sicil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Alt Menü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>   
                                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback3.PerformCallback();
                                                                                            LoadingPanel3.Show();
                                                                                            }" />                                                                                         
                                                                                        </dx:ASPxComboBox>
                                                                                        <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback3">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel3.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel3" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel>
                                                    </td>
                                                    <td align="center" width="60" height="30">
                                                        <dx:ASPxButton ID="btn_temizle_3" runat="server" Text="Temizle" ValidationGroup="Group_Sicil" Width="100" UseSubmitBehavior="true" OnClick="btn_temizle_Click">
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>                                                
                                            </table>   
                                            <br />
                                            <asp:Panel ID="pnl_bit" runat="server" Visible="false">
                                            <table>
                                                <tr>
                                                    <td align="left" width="312">
                                                    </td>
                                                    <td align="left" width="72">
                                                        İşlemler:
                                                    </td>
                                                    <td align="left" width="400" height="30">
                                                        <dx:ASPxCheckBoxList ID="cb_menu_list" runat="server" ValueType="System.String" Width="400">                                                 
                                                        </dx:ASPxCheckBoxList>                                                        
                                                    </td>
                                                    <td align="center" width="97" height="30">                                                        
                                                    </td>
                                                </tr>                                                
                                            </table> 
                                            <br />
                                            <table>
                                                <tr>
                                                    <td align="left" width="312">
                                                    </td>
                                                    <td align="left" width="32">
                                                        
                                                    </td>
                                                    <td align="center" width="400" height="30">
                                                        <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Değişiklikleri Kaydet" ValidationGroup="Group_Sicil" Width="220" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">
                                                        </dx:ASPxButton> 
                                                    </td>
                                                    <td align="center" width="87" height="30">                                                        
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td align="left" width="228">

                                                    </td>
                                                    <td align="left" width="32">
                                                        
                                                    </td>
                                                    <td align="center" width="100" height="30">
                                                        İşlem Türü:
                                                    </td>
                                                    <td align="center" width="87" height="30">                                                        
                                                        <dx:ASPxComboBox ID="cb_islem_turu" runat="server" ValueType="System.String" Width="280" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_islem_turu_SelectedIndexChanged">
                                                                                            <ValidationSettings ValidationGroup="Group_Islem" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="İşlem Türü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>   
                                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback34.PerformCallback();
                                                                                            LoadingPanel34.Show();
                                                                                            }" />                                                                                         
                                                                                        </dx:ASPxComboBox>
                                                                                        <dx:ASPxCallback ID="ASPxCallback4" runat="server" ClientInstanceName="Callback34">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel34.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel4" runat="server" ClientInstanceName="LoadingPanel34" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel>
                                                    </td>
                                                </tr>                                                
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td align="left" width="158">

                                                    </td>
                                                    <td align="left" width="32">
                                                        
                                                    </td>
                                                    <td align="center" width="100" height="30">
                                                        
                                                    </td>
                                                    <td align="center" width="87" height="30">                                                        
                                                       <dx:ASPxCheckBoxList ID="cb_son_islem" runat="server" ValueType="System.String" Width="400">                                                 
                                                        </dx:ASPxCheckBoxList> 
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td align="left" width="158">

                                                    </td>
                                                    <td align="left" width="32">
                                                        
                                                    </td>
                                                    <td align="center" width="100" height="30">
                                                        
                                                    </td>
                                                    <td align="center" width="87" height="30">                                                        
                                                       <dx:ASPxButton ID="btn_alt_kaydet" runat="server" Text="Değişiklikleri Kaydet" ValidationGroup="Group_Alt" Width="220" UseSubmitBehavior="true" OnClick="btn_alt_kaydet_Click" Visible="false">
                                                        </dx:ASPxButton> 
                                                    </td>
                                                </tr>
                                            </table>
                                            </asp:Panel>                                        
                                        </td>
                                        <td>

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