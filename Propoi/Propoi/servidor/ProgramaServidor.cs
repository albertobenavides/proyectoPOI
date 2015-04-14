﻿using System;
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

            else if (message.Substring(0, 4) == "$sm$")
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
                    foreach (KeyValuePair<string, TcpClient> client in clientList)
                    {
                        if (client.Key.Contains(s))
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

            else if (message.Substring(0, 4) == "$gm$")
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

                foreach (KeyValuePair<string, TcpClient> client in clientList)
                {
                    if (client.Key.Contains(userName))
                    {
                        TcpClient senderSocket;
                        senderSocket = (TcpClient)client.Value;
                        NetworkStream senderStream = senderSocket.GetStream();

                        senderSocket.Client.Send(data);
                    }
                }
            }
        }
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
            byte[] buffer = new byte[10025];
            string dataFromClient = null;

            while (true)
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

                    else if (dataFromClient.ToLower() == "$exit$")
                    {
                        Console.WriteLine("Cliente "
                                       + userName
                                       + " desconectado\n");

                        foreach (KeyValuePair<string, TcpClient> client in clientList)
                        {
                            if (client.Key.Contains(userName))
                            {
                                TcpClient senderSocket;
                                senderSocket = (TcpClient)client.Value;
                                senderSocket.Client.Shutdown(SocketShutdown.Both);
                                senderSocket.Close();
                                clientList.Remove(userName);
                            }
                        }

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

                    Console.WriteLine(userName + ": " + dataFromClient);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Oh oh, spaguetti-O " + ex.ToString());
                }
            }
        }
    }
}
