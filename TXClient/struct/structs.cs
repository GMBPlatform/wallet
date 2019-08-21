using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
namespace TXClient
{
    public class structs
    {

        public struct Transaction
        {
            public int Revision; // big
            public int PreviousKeyID;// big
            public int ContractCreateTime;
            public decimal Fintech;
            public byte[] From;
            public decimal Balance;
            public decimal NotePrivacy;
            public struct Note
            {
                public byte[] To;
                public int Fee;
                public int Kind;
                public byte[] Amount;
                public byte[] Contents;
            }
            public byte[] NoteXOR;
            public byte[] Sha256Data;
            public byte[] Sha256Res;
            public string SigKeyData;// From,Privacy,To,Contents
        }
        public struct SaveKeyList
        {
            public string PublicKey;
            public string PrivateKey;
            public string Name;
            public string Path;
        }
        public struct Keys
        {
            public AsymmetricKeyParameter KeyPar;
            public AsymmetricCipherKeyPair CipKeyPar;

            public string PrivateKeyStr;
            public string PublicKeyStr;
            public string SigRStr;
            public string SigSStr;

            public ECPrivateKeyParameters PrivateKey;
            public ECPublicKeyParameters PublicKey;
            public byte[] SigR;
            public byte[] SigS;
        }
        public struct KeyGenerate
        {
            public string PrivateKeyStr;
            public string PublicKeyStr;
            public string RandomNumber;
            public string Nemonic;
            public string Password;
            public Org.BouncyCastle.Math.BigInteger BigPrivateKey;
            public ECPrivateKeyParameters PrivateKey;
            public ECPublicKeyParameters PublicKey;

        }
    }
}