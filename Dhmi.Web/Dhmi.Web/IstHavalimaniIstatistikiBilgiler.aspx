<%@ Page Title="DHMİ İletişim Merkezi - Havalimanı İstatistik Bilgileri" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="IstHavalimaniIstatistikiBilgiler.aspx.cs" Inherits="Dhmi.Web.IstHavalimaniIstatistikiBilgiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float: left; width: 60%; margin-right: 2%">
    <br />   
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages>
                <dx:TabPage Text="Saatlik İstatistiki Bilgiler">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <asp:Panel ID="pnl_yeni_kayit" runat="server" Width="2032" Height="775">                               
                                <table>
                                    <tr>
                                        <td width="2320" align="left">
                                            <dx:WebChartControl ID="WebChartControl1" runat="server" Width="1555" Height="760" ClientInstanceName="chart1">
                                            </dx:WebChartControl>                                            
                                        </td>                                        
                                        <td width="500" align="left">
                                            <table>                                               
                                                <tr>
                                                    <td>
                                                        <asp:Panel ID="panel2" runat="server" Width="428px" Height="416px" BorderColor="Maroon" BorderWidth="1" BorderStyle="Dotted">
                                                        <br />                                                        
                                                        <table>
                                                            <tr>
                                                                <td height="30px" align="left" width="43px">
                                                                </td>
                                                                <td height="30px" align="left" width="70px">
                                                                    Yıl:
                                                                </td>  
                                                                <td height="30px" align="left" width="100px">
                                                                    <dx:ASPxComboBox ID="cb_yil" runat="server" ValueType="System.String" Width="200" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz...">
                                                                                            <ValidationSettings ValidationGroup="Group_S" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Yıl seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                   
                                                                                        </dx:ASPxComboBox>                                                                                        
                                                                </td>                                                                                                                              
                                                            </tr> 
                                                            <tr>
                                                                <td height="30px" align="left" width="43px">
                                                                </td>
                                                                <td height="30px" align="left" width="70px">
                                                                    Ay:
                                                                </td>  
                                                                <td height="30px" align="left" width="100px">
                                                                    <dx:ASPxComboBox ID="cb_ay" runat="server" ValueType="System.String" Width="200" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." AutoPostBack="true" OnSelectedIndexChanged="cb_ay_SelectedIndexChanged">
                                                                                            <ValidationSettings ValidationGroup="Group_S" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Ay seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>   
                                                                                            <ClientSideEvents SelectedIndexChanged="function(s, e) {
                                                                                            Callback33.PerformCallback();
                                                                                            LoadingPanel33.Show();
                                                                                            }" />                                                                                         
                                                                                        </dx:ASPxComboBox>
                                                                                        <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback33">
                                                                                        <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel33.Hide(); }" />
                                                                                        </dx:ASPxCallback>
                                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="LoadingPanel33" Modal="True" Text="Yükleniyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                                        </dx:ASPxLoadingPanel>
                                                                </td>                                                                                                                              
                                                            </tr>                                                              
                                                            <tr>
                                                                <td height="30px" align="left" width="43px">
                                                                </td>
                                                                <td height="30px" align="left" width="70px">
                                                                    Gün:
                                                                </td>  
                                                                <td height="30px" align="left" width="100px">
                                                                    <dx:ASPxComboBox ID="cb_gun" runat="server" ValueType="System.String" Width="200" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_S" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Hafta seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                      
                                                                                        </dx:ASPxComboBox>                                                                                        
                                                                </td>                                                                                                                              
                                                            </tr>  
                                                            <tr>
                                                                <td height="30px" align="left" width="43px">
                                                                </td>
                                                                <td height="30px" align="left" width="70px">
                                                                    Saat:
                                                                </td>  
                                                                <td height="30px" align="left" width="100px">
                                                                    <dx:ASPxComboBox ID="cb_saat" runat="server" ValueType="System.String" Width="200" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" NullText="Seçiniz..." Enabled="false">
                                                                                            <ValidationSettings ValidationGroup="Group_S" ErrorDisplayMode="ImageWithTooltip">
	                                                                                            <RequiredField ErrorText="Hafta seçiniz..." IsRequired="true" />                                                                                
                                                                                            </ValidationSettings>                                                                                                                                                                                      
                                                                                        </dx:ASPxComboBox>                                                                                      
                                                                </td>                                                                                                                              
                                                            </tr>  
                                                            <tr>
                                                                <td height="30px" align="left" width="43px">
                                                                </td>
                                                                <td height="30px" align="left" width="70px">
                                                                    
                                                                </td>  
                                                                <td height="30px" align="left" width="100px">
                                                                    <table>
                                                                        <tr>
                                                                            <td height="30px" align="left" width="103px">
                                                                     <dx:ASPxButton ID="btn_temizle_ana" runat="server" Text="Temizle" ValidationGroup="Group_Vip" Width="90" UseSubmitBehavior="true" OnClick="btn_temizle_ana_Click">
                                                                     <ClientSideEvents Click="function(s, e) {
                                                                            Callback2.PerformCallback();
                                                                            LoadingPanel2.Show();
                                                                            }" />
                                                                    </dx:ASPxButton>
                                                                    <dx:ASPxCallback ID="ASPxCallback8" runat="server" ClientInstanceName="Callback2">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel2.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel7" runat="server" ClientInstanceName="LoadingPanel2" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel> 
                                                                </td>
                                                                <td align="center" width="103px">                                                                    
                                                                    <dx:ASPxButton ID="btn_kaydet_ana" runat="server" Text="Filtrele" ValidationGroup="Group_Vip" Width="90" UseSubmitBehavior="true" OnClick="btn_kaydet_ana_Click">
                                                                    <ClientSideEvents Click="function(s, e) {
                                                                            Callback331.PerformCallback();
                                                                            LoadingPanel331.Show();
                                                                            }" />
                                                                    </dx:ASPxButton>
                                                                    <dx:ASPxCallback ID="ASPxCallback5" runat="server" ClientInstanceName="Callback331">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel331.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel4" runat="server" ClientInstanceName="LoadingPanel331" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel> 
                                                                </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>                                                                                                                              
                                                            </tr>                                                                                                                
                                                        </table>                                                       
                                                        <br />
                                                        <br />
                                                        <br />
                                                        <br />
                                                        <table>
                                                            <tr>
                                                                <td height="30px" align="left" width="43px">
                                                                </td>
                                                                <td height="30px" align="left" width="100px">
                                                                    Başlangıç Tarihi:
                                                                </td>
                                                                <td height="30px" align="left" width="95px">
                                                                    <dx:ASPxTextBox ID="txt_bas_tarihi" runat="server" Width="80">
                                                                                        <ValidationSettings ValidationGroup="Group_Tar" ErrorDisplayMode="ImageWithTooltip">
	                                                                                        <RequiredField ErrorText="Başlangıç Tarihi giriniz..."/>                                                                                
                                                                                        </ValidationSettings>
                                                                                        <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata"/>                                                                            
                                                                                    </dx:ASPxTextBox>
                                                                </td>                                                                
                                                                <td height="30px" align="left" width="70px">
                                                                    Bitiş Tarihi:
                                                                </td>
                                                                <td align="left" width="70px"> 
                                                                    <dx:ASPxTextBox ID="txt_bit_tarihi" runat="server" Width="80">
                                                                                        <ValidationSettings ValidationGroup="Group_Tar" ErrorDisplayMode="ImageWithTooltip">
	                                                                                        <RequiredField ErrorText="Bitiş Tarihi giriniz..."/>                                                                                
                                                                                        </ValidationSettings>
                                                                                        <MaskSettings Mask="dd/MM/yyyy" PromptChar=" " ErrorText="hata"/>                                                                            
                                                                                    </dx:ASPxTextBox>
                                                                </td>                                                                
                                                            </tr>                                                                                                                       
                                                        </table>
                                                        <table>
                                                            <tr>
                                                                <td height="30px" align="left" width="43px">
                                                                </td>
                                                                <td height="30px" align="left" width="100px">
                                                                    
                                                                </td>
                                                                <td height="30px" align="left" width="88px">
                                                                   
                                                                </td>                                                                
                                                                <td height="30px" align="left" width="90px">
                                                                     <dx:ASPxButton ID="btn_temizle" runat="server" Text="Temizle" ValidationGroup="Group_Vip" Width="80" UseSubmitBehavior="true" OnClick="btn_temizle_Click">
                                                                     <ClientSideEvents Click="function(s, e) {
                                                                            Callback12.PerformCallback();
                                                                            LoadingPanel12.Show();
                                                                            }" />
                                                                    </dx:ASPxButton>
                                                                    <dx:ASPxCallback ID="ASPxCallback7" runat="server" ClientInstanceName="Callback12">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel12.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel8" runat="server" ClientInstanceName="LoadingPanel12" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel> 
                                                                </td>
                                                                <td align="center" width="70px">                                                                    
                                                                    <dx:ASPxButton ID="btn_kaydet" runat="server" Text="Filtrele" ValidationGroup="Group_Vip" Width="80" UseSubmitBehavior="true" OnClick="btn_kaydet_Click">
                                                                    <ClientSideEvents Click="function(s, e) {
                                                                            Callback11.PerformCallback();
                                                                            LoadingPanel11.Show();
                                                                            }" />
                                                                    </dx:ASPxButton>
                                                                    <dx:ASPxCallback ID="ASPxCallback9" runat="server" ClientInstanceName="Callback11">
                                                                            <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel11.Hide(); }" />
                                                                        </dx:ASPxCallback>
                                                                        <dx:ASPxLoadingPanel ID="ASPxLoadingPanel9" runat="server" ClientInstanceName="LoadingPanel11" Modal="True" Text="İşlem gerçekleştiriliyor..." Theme="BlackGlass" Width="150" Height="80">
                                                                        </dx:ASPxLoadingPanel> 
                                                                </td>                                                                
                                                            </tr>
                                                        </table>
                                                        <br />                                                        
                                                        <br />     
                                                        <br />     
                                                        <table>                                                            
                                                            <tr>
                                                                <td height="30px" align="left" width="120px">
                                                                </td>
                                                                <td width="193" align="left" height="69px">
                                            <dx:ASPxButton ID="btnPdfExport" runat="server" Text="PDF" Width="80" Image-Url="~/Content/Images/rapor_pdf.png" ImagePosition="Top" Paddings-PaddingLeft="1px" AutoPostBack="False">
                                                <ClientSideEvents Click="function(s, e) {
	                                            chart1.SaveToDisk('pdf');   
                                                }" />
                                            </dx:ASPxButton>                                            
                                        </td>
                                        <td width="193" align="left" height="69px">
                                            <dx:ASPxButton ID="ASPxButton1" runat="server" Text="EXCEL" Width="80" Image-Url="~/Content/Images/rapor_xls.png" ImagePosition="Top" Paddings-PaddingLeft="5px" AutoPostBack="False">
                                                <ClientSideEvents Click="function(s, e) {
	                                            chart1.SaveToDisk('xls');   
                                                }" />
                                            </dx:ASPxButton>
                                        </td>   
                                        <td width="193" align="left" height="69px">
                                            <dx:ASPxButton ID="ASPxButton2" runat="server" Text="WORD" Width="80" Image-Url="~/Content/Images/rapor_word.png" ImagePosition="Top" Paddings-PaddingLeft="3px" AutoPostBack="False">
                                                <ClientSideEvents Click="function(s, e) {
	                                            chart1.SaveToDisk('rtf');   
                                                }" />
                                            </dx:ASPxButton>
                                        </td>
                                        <td width="193" align="left" height="69px">
                                            <dx:ASPxButton ID="ASPxButton3" runat="server" Text="IMAGE" Width="80" Image-Url="~/Content/Images/rapor_image.png" ImagePosition="Top" Paddings-PaddingLeft="1px" AutoPostBack="False">
                                                <ClientSideEvents Click="function(s, e) {
	                                            chart1.SaveToDisk('png');   
                                                }" />
                                            </dx:ASPxButton>
                                        </td> 
                                                            </tr>
                                                        </table>
                                                        </asp:Panel>
                                                    </td>                                    
                                                </tr>                                                
                                            </table>
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
