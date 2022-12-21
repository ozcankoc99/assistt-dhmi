using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dhmi.CollectionClasses;

namespace Dhmi.Web
{
    public class Menu
    {
        static string sonuc;

        public static string MenuKaydet(string deger)
        {
            sonuc = deger;

            MenuCollection CollMenu = new MenuCollection();
            CollMenu.GetMulti(null);

            for (int i = 0; i < CollMenu.Count; i++)
            {
                CollMenu[i].MenuSonLink = CollMenu[i].MenuLink + deger;
                CollMenu[i].Save();
            }

            AltMenuCollection CollAMenu = new AltMenuCollection();
            CollAMenu.GetMulti(null);

            for (int j = 0; j < CollAMenu.Count; j++)
            {
                CollAMenu[j].AltMenuSonLink = CollAMenu[j].AltMenuLink + deger;
                CollAMenu[j].Save();
            }

            AltAltMenuCollection CollAAMenu = new AltAltMenuCollection();
            CollAAMenu.GetMulti(null);

            for (int k = 0; k < CollAAMenu.Count; k++)
            {
                CollAAMenu[k].AltAltMenuSonLink = CollAAMenu[k].AltAltMenuLink + deger;
                CollAAMenu[k].Save();
            }

            return sonuc;
        }

        public static string MenuKontrol(string deger)
        {
            return sonuc;
        }

        public static string AltMenuKontrol(string deger)
        {
            return sonuc;
        }

        public static string AltAltMenuKontrol(string deger)
        {
            return sonuc;
        }
    }
}