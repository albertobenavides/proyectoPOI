using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatPOI
{
    class ClientConection
    {
        static TcpClient _clientSocket = new TcpClient();
        static NetworkStream serverStream = default(NetworkStream);

        private const int _PORT = 55555;

        public static void ConnectToServer(string username)
        {
            while (!_clientSocket.Connected)
            {
                IPAddress myIP = IPAddress.Parse("0.0.0.0");

                IPAddress[] localIP = Dns.GetHostAddresses("Alberto-PC");
                foreach (IPAddress address in localIP)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        myIP = address;
                    }
                }
                try
                {
                    _clientSocket.Connect(myIP, _PORT);
                    serverStream = _clientSocket.GetStream();
                    SendString(username + "$");

                    Thread thread = new Thread(getMessage);
                    thread.Start();
                }
                catch (SocketException)
                {
                    return;
                }
            }
        }


        public static void Exit()
        {
            SendString("$exit$");
            _clientSocket.Close();
            Environment.Exit(0);
        }

        public static void SendString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            serverStream.Write(buffer, 0, buffer.Length);
            serverStream.Flush();
        }

        public static void getMessage()
        {
            while (true)
            {
                serverStream = _clientSocket.GetStream();
                int bufferSize = 0;
                var buffer = new byte[10025];
                bufferSize = _clientSocket.ReceiveBufferSize;
                var data = new byte[10025];
                serverStream.Read(buffer, 0, bufferSize);

                Array.Copy(buffer, data, bufferSize);

                globals.receivedText = Encoding.UTF8.GetString(data);
            }
             
        }
    }
}
