<%@ Page Title="DHMİ İletişim Merkezi - İşlem Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonIslemBilgileri.aspx.cs" Inherits="Dhmi.Web.YonIslemBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">    
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />           
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>                
            <dx:TabPage Text="İşlem Oluştur (Yeni Kayıt - Ara - Güncelle - Sil)">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="625">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel2" runat="server" Width="1305px" Height="190px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                <table>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="99" height="12px">
                                                            
                                                        </td>
                                                        <td align="left" width="390">
                                                            
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Menü:*
                                                        </td>
                                                        <td align="left" width="390">
                                                            <dx:ASPxComboBox ID="cb_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_menu_SelectedIndexChanged">
                                                                                            <ValidationSettings ValidationGroup="Group_Islem" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Menü seçiniz..." IsRequired="true" />                                                                                
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
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Alt Menü:*
                                                        </td>
                                                        <td align="left" width="390">
                                                            <dx:ASPxComboBox ID="cb_alt_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_alt_menu_SelectedIndexChanged" Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_Islem" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Alt Menü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings> 
                                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback33.PerformCallback();
                                                                                            LoadingPanel33.Show();
                                                                                            }" />                                                                                                                                                                                    
                                                                                        </dx:ASPxComboBox>
                                                                                        <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback33">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel33.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel33" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel> 
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Alt Alt Menü:*
                                                        </td>
                                                        <td align="left" width="390">
                                                            <dx:ASPxComboBox ID="cb_alt_alt_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_alt_alt_menu_SelectedIndexChanged" Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_Islem" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Alt Alt Menü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings> 
                                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback3.PerformCallback();
                                                                                            LoadingPanel3.Show();
                                                                                            }" />                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                                                        <dx:ASPxCallback ID="ASPxCallback2" runat="server" ClientInstanceName="Callback3">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel3.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel3" runat="server" ClientInstanceName="LoadingPanel3" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel> 
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            İşlem Türü:*
                                                        </td>
                                                        <td align="left" width="390">
                                                            <dx:ASPxComboBox ID="cb_islem" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_Islem" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="İşlem Türü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>                                                                                                                                                            
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Sıra:*
                                                        </td>
                                                        <td align="left" width="390">
                                                            <dx:ASPxTextBox ID="txt_sira" runat="server" Width="50" MaxLength="2">
                                                                <ValidationSettings ValidationGroup="Group_Islem" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Sıra giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="99" height="28px">                                                            
                                                        </td>
                                                        <td align="left" width="390">  
                                                            <table>
                                                                <tr>
                                                                    <td width="185" align="left">
                                                                        <dx:ASPxButton ID="btn_kayit" runat="server" Text="Kaydet / Güncelle" Width="170" ValidationGroup="Group_Islem" OnClick="btn_kayit_Click">
                                                            </dx:ASPxButton>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxButton ID="btn_temizle" runat="server" Text="Temizle" Width="100" OnClick="btn_temizle_Click">
                                                            </dx:ASPxButton>
                                                                    </td>
                                                                </tr>
                                                            </table>                                                                                                                      
                                                        </td>
                                                        <td>                                                            
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>                                                                                     
                                <br />
                                <asp:Panel ID="panel3" runat="server" Width="1305px" Height="418px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                <br />
                                <table>
                                                <tr>
                                                    <td width="1320px" align="center">                                                        
                                                    </td>
                                                </tr>                                                
                                                <tr>
                                                    <td width="1320px" align="center">
                                                        <dx:ASPxGridView ID="grid_islem" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="IslemId" OnSelectionChanged="grid_islem_SelectionChanged" Width="1280px" OnPageSizeChanged="grid_islem_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="MenuAd" Caption="Menü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="AltMenuAd" Caption="Alt Menü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="270px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="AltAltMenuAd" Caption="Alt Alt Menü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="290px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="IslemTuruAd" Caption="İşlem Türü" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="330px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="IslemSira" Caption="İşlem Sırası" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="216" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager PageSize="5">
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>                                                    
                                                </tr>
                                                <tr>
                                                <td width="1000px" align="center">
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1000px" align="center">
                                                                    <table>
                                                                        <tr>          
                                                                            <td width="450px" align="center" height="50px"></td>                                                                           
                                                                            <td width="150px" align="center" height="50px">                                                                           
                                                                                <br />
                                                                                <dx:ASPxButton ID="btn_guncelle" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_guncelle_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>                                                                                                                                             
                                                                            <td width="150px" align="center" height="50px">                                                                              
                                                                                <br />
                                                                                <dx:ASPxButton ID="btn_sil" runat="server" Text="Sil" Width="80" Image-Url="~/Content/Images/sil.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_sil_Click" Paddings-PaddingLeft="5px" Enabled="false">
                                                                                    <ClientSideEvents Click="function(s,e) { e.processOnServer = confirm('Silmek istediğinizden emin misiniz?'); }" />
                                                                                    <Image Url="~/Content/Images/sil.png"></Image>
                                                                                    <Paddings PaddingLeft="5px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>                                                                            
                                                                            <td width="450px" align="center" height="50px"></td>                                                                           
                                                                        </tr>                                                                                                                                             
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
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
            </TabPages>      
        </dx:ASPxPageControl>
    </div>
</asp:Content>