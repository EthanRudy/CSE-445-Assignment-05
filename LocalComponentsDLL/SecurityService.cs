using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace LocalComponentsDLL
{
    public static class SecurityService
    {

        private static readonly byte[] Key = Encoding.UTF8.GetBytes("TotallyRandomKeyTotallyRandomKey");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("TotallyRandomVec");

        public static string Encrypt(string plainText)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (var sw = new StreamWriter(cs, Encoding.UTF8))
                {
                    sw.Write(plainText);
                    sw.Flush();
                    cs.FlushFinalBlock();

                    byte[] cipherBytes = ms.ToArray();
                    return Convert.ToBase64String(cipherBytes);
                }

            }
        }

        public static string Decrypt(string cipherTextBase64)
        {
            byte[] cipherBytes;
           
            
            try
            {
                cipherBytes = Convert.FromBase64String(cipherTextBase64);
            }
            catch
            {
                // Not valid Base64; treat as not-encrypted text.
                return cipherTextBase64;
            }

            using (var aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var ms = new MemoryStream(cipherBytes))
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs, Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
