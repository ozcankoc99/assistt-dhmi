<%@ Page Title="DHMİ İletişim Merkezi - Şifre Algoritması" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="KulEkstraBilgi.aspx.cs" Inherits="Dhmi.Web.KulEkstraBilgi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Şifre Algoritması">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />                                
                                <table>
                                    <tr>
                                        <td align="left" width="393px" height="30px">
                                        </td>
                                        <td align="left" width="83px" height="30px">
                                            Hash Şifre:
                                        </td>
                                        <td align="left" width="310px">
                                            <dx:ASPxTextBox ID="txt_sifre" runat="server" Width="300"></dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxButton ID="btn_coz" runat="server" Text="Çöz" ValidationGroup="Gro" Width="80" UseSubmitBehavior="true" OnClick="btn_coz_Click">
                                            <ClientSideEvents Click="function(s, e) {
                                                                                        Callback33.PerformCallback();
                                                                                        LoadingPanel33.Show();
                                                                                        }" />
                                            </dx:ASPxButton>
                                            <dx:ASPxCallback ID="ASPxCallback5" runat="server" ClientInstanceName="Callback33">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel33.Hide(); }" />
                                                                                    </dx:ASPxCallback>
                                                                                    <dx:ASPxLoadingPanel ID="ASPxLoadingPanel4" runat="server" ClientInstanceName="LoadingPanel33" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                    </dx:ASPxLoadingPanel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" width="393px" height="30px">
                                        </td>
                                        <td align="left" width="83px" height="30px">
                                            Ham Şifre:
                                        </td>
                                        <td align="left" width="310px">
                                            <dx:ASPxTextBox ID="txt_cozulmus_hali" runat="server" Width="300" Enabled="false"></dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            
                                        </td>
                                    </tr>
                                </table>
                                <br /><br /><br /><br />
                                <table>
                                    <tr>
                                        <td align="left" width="393px" height="30px">
                                        </td>
                                        <td align="left" width="83px" height="30px">
                                            Ham Şifre:
                                        </td>
                                        <td align="left" width="310px">
                                            <dx:ASPxTextBox ID="txt_ham" runat="server" Width="300" MaxLength="10"></dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxButton ID="btn_sifrele" runat="server" Text="Şifrele" ValidationGroup="Gro" Width="80" UseSubmitBehavior="true" OnClick="btn_sifrele_Click">
                                            <ClientSideEvents Click="function(s, e) {
                                                                                        Callback3.PerformCallback();
                                                                                        LoadingPanel3.Show();
                                                                                        }" />
                                            </dx:ASPxButton>
                                            <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback3">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel3.Hide(); }" />
                                                                                    </dx:ASPxCallback>
                                                                                    <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel3" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                    </dx:ASPxLoadingPanel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" width="393px" height="30px">
                                        </td>
                                        <td align="left" width="83px" height="30px">
                                            Hash Şifre:
                                        </td>
                                        <td align="left" width="310px">
                                            <dx:ASPxTextBox ID="txt_hash" runat="server" Width="300" Enabled="false"></dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            
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