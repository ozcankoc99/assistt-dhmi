<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="McDosyaDurumu.aspx.cs" Inherits="Dhmi.Web.McDosyaDurumu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DHMİ İletişim Merkezi - Dosya Sistemi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td width="60" align="left" height="45px">
                    <dx:ASPxLabel ID="asdsadasd" runat="server" Text="Dosya-1:" Font-Names="Calibri" Font-Size="11" Font-Bold="true" ForeColor="Maroon"></dx:ASPxLabel>
                </td>
                <td width="550" align="left" height="45px">
                    <asp:FileUpload ID="upload_foto_1" runat="server" Width="500" />
                </td>
                <td width="170" align="left" height="45px">
                    <dx:ASPxButton ID="btn_kaydet_1" runat="server" Text="Kaydet/Güncelle" Width="140" OnClick="btn_kaydet_1_Click">
                    </dx:ASPxButton>
                </td>                
                <td width="110" align="left" height="45px">
                    <asp:Button ID="btn_goster_1" runat="server" Text="Göster" Width="80" OnClick="btn_goster_1_Click" Enabled="false" OnClientClick="aspnetForm.target ='_blank';" />
                </td>
                <td width="110" align="left" height="45px">
                    <dx:ASPxButton ID="btn_sil_1" runat="server" Text="Sil" Width="80" OnClick="btn_sil_1_Click" Enabled="false">
                    </dx:ASPxButton>
                </td>
            </tr>
            <tr>
                <td width="60" align="left" height="45px">
                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Dosya-2:" Font-Names="Calibri" Font-Size="11" Font-Bold="true" ForeColor="Maroon"></dx:ASPxLabel>
                </td>
                <td width="550" align="left" height="45px">
                    <asp:FileUpload ID="upload_foto_2" runat="server" Width="500" />
                </td>
                <td width="170" align="left" height="45px">
                    <dx:ASPxButton ID="btn_kaydet_2" runat="server" Text="Kaydet/Güncelle" Width="140" OnClick="btn_kaydet_2_Click">
                    </dx:ASPxButton>
                </td>                
                <td width="110" align="left" height="45px">
                    <asp:Button ID="btn_goster_2" runat="server" Text="Göster" Width="80" OnClick="btn_goster_2_Click" Enabled="false" OnClientClick="aspnetForm.target ='_blank';"/>
                    </dx:ASPxButton>
                </td>
                <td width="110" align="left" height="45px">
                    <dx:ASPxButton ID="btn_sil_2" runat="server" Text="Sil" Width="80" OnClick="btn_sil_2_Click" Enabled="false">
                    </dx:ASPxButton>
                </td>
            </tr>
            <tr>
                <td width="60" align="left" height="45px">
                    <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Dosya-3:" Font-Names="Calibri" Font-Size="11" Font-Bold="true" ForeColor="Maroon"></dx:ASPxLabel>
                </td>
                <td width="550" align="left" height="45px">
                    <asp:FileUpload ID="upload_foto_3" runat="server" Width="500" />
                </td>
                <td width="170" align="left" height="45px">
                    <dx:ASPxButton ID="btn_kaydet_3" runat="server" Text="Kaydet/Güncelle" Width="140" OnClick="btn_kaydet_3_Click">
                    </dx:ASPxButton>
                </td>                
                <td width="110" align="left" height="45px">
                    <asp:Button ID="btn_goster_3" runat="server" Text="Göster" Width="80" OnClick="btn_goster_3_Click" Enabled="false" OnClientClick="aspnetForm.target ='_blank';"/>
                    </dx:ASPxButton>
                </td>
                <td width="110" align="left" height="45px">
                    <dx:ASPxButton ID="btn_sil_3" runat="server" Text="Sil" Width="80" OnClick="btn_sil_3_Click" Enabled="false">
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
