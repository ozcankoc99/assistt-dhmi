<%@ Page Title="DHMİ İletişim Merkezi - Canlı (Başkanlık-Ayrıntı)" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="IstCanliBirimAyrintili.aspx.cs" Inherits="Dhmi.Web.IstCanliBirimAyrintili" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">        
        <div style="float: left; width: 60%; margin-right: 2%">
        <br />
            <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="-">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1340" Height="440">
                                <table>
                                    <tr>
                                        <td width="1600" align="center" height="440px">
                                            <dx:WebChartControl ID="WebChartControl1" runat="server" Width="1280" Height="420" ClientInstanceName="chart1">
                                            </dx:WebChartControl> 
                                        </td>
                                    </tr>                                   
                                </table>                                                             
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="-">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1340" Height="440">
                                <table>
                                    <tr>
                                        <td width="1300" align="center" height="440px">                                             
                                            <dx:ASPxGridView ID="grid_diger" ClientInstanceName="grid_diger" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="DigerBirimlerId" Width="1120px" OnPageSizeChanged="grid_diger_PageSizeChanged" OnProcessColumnAutoFilter="grid_diger_ProcessColumnAutoFilter" OnPageIndexChanged="grid_diger_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_diger_BeforeColumnSortingGrouping">
                                                <Columns>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerBirim" Caption="Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="320px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>                                                    
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerAtandiSayi" Caption="Atandı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerInceleniyorSayi" Caption="İnceleniyor" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="150px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerInceleniyorEkSureSayi" Caption="İnceleniyor-Ek Süre" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="190px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerSonuclandiSayi" Caption="Sonuçlandı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="155px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerReddedildiSayi" Caption="Reddedildi" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="155px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                </Columns>
                                                <Styles>
                                                                <AlternatingRow Enabled="True"></AlternatingRow>
                                                            </Styles>
                                                            <SettingsBehavior AllowSelectByRowClick="True"/>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="286" HorizontalScrollBarMode="Auto" />                                                                                                                       
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>                                                            
                                            </dx:ASPxGridView>
                                        </td>
                                    </tr>                                   
                                </table>                                                             
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="-">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <asp:Panel ID="Panel2" runat="server" Width="1340" Height="440">
                                <table>
                                    <tr>
                                        <td width="1300" align="center" height="440px">                                            
                                            <dx:ASPxGridView ID="grid_ayrinti" ClientInstanceName="grid_ayrinti" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="AcikBildirimAyrintiId" Width="1330px" OnPageSizeChanged="grid_ayrinti_PageSizeChanged" OnProcessColumnAutoFilter="grid_ayrinti_ProcessColumnAutoFilter" OnPageIndexChanged="grid_ayrinti_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_ayrinti_BeforeColumnSortingGrouping">
                                                <Columns>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerAyrintiNo" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerAyrintiDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerAyrintiSure" Caption="Süre" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>                                                    
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerAyrintiIcerik" Caption="Talep/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="440px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="DigerBirimlerAyrintiSonDurum" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="517px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                </Columns>
                                                <Styles>
                                                                <AlternatingRow Enabled="True"></AlternatingRow>
                                                            </Styles>
                                                            <SettingsBehavior AllowSelectByRowClick="True"/>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="286" HorizontalScrollBarMode="Auto" />                                                                                                                       
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>                                                           
                                            </dx:ASPxGridView>
                                        </td>
                                    </tr>   
                                    <tr>
                                        <td>
                                            <asp:textbox id="txtUserNameayr" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
                                        </td>
                                    </tr>                                
                                </table>                                                             
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="-">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl4" runat="server">
                            <asp:Panel ID="Panel3" runat="server" Width="1340" Height="440">
                                <table>
                                    <tr>
                                        <td width="1300" align="center" height="440px">
                                            <dx:ASPxGridView ID="grid_konu" ClientInstanceName="grid_konu" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="KonusalDagilimId" Width="1330px" OnPageSizeChanged="grid_konu_PageSizeChanged" OnProcessColumnAutoFilter="grid_konu_ProcessColumnAutoFilter" OnPageIndexChanged="grid_konu_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_konu_BeforeColumnSortingGrouping">
                                                <Columns>
                                                    <dx:GridViewDataMemoColumn FieldName="KonusalDagilimNo" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="KonusalDagilimDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="KonusalDagilimSure" Caption="Süre" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>                                                    
                                                    <dx:GridViewDataMemoColumn FieldName="KonusalDagilimKonu" Caption="Konu" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="KonusalDagilimIcerik" Caption="Talep/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="340px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="KonusalDagilimSonDurum" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="417px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                </Columns>
                                                <Styles>
                                                                <AlternatingRow Enabled="True"></AlternatingRow>
                                                            </Styles>
                                                            <SettingsBehavior AllowSelectByRowClick="True"/>
                                                            <Settings ShowFooter="True" ShowFilterRow="True" ShowGroupFooter="VisibleIfExpanded" VerticalScrollBarMode="Auto" VerticalScrollableHeight="0" />
                                                            <Settings VerticalScrollableHeight="286" HorizontalScrollBarMode="Auto" />                                                                                                                       
                                                            <SettingsPager>
                                                                <PageSizeItemSettings Visible="true" ShowAllItem="true"/>
                                                            </SettingsPager>                                                           
                                            </dx:ASPxGridView>
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
