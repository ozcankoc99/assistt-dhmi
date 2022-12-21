using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dhmi.Web.en
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
            //lblGuvenlik.InnerHtml = sayi.ToString();
            lblGuvenlik.InnerHtml = Guid.NewGuid().ToString().Substring(0, 8);
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {         
            string basvuruNo = basvuruno.Value;
            string tcKimlik = tckimlik.Value;
            if (!string.IsNullOrEmpty(basvuruNo) && !string.IsNullOrEmpty(tcKimlik) && lblGuvenlik.InnerText == txtGuvenlik.Value.Trim())
            {
                ListBildirimTypedList bilList = new ListBildirimTypedList();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter = new PredicateExpression();
                filter.Add(BildirimFields.BildirimId == Convert.ToInt32(basvuruNo));
                filter.AddWithAnd(VatandaFields.VatandasTcNo == tcKimlik);
                bilList.Fill(0, sort, false, filter);

                if (bilList.Count == 0)
                    divSonuc.InnerHtml = @"<div class='address'><h2>Results</h2><br/>You do not have the application has been finalized. </div>";
                else
                    divSonuc.InnerHtml = "<div class='address'><h2>Results</h2><br/>" + bilList[0].BildirimVatandasKarar + "</div>";
            }
            GenerateNumber();
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
                return "<div class='address'><h2>Results</h2><ul class='contact-info'><li>You do not have the application has been finalized.</li></div>";

            return "<div class='address'><h2>Results</h2><ul class='contact-info'><li>" + bilList[0].BildirimVatandasKarar + "</li></div>";
        }
    }
}