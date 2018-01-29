using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.Function
{
    public static class OneSecurity
    {
        public static string SecurityKey = "CDMSMD5";

        /// <summary>
        /// เข้ารหัส
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <returns></returns>
        public static string Encryption(string toEncrypt)
        {
            try
            {
                byte[] keyArray;
                var toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
                hashmd5.Clear();

                var tdes = new TripleDESCryptoServiceProvider() { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };

                var cTransform = tdes.CreateEncryptor();
                var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// ถอดรหัส
        /// </summary>
        /// <param name="cipherString"></param>
        /// <returns></returns>
        public static string Decryption(string cipherString)
        {
            try
            {
                byte[] keyArray;
                var toEncryptArray = Convert.FromBase64String(cipherString);

                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
                hashmd5.Clear();

                var tdes = new TripleDESCryptoServiceProvider() { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };

                var cTransform = tdes.CreateDecryptor();
                var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                tdes.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
