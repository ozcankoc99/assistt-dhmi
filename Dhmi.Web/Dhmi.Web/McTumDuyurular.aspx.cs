using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class McTumDuyurular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Çağrı İşlemleri";

            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");
            }

            
            HttpCookie cookie = Request.Cookies["userC"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddMinutes(15);
                cookie.Secure = true;
                //cookie.SameSite = SameSiteMode.None;
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
            }
            else
            {
                Response.Redirect("Account/Login.aspx");
            }

            if (IsPostBack != true)
            {
                DuyuruCollection CollDuy = new DuyuruCollection();
                ISortExpression sortduy = new SortExpression();
                IPredicateExpression ExpDuy = new PredicateExpression();
                ExpDuy.AddWithAnd(DuyuruFields.DuyuruYayinTarih <= DateTime.Now);
                ExpDuy.AddWithAnd(DuyuruFields.DuyuruDurum == true);
                sortduy.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
                CollDuy.GetMulti(ExpDuy, 0, sortduy);

                for (int i = 0; i < CollDuy.Count; i++)
                {
                    string haber_baslik = CollDuy[i].DuyuruYayinTarih.ToShortDateString() + " - " + CollDuy[i].DuyuruBaslik;

                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciId == CollDuy[i].FkKullaniciId);
                    CollKul.GetMulti(ExpKul);

                    GorevCollection CollGor = new GorevCollection();
                    IPredicateExpression ExpGor = new PredicateExpression();
                    ExpGor.AddWithAnd(GorevFields.GorevId == CollKul[0].FkGorevId);
                    CollGor.GetMulti(ExpGor);

                    ASPxNavBar1.Groups.Add(haber_baslik);
                    ASPxNavBar1.Groups[i].Items.Add(CollDuy[i].DuyuruIcerik);
                    ASPxNavBar1.Groups[i].Items.Add(CollKul[0].KullaniciAdSoyad + " - " + CollGor[0].GorevAd);
                    ASPxNavBar1.Groups[i].Items[1].Image.Url = "~/Content/Images/kullanici.png";
                    ASPxNavBar1.Groups[i].Items[1].ToolTip = "Kullanıcı";
                }
            }
        }

        protected void btn_sorgula_Click(object sender, EventArgs e)
        {
            string aradim = "%" + txt_anahtar_kelime.Text + "%";

            DuyuruCollection CollDuy = new DuyuruCollection();
            ISortExpression sortduy = new SortExpression();
            IPredicateExpression ExpDuy = new PredicateExpression();
            ExpDuy.AddWithAnd(DuyuruFields.DuyuruYayinTarih <= DateTime.Now);
            ExpDuy.AddWithAnd(DuyuruFields.DuyuruDurum == true);
            ExpDuy.AddWithAnd(new FieldLikePredicate(DuyuruFields.DuyuruIcerik, null, aradim));
            sortduy.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
            CollDuy.GetMulti(ExpDuy, 0, sortduy);

            for (int i = 0; i < CollDuy.Count; i++)
            {
                string haber_baslik = CollDuy[i].DuyuruYayinTarih.ToShortDateString() + " - " + CollDuy[i].DuyuruBaslik;

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == CollDuy[i].FkKullaniciId);
                CollKul.GetMulti(ExpKul);

                GorevCollection CollGor = new GorevCollection();
                IPredicateExpression ExpGor = new PredicateExpression();
                ExpGor.AddWithAnd(GorevFields.GorevId == CollKul[0].FkGorevId);
                CollGor.GetMulti(ExpGor);

                ASPxNavBar1.Groups.Add(haber_baslik);
                ASPxNavBar1.Groups[i].Items.Add(CollDuy[i].DuyuruIcerik);
                ASPxNavBar1.Groups[i].Items.Add(CollKul[0].KullaniciAdSoyad + " - " + CollGor[0].GorevAd);
                ASPxNavBar1.Groups[i].Items[1].Image.Url = "~/Content/Images/kullanici.png";
                ASPxNavBar1.Groups[i].Items[1].ToolTip = "Kullanıcı";
            }
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            DuyuruCollection CollDuy = new DuyuruCollection();
            ISortExpression sortduy = new SortExpression();
            IPredicateExpression ExpDuy = new PredicateExpression();
            ExpDuy.AddWithAnd(DuyuruFields.DuyuruYayinTarih <= DateTime.Now);
            ExpDuy.AddWithAnd(DuyuruFields.DuyuruDurum == true);
            sortduy.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
            CollDuy.GetMulti(ExpDuy, 0, sortduy);

            for (int i = 0; i < CollDuy.Count; i++)
            {
                string haber_baslik = CollDuy[i].DuyuruYayinTarih.ToShortDateString() + " - " + CollDuy[i].DuyuruBaslik;

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == CollDuy[i].FkKullaniciId);
                CollKul.GetMulti(ExpKul);

                GorevCollection CollGor = new GorevCollection();
                IPredicateExpression ExpGor = new PredicateExpression();
                ExpGor.AddWithAnd(GorevFields.GorevId == CollKul[0].FkGorevId);
                CollGor.GetMulti(ExpGor);

                ASPxNavBar1.Groups.Add(haber_baslik);
                ASPxNavBar1.Groups[i].Items.Add(CollDuy[i].DuyuruIcerik);
                ASPxNavBar1.Groups[i].Items.Add(CollKul[0].KullaniciAdSoyad + " - " + CollGor[0].GorevAd);
                ASPxNavBar1.Groups[i].Items[1].Image.Url = "~/Content/Images/kullanici.png";
                ASPxNavBar1.Groups[i].Items[1].ToolTip = "Kullanıcı";

                txt_anahtar_kelime.Text = "";
            }
        }
    }
}