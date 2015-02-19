using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections;

namespace ServidorConsola
{
    class Program
    {
        public static Hashtable listaclientes = new Hashtable();
        static TcpClient cliente;
        static TcpListener servidor;
        //static StreamReader str;
        //static StreamWriter stw;
        static int puerto;
        static int numeroclte;

        static void Main(string[] args)
        {
            puerto = 1208;
            numeroclte = 0;

            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("IP: " + address.ToString());
                    Console.WriteLine("Puerto: " + puerto.ToString());
                }
            }

            servidor = new TcpListener(IPAddress.Any, puerto);
            servidor.Start();
            Console.WriteLine("Servidor en linea.");
            //cliente = servidor.AcceptTcpClient();
            //str = new StreamReader(cliente.GetStream());
            //stw = new StreamWriter(cliente.GetStream());
            //stw.AutoFlush = true;

            while (true) 
            {
                try
                {
                    byte[] bytesFrom = new byte[10025];
                    string dataFromClient = null;

                    numeroclte += 1;
                    cliente = servidor.AcceptTcpClient();
                    NetworkStream networkStream = cliente.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)cliente.ReceiveBufferSize);
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    listaclientes.Add(dataFromClient, cliente);

                    broadcast(dataFromClient + " Joined ", dataFromClient, false);

                    Console.WriteLine(" >> " + "Cliente #" + Convert.ToString(numeroclte) + " se ha conectado!");                
                    handleClinet client = new handleClinet();
                    client.startClient(cliente, Convert.ToString(numeroclte),listaclientes);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    break;
                }     
            }
                //Console.WriteLine("\nUn cliente se ha conectado");

                //while (true)
                //{
                //    try
                //    {
                //        NetworkStream networkStream = cliente.GetStream();
                //        byte[] bytesFrom = new byte[10025];
                //        networkStream.Read(bytesFrom, 0, (int)cliente.ReceiveBufferSize);
                //        string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                //        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                //        string serverResponse = dataFromClient;
                //        Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                //        networkStream.Write(sendBytes, 0, sendBytes.Length);
                //        networkStream.Flush();
                //        Console.WriteLine(" >> Mensaje Cliente - " + dataFromClient);
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine(ex.ToString());
                //        break;
                //    }   
                //}

            cliente.Close();
            servidor.Stop();
            Console.WriteLine(">> Saliendo");
            Console.ReadLine();

        }

        public static void broadcast(string f_mensaje, string f_usuario, bool flag)
        {
            foreach (DictionaryEntry elemento in listaclientes)
            {
                TcpClient bcsocket;
                bcsocket = (TcpClient)elemento.Value;
                NetworkStream bcstream = bcsocket.GetStream();                
                Byte[] bcbytes = null;

                if (flag == true)
                {
                    bcbytes = Encoding.ASCII.GetBytes(f_usuario + " says : " + f_mensaje);                    
                }
                else
                {
                    bcbytes = Encoding.ASCII.GetBytes(f_mensaje);
                }
                bcstream.Write(bcbytes, 0, bcbytes.Length);
                bcstream.Flush();   
            }    
        }  
    }

        public class handleClinet
        {
            TcpClient clienteinhandle;
            string numeroclteinhandle;
            Hashtable listaclienteinhandle;

            public void startClient(TcpClient f_cliente, string f_numeroclte, Hashtable f_listaclte)
            {
                clienteinhandle = f_cliente;
                numeroclteinhandle = f_numeroclte;
                listaclienteinhandle = f_listaclte;
                Thread ctThread = new Thread(doChat);
                ctThread.Start();
            }

            private void doChat()
            {
                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
                Byte[] sendBytes = null;
                string serverResponse = null;

                while ((true))
                {
                    try
                    {
                        NetworkStream networkStream = clienteinhandle.GetStream();
                        networkStream.Read(bytesFrom, 0, (int)clienteinhandle.ReceiveBufferSize);
                        dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                        serverResponse = dataFromClient;
                        sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        networkStream.Flush();
                        Console.WriteLine(" >> " + "Mensaje Cliente #" + numeroclteinhandle + " - " + dataFromClient);

                        Program.broadcast(dataFromClient, numeroclteinhandle, true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }

