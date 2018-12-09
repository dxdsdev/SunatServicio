using System;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Criptografia
{
    public class Criptografia
    {
        //private static string KEY = "IDAT";
        private bool Disposing;

        public string Encriptar(string strValor, string KEY)
        {
            try
            {
                TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
                cryptoServiceProvider.IV = new byte[8];
                PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(KEY, new byte[0]);
                cryptoServiceProvider.Key = passwordDeriveBytes.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
                MemoryStream memoryStream = new MemoryStream(strValor.Length * 2 - 1);
                CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
                byte[] bytes = Encoding.UTF8.GetBytes(strValor);
                cryptoStream.Write(bytes, 0, bytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] numArray = new byte[Convert.ToInt32(memoryStream.Length - 1L) + 1];
                memoryStream.Position = 0L;
                memoryStream.Read(numArray, 0, Convert.ToInt32(memoryStream.Length));
                cryptoStream.Close();
                return Convert.ToBase64String(numArray);
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message.ToString();
            }
        }

        public string Desencriptar(string strValor, string KEY)
        {
            try
            {
                TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
                cryptoServiceProvider.IV = new byte[8];
                PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(KEY, new byte[0]);
                cryptoServiceProvider.Key = passwordDeriveBytes.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
                byte[] buffer = Convert.FromBase64String(strValor);
                MemoryStream memoryStream = new MemoryStream(strValor.Length);
                CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
                cryptoStream.Write(buffer, 0, buffer.Length);
                cryptoStream.FlushFinalBlock();
                byte[] numArray = new byte[Convert.ToInt32(memoryStream.Length - 1L) + 1];
                memoryStream.Position = 0L;
                memoryStream.Read(numArray, 0, Convert.ToInt32(memoryStream.Length));
                cryptoStream.Close();
                return Encoding.UTF8.GetString(numArray);
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message.ToString();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool b)
        {
            if (this.Disposing)
                return;
            this.Disposing = true;
            GC.SuppressFinalize((object)this);
        }

        ~Criptografia()
        {
            this.Dispose(true);
        }
    }
}