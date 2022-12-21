using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;

namespace Dhmi.Web
{
    public partial class Test_Deneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userC"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddMinutes(15);
                cookie.Secure = true;
                //cookie.SameSite = SameSiteMode.Lax;
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
            }
            else
            {
                Response.Redirect("Account/Login.aspx");
            }
            /*
            BildirimCollection CollBil = new BildirimCollection();
            CollBil.GetMulti(null);

            for (int i = 0; i < CollBil.Count; i++) 
            {
                CollBil[i].BildirimDavaMahkeme = CollBil[i].BildirimDavaKonu;
                CollBil[i].BildirimDavaKonu = "";
                CollBil[i].Save();
            }
            */
            BildirimCollection CollBil = new BildirimCollection();
            CollBil.GetMulti(null);

            for (int i = 0; i < CollBil.Count; i++)
            {
                if (CollBil[i].BildirimAtanmaDurumu == "Bigi verildi-Kapatıldı.")
                {
                    CollBil[i].BildirimAtanmaDurumu = "Bilgi verildi-Kapatıldı.";
                    CollBil[i].Save();
                }
            }

            for (int i = 0; i < CollBil.Count; i++)
            {
                if (CollBil[i].BildirimAtanmaDurumu == "Bilgi verildi-Kapatıldı.")
                {
                    if (CollBil[i].BildirimVatandasKarar == "" || CollBil[i].BildirimVatandasKarar == null)
                    {
                        CollBil[i].BildirimVatandasKarar = CollBil[i].BildirimMetin;
                        CollBil[i].Save();
                    }
                }
            }

            /*
            VatandaCollection CollVat = new VatandaCollection();
            CollVat.GetMulti(null);

            for (int i = 0; i < CollVat.Count; i++) 
            {
                CollVat[i].VatandasNotes = "";
                CollVat[i].Save();
            }*/

            
            BildirimHistoryCollection CollHis = new BildirimHistoryCollection();
            IPredicateExpression ExpHis = new PredicateExpression();
            ExpHis.AddWithAnd(BildirimHistoryFields.FkBildirimIslemId == 10);
            CollHis.GetMulti(ExpHis);

            for (int i = 0; i < CollHis.Count; i++)
            {
                string deger = CollHis[i].BildirimHistoryAciklama;
                string deger2 = deger.Replace("reddedildi", "sonuçlandı");
                CollHis[i].BildirimHistoryAciklama = deger2;
                CollHis[i].Save();
            }
            
            LogEmailCollection CollEm = new LogEmailCollection();
            CollEm.GetMulti(null);

            for (int i = 0; i < CollEm.Count; i++)
            {
                CollEm[i].LogEmailSendStatus = true;
                CollEm[i].Save();
            }                       
        }
    }
}