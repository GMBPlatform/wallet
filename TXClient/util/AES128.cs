using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TXClient.util
{
    public class AES128
    {
        public void AESEncrypt128FILE(string inputFile, string outputFile, MainForms form)
        {

            try
            {



                UnicodeEncoding UE = new UnicodeEncoding();


                byte[] key = UE.GetBytes("test");
                byte[] solt = form.C_TYPECAST.ToByteArray("45406440774061407240644059616E67"); // ("E@d@w@a@r@d@Yang")


                FileStream fsCrypt = new FileStream(outputFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateEncryptor(key, solt),
                CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);


                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {

            }
        }
        public void AESDecrypt128FILE(string inputFile, string outputFile, MainForms form)
        {
            {
                // string password = @"aaaaaaaa"; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                // byte[] key = UE.GetBytes(password);
                byte[] key = new byte[16];
                byte[] solt = new byte[16];
                // key = form.C_ETC.ToByteArray(form.C_ETC.ToHex(form.process.PrivateKey.D.ToByteArrayUnsigned()).Substring(0, 32));
                // solt = form.C_ETC.ToByteArray(form.C_ETC.ToHex(form.process.PrivateKey.D.ToByteArrayUnsigned()).Substring(32, 32));
                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateDecryptor(key, solt),
                CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);



                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
        }

        public string AESEncrypt128(string data, MainForms form)
        {

            RijndaelManaged RijndaelCipher = new RijndaelManaged();


            byte[] PlainText = Encoding.Unicode.GetBytes(data);


            byte[] key = form.C_TYPECAST.ToByteArray("4050617373776F726420552052204C40"); // @Password U R L@
            byte[] Salt = form.C_TYPECAST.ToByteArray("45406440774061407240644059616E67");

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(key, Salt);
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(PlainText, 0, PlainText.Length);
            cryptoStream.FlushFinalBlock();

            byte[] CipherBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            string EncryptedData = Convert.ToBase64String(CipherBytes);

            return EncryptedData;
        }

        public string AESDecrypt128(string data, MainForms form)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] EncryptedData = Convert.FromBase64String(data);
            byte[] key = form.C_TYPECAST.ToByteArray("4050617373776F726420552052204C40"); // @Password U R L@
            byte[] Salt = form.C_TYPECAST.ToByteArray("40552052204C2050617373776F726440"); // @U R L Password@

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(key, Salt);
            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            MemoryStream memoryStream = new MemoryStream(EncryptedData);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

            byte[] PlainText = new byte[EncryptedData.Length];

            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            return DecryptedData;
        }


        /******************************/


        public string AESDecrypt128Files(string inputFile, MainForms form)
        {



            byte[] ShaRes = form.C_TYPECAST.ToByteArray(new util.Sha256(form.C_TYPECAST.ToByteArray("31")).res);

            byte[] m_key = new byte[16];
            Array.Copy(ShaRes, 0, m_key, 0, 16);

            byte[] m_Salt = new byte[16];
            Array.Copy(ShaRes, 16, m_Salt, 0, 16);
            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
            RMCrypto.CreateDecryptor(m_key, m_Salt),
            CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(inputFile + "test", FileMode.Create);

            MemoryStream memoryStream = new MemoryStream();

            //CryptoStream cryptoStream = new CryptoStream(memoryStream, RMCrypto.CreateDecryptor(m_key, m_Salt), CryptoStreamMode.Read);
            //byte[] PlainText = new byte[256];
            //int DecryptedCount = cs.Read(PlainText, 0, PlainText.Length);
            // int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);
            //string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);


            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);

            //memoryStream.Close();
            //cryptoStream.Close();


            fsOut.Close();
            cs.Close();
            fsCrypt.Close();
            return "";
            // Stream dest = new Stream();
            // byte[] buffer = new byte[2048];
            // 
            // int data;
            // while ((data = cs.ReadByte()) != -1)
            //     // fsOut.WriteByte((byte)data);
            //     dest.Write(buffer, 0, (byte)data);
            //

            // return "";

        }

        public string AESEncrypt128ForKeyFile(string data, string KeyPassword, MainForms form)
        {

            RijndaelManaged RijndaelCipher = new RijndaelManaged();


            byte[] PlainText = Encoding.Unicode.GetBytes(data);

            byte[] ShaRes = form.C_TYPECAST.ToByteArray(new Sha256(form.C_TYPECAST.ToByteArray("45406440774061407240644059616E67")).res);// sha256 {("E@d@w@a@r@d@Yang").to byte array}

            byte[] m_key = new byte[16];
            Array.Copy(ShaRes, 0, m_key, 0, 16);

            byte[] m_Salt = new byte[16];
            Array.Copy(ShaRes, 16, m_Salt, 0, 16);

            ShaRes = null;

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(m_key, m_Salt);
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(PlainText, 0, PlainText.Length);
            cryptoStream.FlushFinalBlock();

            byte[] CipherBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            return Convert.ToBase64String(CipherBytes);
        }

    }
}
