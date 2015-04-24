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
        static Hashtable clientList = new Hashtable();
        static TcpListener serversocket;
        static int port = 55555;

        static void Main(string[] args)
        {
            string ip = null;
            Console.Title = "Cheet-A-Chat";
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = Convert.ToString(address);
                }
            }

            serversocket = new TcpListener(IPAddress.Parse(ip), port);
            TcpClient clientSocket = default(TcpClient);

            serversocket.Start();


            Console.WriteLine("///////////////////////////////");
            Console.WriteLine("Servidor Cheet-a-Chat en línea.");
            Console.WriteLine("IP: " + ip);
            Console.WriteLine("/////////////////////////////// \n");

            while (true)
            {
                clientSocket = serversocket.AcceptTcpClient();

                string nickClient = null;

                byte[] buffer = new byte[10025];

                NetworkStream networkStrem = clientSocket.GetStream();
                networkStrem.Read(buffer, 0, (int)clientSocket.ReceiveBufferSize);
                nickClient = System.Text.Encoding.UTF8.GetString(buffer);

                nickClient = nickClient.Substring(0, nickClient.IndexOf("$$$$"));

                clientList.Add(nickClient, clientSocket);

                sender("$uc$", nickClient);

                handleClient client = new handleClient();
                client.startClient(clientSocket, nickClient, clientList);
            }

            clientSocket.Close();
            serversocket.Stop();
            Console.WriteLine("exit");
            Console.ReadLine();
        }

        public static void sender(string message, string userName)
        {

            if (message == "$uc$")
            {
                Console.WriteLine("¡" + userName + " se ha conectado!");
                string dataToSend = "$cl$";

                foreach (DictionaryEntry client in clientList)
                {
                    dataToSend += client.Key + ",";
                }

                dataToSend += "$$$$";

                System.IO.Directory.CreateDirectory("clients\\" + userName);
                    
                Byte[] senderBytes = null;
                senderBytes = Encoding.UTF8.GetBytes(dataToSend);

                foreach (DictionaryEntry client in clientList)
                {
                    TcpClient senderSocket = (TcpClient)client.Value;
                    senderSocket.Client.Send(senderBytes);
                    Console.WriteLine("@" + client.Key + ": " + dataToSend);
                }
                Console.WriteLine("");
            }
        }
    }

    public class handleClient
    {
        TcpClient currentClientSocket;
        string userName;
        Hashtable clientList;

        private volatile bool isConected;

        public void startClient(TcpClient currentClientSocket, string userName, Hashtable clientList)
        {
            this.currentClientSocket = currentClientSocket;
            this.userName = userName;
            this.clientList = clientList;

            isConected = true;

            Thread thread = new Thread(doChat);
            thread.Start();
        }

        private void doChat()
        {
            byte[] buffer = new byte[10025];
            string dataFromClient = null;

            while (isConected)
            {
                try
                {
                    NetworkStream networkStrem = currentClientSocket.GetStream();
                    networkStrem.Read(buffer, 0, (int)currentClientSocket.ReceiveBufferSize);
                    dataFromClient = System.Text.Encoding.UTF8.GetString(buffer);

                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$$$$"));

                    if (dataFromClient.Substring(0, 4) == "$cs$")
                    {

                        dataFromClient += "$$$$";
                        byte[] data = Encoding.UTF8.GetBytes(dataFromClient);

                        foreach (DictionaryEntry client in clientList)
                        {
                            if (!client.Key.ToString().Contains(userName))
                            {
                                TcpClient senderSocket = (TcpClient)client.Value;
                                senderSocket.Client.Send(data);
                                Console.WriteLine("@" + client.Key + ": " + dataFromClient);
                            }
                        }
                        Console.WriteLine("");
                    }

                    else if (dataFromClient.Substring(0, 4) == "$cl$")
                    {
                        string dataToSend = "$cl$";

                        foreach (DictionaryEntry client in clientList)
                        {
                            dataToSend += client.Key + ",";
                        }

                        dataToSend += "$$$$";

                        System.IO.Directory.CreateDirectory("clients\\" + userName);

                        Byte[] senderBytes = null;
                        senderBytes = Encoding.UTF8.GetBytes(dataToSend);

                        TcpClient senderSocket = (TcpClient)clientList[userName];
                        senderSocket.Client.Send(senderBytes);
                        Console.WriteLine("@" + userName + ": " + dataToSend);

                        Console.WriteLine("");
                    }

                    else if (dataFromClient.Substring(0, 4) == "$sm$")
                    {
                        dataFromClient = dataFromClient.Substring(4);
                        string clientString = dataFromClient.Substring(0, dataFromClient.IndexOf("$sm$"));

                        string[] users = clientString.Split(',');

                        string messageToSend;
                        messageToSend = "$mr$";
                        messageToSend += userName + "$mr$";
                        dataFromClient = dataFromClient.Substring(dataFromClient.IndexOf("$sm$") + 4);
                        messageToSend += dataFromClient;

                        byte[] data = Encoding.UTF8.GetBytes(messageToSend);

                        if (users.Length == 2)
                        {
                            System.IO.Directory.CreateDirectory("clients\\" + userName);
                            using (StreamWriter writer = new StreamWriter("clients\\" + userName + "\\" + users[0] + ".txt", true))
                            {
                                writer.Write("\nTú : " + dataFromClient);
                            }

                            System.IO.Directory.CreateDirectory("clients\\" + users[0]);
                            using (StreamWriter writer = new StreamWriter("clients\\" + users[0] + "\\" + userName + ".txt", true))
                            {
                                writer.Write("\n" + userName + ": " + dataFromClient);
                            }
                        }

                        foreach (string user in users)
                        {
                            TcpClient senderSocket = (TcpClient)clientList[user];
                            senderSocket.Client.Send(data);
                            Console.WriteLine("@" + user + ": " + messageToSend);
                        }
                        Console.WriteLine("");
                    }

                    else if (dataFromClient.Substring(0, 4) == "$gm$")
                    {
                        dataFromClient = dataFromClient.Substring(4);

                        string msgtosend;
                        msgtosend = "$gm$" + dataFromClient + "$gm$";
                        using (StreamReader reader = new StreamReader("clients\\" + userName + "\\" + dataFromClient + ".txt"))
                        {
                            string temp;
                            while ((temp = reader.ReadLine()) != null)
                            {
                                msgtosend += temp + "\n";
                            }
                        }

                        byte[] data = Encoding.UTF8.GetBytes(msgtosend);

                        foreach (DictionaryEntry client in clientList)
                        {
                            if (client.Key.ToString().Equals(userName))
                            {
                                TcpClient senderSocket = (TcpClient)client.Value;
                                senderSocket.Client.Send(data);
                            }
                        }
                    }

                    else if (dataFromClient.Substring(0,6).Equals("$exit$"))
                    {
                        isConected = false;
                        Console.WriteLine("Cliente "
                                       + userName
                                       + " desconectado\n");

                        TcpClient senderSocket = (TcpClient)clientList[userName];
                        senderSocket.Client.Shutdown(SocketShutdown.Both);
                        senderSocket.Close();
                        clientList.Remove(userName);

                        if (clientList.Count > 0)
                        {

                            string cdata = "$cl$";

                            foreach (DictionaryEntry client in clientList)
                            {
                                cdata += client.Key + ",";
                            }

                            byte[] data = Encoding.UTF8.GetBytes(cdata);

                            foreach (DictionaryEntry client in clientList)
                            {
                                TcpClient tcpSocket = (TcpClient)client.Value;
                                tcpSocket.Client.Send(data);
                                Console.WriteLine("@" + client.Key + ": " + cdata);
                            }
                            Console.WriteLine("");
                        }
                        return;
                    }

                    Console.WriteLine(userName + ": " + dataFromClient);
                }
                catch (Exception ex)
                {
                    // Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }
    }
}
