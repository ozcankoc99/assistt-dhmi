using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dhmi.CollectionClasses;

namespace Dhmi.Web
{
    public partial class deneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VatandaCollection CollBil = new VatandaCollection();
            CollBil.GetMulti(null);

            for (int i = 0; i < CollBil.Count; i++) 
            {
                string deger1 = CollBil[i].VatandasTel1;
                string deger2 = CollBil[i].VatandasTel2;
                string deger3 = CollBil[i].VatandasFax;

                CollBil[i].VatandasTel1 = deger1.Trim().Replace(" ", string.Empty);
                CollBil[i].VatandasTel2 = deger2.Trim().Replace(" ", string.Empty);
                CollBil[i].VatandasFax = deger3.Trim().Replace(" ", string.Empty); 
                CollBil[i].Save();
            }
        }
    }
}