
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

                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
            
            while(true){
                numeroclte += 1;
                cliente = servidor.AcceptTcpClient();
                NetworkStream networkStream = cliente.GetStream();
                networkStream.Read(bytesFrom, 0, (int)cliente.ReceiveBufferSize);
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                listaclientes.Add(dataFromClient, cliente);

                broadcast(dataFromClient + "se ha conectado", dataFromClient, false);
                Console.WriteLine(" >> " + "Cliente #" + Convert.ToString(numeroclte) + " - " + dataFromClient +" se ha conectado!");

                handleClinet client = new handleClinet();
                client.startClient(cliente, Convert.ToString(numeroclte), listaclientes);
            }           
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
                    bcbytes = Encoding.ASCII.GetBytes(f_usuario + ": " + f_mensaje);                    
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

                while ((true))
                {
                    try
                    {
                        NetworkStream networkStream = clienteinhandle.GetStream();
                        networkStream.Read(bytesFrom, 0, (int)clienteinhandle.ReceiveBufferSize);
                        dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                        Console.WriteLine(" >> " + "Mensaje Cliente #" + numeroclteinhandle + " - " + dataFromClient);

                        Program.broadcast(dataFromClient, numeroclteinhandle, true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        break;
                    }
                }
            }
        }
    }

