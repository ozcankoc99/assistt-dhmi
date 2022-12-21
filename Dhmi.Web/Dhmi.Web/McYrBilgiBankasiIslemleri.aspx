<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="McYrBilgiBankasiIslemleri.aspx.cs" Inherits="Dhmi.Web.McYrBilgiBankasiIslemleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="1050px">
            <tr>
                <td align="left" width="15px">
                </td>               
                <td align="left" width="110px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Names="Calibri" ForeColor="Maroon" Font-Size="10" Text="Bilgi Bankası Türü:"></asp:Label>
                </td>
                <td align="left" width="360px">
                    <dx:ASPxComboBox ID="cb_bil_tur" runat="server" ValueType="System.String" Width="350" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_bil_tur_SelectedIndexChanged">
                                                                                            <ValidationSettings ValidationGroup="Group_Sicil" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Ana Menü seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>   
                                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback333.PerformCallback();
                                                                                            LoadingPanel333.Show();
                                                                                            }" />                                                                                         
                                                                                        </dx:ASPxComboBox>
                                                                                        <dx:ASPxCallback ID="ASPxCallback3" runat="server" ClientInstanceName="Callback333">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel333.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel2" runat="server" ClientInstanceName="LoadingPanel333" Modal="True" Text="Uygulanıyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel> 
                </td>
                <td align="left" width="110px">
                    <asp:Label ID="lbl_kelime" runat="server" Font-Bold="true" Font-Names="Calibri" ForeColor="Maroon" Font-Size="10" Text="Anahtar Kelime:*"></asp:Label>
                </td>
                <td align="left" width="150px">
                    <dx:ASPxTextBox ID="txt_anahtar_kelime" runat="server" Width="130" MaxLength="30">
                                                                <ValidationSettings ValidationGroup="Group_Filtrele" ErrorDisplayMode="ImageWithTooltip">
	                                                                <RequiredField ErrorText="Anahtar Kelime giriniz..." IsRequired="true" />                                                                                
                                                                </ValidationSettings>
                                                            </dx:ASPxTextBox> 
                </td>
                <td align="center" width="110px">
                    <dx:ASPxButton ID="btn_sorgula" runat="server" Text="İçerik Ara" Width="110" ValidationGroup="Group_Filtrele" OnClick="btn_sorgula_Click">
                    </dx:ASPxButton>
                </td>
                <td align="center" width="140px">
                    <dx:ASPxButton ID="btn_temizle" runat="server" Text="Tümünü Göster" Width="130" OnClick="btn_temizle_Click">
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>        
        <br />
        <dx:ASPxNavBar ID="ASPxNavBar1" runat="server" AutoCollapse="True" EnableAnimation="True" Width="100%" RenderMode="Lightweight" AllowExpanding="true" EnableViewState="False" EnableTheming="True" AllowSelectItem="false" EnableCallbackAnimation="true" EnableHotTrack="true" AutoPostBack="false">
            <ItemStyle Wrap="True"/>
            <Border BorderWidth="1px" BorderColor="LightGray"/>
            <Paddings Padding="0px" />
            <GroupHeaderStyle HorizontalAlign="Left" Font-Bold="true" Font-Names="Arial" Font-Size="10" ForeColor="Maroon" Wrap="True"></GroupHeaderStyle>
            <GroupHeaderImage Url="Content/Images/soru.png" Width="17" Height="17"></GroupHeaderImage>            
        </dx:ASPxNavBar>
    </div>
    </form>
</body>
</html>
