<%@ Page Title="DHMİ İletişim Merkezi - Konu Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonKonuBilgileri.aspx.cs" Inherits="Dhmi.Web.YonKonuBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />           
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>                
            <dx:TabPage Text="Konu (Yeni Kayıt - Ara - Güncelle - Sil)">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="585">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel2" runat="server" Width="1305px" Height="108px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
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
                                                            Konu Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_konu" runat="server" Width="400" MaxLength="300">
                                                                <ValidationSettings ValidationGroup="Group_Konu" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Konu Adı giriniz..." IsRequired="true" />                                                                                
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
                                                            Durum:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxComboBox ID="cb_durum" runat="server" ValueType="System.String" Width="100" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Konu" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Durum seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                                                                                                                
                                                                                        </dx:ASPxComboBox>                                                                                        
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
                                                                    <td width="110" align="left">
                                                                        <dx:ASPxButton ID="btn_kayit" runat="server" Text="Kaydet" Width="100" ValidationGroup="Group_Konu" OnClick="btn_kayit_Click">
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
                                <asp:Panel ID="panel3" runat="server" Width="1305px" Height="461px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
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
                                                        <dx:ASPxGridView ID="grid_konu" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="KonuId" OnSelectionChanged="grid_konu_SelectionChanged" Width="900px" OnPageSizeChanged="grid_konu_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="KonuAd" Caption="Konu Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="459px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="KonuTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="250px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataCheckColumn FieldName="KonuDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="170px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>                                                                                                                                 
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="313" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager PageSize="5">
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                        <td width="488px" align="left">
                                                            <table>
                                                            <tr>                                                                
                                                                <td width="1000px" align="left">
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
                <dx:TabPage Text="Alt Konu (Yeni Kayıt - Ara - Güncelle - Sil)">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="Panel4" runat="server" Width="1310" Height="651">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel5" runat="server" Width="1305px" Height="134px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
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
                                                            Konu Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxComboBox ID="cb_menu" runat="server" ValueType="System.String" Width="400" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Alt_Konu" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Konu Adı seçiniz..." IsRequired="true" />                                                                                
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
                                                            Alt Konu Adı:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxTextBox ID="txt_alt_konu" runat="server" Width="400" MaxLength="300">
                                                                <ValidationSettings ValidationGroup="Group_Alt_Konu" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Alt Konu Adı giriniz..." IsRequired="true" />                                                                                
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
                                                            Durum:*
                                                        </td>
                                                        <td align="left" width="490">
                                                            <dx:ASPxComboBox ID="cb_durum2" runat="server" ValueType="System.String" Width="100" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Alt_Konu" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Durum seçiniz..." IsRequired="true" />                                                                                
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
                                                        </td>
                                                        <td align="left" width="490">  
                                                            <table>
                                                                <tr>
                                                                    <td width="110" align="left">
                                                                        <dx:ASPxButton ID="btn_kayit2" runat="server" Text="Kaydet" Width="100" ValidationGroup="Group_Alt_Konu" OnClick="btn_kayit2_Click">
                                                                        </dx:ASPxButton>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxButton ID="btn_temizle2" runat="server" Text="Temizle" Width="100" OnClick="btn_temizle2_Click">
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
                                <asp:Panel ID="panel6" runat="server" Width="1305px" Height="507px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
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
                                                        <dx:ASPxGridView ID="grid_alt_konu" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="AltKonuId" OnSelectionChanged="grid_alt_konu_SelectionChanged" Width="1150px" OnPageSizeChanged="grid_alt_konu_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="KonuAd" Caption="Konu Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="280px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="AltKonuAd" Caption="Alt Konu Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="579px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>  
                                                                <dx:GridViewDataTextColumn FieldName="AltKonuTarih" Caption="İşlem Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="180px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataCheckColumn FieldName="AltKonuDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="90px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>                                                                                                                                 
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="365" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager PageSize="5">
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>
                                                        </dx:ASPxGridView>                                                                                                                 
                                                    </td>
                                                        <td width="488px" align="left">
                                                            <table>
                                                            <tr>                                                                
                                                                <td width="1000px" align="left">
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
            </TabPages>      
        </dx:ASPxPageControl>
    </div>
</asp:Content>
