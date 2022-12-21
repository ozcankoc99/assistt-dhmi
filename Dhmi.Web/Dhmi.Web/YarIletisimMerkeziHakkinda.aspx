<%@ Page Title="DHMİ İletişim Merkezi - İletişim Merkezi Hakkında" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="YarIletisimMerkeziHakkinda.aspx.cs" Inherits="Dhmi.Web.YarIletisimMerkeziHakkinda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="1">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td width="1310px" align="left">                                                                                                                                    
                                        <asp:Label ID="asdsada" runat="server" Text="İletişim Merkezi Yazılım Sistemi, Devlet Hava Meydanları İşletmesi Genel Müdürlüğü İletişim Merkezi ihtiyaçlarına göre özel olarak tasarlanmış ve Kurumun ihtiyaçlarına tam olarak cevap verebilmesi amaçlanmıştır." Font-Names="Calibri" Font-Size="10"></asp:Label>                                        
                                        </td>
                                    </tr>                                    
                                    <tr>
                                        <td width="1310px" align="left">                                                                                                                                                                            
                                        </td>
                                    </tr> 
                                </table>                                
                                <table>
                                    <tr>
                                        <td width="1310px" align="left">                                                                                                                                    
                                        <br />
                                        <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1310px" align="left">                                                                                                                                    
                                        <asp:Label ID="Label1" runat="server" Text="İletişim Merkezi Yazılım Sistemi ile izleme ve geri dönüş mekanizmalarının doğru bir şekilde işletilmesi ile hizmet kalitesinin yükseltilmesi, vatandaşın Kurumdan beklediği memnuniyetin arttırılması, kontrol edilebilir bir ekip yönetimi ve kalıcı bir sistem veritabanının oluşturulması, personel verimliliğini maksimum seviyeye çıkarılması ve kurumsal bir iş takip mekanizmasının oluşturulması amaçlanmıştır." Font-Names="Calibri" Font-Size="10"></asp:Label>                                        
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1310px" align="left">                                                                                                                                    
                                        <br />                                        
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1310px" align="center">                                                                                                                                    
                                        <img src="Content/Images/ara_part.png" alt=""/>
                                        </td>
                                    </tr>                                   
                                    <tr>
                                        <td width="11310px" align="left">                                                                                                                                    
                                        <br />
                                        <br />
                                        </td>
                                    </tr>                                   
                                    <tr>
                                        <td width="1310px" align="left"> 
                                        <asp:Label ID="Label3" runat="server" Text="İletişim Merkezi Yazılım Sistemi üzerinde 27 modülümüz bağımsız olarak hizmet vermektedir. Portal şeklinde tasarımını gerçekleştirdiğimiz sistemimiz esnekliği sayesinde Kurumdan gelecek her türlü ekstra isteklere de cevap verebilecek durumdadır." Font-Names="Calibri" Font-Size="10"></asp:Label>                                                                                                                                                                                                                                                                                                                                                      
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="1310px" align="left">                                                                                                                                    
                                        <br />
                                        <br />
                                        </td>
                                    </tr>                                   
                                    <tr>
                                        <td width="1310px" align="left"> 
                                        <asp:Label ID="Label2" runat="server" Text="Sistem içeriği, Devlet Hava Meydanları Genel Müdürlüğü Daire Başkanlıkları tarafından belirlenen isimlerin katılımı ile gerçekleştirilen süreç toplantıları sonucunda oluşturulan iş süreçleri neticesinde oluşturulmuştur." Font-Names="Calibri" Font-Size="10"></asp:Label>                                                                                                                                                                                                                                                                                                                                                     
                                        </td>
                                    </tr>
                                </table>
                                <table>
                                    <tr>
                                        <td width="1310px" align="center">                                                                                                                                    
                                        <br />
                                        </td>
                                    </tr>                                    
                                </table>
                            </asp:Panel>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>       
                <dx:TabPage Text="2">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <asp:Panel ID="Panel1" runat="server" Width="1325" Height="440">
                                <table>
                                    <tr>
                                        <td align="center" width="1310px" height="395px">
                                            <a href="Content/Document/call_center_help_dhmi.pdf" target="_blank" title="Kullanım Kılavuzu">
                                            <dx:ASPxButton ID="btn_yar_doc" runat="server" Text="Yardım Dokümanı İncele" Width="220" Image-Url="~/Content/Images/yar_doc.png" ImagePosition="Top" UseSubmitBehavior="false" Paddings-PaddingLeft="18px" Height="150px" Font-Bold="true" ForeColor="Maroon">                                                                                    
                                                                                    <Image Url="~/Content/Images/yar_doc.png"></Image>
                                                                                    <Paddings PaddingLeft="18px"></Paddings>
                                                                                </dx:ASPxButton></a>
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