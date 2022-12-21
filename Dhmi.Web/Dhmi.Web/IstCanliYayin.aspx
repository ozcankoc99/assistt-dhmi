<%@ Page Title="DHMİ İletişim Merkezi - Canlı (Live)" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="IstCanliYayin.aspx.cs" Inherits="Dhmi.Web.IstCanliYayin" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ToolkitScriptManager ID="asdsadasd" runat="server"></asp:ToolkitScriptManager>    
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Belge Oluşturma">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1310" Height="2620">
                                <table>
                                    <tr>
                                        <td width="1600" align="center" height="440px">
                                            <dx:WebChartControl ID="WebChartControl1" runat="server" Width="1280" Height="420" ClientInstanceName="chart1">
                                            </dx:WebChartControl> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1600" align="center" height="440px">
                                            <dx:WebChartControl ID="WebChartControl6" runat="server" Width="1280" Height="420" ClientInstanceName="chart6">
                                            </dx:WebChartControl> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1600" align="center" height="440px">
                                            <dx:WebChartControl ID="WebChartControl2" runat="server" Width="1280" Height="420" ClientInstanceName="chart2">
                                            </dx:WebChartControl> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1600" align="center" height="440px">
                                            <dx:WebChartControl ID="WebChartControl3" runat="server" Width="1280" Height="420" ClientInstanceName="chart3">
                                            </dx:WebChartControl> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1600" align="center" height="440px">
                                            <dx:WebChartControl ID="WebChartControl4" runat="server" Width="1280" Height="420" ClientInstanceName="chart4">
                                            </dx:WebChartControl> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1600" align="center" height="440px">
                                            <dx:WebChartControl ID="WebChartControl5" runat="server" Width="1280" Height="420" ClientInstanceName="chart5">
                                            </dx:WebChartControl> 
                                        </td>
                                    </tr>
                                </table>                              
                                <asp:Timer ID="Timer1" OnTick="Timer1_Tick" runat="server" Interval="60000">
                                </asp:Timer>
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
    </div>
</asp:Content>
