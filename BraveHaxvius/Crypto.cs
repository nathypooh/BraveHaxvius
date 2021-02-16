using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BraveHaxvius
{
    public class Crypto
    {
        public static String OldDecrypt(String data, String key)
        {
            return Crypt(data, key, false, true);
        }
        public static String Decrypt(String data, String key)
        {
            return Crypt(data, key, false);
        }
        public static String Encrypt(String data, String key)
        {
            return Crypt(data, key, true);
        }

        public static String Crypt(String data, String key, Boolean encrypt, [System.Runtime.InteropServices.Optional] Boolean isContext )
        {
            string Padding(string a) => encrypt ? a.PadRight(a.Length + (16 - a.Length % 16), (char)(16 - a.Length % 16)): a.Trim((char)(isContext ? 0:a.Last()));
            string iv = "dZMjkk8gFDzKHlsx";
            var ivBytes = Encoding.UTF8.GetBytes(iv);

            var keyBytes = new Byte[16];
            Array.Copy(Encoding.UTF8.GetBytes(key), keyBytes, key.Length);
            var aes = isContext ?
                        new AesManaged { Mode = CipherMode.ECB, Key = keyBytes, Padding = PaddingMode.PKCS7 } :
                        new AesManaged { Mode = CipherMode.CBC, Key = keyBytes, IV = ivBytes };
            Byte[] uncryptedBytes = encrypt ? Encoding.UTF8.GetBytes(Padding(data)) : Convert.FromBase64String(data);
            ICryptoTransform transform = encrypt ? aes.CreateEncryptor() : aes.CreateDecryptor();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                    cryptoStream.Write(uncryptedBytes, 0, uncryptedBytes.Length);
                return encrypt ? Convert.ToBase64String(memoryStream.ToArray()) : Padding(Encoding.UTF8.GetString(memoryStream.ToArray()));
            }
        }
    }
}
