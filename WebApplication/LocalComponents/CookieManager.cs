using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.LocalComponents
{
    public class CookieManager
    {
        // Example cookie stores the user's favorite color
        public static void SaveUserProfile(string name, string color)
        {
            // Create a new cookie and populate it with user data
            HttpCookie c = new HttpCookie("UserProfile");
            c["Name"] = name;
            c["Color"] = color;
            c.Expires = DateTime.Now.AddMinutes(30); // Cookie expires in 30 minutes

            // Add the cookie to the current web response
            HttpContext.Current.Response.Cookies.Add(c);
        }

        public static (string name, string color) ReadUserProfile()
        {
            HttpCookie c = HttpContext.Current.Request.Cookies["UserProfile"];
            if (c == null) {  return ("", ""); }
            return (c["Name"] ?? "", c["Color"] ?? "");
        }

        public static void DeleteUserProfile()
        {
            HttpCookie c = new HttpCookie("UserProfile");
            c.Expires = DateTime.Now.AddDays(-1); // Set the cookie to expire in the past
            HttpContext.Current.Response.Cookies.Add(c);
        }
    }
}