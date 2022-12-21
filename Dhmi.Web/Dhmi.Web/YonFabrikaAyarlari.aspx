<%@ Page Title="DHMİ İletişim Merkezi - Fabrika Ayarları" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YonFabrikaAyarlari.aspx.cs" Inherits="Dhmi.Web.YonFabrikaAyarlari" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Fabrika Ayarları">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td align="center" width="1320px" height="395px">
                                            <dx:ASPxButton ID="btn_fabrika_don" runat="server" Text="Fabrika Ayarlarına Dön" Width="220" Image-Url="~/Content/Images/setttte.png" ImagePosition="Top" UseSubmitBehavior="false" OnClick="btn_fabrika_don_Click" Paddings-PaddingLeft="7px" Height="150px" Font-Bold="true" ForeColor="Maroon">
                                                                                    <ClientSideEvents Click="function(s,e) { e.processOnServer = confirm('Fabrika ayarlarına dönmek istediğinizden emin misiniz?'); }" />
                                                                                    <Image Url="~/Content/Images/setttte.png"></Image>
                                                                                    <Paddings PaddingLeft="7px"></Paddings>
                                                                                </dx:ASPxButton>
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