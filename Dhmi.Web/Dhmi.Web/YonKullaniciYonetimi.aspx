<%@ Page Title="DHMİ İletişim Merkezi - Kullanıcı Yönetimi" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonKullaniciYonetimi.aspx.cs" Inherits="Dhmi.Web.YonKullaniciYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />           
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Yeni Kayıt">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1310" Height="480">
                                <table>
                                    <tr>
                                        <td width="955px" align="left">                                            
                                            <table>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>
                                                                <td>                                                                    
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
                                                    <td width="910px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server"><br />
                                                         <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                                <Items>       
                                                                                
                                                    <dx:LayoutGroup Caption="Kullanıcı Bilgileri" Width="340px">
                                                        <Items>                                                              
                                                            <dx:LayoutItem Caption="Birim:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxComboBox ID="cb_birim" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Birim seçiniz..."/>                                                                                
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Görev:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxComboBox ID="cb_gorev" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Görev seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                            
                                                            <dx:LayoutItem Caption="Yetki Türü:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxComboBox ID="cb_yetki" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Yetki Türü seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>  
                                                            <dx:LayoutItem Caption="Hiyerarşi Tür:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxComboBox ID="cb_hiyerarsi" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Hiyerarşi Tür seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                          
                                                            <dx:LayoutItem Caption="Ad:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_ad" runat="server" MaxLength="30" Width="275">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Ad giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                                   
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Soyad:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_soyad" runat="server" MaxLength="30" Width="275">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Soyad giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                                                                                                        
                                                                        </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Kullanıcı Adı:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_kullaniciadi" runat="server" MaxLength="11" Width="275">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Kullanıcı Adı giriniz..." IsRequired="true"/>                                                                                                                                                                                                                                               
	                                                                        </ValidationSettings>                                                                                                                                                 
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                                                            <dx:LayoutItem Caption="Şifre:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_sifre" runat="server" MaxLength="11" Width="275" Password="true">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Şifre giriniz..." IsRequired="true"/>
	                                                                        </ValidationSettings>                                                                                
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem> 
                                                            <dx:LayoutItem Caption="Şifre(Tekrar):" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>
                                                                        <dx:ASPxTextBox ID="txt_sifre2" runat="server" MaxLength="11" Width="275" Password="true">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Şifre(Tekrar) giriniz..." IsRequired="true"/>
	                                                                        </ValidationSettings>                                                                                
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                                                            <dx:LayoutItem Caption="Mail Adresi:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxTextBox ID="txt_mail" runat="server" Width="275" Native="false" EnableDefaultAppearance="false" MaxLength="80" BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">	            
                                                                                <RequiredField ErrorText="Mail Adresi giriniz..."/> 	                                                                            
	                                                                        </ValidationSettings>
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                            
                                                            <dx:LayoutItem Caption="TC Kimlik No:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxTextBox ID="txt_tc_no" runat="server" Width="275" Native="false" EnableDefaultAppearance="false" MaxLength="11" BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">	            
                                                                                <RequiredField ErrorText="TC Kimlik No giriniz..."/> 	                                                                            
	                                                                        </ValidationSettings>
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Avaya Login ID:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxTextBox ID="txt_avaya" runat="server" Width="275" Native="false" EnableDefaultAppearance="false" MaxLength="6" BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">	            
                                                                                <RequiredField ErrorText="Avaya Login ID giriniz..."/> 	                                                                            
	                                                                        </ValidationSettings>
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Extension:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxTextBox ID="txt_exs" runat="server" Width="275" Native="false" EnableDefaultAppearance="false" MaxLength="5" BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">	            
                                                                                <RequiredField ErrorText="Extension giriniz..."/> 	                                                                            
	                                                                        </ValidationSettings>
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Açıklama:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                            
                                                                        <dx:ASPxTextBox ID="txt_aciklama" runat="server" Width="275" Native="false" EnableDefaultAppearance="false" MaxLength="150" BackColor="#F2EDED">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">	            
                                                                                <RequiredField ErrorText="Açıklama giriniz..."/> 	                                                                            
	                                                                        </ValidationSettings>
                                                                        </dx:ASPxTextBox>                                                                        
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Durum:" Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxComboBox ID="cb_durum" runat="server" ValueType="System.String" Width="275" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Durum seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption=" " Width="400px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>   
                                                                        <table>
                                                                            <tr>
                                                                                <td width="138" align="left">
                                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Kaydet" Width="127" UseSubmitBehavior="true" ValidationGroup="Group_Egt" OnClick="btn_kaydet_Click">                                                                       
                                                                                    </dx:ASPxButton>
                                                                                </td>
                                                                                <td width="138" align="right">
                                                                                    <dx:ASPxButton ID="btn_temizle" runat="server" Text="Temizle" Width="127"  UseSubmitBehavior="true" OnClick="btn_temizle_Click">                                                                       
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
                            <asp:Panel ID="pnl_kayit_listele_raporla" runat="server" Width="1310" Height="622">
                                <table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td>                                                                                                           
                                                        <table border="2px" bordercolor="blue">                                                                                                                                                                                                                                                                                                           
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_ad" runat="server" Text="Ad"  OnCheckedChanged="k_ad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td> 
                                                                <td width="260px" align="left">                                                                    
                                                                    <dx:ASPxCheckBox ID="k_soyad" runat="server" Text="Soyad"  OnCheckedChanged="k_soyad_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_birt" runat="server" Text="Birim"  OnCheckedChanged="k_birt_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>    
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_gorev" runat="server" Text="Görev"  OnCheckedChanged="k_gorev_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>         
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_yetki" runat="server" Text="Yetki"  OnCheckedChanged="k_yetki_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                                                                 
                                                            </tr>                                                            
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_hiyerarsi" runat="server" Text="Hiyerarşi Tür"  OnCheckedChanged="k_hiyerarsi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_kadi" runat="server" Text="Kullanıcı Adı"  OnCheckedChanged="k_kadi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_mail" runat="server" Text="Mail Adresi"  OnCheckedChanged="k_mail_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tcsino" runat="server" Text="TC Kimlik No"  OnCheckedChanged="k_tcsino_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_avayasi" runat="server" Text="Avaya Login ID"  OnCheckedChanged="k_avayasi_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                            </tr>                                                                                                                                                                                                                                                                                                        
                                                            <tr>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_exs" runat="server" Text="Extension"  OnCheckedChanged="k_exs_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>                                                               
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_aciklama" runat="server" Text="Açıklama"  OnCheckedChanged="k_aciklama_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
                                                                </td>
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_tar" runat="server" Text="Kayıt Tarihi"  OnCheckedChanged="k_tar_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>                                                                    
                                                                </td>                                                                 
                                                                <td width="260px" align="left">
                                                                    <dx:ASPxCheckBox ID="k_durum" runat="server" Text="Durum"  OnCheckedChanged="k_durum_CheckedChanged" AutoPostBack="true" Checked="true"></dx:ASPxCheckBox>
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
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.SelectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAll" runat="server" Text="Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.UnselectRows(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnSelectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Seç" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.SelectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td style="padding-right: 4px">
                                                        <dx:ASPxButton ID="btnUnselectAllOnPage" runat="server" Text="Bu Sayfada Hepsini Bırak" UseSubmitBehavior="False" AutoPostBack="false">
                                                            <ClientSideEvents Click="function(s, e) { grid_kul.UnselectAllRowsOnPage(); }" />
                                                        </dx:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxGridView ID="grid_kul" runat="server" ClientInstanceName="grid_kul" Width="1305px" AutoGenerateColumns="false" KeyFieldName="KullaniciId" OnPageSizeChanged="grid_kul_PageSizeChanged">
                                                            <Columns>
                                                                <dx:GridViewCommandColumn EditButton-Text="İncele" EditButton-Visible="true" VisibleIndex="0" EditButton-Image-Url="Content/Images/incele.png" ButtonType="Image" EditButton-Image-Height="20" EditButton-Image-Width="20" Caption="İNCELE" Width="55">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption="SEÇ" Width="40px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewCommandColumn>                                                                                                                                 
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAd" Caption="Ad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciSoyad" Caption="Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciBirim" Caption="Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="GorevAd" Caption="Görev" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="YetkiAd" Caption="Yetki" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="HiyerarsiTurAd" Caption="Hiyerarşi Tür" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciUsername" Caption="Kullanıcı Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="220px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="TcKimlikNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="AvayaLoginId" Caption="Avaya Login ID" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="Extension" Caption="Extension" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                        
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="210px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciTarih" Caption="Kayıt Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataCheckColumn FieldName="KullaniciDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="90px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <SettingsEditing EditFormColumnCount="2" Mode="PopupEditForm"/>
                                                            <SettingsPopup>
                                                                <EditForm Width="1000px" Height="225px" Modal="true" VerticalAlign="WindowCenter"/>
                                                            </SettingsPopup>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="355" HorizontalScrollBarMode="Auto"/>
                                                            <SettingsPager Mode="EndlessPaging" PageSize="20" />
                                                        </dx:ASPxGridView>
                                                        <dx:ASPxGridViewExporter ID="gr_kul_export" runat="server" GridViewID="grid_kul" ExportedRowType="Selected" PageFooter-Font-Size="12" PageFooter-Font-Bold="true" PageHeader-Font-Size="13" PageHeader-Font-Bold="true" PaperKind="A4Rotated" LeftMargin="100" RightMargin="100" MaxColumnWidth="250">
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
                <dx:TabPage Text="Kayıt Ara - Güncelle - Sil">
                <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1310" Height="490">
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
                                                        <dx:ASPxGridView ID="grid_kul_sil" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="KullaniciId" OnSelectionChanged="grid_kul_sil_SelectionChanged" Width="1305px" OnPageSizeChanged="grid_kul_sil_PageSizeChanged">
                                                            <Columns>        
                                                                <dx:GridViewCommandColumn ShowInCustomizationForm="true" VisibleIndex="0" Width="0px">
                                                                </dx:GridViewCommandColumn>                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAd" Caption="Ad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="125px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciSoyad" Caption="Soyad" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciBirim" Caption="Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="300px" HeaderStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                          
                                                                <dx:GridViewDataTextColumn FieldName="GorevAd" Caption="Görev" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="YetkiAd" Caption="Yetki" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                                
                                                                <dx:GridViewDataTextColumn FieldName="HiyerarsiTurAd" Caption="Hiyerarşi Tür" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciUsername" Caption="Kullanıcı Adı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                               
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciMail" Caption="Mail Adresi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="220px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="TcKimlikNo" Caption="TC Kimlik No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="AvayaLoginId" Caption="Avaya Login ID" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="140px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn> 
                                                                <dx:GridViewDataTextColumn FieldName="Extension" Caption="Extension" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                                </dx:GridViewDataTextColumn>                                                                                                                                                                                                                                                                                                                    
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciAciklama" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="210px" HeaderStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>     
                                                                <dx:GridViewDataTextColumn FieldName="KullaniciTarih" Caption="Kayıt Tarihi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                </dx:GridViewDataTextColumn>                                                           
                                                                <dx:GridViewDataCheckColumn FieldName="KullaniciDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="90px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" ShowInCustomizationForm="true">
                                                                    <PropertiesCheckEdit DisplayTextChecked="Aktif" DisplayTextUnchecked="Pasif">
                                                                    </PropertiesCheckEdit>
                                                                </dx:GridViewDataCheckColumn>
                                                            </Columns>
                                                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True"
                                                            AllowSelectSingleRowOnly="True" ProcessSelectionChangedOnServer="True" />
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0"/>
                                                            <Settings VerticalScrollableHeight="308" HorizontalScrollBarMode="Auto"/>
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
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Şifre(Parola) Sıfırlama">
                <ContentCollection>
                        <dx:ContentControl ID="ContentControl4" runat="server">
                            <asp:Panel ID="Panel2" runat="server" Width="1323" Height="440">
                                <table>
                                    <tr>
                                        <td>
                                            <br />                                            
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="panel3" runat="server" Width="1320px" Height="50px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                <table>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="165">
                                                            <br />
                                                        </td>
                                                        <td align="left" width="100">
                                                           
                                                        </td>
                                                        <td align="left" width="100">
                                                            
                                                        </td>
                                                        <td align="left" width="405">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left" width="365">
                                                        </td>
                                                        <td align="left" width="165">
                                                            Personel Kullanıcı Adı:
                                                        </td>
                                                        <td align="left" width="100">
                                                            <dx:ASPxComboBox ID="cb_per_bul" runat="server" ValueType="System.String" Width="220" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                            <ValidationSettings ValidationGroup="Group_Per" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Personel Kullanıcı Adı seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                        </dx:ASPxComboBox>
                                                        </td>
                                                        <td align="left" width="100">
                                                            <dx:ASPxButton ID="btn_per_bul" runat="server" Text="Kayıt Bul" Width="100" ValidationGroup="Group_Per" OnClick="btn_per_bul_Click">
                                                            </dx:ASPxButton>
                                                        </td>
                                                        <td align="left" width="405">
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />                                            
                                            <br />  
                                            <br />  
                                            <br />  
                                            <table>
                                                <tr>
                                                    <td align="right" width="820px">
                                                        <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                                                <Items>
                                                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>                                 
                                                    <dx:LayoutGroup Caption="Kullanıcı Bilgileri" Width="300px">
                                                        <Items>
                                                            <dx:LayoutItem Caption="Ad:" Width="300px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxTextBox ID="txt_yetki_ad" runat="server" Width="130" MaxLength="50" Enabled="false">
                                                                <ValidationSettings ValidationGroup="Group_Palt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Ad giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Soyad:" Width="300px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxTextBox ID="txt_yetki_soyad" runat="server" Width="130" MaxLength="50" Enabled="false">
                                                                <ValidationSettings ValidationGroup="Group_Palt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Soyad giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>
                                                            <dx:LayoutItem Caption="Yeni Şifre(Parola):" Width="300px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>                                                                                                                                  
                                                                        <dx:ASPxTextBox ID="txt_yet_sifre" runat="server" Width="130" MaxLength="10">
                                                                <ValidationSettings ValidationGroup="Group_Palt" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Şifre giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox>
                                                                    </dx:LayoutItemNestedControlContainer>
                                                                </LayoutItemNestedControlCollection>
                                                            </dx:LayoutItem>                                                            
                                                            <dx:LayoutItem Caption=" " Width="300px">
                                                                <LayoutItemNestedControlCollection >
                                                                    <dx:LayoutItemNestedControlContainer>   
                                                                        <table>
                                                                            <tr>
                                                                                <td>
                                                                                    <dx:ASPxButton ID="btn_son_kay" runat="server" Text="Kaydet" Width="130" UseSubmitBehavior="true" ValidationGroup="Group_Palt" OnClick="btn_son_kay_Click" Enabled="false">
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