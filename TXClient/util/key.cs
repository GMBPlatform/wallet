using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace TXClient.util
{
    public class key
    {
        MainForms MainForm = null;
        public void Init(MainForms m)
        {
            MainForm = m;
        }

        public structs.Keys ReadPrivatePemFile(string KeyFile, string algorithm)
        {
            structs.Keys tmp = new structs.Keys();

            FileInfo fi = new FileInfo(KeyFile);
            if (!fi.Exists)
            {
                return tmp;
            }

            var priKeyStream = new StreamReader(KeyFile);
            var priPemReader = new Org.BouncyCastle.OpenSsl.PemReader(priKeyStream);



            var type = priPemReader.ReadObject();
            //var priKeyParameter = (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)priPemReader.ReadObject();

            if (type.GetType().Name == "AsymmetricCipherKeyPair")
            {
                tmp.CipKeyPar = (Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair)type;
                tmp.KeyPar = (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)tmp.CipKeyPar.Private;
            }
            else
            {
                tmp.KeyPar = (Org.BouncyCastle.Crypto.AsymmetricKeyParameter)type;
            }


            ECPrivateKeyParameters PrivateKey = (ECPrivateKeyParameters)tmp.KeyPar;

            ECPublicKeyParameters PublicKey = GetPublicKey(PrivateKey);

            X9ECParameters ec = SecNamedCurves.GetByName(algorithm);

            ECPoint q = PublicKey.Q;
            FpPoint fp = new FpPoint(ec.Curve, q.AffineXCoord, q.AffineYCoord);
            byte[] enc = fp.GetEncoded(true);//true : compression O , false : compression X

            tmp.PublicKeyStr = BitConverter.ToString(enc).Replace("-", "");
            tmp.PrivateKeyStr = MainForm.C_TYPECAST.ByteArrayToHexString(PrivateKey.D.ToByteArrayUnsigned());
            tmp.PublicKey = PublicKey;
            tmp.PrivateKey = PrivateKey;

            priKeyStream.Close();

            priKeyStream = null;
            priPemReader = null;
            //priKeyParameter = null;
            PrivateKey = null;
            PublicKey = null;
            ec = null;
            q = null;
            fp = null;
            enc = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return tmp;
        }
        // pri -> pub
        public ECPublicKeyParameters GetPublicKey(ECPrivateKeyParameters privKey)
        {
            ECDomainParameters ec = privKey.Parameters;
            ECPoint q = new FixedPointCombMultiplier().Multiply(ec.G, privKey.D);

            if (privKey.PublicKeyParamSet != null)
            {
                return new ECPublicKeyParameters(privKey.AlgorithmName, q, privKey.PublicKeyParamSet);
            }

            return new ECPublicKeyParameters(privKey.AlgorithmName, q, ec);
        }
        public bool PublicKeyCheckDuplication(string PublicKey)
        {
            for (int i = 0; i < MainForm.C_SAVEKEYLIST.Length; i++)
            {
                if (PublicKey == MainForm.C_SAVEKEYLIST[i].PublicKey)
                {
                    return false;
                }
            }
            return true;
        }
        public void KeySave(structs.Keys key, string path, string listpath)
        {
            StreamWriter outputFile = null;

            string ReadText = File.ReadAllText(listpath);
            int KeyIdx = 0;

            if (ReadText.Contains("[KeyList]"))
            {
                string LastLine = File.ReadLines(listpath).Last();
                KeyIdx = Int32.Parse(LastLine.Substring(3, LastLine.IndexOf("Name") - 3)) + 1;
            }
            else
            {
                outputFile = new StreamWriter(listpath, true);
                outputFile.WriteLine("[KeyList]");
                outputFile.Close();
            }

            string[] lines = {
                    "Key"+KeyIdx+"Path=" + path,
                    "Key"+KeyIdx+"Private=" + key.PrivateKeyStr,
                    "Key" +KeyIdx+"Public=" + key.PublicKeyStr,
                    "Key" +KeyIdx+"Name=" + key.PublicKeyStr.Substring(key.PublicKeyStr.Length - 5, 5) };

            outputFile = new StreamWriter(listpath, true);

            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }

            outputFile.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public structs.SaveKeyList[] KeyListUpdate(string path)
        {

            string[] lines = File.ReadAllLines(path);
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {


                structs.SaveKeyList[] tmp = new structs.SaveKeyList[0];
                int keynum = 0;
                foreach (string LineText in lines)
                {

                    if (LineText.Contains("Path="))
                    {
                        Array.Resize(ref tmp, tmp.Length + 1);
                        tmp[keynum].Path = LineText.Substring(LineText.IndexOf("Path=") + 5, LineText.Length - (LineText.IndexOf("Path=") + 5));
                    }
                    else if (LineText.Contains("Private="))
                    {
                        tmp[keynum].PrivateKey = LineText.Substring(LineText.IndexOf("Private=") + 8, LineText.Length - (LineText.IndexOf("Private=") + 8));
                    }
                    else if (LineText.Contains("Public="))
                    {
                        tmp[keynum].PublicKey = LineText.Substring(LineText.IndexOf("Public=") + 7, LineText.Length - (LineText.IndexOf("Public=") + 7));
                    }
                    else if (LineText.Contains("Name="))
                    {
                        tmp[keynum].Name = LineText.Substring(LineText.IndexOf("Name=") + 5, LineText.Length - (LineText.IndexOf("Name=") + 5));
                        keynum++;
                    }

                }
                return tmp;
            }
        }
        public structs.Keys signer(ECPrivateKeyParameters PrivateKey, byte[] data)
        {

            structs.Keys tmp = new structs.Keys(); ;
            ECDsaSigner signer = new ECDsaSigner();

            signer.Init(true, PrivateKey);

            BigInteger[] sigs = signer.GenerateSignature(data);

            int sigLen;
            int pos1 = 0;
            int pos2 = 0;

            // Signature R
            sigLen = 32;
            pos1 = 0;
            pos2 = 0;
            byte[] SigR = new byte[sigLen];


            if (MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[0].ToByteArrayUnsigned())).Length < SigR.Length)
            {
                sigLen = MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[0].ToByteArrayUnsigned())).Length;
                pos2 = SigR.Length - MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[0].ToByteArrayUnsigned())).Length;
            }
            else if (MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[0].ToByteArrayUnsigned())).Length > SigR.Length)
            {
                pos1 = MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[0].ToByteArrayUnsigned())).Length - SigR.Length;
            }
            else
            {

            }
            Array.Copy(MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[0].ToByteArrayUnsigned())), pos1, SigR, pos2, sigLen);

            // Signature S
            sigLen = 32;
            pos1 = 0;
            pos2 = 0;
            byte[] SigS = new byte[sigLen];

            if (MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[1].ToByteArrayUnsigned())).Length < SigS.Length)
            {
                sigLen = MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[1].ToByteArrayUnsigned())).Length;
                pos2 = SigS.Length - MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[1].ToByteArrayUnsigned())).Length;
            }
            else if (MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[1].ToByteArrayUnsigned())).Length > SigS.Length)
            {
                pos1 = MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[1].ToByteArrayUnsigned())).Length - SigS.Length;
            }
            else
            {

            }
            Array.Copy(MainForm.C_TYPECAST.ToByteArray(MainForm.C_TYPECAST.ByteArrayToHexString(sigs[1].ToByteArrayUnsigned())), pos1, SigS, pos2, sigLen);

            tmp.SigR = SigR; // ECDSA R
            tmp.SigS = SigS; // ECDSA S

            return tmp;
        }
        public bool KeyDel(int DelIdx, string KeyFilePath)
        {
            List<string> lines = new List<string>();

            using (TextReader tReader = new StreamReader(KeyFilePath))
            {
                string line = string.Empty;
                while ((line = tReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                if (lines.Count == 0)
                {
                    //MessageBox.Show("Deletable key does not exist.");
                    return false;
                }
                for (int i = lines.Count - 1; i >= 0; i--)
                {

                    if (lines[i].Contains("Key" + DelIdx + "Name"))
                    {
                        lines.RemoveAt(i);
                    }
                    else if (lines[i].Contains("Key" + DelIdx + "Public"))
                    {
                        lines.RemoveAt(i);
                    }
                    else if (lines[i].Contains("Key" + DelIdx + "Private"))
                    {
                        lines.RemoveAt(i);
                    }
                    else if (lines[i].Contains("Key" + DelIdx + "Path"))
                    {
                        lines.RemoveAt(i);
                    }
                }
                if (lines.Count == 1)
                {
                    lines.RemoveAt(0);
                }
            }
            using (TextWriter tWriter = new StreamWriter(KeyFilePath))
            {
                foreach (var line in lines)
                {
                    tWriter.WriteLine(line);
                }
            }
            lines.Clear();
            lines = null;
            KeyFileIdxRefresh(DelIdx, KeyFilePath);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return true;
        }
        // Functions to be executed after KeyDel
        public void KeyFileIdxRefresh(int DelIdx, string KeyFilePath)
        {
            string[] linesd = File.ReadAllLines(KeyFilePath);
            using (TextWriter tWriters = new StreamWriter(KeyFilePath))
            {

                int KeyNum = DelIdx + 1;

                foreach (string LineText in linesd)
                {
                    string tmp_str = LineText;
                    if (LineText.Contains("Key" + KeyNum + "Path"))
                    {
                        tmp_str = LineText.Replace("Key" + KeyNum + "Path", "Key" + (KeyNum - 1).ToString() + "Path");
                    }
                    else if (LineText.Contains("Key" + KeyNum + "Private"))
                    {
                        tmp_str = LineText.Replace("Key" + KeyNum + "Private", "Key" + (KeyNum - 1).ToString() + "Private");
                    }
                    else if (LineText.Contains("Key" + KeyNum + "Public"))
                    {
                        tmp_str = LineText.Replace("Key" + KeyNum + "Public", "Key" + (KeyNum - 1).ToString() + "Public");
                    }
                    else if (LineText.Contains("Key" + KeyNum + "Name"))
                    {
                        tmp_str = LineText.Replace("Key" + KeyNum + "Name", "Key" + (KeyNum - 1).ToString() + "Name");
                        KeyNum++;
                    }
                    tWriters.WriteLine(tmp_str);

                }
            }
        }
        public void KeyFileNameChange(int KeyIdx, string KeyFile)
        {
            string[] linesd = File.ReadAllLines(KeyFile);
            using (TextWriter tWriters = new StreamWriter(KeyFile))
            {

                foreach (string LineText in linesd)
                {
                    string tmp_str = LineText;

                    if (LineText.Contains("Key" + KeyIdx + "Name"))
                    {
                        int StrSize = ("Key" + KeyIdx + "Name=").Length;

                        tmp_str = LineText.Replace(LineText.Substring(StrSize, LineText.Length - StrSize), MainForm.F_KEYNAMECHANGE.Txt_change.Text);
                    }
                    tWriters.WriteLine(tmp_str);
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}