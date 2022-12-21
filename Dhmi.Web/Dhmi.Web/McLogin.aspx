<%@ Page Title="DHMİ İletişim Merkezi - HOŞEGLDİNİZ" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="McLogin.aspx.cs" Inherits="Dhmi.Web.McLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float: left; width: 60%; margin-right: 2%">    
        <br />
        <br />
        <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1340" Height="850">
        <table>
            <tr>
                <td align="center" width="1700">
                    <dx:WebChartControl ID="chart_pasta" runat="server" Width="1315" Height="400" ClientInstanceName="chart1">
                    </dx:WebChartControl> 
                </td>                
            </tr>
            <tr>
                <td align="center" width="1700">
                    <br />
                    <br />
                    <dx:WebChartControl ID="chart_cizgi" runat="server" Width="1315" Height="400" ClientInstanceName="chart1">
                    </dx:WebChartControl> 
                </td>
            </tr>
        </table>         
        </asp:Panel>
    </div>
</asp:Content>
