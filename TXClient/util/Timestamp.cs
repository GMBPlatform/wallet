
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TXClient.util
{
    public class Timestamp
    {
        public int ResInt;
        public string ResStr;
        public Timestamp(string kind)
        {
            if (kind == "NowInt")
            {
                Timestamp_For_Int();
            }
            else if (kind == "yyyyMMddHHmmss")
            {
                yyyyMMddHHmmss();
            }
        }
        public void Timestamp_For_Int()
        {
            var now = DateTime.Now.ToLocalTime();
            var span = now - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();

            ResInt = (int)span.TotalSeconds;
        }

        public void yyyyMMddHHmmss()
        {
            ResStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}