using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Models.Helpers
{
    public static class Hash
    {
        public static string GetHashSHA256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);

            string hashString = string.Empty;
            foreach (byte x in hash)
                hashString += string.Format("{0:x2}", x);

            return hashString;
        }

        public static string GenerarSalt()
        {
            var salt = "";
            var num = new Random();

            //Genera un número aleatorio de 64 dígitos
            for (int i = 0; i < 16; i++)
                salt += num.Next(1000, 9999);

            return salt;
        }
    }
}