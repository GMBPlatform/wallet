using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
namespace TXClient.util
{
    public class WebApi
    {
        string ParseData;
        string data;
        string url;
        public JObject res;
        public WebApi(string url, string data, string ParseData)
        {
            this.data = data;
            this.url = url;
            this.ParseData = ParseData;

            if (ParseData == "Function")
            {

            }
            else if (ParseData == null)
            {
                StringApi();
            }
            else
            {
                JsonApi();
            }
        }
        public void StringApi()
        {

        }
        public void JsonApi()
        {
            res = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            byte[] bytes = Encoding.ASCII.GetBytes(data);
            request.ContentLength = bytes.Length;

            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(bytes, 0, bytes.Length);
            }

            string responseText = string.Empty;


            using (WebResponse resp = request.GetResponse())
            {

                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }
            }
            this.res = JObject.Parse(responseText);
        }

        public decimal GetBalance(byte[] key)
        {
            string ApiUrl = new config.Define().BlockexplorerApiUrl + new config.Define().ApiItemBalance;
            JObject ResApi = new WebApi(ApiUrl, new TypeCast().ByteArrayToHexString(key), "Balance").res;
            return Convert.ToDecimal(ResApi["balance"].ToString());
        }

        public structs.KeyGenerate KeyGenerate(string data)
        {
            structs.KeyGenerate tmp = new structs.KeyGenerate();
            string ApiUrl = new config.Define().BlockexplorerApiUrl + new config.Define().ApiItemKeyGenerate;
            JObject ResApi = new WebApi(ApiUrl, data, "KeyGenerate").res;

            tmp.PrivateKeyStr = ResApi["privateKey"].ToString();
            tmp.PublicKeyStr = ResApi["publicKey"].ToString();
            tmp.RandomNumber = ResApi["randomNumber"].ToString();

            return tmp;
        }
    }
}

