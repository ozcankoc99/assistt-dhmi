using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Dhmi.Web
{
    public class Rastgele
    {
        static string path;

        public static string RastGetir()
        {
            path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path;
        }
    }
}