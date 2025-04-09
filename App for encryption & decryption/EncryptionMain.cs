using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;



namespace App_for_encryption___decryption
{
    internal class EncryptionMain
    {
        public class EncryptionManager
        {
            // Encrypts the plain text using the provided key
            public string EncryptText(string plainText, string key)
            {
                try
                {
                    // Convert the key and plaintext into bytes
                    byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                    // Ensure key length is exactly 16 bytes (128-bit key for AES)
                    if (keyBytes.Length != 16)
                        throw new Exception("Key must be 16 characters long.");

                    // Create AES encryptor
                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = keyBytes;

                        // Use a fixed IV for simplicity 
                        aes.IV = new byte[16]; // 16 bytes of zero

                        using (var encryptor = aes.CreateEncryptor())
                        {
                            byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                            return Convert.ToBase64String(encryptedBytes); // Return Base64 for display
                        }
                    }
                }
                catch (Exception ex)
                {
                    // If anything goes wrong, return the error message
                    throw new Exception("Encryption failed: " + ex.Message);
                }
            }
        }
    }
}
