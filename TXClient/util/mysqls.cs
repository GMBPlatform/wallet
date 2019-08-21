using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Text.RegularExpressions;
namespace TXClient.util
{
    public class mysqls
    {
        MySqlConnection conn = null;
        public bool DbCon()
        {
            try
            {
                string strconn =
                    "Server=203.238.181.176;" +
                    "Database=SCA_test;" +
                    "Uid=root;" +
                    "Pwd=MoFAS15243%!$@#;";

                conn = new MySqlConnection(strconn);

                conn.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public int DB_GetAmount(string PubKey)
        {
            //string topkSelect = "SELECT amount FROM `transfer` WHERE topk = '" + PubKey + "';";
            //string frompkSelect = "SELECT amount FROM `transfer` WHERE frompk = '" + PubKey + "';";
            ////본인의 DB이름
            //MySqlCommand cmd = new MySqlCommand(topkSelect, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();
            //int amount = 0;
            //while (rdr.Read())
            //{
            //    amount = amount + Convert.ToInt32(rdr["topk"].ToString());
            //}
            //
            //MySqlCommand cmd = new MySqlCommand(topkSelect, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();
            //int amount = 0;
            //while (rdr.Read())
            //{
            //    amount = amount + Convert.ToInt32(rdr["topk"].ToString());
            //}
            return 0;
        }

    }
}
