using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Noodle.model.action
{
    public class AESCrypt
    {
        private static readonly byte[] key = Encoding.UTF8.GetBytes("La llave es mas larga que ellos.");
        private static readonly byte[] iv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        public static byte[] Encrypt(string input) 
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            
                
            return Encrypt(bytes);
        }

  

        private static byte[] Encrypt(byte[] plainBytes) 
        {
            byte[] encryptedBytes = null;

            using (Aes aes = Aes.Create())
            { 
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform encryptor = aes.CreateEncryptor()) 
                {
                    encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                }
            } 

            return encryptedBytes;
        }

        public static string Decrypt(byte[] cipherBytes)
        {
            byte[] decryptedBytes = null;

            using(Aes aes = Aes.Create()) 
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0 , cipherBytes.Length);
                }
            }
            var texto = Encoding.UTF8.GetString(decryptedBytes);
            return texto;
        }


    }
}
