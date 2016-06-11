using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utalca.Utils
{
    public class MensajesUI
    {
        public static void SetError(string error)
        {
            HttpContext.Current.Session.Add("Error", error);
        }

        public static string ObtieneUltimoError()
        {
            var error = HttpContext.Current.Session["Error"];
            if (error != null)
            {
                HttpContext.Current.Session.Clear();
                return error.ToString();
            }
            else
                return string.Empty;
        }
    }
}