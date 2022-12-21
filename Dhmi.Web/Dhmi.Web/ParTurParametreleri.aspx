<%@ Page Title="DHMİ İletişim Merkezi - Tür Parametreleri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ParTurParametreleri.aspx.cs" Inherits="Dhmi.Web.ParTurParametreleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Parametre Güncelle">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="66">
                                <table>
                                    <tr>
                                        <td width="830px" align="left">                                            
                                            <table>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>
                                                                <td>
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
                                                    <td width="1205px" align="right">
                                                        <asp:Panel ID="pnl_alt_taraf" runat="server">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <table>
                                                                <tr>
                                                                    <td width="203px" align="left" height="30px"></td>
                                                                    <td width="103px" align="left" height="30px">
                                                                    Parametre Türü:
                                                                    </td>
                                                                    <td width="270px" align="left" height="30px">
                                                                        <dx:ASPxComboBox ID="cb_parametre" runat="server" ValueType="System.String" Width="260" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_parametre_SelectedIndexChanged">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Parametre Türü seçiniz..." IsRequired="true" />                                                                                
                                                                            </ValidationSettings>
                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                            Callback.PerformCallback();
                                                                            LoadingPanel.Show();
                                                                            }" />
                                                                        </dx:ASPxComboBox>
                                                                        <dx:ASPxCallback ID="ASPxCallback3" runat="server" ClientInstanceName="Callback">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel>
                                                                    </td>
                                                                </tr>                                                               
                                                                </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>                                                                                                                                      
                                                                    </td>
                                                                </tr>
                                                            </table>                                                                                                                                                                                                                                                            
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
                            <asp:Panel ID="pnl_alttaki" runat="server" Width="1323px" Height="370px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted" Enabled="true">
                                <table>
                                    <tr>
                                        <td align="left" width="850">
                                            <br /><br /><br />
                                            <table>
                                                <tr>
                                                    <td width="65">
                                                        
                                                    </td>
                                                    <td width="50">
                                                        Değer:
                                                    </td>
                                                    <td width="420">
                                                        <dx:ASPxTextBox ID="txt_deger" runat="server" MaxLength="99" Width="400">
                                                                            <ValidationSettings ValidationGroup="Group_Egt" ErrorDisplayMode="ImageWithTooltip">
	                                                                            <RequiredField ErrorText="Parametre Değeri giriniz..." IsRequired="true"/>                                                                                
	                                                                        </ValidationSettings>                                                                            
                                                                        </dx:ASPxTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table>
                                                <tr>
                                                    <td height="52" width="65">
                                                        
                                                    </td>
                                                    <td width="50">
                                                        
                                                    </td>
                                                    <td width="156" align="left">
                                                    <dx:ASPxButton ID="btn_deger_ekle" runat="server" Text="Değer Ekle/Güncelle" ValidationGroup="Group_Egt" Width="156" UseSubmitBehavior="true" OnClick="btn_deger_ekle_Click"></dx:ASPxButton>                                                                                                      
                                                    </td>
                                                    <td width="122" align="right">
                                                    <dx:ASPxButton ID="btn_deger_sil" runat="server" Text="Değer Sil" Width="100" UseSubmitBehavior="true" OnClick="btn_deger_sil_Click" Enabled="false"></dx:ASPxButton>                                                                                                      
                                                    </td>                                                    
                                                    <td width="122" align="right">
                                                    <dx:ASPxButton ID="btn_iptal_et" runat="server" Text="İptal Et" Width="100" UseSubmitBehavior="true" OnClick="btn_iptal_et_Click"></dx:ASPxButton>                                                                                                      
                                                    </td>  
                                                </tr>
                                                <tr>
                                                    <td height="40" width="15">
                                                        
                                                    </td>
                                                    <td width="50">
                                                        
                                                    </td>
                                                    <td width="156" align="left">
                                                        
                                                    </td>
                                                    <td width="122" align="right">
                                                    
                                                    </td>                                                    
                                                    <td width="122" align="right">
                                                    
                                                    </td>  
                                                </tr>
                                            </table>                                            
                                        </td>
                                        <td align="left" width="850">
                                            <br />
                                            <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxListBox ID="lb_benden" runat="server" Width="585" Height="344" AutoPostBack="true" OnSelectedIndexChanged="lb_benden_SelectedIndexChanged"></dx:ASPxListBox>
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