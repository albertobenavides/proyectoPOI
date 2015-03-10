﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatPOI
{
    class ClientConection
    {
        private static readonly Socket _clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int _PORT = 55555;

        public static void ConnectToServer(string username)
        {
            int attempts = 0;

            while (!_clientSocket.Connected)
            {
                IPAddress myIP = IPAddress.Parse("0.0.0.0");

                IPAddress[] localIP = Dns.GetHostAddresses("RAFALAPTOP-PC");
                foreach (IPAddress address in localIP)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        myIP = address;
                    }
                }
                try
                {
                    attempts++;
                    _clientSocket.Connect(myIP, _PORT);
                    SendString("$uc$" + username); // $uc$ : (User connected) Nuevo usuario conectado
                }
                catch (SocketException)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Close socket and exit app
        /// </summary>
        public static void Exit()
        {
            SendString("exit"); // Tell the server we re exiting
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
            Environment.Exit(0);
        }

        public static void SendRequest(string s)
        {
            string request = s;
            SendString(request);
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding
        /// </summary>
        private static void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public static void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = _clientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            globals.receivedText = Encoding.ASCII.GetString(data);
        }
    }
}