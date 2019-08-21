using System;
using System.Security.Cryptography;
using System.Text;
namespace TXClient.util
{
    public class Sha256
    {
        public string res;
        public Sha256(string type)
        {
            Encrypt_String(type);
        }
        public Sha256(byte[] type)
        {
            Encrypt_Byte(type);
        }
        public void Encrypt_String(string Strings)
        {
            int euckrCodepage = 51949;
            Encoding encoder = Encoding.GetEncoding(euckrCodepage);

            SHA256CryptoServiceProvider sha256hasher = new SHA256CryptoServiceProvider();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(Strings));

            string hashString = string.Empty;

            foreach (byte x in hashedDataBytes)
            {
                hashString += String.Format("{0:x2}", x);
            }
            res = hashString;
        }


        public void Encrypt_Byte(byte[] Bytes)
        {

            SHA256CryptoServiceProvider sha256hasher = new SHA256CryptoServiceProvider();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(Bytes);

            string hashString = string.Empty;

            foreach (byte x in hashedDataBytes)
            {
                hashString += String.Format("{0:x2}", x);
            }
            hashedDataBytes = null;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            res = hashString;
        }
    }
}