<%@ Page Title="DHMİ İletişim Merkezi - Matbuu Raporlar" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="RapMatbuuRaporlar.aspx.cs" Inherits="Dhmi.Web.RapMatbuuRaporlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Belge Oluşturma">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1082" Height="426">
                                <table>
                                    <tr>
                                        <td width="1200" align="center" height="400px">
                                            <dx:ASPxLabel ID="asdasdas" runat="server" Font-Size="14" ForeColor="Maroon" Text="Sistem Yöneticisi tarafından tanımlanan yetki dahilinde MATBUU RAPORLARI alabilirsiniz... "></dx:ASPxLabel>
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