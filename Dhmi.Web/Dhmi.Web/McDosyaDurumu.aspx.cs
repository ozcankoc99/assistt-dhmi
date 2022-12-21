using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dhmi.Web
{
    public partial class McDosyaDurumu : System.Web.UI.Page
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
                //cookie.SameSite = SameSiteMode.Lax;
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
            }
            else
            {
                Response.Redirect("Account/Login.aspx");
            }

            if (IsPostBack != true)
            {
                if (Session["file_path_1"] != null)
                {
                    btn_kaydet_1.Enabled = false;
                    btn_goster_1.Enabled = true;
                    btn_sil_1.Enabled = true;
                }

                if (Session["file_path_2"] != null)
                {
                    btn_kaydet_2.Enabled = false;
                    btn_goster_2.Enabled = true;
                    btn_sil_2.Enabled = true;
                }

                if (Session["file_path_3"] != null)
                {
                    btn_kaydet_3.Enabled = false;
                    btn_goster_3.Enabled = true;
                    btn_sil_3.Enabled = true;
                }
            }
        }

        protected void btn_kaydet_1_Click(object sender, EventArgs e)
        {
            string fileType = System.IO.Path.GetExtension(upload_foto_1.FileName).ToLower();
            double filesize = Convert.ToDouble(upload_foto_1.PostedFile.ContentLength) / 1048576.0; // mb cinsinden
            bool isValid = IsValidImage(upload_foto_1.FileBytes);
            if (upload_foto_1.HasFile && (fileType == ".jpeg" || fileType == ".jpg" || fileType == ".png") && isValid && filesize <= 20)
            {
                Random rastgele = new Random();
                Int32 sayi = rastgele.Next(100000, 999999);

                string ara_ver = Session["kullanici_var_mi"].ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + sayi.ToString() + "_" + upload_foto_1.FileName;

                upload_foto_1.SaveAs(Server.MapPath("Content/Files/" + ara_ver));

                Session["file_path_1"] = ara_ver;

                btn_goster_1.Enabled = true;
                btn_sil_1.Enabled = true;
                btn_kaydet_1.Enabled = false;

                string CloseWindow;
                CloseWindow = "alert('Belge sisteme yüklenmiştir...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir dosya türü seçiniz ve dosya boyutunun 20 Mb ile sınırlı olduğunu unutmayınız..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_kaydet_2_Click(object sender, EventArgs e)
        {
            string fileType = System.IO.Path.GetExtension(upload_foto_2.FileName).ToLower();
            double filesize = Convert.ToDouble(upload_foto_2.PostedFile.ContentLength) / 1048576.0; // mb cinsinden
            bool isValid = IsValidImage(upload_foto_2.FileBytes);
            if (upload_foto_2.HasFile && (fileType == ".jpeg" || fileType == ".jpg" || fileType == ".png") && isValid && filesize <= 20)
            {
                Random rastgele = new Random();
                Int32 sayi = rastgele.Next(100000, 999999);

                string ara_ver = Session["kullanici_var_mi"].ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + sayi.ToString() + "_" + upload_foto_2.FileName;

                upload_foto_2.SaveAs(Server.MapPath("Content/Files/" + ara_ver));

                Session["file_path_2"] = ara_ver;

                btn_goster_2.Enabled = true;
                btn_sil_2.Enabled = true;
                btn_kaydet_2.Enabled = false;

                string CloseWindow;
                CloseWindow = "alert('Belge sisteme yüklenmiştir...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir dosya türü seçiniz ve dosya boyutunun 20 Mb ile sınırlı olduğunu unutmayınız..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_kaydet_3_Click(object sender, EventArgs e)
        {
            string fileType = Path.GetExtension(upload_foto_3.FileName).ToLower();
            double filesize = Convert.ToDouble(upload_foto_3.PostedFile.ContentLength) / 1048576.0; // mb cinsinden
            bool isValid = IsValidImage(upload_foto_3.FileBytes);
            if (upload_foto_3.HasFile && (fileType == ".jpeg" || fileType == ".jpg" || fileType == ".png") && isValid && filesize <= 20)
            {
                Random rastgele = new Random();
                Int32 sayi = rastgele.Next(100000, 999999);

                string ara_ver = Session["kullanici_var_mi"].ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + sayi.ToString() + "_" + upload_foto_3.FileName;

                upload_foto_3.SaveAs(Server.MapPath("Content/Files/" + ara_ver));

                Session["file_path_3"] = ara_ver;

                btn_goster_3.Enabled = true;
                btn_sil_3.Enabled = true;
                btn_kaydet_3.Enabled = false;

                string CloseWindow;
                CloseWindow = "alert('Belge sisteme yüklenmiştir...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir dosya türü seçiniz ve dosya boyutunun 20 Mb ile sınırlı olduğunu unutmayınız..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        public static bool IsValidImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    System.Drawing.Image.FromStream(ms);
                }

            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        protected void btn_sil_1_Click(object sender, EventArgs e)
        {
            Session["file_path_1"] = null;
            btn_kaydet_1.Enabled = true;
            btn_goster_1.Enabled = false;
            btn_sil_1.Enabled = false;
        }

        protected void btn_sil_2_Click(object sender, EventArgs e)
        {
            Session["file_path_2"] = null;
            btn_kaydet_2.Enabled = true;
            btn_goster_2.Enabled = false;
            btn_sil_2.Enabled = false;
        }

        protected void btn_sil_3_Click(object sender, EventArgs e)
        {
            Session["file_path_3"] = null;
            btn_kaydet_3.Enabled = true;
            btn_goster_3.Enabled = false;
            btn_sil_3.Enabled = false;
        }

        protected void btn_goster_1_Click(object sender, EventArgs e)
        {
            string git = "~/Content/Files/" + Session["file_path_1"].ToString();
            Response.Redirect(git);
        }

        protected void btn_goster_2_Click(object sender, EventArgs e)
        {
            string git = "~/Content/Files/" + Session["file_path_2"].ToString();
            Response.Redirect(git);
        }

        protected void btn_goster_3_Click(object sender, EventArgs e)
        {
            string git = "~/Content/Files/" + Session["file_path_3"].ToString();
            Response.Redirect(git);
        }
    }
}