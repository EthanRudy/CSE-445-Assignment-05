using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.Controls
{
    public partial class Captcha : System.Web.UI.UserControl
    {
        private const string CaptchaSessionKey = "CaptchaValue";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateCaptcha();
            }
        }

        private void GenerateCaptcha()
        {
            string code = GenerateRandomCode(5);
            Session[CaptchaSessionKey] = code;
            lblCode.Text = code;
        }

        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            char[] buffer = new char[length];
            for (int i = 0; i < length; ++i)
            {
                buffer[i] = chars[rnd.Next(chars.Length)];
            }

            return new string(buffer);
        }

        public bool IsValid()
        {
            string expected = Session[CaptchaSessionKey] as string;
            string actual = txtInput.Text.Trim();

            return String.Equals(expected, actual, StringComparison.OrdinalIgnoreCase);
        }

        public void Refresh()
        {
            GenerateCaptcha();
            txtInput.Text = "";
        }


    }
}