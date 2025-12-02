using LocalComponentsDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.LocalComponents;

namespace WebApplication
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Load cookie data if it exists
            var (username, encrypted_pass) = CookieManager.ReadUserProfile();
            // If it doesn't exist, do nothing
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(encrypted_pass))
            {
                return;
            }
            else
            {
                // Insert to the fields
                txtUsername.Text = username;
                txtPassword.Attributes["value"] = SecurityService.Decrypt(encrypted_pass);
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            // Collect the username
            string username = txtUsername.Text.Trim();

            // Collect and encrypt the password
            string password = txtPassword.Text.Trim();
            string encrypted_pass = SecurityService.Encrypt(password);

            // Check that the captcha is correct
            CookieManager.SaveUserProfile(username, encrypted_pass);

            /*
            if (CaptchaControl.IsValid())
            {
                //btnSignIn.Text = "CORRECT!";

                CookieManager.SaveUserProfile(username, encrypted_pass);



                
                using (var client = new ServiceReference1.UtilityServiceSoapClient())
                {
                    
                    bool isValidUser = client.ValidateMember(username, encrypted_pass);
                    if (isValidUser)
                    {

                        // Store the username and encrypted password in a cookie
                        CookieManager.SaveUserProfile(username, encrypted_pass);

                        // Swap visibility of panels
                        pnlSignIn.Visible = false;
                        pnlMain.Visible = true;
                    }
                    
                }
                

                pnlHotelList.Visible = true;
                pnlSignIn.Visible = false;
                

            }
            else
            {
                btnSignIn.Text = "Incorrect Captcha, try again";
            }
            */



        }
    }
}