using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace App_for_encryption___decryption
{
    internal class DecryptionMain
    {
        public static string Decrypt(string cipherText, string key)
        {
            try
            {
                // Convert key to bytes
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);

                // Create AES object
                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;
                    aes.IV = new byte[16]; // Default IV with zeros (should match encryption IV)

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    // Convert Base64 cipher to bytes
                    byte[] cipherBytes = Convert.FromBase64String(cipherText);

                    // Perform decryption
                    using (MemoryStream ms = new MemoryStream(cipherBytes))
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (StreamReader reader = new StreamReader(cs))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                // If something goes wrong, return an error message
                return $"Decryption failed: {ex.Message}";
            }
        }

    }
}
