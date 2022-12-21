<%@ Page Title="DHMİ İletişim Merkezi - Kullanıcı Bilgisi Güncelle" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="KulKullaniciBilgisiGuncelle.aspx.cs" Inherits="Dhmi.Web.KulKullaniciBilgisiGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />           
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Kullanıcı Bilgisi Güncelle">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td width="970px" align="left">                                            
                                            <table>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>
                                                                <td>
                                                                    <br />                                                                    
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
                                                        </td>
                                                       </tr>
                                                        <tr>
                                                    <td width="930px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                         <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                <Items>       
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                 
                                                    <dx:LayoutGroup Caption="Kullanıcı Bilgisi Güncelle" Width="430">
                                                        <Items>   
                                                            <dx:LayoutItem Caption="Birim:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_birim" runat="server" MaxLength="50" Width="273" Enabled="false">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Birim giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                                   
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Görev:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_gorev" runat="server" MaxLength="50" Width="273" Enabled="false">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Görev giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                                   
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Ad:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_ad" runat="server" MaxLength="50" Width="273" Enabled="false">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Ad giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                                   
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Soyad:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_soyad" runat="server" MaxLength="50" Width="273" Enabled="false">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Soyad giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                                                                                                        
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Kullanıcı Adı:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_kullaniciadi" runat="server" MaxLength="11" Width="273" Enabled="false">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Kullanıcı Adı giriniz..." IsRequired="true"/>                                                                                                                                                                                                                                               
	                                                                        </ValidationSettings>                                                                                
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                                                            <dx:LayoutItem Caption="Şifre:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_sifre" Password="true" runat="server" MaxLength="11" Width="273" Enabled="true">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Şifre giriniz..." IsRequired="true"/>                                                                                                                                                                                                                                               
	                                                                        </ValidationSettings>                                                                                
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem> 
                                                            <dx:LayoutItem Caption=" Yeni Şifre:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_sifre2" runat="server" MaxLength="30" Width="273" Password="true">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Yeni Şifre giriniz..."/>                                                                                                                                                                                                                                               
	                                                                        </ValidationSettings>                                                                               
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem> 
                                                            <dx:LayoutItem Caption=" Yeni Şifre(Tekrar):" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_sifre3" runat="server" MaxLength="30" Width="273" Password="true">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Yeni Şifre(Tekrar) giriniz..."/>                                                                                                                                                                                                                                               
	                                                                        </ValidationSettings>                                                                               
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                                                            <dx:LayoutItem Caption="Mail Adresi:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxTextBox ID="txt_mail" runat="server" Width="273" Native="false" EnableDefaultAppearance="false" MaxLength="70">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">	            
                                                                                <RequiredField ErrorText="Mail Adresi giriniz..." IsRequired="true"/> 	                                                                            
	                                                                        </ValidationSettings>
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Gizli Soru:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxComboBox ID="cb_soru" runat="server" ValueType="System.String" Width="273" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Gizli Soru seçiniz..." />
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>                                                                       
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Gizli Soru Cevabı:" Width="430px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxTextBox ID="txt_soru_cevap" runat="server" Width="273" Native="false" EnableDefaultAppearance="false" MaxLength="150" BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">	            
                                                                                <RequiredField ErrorText="Gizli Soru Cevabı giriniz..."/> 	                                                                            
	                                                                        </ValidationSettings>
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption=" " Width="430">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>   
                                                                        <table>
                                                                            <tr>                                                                                
                                                                                <td width="110" align="center">
                                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" Width="273" ValidationGroup="Group_Egt" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">                                                                       
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
            </TabPages>      
        </dx:ASPxPageControl>
    </div>
</asp:Content>
