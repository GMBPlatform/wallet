using System;
using System.Text;
namespace TXClient.util
{
    public class TypeCast
    {
        public string ByteArrayToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", "");
        }
        public byte[] ToByteArray(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length / 2; i++) bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return bytes;
        }
        public byte[] StringToByte(string str)
        {
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            return StrByte;
        }
        public string IntToHex(int data)
        {
            return data.ToString("X");
        }
        public static int HexToInt(char h)
        {
            if ((h >= '0') && (h <= '9'))
            {
                return (h - '0');
            }
            if ((h >= 'a') && (h <= 'f'))
            {
                return ((h - 'a') + 10);
            }
            if ((h >= 'A') && (h <= 'F'))
            {
                return ((h - 'A') + 10);
            }
            return -1;
        }
        public string Base64Encoding(string EncodingText, Encoding oEncoding = null)
        {
            if (oEncoding == null)
                oEncoding = Encoding.UTF8;

            byte[] arr = oEncoding.GetBytes(EncodingText);
            return Convert.ToBase64String(arr);
        }

        public string Base64Decoding(string DecodingText, Encoding oEncoding = null)
        {
            if (oEncoding == null)
                oEncoding = Encoding.UTF8;

            byte[] arr = Convert.FromBase64String(DecodingText);
            return oEncoding.GetString(arr);
        }
        public byte[] XOR(byte[] arr1, byte[] arr2)
        {
            byte[] arry1_tmp = arr1;
            byte[] arry2_tmp = arr2;
            int arr1_Len = 0;
            int arr2_Len = 0;

            if (arry1_tmp == null)
            {

                arr2_Len = arr2.Length;
                arry1_tmp = new byte[arr2_Len];
                arr1_Len = arr2_Len;
            }
            else if (arry2_tmp == null)
            {

                arr1_Len = arr1.Length;
                arry2_tmp = new byte[arr1_Len];
                arr2_Len = arr1_Len;
            }
            else
            {
                arr1_Len = arr1.Length;
                arr2_Len = arr2.Length;

                if (arr1_Len > arr2_Len)
                {
                    arry2_tmp = new byte[arr1_Len];
                    Array.Copy(arr2, 0, arry2_tmp, 0, arr2_Len);
                }
                else if (arr1_Len < arr2_Len)
                {
                    arry1_tmp = new byte[arr2_Len];
                    Array.Copy(arr1, 0, arry1_tmp, 0, arr1_Len);
                }
            }



            byte[] Res = new byte[arr1_Len];

            for (int i = 0; i < arr1_Len; ++i)
                Res[i] = (byte)(arry1_tmp[i] ^ arry2_tmp[i]);

            return Res;
        }

    }
}