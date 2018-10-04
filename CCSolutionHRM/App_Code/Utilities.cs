using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.App_Code
{
    public class Utilities
    {
        public static string GetUserIP()
        {
            string VisitorsIPAddr = string.Empty;
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {
                VisitorsIPAddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
            {
                VisitorsIPAddr = HttpContext.Current.Request.UserHostAddress;
            }

            if (VisitorsIPAddr.IndexOf(':') > 0)
            {
                VisitorsIPAddr = VisitorsIPAddr.Split(':').GetValue(0).ToString();
            }
            return VisitorsIPAddr;
        }
    }
}