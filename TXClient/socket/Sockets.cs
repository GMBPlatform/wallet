using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace TXClient
{
    public class Sockets
    {
        public class IDX
        {
            public string m_IP;
            public Int32 m_PORT;
            public bool res;

            Socket m_socket = null;
            IPEndPoint m_ipEndPoint = null;
            static Int32 m_BufferSizes = 10000;





            void setting()
            {
                m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                m_ipEndPoint = new IPEndPoint(IPAddress.Parse(m_IP), m_PORT);
                m_socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, true);
                m_socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, true);
                m_socket.SendBufferSize = m_BufferSizes;

                //TcpClient cli = new TcpClient(new IPEndPoint(IPAddress.Any, 1234));
                //m_socket.LocalEndPoint.Create(m_socket);

            }
            public IDX(JObject gps, SCN scn_info)
            {
                try
                {
                    if (gps == null)
                    {
                        MessageBox.Show("I failed to get the gps information..");
                        Application.Exit();
                    }
                    string[] linesd = File.ReadAllLines(new config.Define().IsInfoFilePath);

                    foreach (string LineText in linesd)
                    {
                        string tmp_str = LineText;
                        if (LineText.Contains("IP"))
                        {
                            m_IP = LineText.Replace("IP=", "");
                        }
                        else if (LineText.Contains("PORT"))
                        {
                            m_PORT = Convert.ToInt32(LineText.Replace("PORT=", ""));
                        }
                    }

                    if (m_IP == null)
                    {
                        res = false;
                    }
                    else if (m_PORT == 0)
                    {
                        res = false;
                    }

                    //JObject jobj_WALLET = new JObject();
                    //jobj_WALLET["WALLET"] = gps;

                    string json = gps.ToString(Formatting.None);


                    setting();
                    m_socket.Connect(m_ipEndPoint);


                    byte[] ResSendData = new byte[Encoding.UTF8.GetBytes(json).Length];
                    Array.Copy(Encoding.UTF8.GetBytes(json), 0, ResSendData, 0, Encoding.UTF8.GetBytes(json).Length);

                    m_socket.Send(ResSendData, Encoding.UTF8.GetBytes(json).Length, 0);

                    byte[] ReceiveMsg = new byte[1024];
                    m_socket.Receive(ReceiveMsg);

                    string ResJson = Encoding.ASCII.GetString(ReceiveMsg).Trim('\0');

                    JObject jobj = JObject.Parse(ResJson);

                    scn_info.m_IP = jobj["ip"].ToString();
                    scn_info.m_PORT = Convert.ToInt32(jobj["port"].ToString());

                    m_socket.Close();

                    res = true;
                }
                catch
                {
                    res = false;
                }
            }
        }
        public class SCN
        {

            public string m_IP;
            public Int32 m_PORT;

            Socket m_socket = null;
            IPEndPoint m_ipEndPoint = null;
            static Int32 m_BufferSizes = 10000;



            void setting()
            {
                m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                m_ipEndPoint = new IPEndPoint(IPAddress.Parse(m_IP), m_PORT);
                m_socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, true);
                m_socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, true);
                m_socket.SendBufferSize = m_BufferSizes;
            }
            public bool send(string Data)
            {
                try
                {
                    setting();

                    m_socket.Connect(m_ipEndPoint);

                    byte[] ResSendData = new byte[Encoding.UTF8.GetBytes(Data).Length + 2];
                    Array.Copy(BitConverter.GetBytes(Encoding.UTF8.GetBytes(Data).Length), 0, ResSendData, 0, 2);
                    Array.Copy(Encoding.UTF8.GetBytes(Data), 0, ResSendData, 2, Encoding.UTF8.GetBytes(Data).Length);

                    m_socket.Send(ResSendData, Encoding.UTF8.GetBytes(Data).Length + 2, 0);

                    byte[] ReceiveMsg = new byte[m_BufferSizes];
                    m_socket.Receive(ReceiveMsg);
                    m_socket.Close();

                    string ResJson = Encoding.ASCII.GetString(ReceiveMsg).Trim('\0');

                    JObject jobj = JObject.Parse(ResJson);

                    if (jobj["res"].ToString().Equals("success") == true)
                    {
                        if (MessageBox.Show(jobj["hash"].ToString() + "\nDo you want to save the hash to the clipboard??", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Clipboard.SetText(jobj["hash"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("SCN connection failed" + jobj["message"].ToString());
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("SCN connection failed");
                    return false;
                }
                return true;
            }

        }
    }
}
