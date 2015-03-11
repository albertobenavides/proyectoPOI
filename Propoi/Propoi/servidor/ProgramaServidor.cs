using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace Servidor
{
    class ProgramaServidor
    {
        static Socket _serversocket;
        static Dictionary<string, Socket> _clientsockets = new Dictionary<string, Socket>();
        static int _port = 55555;
        const int _buffersize = 2048;
        static byte[] _buffer = new byte[_buffersize];
        static string _ip;
        static Socket beginner;

        static void Main(string[] args)
        {
            Console.Title = "MyServidor";
            SetupServer();
            Console.ReadLine(); // When we press enter close everything
            CloseAllSockets();
        }

        private static void SetupServer()
        {
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    _ip = Convert.ToString(address);
                }
            }

            _serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint _ipend = new IPEndPoint(IPAddress.Parse(_ip), _port);
            _serversocket.Bind(_ipend);
            _serversocket.Listen(1);
            _serversocket.BeginAccept(AcceptCallback, null);
            Console.WriteLine("///////////////////////////////");
            Console.WriteLine("Servidor Cheet-a-Chat en línea.");
            Console.WriteLine("IP: " + _ip);
            Console.WriteLine("/////////////////////////////// \n");
        }

        private static void CloseAllSockets()
        {

            foreach (KeyValuePair<string, Socket> d in _clientsockets)
            {
                d.Value.Shutdown(SocketShutdown.Both);
                d.Value.Close();
            }
            _serversocket.Close();
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
           
            try
            {
                beginner = _serversocket.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }
                     
            beginner.BeginReceive(_buffer, 0, _buffersize, SocketFlags.None, ReceiveCallback, beginner);
            _serversocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Cliente " 
                               + _clientsockets.FirstOrDefault(x => x.Value == current).Key 
                               + " desconectado\n");
                current.Close();
                _clientsockets.Remove(_clientsockets.FirstOrDefault(x => x.Value == current).Key);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(_buffer, recBuf, received);
            string text;
            text = Encoding.UTF8.GetString(recBuf);

            if (!text.Contains("$$$$"))
            {
                Console.WriteLine(_clientsockets.FirstOrDefault(x => x.Value == current).Key + ": " + text);
            }

            if (text.Substring(0, 4) == "$uc$")
            {
                _clientsockets.Add(text.Substring(4), current);
                Console.WriteLine(text.Substring(4) + " se ha conectado!");
                string cdata = "$cl$";

                foreach (KeyValuePair<string, Socket> v in _clientsockets)
                {
                    cdata += v.Key + ",";
                }

                byte[] data = Encoding.UTF8.GetBytes(cdata);

                foreach (KeyValuePair<string, Socket> v in _clientsockets)
                {
                    v.Value.Send(data);
                    Console.WriteLine("@" + v.Key + ": " + cdata);
                }
                Console.WriteLine("");
            }

            else if (text.Substring(0, 4) == "$sm$")
            {
                text = text.Substring(4);
                string clientstring = text.Substring(0, text.IndexOf("$sm$"));

                string[] users = clientstring.Split(',');

                string msgtosend;
                msgtosend = "$mr$";
                msgtosend += _clientsockets.FirstOrDefault(x => x.Value == current).Key + "$mr$";
                text = text.Substring(text.IndexOf("$sm$") + 4);
                msgtosend += text;

                byte[] data = Encoding.UTF8.GetBytes(msgtosend);

                foreach (string s in users)
                {
                    if (s != "")
                    {
                        _clientsockets[s].Send(data);
                        Console.WriteLine("@" + s + ": " + msgtosend);
                    }
                }
                Console.WriteLine("");
            }
            else if (text.ToLower() == "$exit$")
            {
                Console.WriteLine("Cliente "
                               + _clientsockets.FirstOrDefault(x => x.Value == current).Key
                               + " desconectado\n");
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                _clientsockets.Remove(_clientsockets.FirstOrDefault(x => x.Value == current).Key);
                
                return;
            }
            else
            {
                byte[] data = Encoding.UTF8.GetBytes("$$$$");
                current.Send(data);
            }
            
            current.BeginReceive(_buffer, 0, _buffersize, SocketFlags.None, ReceiveCallback, current);
        }
    }
}
