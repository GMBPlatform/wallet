using Newtonsoft.Json.Linq;
using System;
using System.Net;
namespace TXClient.util
{
    public class Gps
    {
        public string GetJsonString()
        {
            string s = "";
            try
            {
                var client = new WebClient();
                s = client.DownloadString(new config.Define().GpsApiUrl);
            }
            catch
            {
            }
            return s;
        }
        public JObject GetJsonObj()
        {
            JObject GpsJsonObj = null;
            try
            {
                string s = null;
                var client = new WebClient();
                s = client.DownloadString(new config.Define().GpsApiUrl);

                GpsJsonObj = JObject.Parse(s);
            }
            catch
            {
                GpsJsonObj = null;
            }
            return GpsJsonObj;
        }
        public JObject GetHexJsonObj(JObject GpsJsonObj)
        {
            JObject Jobj_GPS = null;
            try
            {
                string[] lat = GpsJsonObj["lat"].ToString().Split('.'); ;
                //lat[0] = Int32.Parse(lat[0].ToString()).ToString("X");
                //lat[1] = Int32.Parse(lat[1].Substring(0, 2)).ToString("X");

                string[] lon = GpsJsonObj["lon"].ToString().Split('.'); ;
                //lon[0] = Int32.Parse(lon[0].ToString()).ToString("X");
                //lon[1] = Int32.Parse(lon[1].Substring(0, 2)).ToString("X");

                JArray Jarr = new JArray();

                Jobj_GPS = new JObject();
                //string GpsRes = lat[0] + lat[1] + lon[0] + lon[1];
                //Jobj_GPS["GPS"] = "0x" + GpsRes;
                string latitude = lat[0] + "." + lat[1];
                string longitude = lon[0] + "." + lon[1];
                Jobj_GPS["latitude"] = latitude;
                Jobj_GPS["longitude"] = longitude;


            }
            catch
            {
                Jobj_GPS = null;
            }
            return Jobj_GPS;
        }
        public string GetCountryCodeString(JObject GpsJsonObj)
        {
            string res = "";
            try
            {
                res = GpsJsonObj["countryCode"].ToString(); ;
            }
            catch
            {
                res = "";
            }
            return res;
        }
        public string GetCountryString(JObject GpsJsonObj)
        {
            string res = "";
            try
            {
                res = GpsJsonObj["country"].ToString(); ;
            }
            catch
            {
                res = "";
            }
            return res;
        }
        public string GetCityString(JObject GpsJsonObj)
        {
            string res = "";
            try
            {
                res = GpsJsonObj["city"].ToString(); ;
            }
            catch
            {
                res = "";
            }
            return res;
        }
    }
}
