using dhmi.EntityClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using Newtonsoft.Json;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dhmi.Web
{
    public partial class AjaxRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            switch (action)
            {
                case "SonucGoster":
                    if (Request.QueryString["lang"] == "tr")
                        SonucGoster();
                    else if (Request.QueryString["lang"] == "eng")
                        SonucGosterIng();
                    break;
                case "MailGonder":
                    if (Request.QueryString["lang"] == "tr")
                        MailGonder();
                    else if (Request.QueryString["lang"] == "eng")
                        MailGonderIng();
                    break;
                /*case "CagriKaydiOlustur":
                    if (Request.QueryString["lang"] == "tr")
                        CagriKaydiOlustur();
                    else if (Request.QueryString["lang"] == "eng")
                        CagriKaydiOlusturIng();
                    break;*/
            }

        }

        private void CagriKaydiOlustur()
        {
            throw new NotImplementedException();
        }

        private void CagriKaydiOlusturIng()
        {
            throw new NotImplementedException();
        }

        private void MailGonder()
        {
            string ad = Request.QueryString["Ad"];
            string mailAdresi = Request.QueryString["Cc"];
            string konu = Request.QueryString["Konu"];
            string icerik = Request.QueryString["Icerik"];

            //string sonuc = Mail.MailGonder(ad, mailAdresi, konu, icerik);
            string sonuc = "YES";
                        
            if (sonuc == "YES")
                sonuc = "Mail gönderme işlemi gerçekleşmiştir. Gönderilmiş kopyasına mail adresinizden ulaşabilirsiniz.";
            else
                sonuc = "Mail gönderme işlemi gerçekleştirilememiştir.";
            
            StringBuilder sb = new StringBuilder();
            sb.Append(JsonConvert.SerializeObject(sonuc, Formatting.Indented));
            Response.ContentType = "application/json";
            Response.CacheControl = "No-cache";
            Response.Write(sb.ToString());
            Response.End();
        }

        private void MailGonderIng()
        {
            string ad = Request.QueryString["Ad"];
            string mailAdresi = Request.QueryString["Cc"];
            string konu = Request.QueryString["Konu"];
            string icerik = Request.QueryString["Icerik"];

            //string sonuc = Mail.MailGonder(ad, mailAdresi, konu, icerik);
            string sonuc = "YES";

            if (sonuc == "YES")
                sonuc = "Mail sending has been completed succesfully. You can reach e-mail copy from your address.";
            else
                sonuc = "An error has been occured. Mail could not send.";

            StringBuilder sb = new StringBuilder();
            sb.Append(JsonConvert.SerializeObject(sonuc, Formatting.Indented));
            Response.ContentType = "application/json";
            Response.CacheControl = "No-cache";
            Response.Write(sb.ToString());
            Response.End();
        }      

        private void SonucGoster()
        {
            string tcKimlik = Request.QueryString["Tc"];
            int basvuruNo = Convert.ToInt32(Request.QueryString["BasvuruNo"]);

            ListBildirimTypedList bilList = new ListBildirimTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            filter.Add(BildirimFields.BildirimId == basvuruNo);
            filter.AddWithAnd(VatandaFields.VatandasTcNo == tcKimlik);
            bilList.Fill(0, sort, false, filter);

            StringBuilder sb = new StringBuilder();
            sb.Append(JsonConvert.SerializeObject(bilList.ToList(), Formatting.Indented));
            bilList = null;
            Response.ContentType = "application/json";
            Response.CacheControl = "No-cache";
            Response.Write(sb.ToString());
            Response.End();
        }

        private void SonucGosterIng()
        {
            string tcKimlik = Request.QueryString["Tc"];
            int basvuruNo = Convert.ToInt32(Request.QueryString["BasvuruNo"]);

            ListBildirimTypedList bilList = new ListBildirimTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            filter.Add(BildirimFields.BildirimId == basvuruNo);
            filter.AddWithAnd(VatandaFields.VatandasPasaportNo == tcKimlik);
            bilList.Fill(0, sort, false, filter);

            StringBuilder sb = new StringBuilder();
            sb.Append(JsonConvert.SerializeObject(bilList.ToList(), Formatting.Indented));
            bilList = null;
            Response.ContentType = "application/json";
            Response.CacheControl = "No-cache";
            Response.Write(sb.ToString());
            Response.End();
        }
    }
}