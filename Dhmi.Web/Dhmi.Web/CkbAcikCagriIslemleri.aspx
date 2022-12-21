<%@ Page Title="DHMİ İletişim Merkezi - Açık Çağrı İşlemleri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="CkbAcikCagriIslemleri.aspx.cs" Inherits="Dhmi.Web.CkbAcikCagriIslemleri" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">    
    <style type="text/css">
        .linkMenu 
       {
           background: none!important;
           border: 0!important; 
           color: #162436!important;
           padding: 0!important;
           text-decoration: none!important;
           font-size:12px;                                
       }
       
       .linkMenu a:hover,
       .linkMenu a:hover *
       {
           text-decoration: underline!important;
       }
       .linkMenuItem,
       .linkMenuItem > div
       {
           padding: 0!important;
           font: 11px Tahoma!important;
       }
       .linkMenuSeparator
       {
           padding: 0 14px!important;
       }
       .linkMenuSeparator > *
       {
           background: #5386CB!important;
           margin: 4px 0!important;
           height: 10px!important;
           width: 1px!important;
       }
    </style>
    <asp:ToolkitScriptManager ID="asdsadasd" runat="server" CombineScripts="true" LoadScriptsBeforeUI="false"></asp:ToolkitScriptManager>
    <div style="float: left; width: 58%; margin-right: 2%">
        <br />
        <asp:UpdatePanel ID="asascsad" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Menu1" />
            </Triggers>
            <ContentTemplate>
                <dx:ASPxMenu ID="Menu1" runat="server" RenderMode="Lightweight" Width="100%" Paddings-PaddingTop="0" OnItemClick="Menu1_MenuItemClick" CssClass="linkMenu">                                    
                                    <BorderTop BorderWidth="1px" BorderColor="Black"/>
                                    <BorderBottom BorderWidth="1px" BorderColor="Black"/>
                                    <BorderLeft BorderWidth="1px" BorderColor="Black"/>
                                    <BorderRight BorderWidth="1px" BorderColor="Black"/>
                                    <ItemStyle ForeColor="#C0262A" />
                                    <LinkStyle Color="Red"></LinkStyle>
                                    <clientsideevents ItemClick="function(s, e) {                                                            
                                                            Callback1313.PerformCallback();
	                                                        LoadingPanel1313.Show();                                                                                          
                                                               }" />
               </dx:ASPxMenu>
               <dx:ASPxCallback ID="ASPxCallback6" runat="server" ClientInstanceName="Callback1313">
                                                                                                                    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel1313.Hide(); }" />
                                                                                                                </dx:ASPxCallback>
                                                                                                                <dx:ASPxLoadingPanel ID="ASPxLoadingPanel3" runat="server" ClientInstanceName="LoadingPanel1313" Modal="True" Text="Bilgiler Alınıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                                                </dx:ASPxLoadingPanel>
               <div class="tabcontents">
                    <asp:MultiView ID="MultiView1" ActiveViewIndex="0" runat="server">
                        <asp:View ID="tab_panel_4" runat="server">
                            <br />
                            <asp:Panel ID="Panel2" runat="server" Width="1340" Height="440">
                                <table>
                                    <tr>
                                        <td width="80" align="center">
                                        </td>
                                        <td width="1200" align="center">
                                            <dx:ASPxGridView ID="grid_genel" ClientInstanceName="grid_genel" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="AcikBildirimId" Width="920px" OnPageSizeChanged="grid_genel_PageSizeChanged" OnProcessColumnAutoFilter="grid_genel_ProcessColumnAutoFilter" OnPageIndexChanged="grid_genel_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_genel_BeforeColumnSortingGrouping">
                                                <Columns>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimBirim" Caption="Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="270px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAtandiSayi" Caption="Atanan Bildirim Sayısı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimInceleniyorSayi" Caption="İncelenen Bildirim Sayısı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="200px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimInceleniyorEkSureSayi" Caption="Ek Süre İstenen Bildirim Sayısı" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="231px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
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
                                        <td width="80" align="center">
                                        </td>
                                        <td width="1200" align="center">
                                            <br />
                                            <dx:ASPxButton ID="btnPdfExport" runat="server" Text="  Rapor Al" Width="180" Font-Bold="true" Image-Url="~/Content/Images/report.png" ImagePosition="Left" UseSubmitBehavior="true" Paddings-PaddingLeft="7px" OnClick="btnPdfExport_Click" ForeColor="Maroon">
                                                                                </dx:ASPxButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="80" align="center">
                                        </td>
                                        <td width="1200" align="center">
                                            <asp:textbox id="txtUserName" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:View>
                        <asp:View ID="tab_panel_5" runat="server">
                            <br />
                            <asp:Panel ID="Panel1" runat="server" Width="1340" Height="440">
                                <table>
                                    <tr>
                                        <td width="60" align="center">
                                        </td>
                                        <td width="1200" align="center">
                                            <dx:ASPxGridView ID="grid_ayrinti" ClientInstanceName="grid_ayrinti" runat="server" AutoGenerateColumns="false" ClientIDMode="AutoID" EnableCallBacks="false" KeyFieldName="AcikBildirimAyrintiId" Width="1330px" OnPageSizeChanged="grid_ayrinti_PageSizeChanged" OnProcessColumnAutoFilter="grid_ayrinti_ProcessColumnAutoFilter" OnCustomCallback="grid_ayrinti_CustomCollback" OnPageIndexChanged="grid_ayrinti_PageIndexChanged" OnBeforeColumnSortingGrouping="grid_ayrinti_BeforeColumnSortingGrouping">
                                                <Columns>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiNo" Caption="Bildirim No" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiDurum" Caption="Durum" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiSure" Caption="Süre" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiBirim" Caption="Atanan Birim" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="130px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiIcerik" Caption="Talep/Şikayet" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="420px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
                                                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AutoFilterCondition="Contains"/>
                                                    </dx:GridViewDataMemoColumn>
                                                    <dx:GridViewDataMemoColumn FieldName="AcikBildirimAyrintiSonDurum" Caption="Açıklama" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="Maroon" Width="420px" HeaderStyle-HorizontalAlign="Center">                                                                                                                            
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
                                        <td width="80" align="center">
                                        </td>
                                        <td width="1200" align="center">
                                            <br />
                                            <dx:ASPxButton ID="btnPdfExportayr" runat="server" Text="  Rapor Al" Width="180" Font-Bold="true" Image-Url="~/Content/Images/report.png" ImagePosition="Left" UseSubmitBehavior="true" Paddings-PaddingLeft="7px" OnClick="btnPdfExportayr_Click" ForeColor="Maroon">
                                                                                </dx:ASPxButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="80" align="center">
                                        </td>
                                        <td width="1200" align="center">
                                            <asp:textbox id="txtUserNameayr" runat="server" width="180px" visible="false" xmlns:asp="#unknown"></asp:textbox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:View>
                    </asp:MultiView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>                
    </div>
</asp:Content>

