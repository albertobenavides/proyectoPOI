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
        static Hashtable _clientList = new Hashtable();
        static TcpListener _serversocket;
        static int _port = 55555;
        static byte[] _buffer = new byte[10025];
        static string _ip;

        static void Main(string[] args)
        {
            Console.Title = "Cheet-A-Chat";
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    _ip = Convert.ToString(address);
                }
            }

            _serversocket = new TcpListener(IPAddress.Parse(_ip), _port);
            TcpClient _clientSocket = default(TcpClient);

            _serversocket.Start();

            Console.WriteLine("///////////////////////////////");
            Console.WriteLine("Servidor Cheet-a-Chat en línea.");
            Console.WriteLine("IP: " + _ip);
            Console.WriteLine("/////////////////////////////// \n");

            while (true)
            {
                _clientSocket = _serversocket.AcceptTcpClient();

                string nickClient = null;

                NetworkStream networkStrem = _clientSocket.GetStream();
                networkStrem.Read(_buffer, 0, (int)_clientSocket.ReceiveBufferSize);
                nickClient = System.Text.Encoding.UTF8.GetString(_buffer);

                nickClient = nickClient.Substring(0, nickClient.IndexOf("$"));

                _clientList.Add(nickClient, _clientSocket);

                sender("$uc$", nickClient); // regresar lista de clientes

                handleClient client = new handleClient();
                client.startClient(_clientSocket, nickClient, _clientList);
            }

            foreach (KeyValuePair<string, Socket> v in _clientList)
            {
                v.Value.Close();
            }
            _serversocket.Stop();
        }

        public static void sender(string message, string userName)
        {

            if (message == "$uc$") // Cliente conectado
            {
                Console.WriteLine("¡" + userName + " se ha conectado!");
                string dataToSend = "$cl$";

                foreach (DictionaryEntry client in _clientList)
                {
                    dataToSend += client.Key + ",";
                }

                System.IO.Directory.CreateDirectory("clients\\" + userName);
                    
                Byte[] senderBytes = null;
                senderBytes = Encoding.UTF8.GetBytes(dataToSend);

                foreach (DictionaryEntry client in _clientList)
                {
                    TcpClient senderSocket;
                    senderSocket = (TcpClient)client.Value;
                    NetworkStream senderStream = senderSocket.GetStream();

                    senderSocket.Client.Send(senderBytes);
                    Console.WriteLine("@" + client.Key + ": " + dataToSend);
                }
                Console.WriteLine("");
            }

            if (message.Substring(0, 4) == "$sm$")
            {
                message = message.Substring(4);
                string clientString = message.Substring(0, message.IndexOf("$sm$"));

                string[] users = clientString.Split(',');

                string messageToSend;
                messageToSend = "$mr$";
                messageToSend += userName + "$mr$";
                message = message.Substring(message.IndexOf("$sm$") + 4);
                messageToSend += message;

                byte[] data = Encoding.UTF8.GetBytes(messageToSend);

                if (users.Length == 2)
                {
                    System.IO.Directory.CreateDirectory("clients\\" + userName); // Crear carpeta de quien lo manda
                    using (StreamWriter writer = new StreamWriter("clients\\" + userName + "\\" + users[0] + ".txt", true))
                    {
                        writer.Write("\nTú : " + message);
                    }

                    System.IO.Directory.CreateDirectory("clients\\" + users[0]); // Crear carpeta de quien lo recibe
                    using (StreamWriter writer = new StreamWriter("clients\\" + users[0] + "\\" + userName + ".txt", true))
                    {
                        writer.Write("\n" + userName + ": " + message);
                    }
                }

                foreach (string s in users)
                {
                    foreach (DictionaryEntry client in _clientList)
                    {
                        if (client.Key == s)
                        {
                            TcpClient senderSocket;
                            senderSocket = (TcpClient)client.Value;
                            NetworkStream senderStream = senderSocket.GetStream();

                            senderSocket.Client.Send(data);
                            Console.WriteLine("@" + s + ": " + messageToSend);
                        }
                    }
                }
                Console.WriteLine("");
            }

            if (message.Substring(0, 4) == "$cs$")
            {
                byte[] data = Encoding.UTF8.GetBytes(message);

                foreach (DictionaryEntry client in _clientList)
                {
                    if (client.Key != userName)
                    {
                        TcpClient senderSocket;
                        senderSocket = (TcpClient)client.Value;
                        NetworkStream senderStream = senderSocket.GetStream();

                        senderSocket.Client.Send(data);
                        Console.WriteLine("@" + client.Key + ": " + message);
                    }
                }
                Console.WriteLine("");
            }

            if (message.Substring(0, 4) == "$gm$")
            {
                message = message.Substring(4); // usuario

                string msgtosend;
                msgtosend = "$gm$" + message + "$gm$";
                using (StreamReader reader = new StreamReader("clients\\" + userName + "\\" + message + ".txt"))
                {
                    string temp;
                    while ((temp = reader.ReadLine()) != null)
                    {
                        msgtosend += temp + "\n";
                    }
                }

                byte[] data = Encoding.UTF8.GetBytes(msgtosend);

                foreach (DictionaryEntry client in _clientList)
                {
                    if (client.Key == userName)
                    {
                        TcpClient senderSocket;
                        senderSocket = (TcpClient)client.Value;
                        NetworkStream senderStream = senderSocket.GetStream();

                        senderSocket.Client.Send(data);
                    }
                }

                if (message.ToLower() == "$exit$")
                {
                    Console.WriteLine("Cliente "
                                   + userName
                                   + " desconectado\n");

                    foreach (DictionaryEntry client in _clientList)
                    {
                        if (client.Key == userName)
                        {
                            TcpClient senderSocket;
                            senderSocket = (TcpClient)client.Value;
                            senderSocket.Close();
                            //Shutdown(SocketShutdown.Both); // Revisar
                            _clientList.Remove(userName);
                        }
                    }

                    if (_clientList.Count > 0)
                    {

                        string cdata = "$cl$";

                        foreach (DictionaryEntry client in _clientList)
                        {
                            cdata += client.Key + ",";
                        }

                        //byte[] data = Encoding.UTF8.GetBytes(cdata);

                        foreach (DictionaryEntry client in _clientList)
                        {
                            TcpClient senderSocket;
                            senderSocket = (TcpClient)client.Value;
                            NetworkStream senderStream = senderSocket.GetStream();

                            senderSocket.Client.Send(data);
                            Console.WriteLine("@" + client.Key + ": " + cdata);
                        }
                        Console.WriteLine("");
                    }
                    return;
                }

                //senderStream.Write(senderBytes, 0, senderBytes.Length);
                //senderStream.Flush();
            }
        }            

        //private static void CloseAllSockets()
        //{

        //    foreach (KeyValuePair<string, Socket> d in _clientList)
        //    {
        //        d.Value.Shutdown(SocketShutdown.Both);
        //        d.Value.Close();
        //    }
        //    _serversocket.Close();
        //}
    }

    public class handleClient
    {
        TcpClient currentClientSocket;
        string userName;
        Hashtable clientList;

        public void startClient(TcpClient currentClientSocket, string userName, Hashtable clientList)
        {
            this.currentClientSocket = currentClientSocket;
            this.userName = userName;
            this.clientList = clientList;
            Thread thread = new Thread(doChat);
            thread.Start();
        }

        private void doChat()
        {
            int requestCount = 0;
            byte[] buffer = new byte[10025];
            string dataFromClient = null;

            while (true)
            {
                try
                {
                    requestCount++;
                    NetworkStream networkStrem = currentClientSocket.GetStream();
                    networkStrem.Read(buffer, 0, (int)currentClientSocket.ReceiveBufferSize);
                    dataFromClient = System.Text.Encoding.UTF8.GetString(buffer);

                    Console.WriteLine("Tal Cliente escribió: " + dataFromClient);

                    ProgramaServidor.sender(dataFromClient, userName); // revisar revisar REVISAR!
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Oh oh, spaguetti-O " + ex.ToString());
                }
            }
        }
    }
}
