<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="McCagriGenisOzet.aspx.cs" Inherits="Dhmi.Web.McCagriGenisOzet" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DHMİ İletişim Merkezi - Çağrı Genel Özet</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
                                    <tr>
                                        <td align="center" width="1600px">
                                            <table>
                                                <tr>
                                                    <td align="center" width="1150">
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="center" width="1150px" height="14px">
                                                                    
                                                                    <asp:Label ID="Label9" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="18pt" Text="V A T A N D A Ş / F İ R M A"></asp:Label>&nbsp; &nbsp; &nbsp; <asp:Label ID="Label49" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="18pt" Text="B İ L G İ L E R İ"></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>                                                                                                      
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="asdasdas" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Kayıt Türü"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_kayit_turu" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label8" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="TC Kimlik No"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_tc_kimlik_no" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label2" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Pasaport No"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_pasaport_no" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                                
                                                            </tr>                                                                                                                      
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="sdsd" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Uyruk"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_uyruk" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="asdas" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Ad Soyad / Firma Adı"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_ad_soyad_firma" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label11" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Cinsiyet"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_cinsiyet" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                                
                                                            </tr>
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label13" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Doğum Tarihi"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_dogum_tarihi" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label15" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Telefon Numarası"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_telefon_no" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label17" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Mail Adresi"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="vt_mail_adresi" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                                
                                                            </tr>
                                                        </table> 
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label19" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Adres"></asp:Label>
                                                                </td>
                                                                <td align="left" width="930px">&nbsp;
                                                                    <asp:Label ID="vt_adres" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                       
                                                            </tr>
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label21" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Not"></asp:Label>
                                                                </td>
                                                                <td align="left" width="930px">&nbsp;
                                                                    <asp:Label ID="vt_not" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                       
                                                            </tr>
                                                        </table>
                                                        <br />                                                        
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="center" width="1150px" height="14px">                                                                    
                                                                    <asp:Label ID="Label23" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="18pt" Text="Ç A Ğ R I"></asp:Label>&nbsp; &nbsp; &nbsp; <asp:Label ID="Label48" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="18pt" Text="B İ L G İ L E R İ"></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>                                                                                                      
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label24" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Bildirim No"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_bildirim_no" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label26" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Bildirim Türü"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_bildirim_turu" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label28" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Bilgilendirme Şekli"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_bilgi_sekil" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                                
                                                            </tr>                                                                                                                      
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label30" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Sonuç"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_sonuc" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label32" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Son İşlem Tarihi"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_son_islem_tarihi" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label34" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Havalimanı"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_havalimani" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                                
                                                            </tr>
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label36" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Dava Ad Soyad"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_dava_ad_soyad" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label38" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Dava Dosya No"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_dava_dosya_no" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label40" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Dava Mahkeme Adı"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_dava_mahkeme" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                                
                                                            </tr>
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label42" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Dava Konu"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_dava_konu" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label44" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Toplam İşlem Süresi"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_top_islem" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label46" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Geri Dönüş Yapıldı mı?"></asp:Label>
                                                                </td>
                                                                <td align="left" width="200px">&nbsp;
                                                                    <asp:Label ID="cb_geri_donus_mu" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                                
                                                            </tr>
                                                        </table>
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label50" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Konu"></asp:Label>
                                                                </td>
                                                                <td align="left" width="930px">&nbsp;
                                                                    <asp:Label ID="cb_konu" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                       
                                                            </tr>                                                            
                                                        </table>
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label52" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Açıklama / Şikayet"></asp:Label>
                                                                </td>
                                                                <td align="left" width="930px">&nbsp;
                                                                    <asp:Label ID="cb_aciklama_sikayet" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                       
                                                            </tr>                                                            
                                                        </table>
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label54" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Atanma Durumu"></asp:Label>
                                                                </td>
                                                                <td align="left" width="930px">&nbsp;
                                                                    <asp:Label ID="cb_atanma_durumu" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                       
                                                            </tr>                                                            
                                                        </table>
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label56" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Not"></asp:Label>
                                                                </td>
                                                                <td align="left" width="930px">&nbsp;
                                                                    <asp:Label ID="cb_not" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                       
                                                            </tr>                                                            
                                                        </table>
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="left" width="150px" height="20px">&nbsp;
                                                                    <asp:Label ID="Label58" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="10pt" Text="Vatandaş Karar"></asp:Label>
                                                                </td>
                                                                <td align="left" width="930px">&nbsp;
                                                                    <asp:Label ID="cb_vatandas_karar" runat="server" Text="0" Font-Underline="False" ForeColor="White" Font-Names="Calibri" Font-Size="10pt"></asp:Label>
                                                                </td>                                                       
                                                            </tr>                                                            
                                                        </table>
                                                        <br />
                                                        <table border="1" bordercolor="#928787" bgcolor="#96BAEE">
                                                            <tr>
                                                                <td align="center" width="1150px" height="14px">
                                                                    
                                                                    <asp:Label ID="Label60" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="18pt" Text="Ç A Ğ R I"></asp:Label>&nbsp; &nbsp; &nbsp; <asp:Label ID="Label61" runat="server" ForeColor="Maroon" Font-Names="Calibri" Font-Size="18pt" Text="G E Ç M İ Ş İ"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="center" width="1150px" height="14px">
                                                                    <asp:ListBox ID="lb_gecmis" runat="server" Width="1040" Height="200" Font-Size="9"></asp:ListBox>                                                                    
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
    </form>
</body>
</html>
