<%@ Page Title="DHMİ İletişim Merkezi - Tüm Duyurular" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="McTumDuyurular.aspx.cs" Inherits="Dhmi.Web.McTumDuyurular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">    
        <br />
        <table>
            <tr>
                <td align="center" width="1px">
                    
                </td>
                <td align="center" width="120px">
                    <asp:Label ID="lbl_kelime" runat="server" Font-Bold="true" Font-Names="Calibri" ForeColor="Maroon" Font-Size="10" Text="Anahtar Kelime:*"></asp:Label>
                </td>
                <td align="center" width="10px">
                    <dx:ASPxTextBox ID="txt_anahtar_kelime" runat="server" Width="150" MaxLength="30">
                                                                <ValidationSettings ValidationGroup="Group_Filtrele" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Anahtar Kelime giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox> 
                </td>
                <td align="center" width="130px">
                    <dx:ASPxButton ID="btn_sorgula" runat="server" Text="İçerik Ara" Width="120" ValidationGroup="Group_Filtrele" OnClick="btn_sorgula_Click">
                    </dx:ASPxButton>
                </td>
                <td align="center" width="90px">
                    <dx:ASPxButton ID="btn_temizle" runat="server" Text="Tümü" Width="80" OnClick="btn_temizle_Click">
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>        
        <br />
        <dx:ASPxNavBar ID="ASPxNavBar1" runat="server" AutoCollapse="True" EnableAnimation="True" Width="166%" RenderMode="Lightweight" AllowExpanding="true" EnableViewState="False" EnableTheming="True" AllowSelectItem="false" EnableCallbackAnimation="true" EnableHotTrack="true" AutoPostBack="false">
            <ItemStyle Wrap="True"/>
            <Border BorderWidth="1px" BorderColor="LightGray"/>
            <Paddings Padding="0px" />
            <GroupHeaderStyle HorizontalAlign="Left" Font-Bold="true" Font-Names="Arial" Font-Size="10" ForeColor="Maroon"></GroupHeaderStyle>
            <GroupHeaderImage Url="Content/Images/soru_d.png" Width="17" Height="17"></GroupHeaderImage>
        </dx:ASPxNavBar>
    </div>
</asp:Content>

