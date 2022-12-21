using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dhmi.EntityClasses;

namespace Dhmi.Web
{
    public partial class Hata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.CurrentExecutionFilePath != Request.Url.AbsolutePath)
            {
                _msg.Text = Convert.ToString(Request.QueryString["msg"]);
                string _trace = Convert.ToString(Request.QueryString["trace"]);
                int kullaniciId = 0;
                try
                {
                    if (Session["kullanici_var_mi"] != null)
                        kullaniciId = Convert.ToInt32(Session["kullanici_var_mi"]);

                    LogHataEntity hataEntity = new LogHataEntity();
                    hataEntity.FkKullaniciId = kullaniciId;
                    hataEntity.Ekran = Request.RawUrl;
                    hataEntity.Method = "";
                    hataEntity.Mesaj = _msg.Text;
                    hataEntity.Trace = _trace;
                    hataEntity.Tarih = DateTime.Now;
                    
                    hataEntity.Save();
                    _hataNo.Text = hataEntity.LogHataId.ToString() + " numaralı";
                }
                catch
                {

                }
            }
        }
    }
}