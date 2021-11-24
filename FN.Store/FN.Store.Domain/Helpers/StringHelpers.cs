using System;
using System.Security.Cryptography;
using System.Text;

namespace FN.Store.Domain.Helpers
{
    public static class StringHelpers
    {
        public static string Encrypt(this string senha)
        {
            var salt = "|D3CC3CE894D04CBD876FDDFE6450BDB25122DB5A04414D5DBA27A0B131F757C8";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
