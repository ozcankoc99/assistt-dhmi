using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dhmi.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack != true)
            {
                GenerateNumber();
            }
        }

        private void GenerateNumber()
        {
            //Random rastgele = new Random();
            //Int32 sayi = rastgele.Next(100000, 999999);
            //lblGuvenlik.Text = sayi.ToString();
            lblGuvenlik.Text = Guid.NewGuid().ToString().Substring(0, 8);
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            string basvuruNo = basvuruno.Value;
            string tcKimlik = tckimlik.Value;
            string ePosta = eposta.Value;
            //if (Page.IsValid)
            //{
            if (!string.IsNullOrEmpty(basvuruNo) && (!string.IsNullOrEmpty(tcKimlik) || (!string.IsNullOrEmpty(ePosta) && EmailValidate(ePosta))) && lblGuvenlik.Text == txtGuvenlik.Value.Trim())
            {
                ListBildirimTypedList bilList = new ListBildirimTypedList();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter = new PredicateExpression();
                filter.Add(BildirimFields.BildirimId == Convert.ToInt32(basvuruNo));
                if (!string.IsNullOrEmpty(tcKimlik))
                    filter.AddWithAnd(VatandaFields.VatandasTcNo == tcKimlik);
                else if (!string.IsNullOrEmpty(ePosta))
                    filter.AddWithAnd(VatandaFields.VatandasMail == ePosta);
                bilList.Fill(0, sort, false, filter);

                if (bilList.Count == 0)
                    divSonuc.InnerHtml = @"<div class='address'><h2>Sonuçlar</h2><br/>Sonuçlandırılmış başvurunuz bulunmamaktadır. </div>";
                else
                    divSonuc.InnerHtml = "<div class='address'><h2>Sonuçlar</h2><br/>" + bilList[0].BildirimVatandasKarar + "</div>";
            }
            //}
            GenerateNumber();
        }

        private bool EmailValidate(string email)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match match = regex.Match(email);

            return match.Success;
        }

        [System.Web.Services.WebMethod]
        public static string SonucGoster(string tckimlik, string basvuruno)
        {
            ListBildirimTypedList bilList = new ListBildirimTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            filter.Add(BildirimFields.BildirimId == Convert.ToInt32(basvuruno));
            filter.AddWithAnd(VatandaFields.VatandasTcNo == tckimlik);
            bilList.Fill(0, sort, false, filter);

            if (bilList.Count > 0)
                return "<div class='address'><h2>Sonuçlar</h2><ul class='contact-info'><li>Sonuçlandırılmış başvurunuz bulunmamaktadır.</li></div>";

            return "<div class='address'><h2>Sonuçlar</h2><ul class='contact-info'><li>" + bilList[0].BildirimAciklama + "</li></div>";
        }
    }
}