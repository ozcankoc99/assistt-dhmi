<%@ Page Title="DHMİ İletişim Merkezi - Bildirim Türü Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonBildirimTuruBilgileri.aspx.cs" Inherits="Dhmi.Web.YonBildirimTuruBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />           
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>                
            <dx:TabPage Text="Bildirim Türü (Yeni Kayıt - Ara - Güncelle - Sil)">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="590">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Panel ID="panel2" runat="server" Width="1310" Height="220px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                <table>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="159" height="12px">
                                                            
                                                        </td>
                                                        <td align="left" width="290">
                                                            
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="169" height="28px">
                                                            Bildirim Türü Adı:*
                                                        </td>
                                                        <td align="left" width="290">
                                                            <dx:ASPxTextBox ID="txt_bildirim_adi" runat="server" Width="275" MaxLength="100">
                                                                <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Bildirim Türü Adı giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="169" height="28px">
                                                            Atanma Max Süre:*
                                                        </td>
                                                        <td align="left" width="290">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <dx:ASPxTextBox ID="txt_top_adet" runat="server" Width="50" MaxLength="4">
                                                                <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Atanma Max Süre giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxComboBox ID="cb_top_adet" runat="server" ValueType="System.String" Width="100" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Zaman Türü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="169" height="28px">
                                                            İnceleme Max Süre:*
                                                        </td>
                                                        <td align="left" width="290">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <dx:ASPxTextBox ID="txt_hat_adet" runat="server" Width="50" MaxLength="100">
                                                                <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="İnceleme Max Süre seçiniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxComboBox ID="cb_hat_adet" runat="server" ValueType="System.String" Width="100" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Zaman Türü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>                                                   
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="169" height="28px">
                                                            SMS Gönderilsin mi?:*
                                                        </td>
                                                        <td align="left" width="290">
                                                            <dx:ASPxComboBox ID="cb_sms" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="İçerik seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="169" height="28px">
                                                            Mail Gönderilsin mi?:*
                                                        </td>
                                                        <td align="left" width="290">
                                                            <dx:ASPxComboBox ID="cb_mail" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="İçerik seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="169" height="28px">
                                                            Durum:*
                                                        </td>
                                                        <td align="left" width="290">
                                                            <dx:ASPxComboBox ID="cb_durum" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_Bil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Durum seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                     
                                                                                        </dx:ASPxComboBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="385">
                                                        </td>
                                                        <td align="left" width="169" height="28px">                                                            
                                                        </td>
                                                        <td align="left" width="290"> 
                                                            <table>
                                                                <tr>
                                                                    <td width="190" align="left">
                                                                        <dx:ASPxButton ID="btn_kayit" runat="server" Text="Kaydet / Güncelle" Width="160" ValidationGroup="Group_Bil" OnClick="btn_kayit_Click">
                                                            </dx:ASPxButton>
                                                                    </td>
                                                                    <td>
                                                                        <dx:ASPxButton ID="btn_temizle" runat="server" Text="Temizle" Width="85" OnClick="btn_temizle_Click">
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
                                <asp:Panel ID="panel3" runat="server" Width="1310" Height="356px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">                                
                                <table>
                                                <tr>
                                                    <td width="1078px" align="center">                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <br />                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="1320px" align="center">
                                                        <dx:ASPxGridView ID="grid_bildirim" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="BildirimTuruId" OnSelectionChanged="grid_bildirim_SelectionChanged" Width="1200px" OnPageSizeChanged="grid_bildirim_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruAd" Caption="Bildirim Türü Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="304px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruIslemAlSure" Caption="Atanma Max Süre" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="193px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                             
                                                                <dx:GridViewDataTextColumn FieldName="BildirimTuruInclemeSure" Caption="İnceleme Max Süre" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="197px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                              
                                                                <dx:GridViewDataCheckColumn FieldName="BildirimTuruSms" Caption="SMS Gönderilsin mi?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="196px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Evet" DisplayTextUnchecked="Hayır">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>
                                                                <dx:GridViewDataCheckColumn FieldName="BildirimTuruMail" Caption="Mail Gönderilsin mi?" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Evet" DisplayTextUnchecked="Hayır">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>
                                                                <dx:GridViewDataCheckColumn FieldName="BildirimTuruDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="152" HorizontalScrollBarMode="Auto"/>
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
                                            <br />
                                            <table>
                                                <tr>
                                                    <td width="1320px" align="center">
                                                        <table>
                                                            <tr>                                                                
                                                                <td width="1320px" align="center">
                                                                    <table>
                                                                        <tr>          
                                                                            <td width="200px" align="center" height="50px">                                                                           
                                                                                <dx:ASPxButton ID="btn_guncelle" runat="server" Text="Güncelle" Width="80" Image-Url="~/Content/Images/guncelle.png" ImagePosition="Top" UseSubmitBehavior="true" OnClick="btn_guncelle_Click" Paddings-PaddingLeft="3px" Enabled="false">
                                                                                    <Image Url="~/Content/Images/guncelle.png"></Image>
                                                                                    <Paddings PaddingLeft="3px"></Paddings>
                                                                                </dx:ASPxButton>
                                                                            </td>                                                                                                                                             
                                                                            <td width="200px" align="center" height="50px">                                                                              
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
