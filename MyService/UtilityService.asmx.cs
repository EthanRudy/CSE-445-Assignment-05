using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyService
{
    /// <summary>
    /// Summary description for UtilityService
    /// </summary>
    [WebService(Namespace = "https://webstrar.fulton.asu.edu/website142")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UtilityService : System.Web.Services.WebService
    {

        public UtilityService() { }

        [WebMethod(Description = "Counts the number of characters in the input string.")]
        public int CountCharacters(string input)
        {
            if (input == null)
            {
                return 0;
            }
            return input.Length;
        }

        [WebMethod(Description = "Adds two integers and returns the sum.")]
        public int AddIntegers(int a, int b)
        {
            return a + b;
        }

        [WebMethod(Description = "Reverses the input string and returns the reversed string.")]
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

// 142