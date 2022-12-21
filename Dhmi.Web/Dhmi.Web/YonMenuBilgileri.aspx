<%@ Page Title="DHMİ İletişim Merkezi - Menü Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonMenuBilgileri.aspx.cs" Inherits="Dhmi.Web.YonMenuBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />           
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>                
            <dx:TabPage Text="Menü (Yeni Kayıt - Ara - Güncelle - Sil)">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="485">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel2" runat="server" Width="1305px" Height="162px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                <table>
                                                    <tr>
                                                        <td align="left" width="395">
                                                        </td>
                                                        <td align="left" width="79" height="12px">
                                                            
                                                        </td>
                                                        <td align="left" width="490">
                                                            
                                                        </td>
                                                        <td align="left" width="200">
                                                            
                                                        </td>
                                                    </tr>                                                                                                                                                                                                              
                                                    <tr>
                                                        <td align="left" width="395">
                                                        </td>
                                                        <td align="left" width="79" height="28px">
                                                            Menü Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_menu" runat="server" Width="400" MaxLength="300">
                                                                <ValidationSettings ValidationGroup="Group_Menu" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Menü Adı giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="395">
                                                        </td>
                                                        <td align="left" width="79" height="28px">
                                                            Link:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_link" runat="server" Width="400" MaxLength="300">
                                                                <ValidationSettings ValidationGroup="Group_Menu" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Link giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="395">
                                                        </td>
                                                        <td align="left" width="79" height="28px">
                                                            Sıra:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_sira" runat="server" Width="100" MaxLength="3">
                                                                <ValidationSettings ValidationGroup="Group_Menu" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Sıra giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="395">
                                                        </td>
                                                        <td align="left" width="79" height="28px">
                                                            Açıklama:
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_aciklama" runat="server" Width="400" MaxLength="300" BackColor="#F2EDED">
                                                                <ValidationSettings ValidationGroup="Group_Menu" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Açıklama giriniz..."/>                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="395">
                                                        </td>
                                                        <td align="left" width="79" height="28px">                                                            
                                                        </td>
                                                        <td align="left" width="490">  
                                                            <table>
                                                                <tr>
                                                                    <td width="160" align="left">
                                                                        <dx:ASPxButton ID="btn_kayit" runat="server" Text="Kaydet / Güncelle" Width="140" ValidationGroup="Group_Menu" OnClick="btn_kayit_Click">
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
                                <asp:Panel ID="panel3" runat="server" Width="1305px" Height="308px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                <br />
                                <table>
                                                <tr>
                                                    <td width="1320px" align="center">                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>                                                                                                              
                                                    </td>
                                                </tr>
                                                <tr>                                                                                                       
                                                    <td width="1320px" align="center">
                                                        <dx:ASPxGridView ID="grid_menu" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="MenuId" OnSelectionChanged="grid_menu_SelectionChanged" Width="800px" OnPageSizeChanged="grid_menu_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="MenuAd" Caption="Menü Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="210px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="MenuLink" Caption="Link" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="292px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="MenuSira" Caption="Sıra" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="78px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="MenuAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                           
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="170" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager PageSize="5">
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                        <td width="488px" align="left">
                                                            <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="left">
                                                                    <table>
                                                                        <tr>    
                                                                            <td width="150px" align="center" height="50px">                                                                           
                                                                                <br />
                                                                                <dx:ASPxButton ID="btn_guncelle" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_guncelle_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                                                                        </tr>                                                                                                                                             
                                                                        <tr>
                                                                            <td width="150px" align="center" height="50px">                                                                              
                                                                                <br />
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
                <dx:TabPage Text="Alt Menü (Yeni Kayıt - Ara - Güncelle - Sil)">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="Panel4" runat="server" Width="1310" Height="485">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel5" runat="server" Width="1305px" Height="162px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                <table>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="99" height="12px">
                                                            
                                                        </td>
                                                        <td align="left" width="490">
                                                            
                                                        </td>
                                                        <td align="left" width="200">
                                                            
                                                        </td>
                                                    </tr>                                                                                                                                                                                                              
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Menü Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxComboBox ID="cb_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Menu_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Menü Adı seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                                                                                                             
                                                                                        </dx:ASPxComboBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Alt Menü Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_menu_alt" runat="server" Width="400" MaxLength="300">
                                                                <ValidationSettings ValidationGroup="Group_Menu_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Alt Menü Adı giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>                                                   
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Sıra:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_sira_alt" runat="server" Width="100" MaxLength="3">
                                                                <ValidationSettings ValidationGroup="Group_Menu_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Sıra giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="99" height="28px">
                                                            Açıklama:
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_aciklama_alt" runat="server" Width="400" MaxLength="300" BackColor="#F2EDED">
                                                                <ValidationSettings ValidationGroup="Group_Menu_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Açıklama giriniz..."/>                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="99" height="28px">                                                            
                                                        </td>
                                                        <td align="left" width="490">  
                                                            <table>
                                                                <tr>
                                                                    <td width="160" align="left">
                                                                        <dx:ASPxButton ID="btn_kayit_alt" runat="server" Text="Kaydet / Güncelle" Width="140" ValidationGroup="Group_Menu_Alt" OnClick="btn_kayit_alt_Click">
                                                            </dx:ASPxButton>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxButton ID="btn_temizle_alt" runat="server" Text="Temizle" Width="100" OnClick="btn_temizle_alt_Click">
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
                                <asp:Panel ID="panel6" runat="server" Width="1305px" Height="308px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                <br />
                                <table>
                                                <tr>
                                                    <td width="1320px" align="center">                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>                                                                                                              
                                                    </td>
                                                </tr>
                                                <tr>                                                                                                       
                                                    <td width="1320px" align="center">
                                                        <dx:ASPxGridView ID="grid_menu_alt" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="AltMenuId" OnSelectionChanged="grid_menu_alt_SelectionChanged" Width="950px" OnPageSizeChanged="grid_menu_alt_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="MenuAd" Caption="Menü Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="273px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="AltMenuAd" Caption="Alt Menü Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="273px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="AltMenuSira" Caption="Sıra" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="AltMenuAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="284px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                           
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="170" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager PageSize="5">
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                        <td width="488px" align="left">
                                                            <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="left">
                                                                    <table>
                                                                        <tr>    
                                                                            <td width="150px" align="center" height="50px">                                                                           
                                                                                <br />
                                                                                <dx:ASPxButton ID="btn_guncelle2" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_guncelle2_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                                                                        </tr>                                                                                                                                             
                                                                        <tr>
                                                                            <td width="150px" align="center" height="50px">                                                                              
                                                                                <br />
                                                                                <dx:ASPxButton ID="btn_sil2" runat="server" Text="Sil" Width="80" Image-Url="~/Content/Images/sil.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_sil2_Click" Paddings-PaddingLeft="5px" Enabled="false">
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
                                                    <td width="1078px" align="center">
                                                        <asp:TextBox ID="txtUserName2" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
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
                <dx:TabPage Text="Alt Alt Menü (Yeni Kayıt - Ara - Güncelle - Sil)">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <asp:Panel ID="Panel7" runat="server" Width="1310" Height="535">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel8" runat="server" Width="1305px" Height="222px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                <table>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="12px">
                                                            
                                                        </td>
                                                        <td align="left" width="490">
                                                            
                                                        </td>
                                                        <td align="left" width="200">
                                                            
                                                        </td>
                                                    </tr>                                                                                                                                                                                                              
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="28px">
                                                            Menü Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxComboBox ID="cb_a_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_a_menu_SelectedIndexChanged">
                                                                                            <ValidationSettings ValidationGroup="Group_Menu_Alt_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Menü Adı seçiniz..." IsRequired="true" />                                                                                
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
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="28px">
                                                            Alt Menü Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxComboBox ID="cb_a_alt_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_Menu_Alt_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Alt Menü Adı seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                                                                                                             
                                                                                        </dx:ASPxComboBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="28px">
                                                            Alt Alt Menü Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_a_alt_alt_menuu" runat="server" Width="400" MaxLength="300">
                                                                <ValidationSettings ValidationGroup="Group_Menu_Alt_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Alt Alt Menü Adı giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>                                                   
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="28px">
                                                            Link:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_a_link" runat="server" Width="400" MaxLength="300">
                                                                <ValidationSettings ValidationGroup="Group_Menu_Alt_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Link giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="28px">
                                                            Sıra:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_a_sira" runat="server" Width="100" MaxLength="3">
                                                                <ValidationSettings ValidationGroup="Group_Menu_Alt_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Sıra giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="28px">
                                                            Açıklama:
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_a_aciklama" runat="server" Width="400" MaxLength="300" BackColor="#F2EDED">
                                                                <ValidationSettings ValidationGroup="Group_Menu_Alt_Alt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Açıklama giriniz..."/>                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>                                                                                        
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="119" height="28px">                                                            
                                                        </td>
                                                        <td align="left" width="490">  
                                                            <table>
                                                                <tr>
                                                                    <td width="160" align="left">
                                                                        <dx:ASPxButton ID="btn_a_kayit" runat="server" Text="Kaydet / Güncelle" Width="140" ValidationGroup="Group_Menu_Alt_Alt" OnClick="btn_a_kayit_Click">
                                                            </dx:ASPxButton>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxButton ID="btn_a_temizle" runat="server" Text="Temizle" Width="100" OnClick="btn_a_temizle_Click">
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
                                <asp:Panel ID="panel9" runat="server" Width="1305px" Height="298px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                <br />
                                <table>
                                                <tr>
                                                    <td width="1320px" align="center">                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>                                                                                                              
                                                    </td>
                                                </tr>
                                                <tr>                                                                                                       
                                                    <td width="1320px" align="center">
                                                        <dx:ASPxGridView ID="grid_a_menu" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="AltAltMenuId" OnSelectionChanged="grid_a_menu_SelectionChanged" Width="1150px" OnPageSizeChanged="grid_a_menu_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="MenuAd" Caption="Menü Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="AltMenuAd" Caption="Alt Menü Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="AltAltMenuAd" Caption="Alt Alt Menü Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="AltAltMenuSira" Caption="Sıra" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="65px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="AltAltMenuLink" Caption="Link" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="AltAltMenuAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="295px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                                                                                           
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="160" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager PageSize="5">
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                        <td width="488px" align="left">
                                                            <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="left">
                                                                    <table>
                                                                        <tr>    
                                                                            <td width="150px" align="center" height="50px">                                                                           
                                                                                <br />
                                                                                <dx:ASPxButton ID="btn_a_guncelle" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_a_guncelle_Click" Paddings-PaddingLeft="1px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="1px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                                                                        </tr>                                                                                                                                             
                                                                        <tr>
                                                                            <td width="150px" align="center" height="50px">                                                                              
                                                                                <br />
                                                                                <dx:ASPxButton ID="btn_a_sil" runat="server" Text="Sil" Width="80" Image-Url="~/Content/Images/sil.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_a_sil_Click" Paddings-PaddingLeft="5px" Enabled="false">
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
                                                    <td width="1078px" align="center">
                                                        <asp:TextBox ID="txtUserName3" runat="server" width="180px" Visible="false" xmlns:asp="#unknown"></asp:TextBox>
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