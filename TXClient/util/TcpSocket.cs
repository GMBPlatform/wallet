using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TXClient.util
{
    public class TcpSocket
    {
        public byte[] StringToByte(string str)
        {
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            return StrByte;
        }
        public int Run(string IP, int PORT, string data)
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ipaddr = IPAddress.Parse(IP);
                IPEndPoint ipEndPoint = new IPEndPoint(ipaddr, PORT);


                socket.Connect(ipEndPoint);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, true);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, true);
                socket.NoDelay = true;
                socket.SendBufferSize = 16384;

                byte[] senddata = new byte[Encoding.UTF8.GetBytes(data).Length + 2];
                Array.Copy(BitConverter.GetBytes(Encoding.UTF8.GetBytes(data).Length), 0, senddata, 0, 2);
                Array.Copy(Encoding.UTF8.GetBytes(data), 0, senddata, 2, Encoding.UTF8.GetBytes(data).Length);

                socket.Send(senddata, Encoding.UTF8.GetBytes(data).Length + 2, 0);

                byte[] ReceiveMsg = new byte[1024];
                socket.Receive(ReceiveMsg);

                socket.Close();

                string ResJson = Encoding.ASCII.GetString(ReceiveMsg).Trim('\0');

                JObject jobj = JObject.Parse(ResJson);

                if (jobj["res"].ToString().Equals("success") == false)
                {
                    return -2;
                }
                if (MessageBox.Show(jobj["hash"].ToString() + "\nhash를 클립보드에 저장 하시겠습니까?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Clipboard.SetText(jobj["hash"].ToString());
                }
                return 0;
            }
            catch
            {
                return -1;
            }

        }
    }
}