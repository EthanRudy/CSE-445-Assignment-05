using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Controls;
using WebApplication.LocalComponents;

namespace WebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Do nothing rn
        }

        // COOKIE MANAGEMENT
        protected void btnSaveCookie_Click(object sender, EventArgs e)
        {
            string name = txtCookieName.Text.Trim();
            string color = txtCookieColor.Text.Trim();

            CookieManager.SaveUserProfile(name, color);
            lblCookieResult.Text = "Cookie saved successfully!";
        }

        protected void btnReadCookie_Click(object sender, EventArgs e)
        {
            var (name, color) = CookieManager.ReadUserProfile();

            if (name == "" && color == "")
            {
                lblCookieResult.Text = "No cookie found";
            }
            else
            {
                lblCookieResult.Text = $"Name: {name} | Favorite Color: {color}";
            }
        }

        protected void btnDeleteCookie_Click(object sender, EventArgs e)
        {
            CookieManager.DeleteUserProfile();
            lblCookieResult.Text = "Cookie deleted successfully";
        }

        // CAPTCHA MANAGEMENT

        protected void btnVerifyCaptcha_Click(object sender, EventArgs e)
        {
            if (CaptchaControl.IsValid())
            {
                lblCaptchaResult.Text = "Correct :D";
            } else
            {
                lblCaptchaResult.Text = "Incorrect D:";
            }
        }

        protected void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            CaptchaControl.Refresh();
            lblCaptchaResult.Text = "Captcha refreshed";
        }

        protected void btnCharCount_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtCharCount.Text.Trim() ?? string.Empty;

                using (var client = new UtilityServiceRef.UtilityServiceSoapClient())
                {
                    int count = client.CountCharacters(input);
                    lblCharCount.Text = $"Character Count: {count}";
                }
            }
            catch (Exception ex)
            {
                lblCharCount.Text = $"Error: {ex.Message}";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string num1 = txtNum1.Text.Trim();
                string num2 = txtNum2.Text.Trim();

                using (var client = new UtilityServiceRef.UtilityServiceSoapClient())
                {
                    int a = int.Parse(num1);
                    int b = int.Parse(num2);
                    int sum = client.AddIntegers(a, b);
                    lblSum.Text = $"Sum: {sum}";
                }
            }
            catch (Exception ex)
            {
                lblSum.Text = $"Error: {ex.Message}";
            }
        }

        protected void btnRevString_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtRevString.Text.Trim() ?? string.Empty;

                using (var client = new UtilityServiceRef.UtilityServiceSoapClient())
                {
                    string reversed = client.ReverseString(input);
                    lblRevString.Text = $"Reversed String: {reversed}";
                }
            }
            catch (Exception ex)
            {
                lblSum.Text = $"Error: {ex.Message}";
            }
        }
    }
}