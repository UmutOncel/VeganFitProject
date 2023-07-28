using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VeganFit.UI.UserOperation
{
    public static class PasswordHassing 
    {
        /// <summary>
        /// Kullanıcının şifresini şifrelemek için kullanılan ve bunu geri döndüren metot. (Kullanıcının şifresini database'e şifreli bir şekilde kaydederken kullanılır.)
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Sha256Hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }
    }
}
