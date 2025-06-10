using System;
using System.Security.Cryptography;

namespace OnlineCinemaDB.utility
{
    public class CryptoService
    {
        const int keySize = 32;
        const int iterations = 32000;

        public static string HashPasword(string password, out string salt)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[keySize];
            rng.GetBytes(saltBytes);
            salt = Convert.ToBase64String(saltBytes);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations);
            byte[] hash = pbkdf2.GetBytes(keySize);

            return BitConverter.ToString(hash).Replace("-", "");
        }

        public static bool VerifyPassword(string password, string hash, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations);
            byte[] hashToCompare = pbkdf2.GetBytes(keySize);

            string hashToCompareString = BitConverter.ToString(hashToCompare).Replace("-", "");

            return hash == hashToCompareString;
        }
    }
}
