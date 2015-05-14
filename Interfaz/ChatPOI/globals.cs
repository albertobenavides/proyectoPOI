using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatPOI
{
    
    class globals
    {
        public static string sendedText;

        public static string receivedText;

        public static string username;

        public static Dictionary<string, string> udpClients = new Dictionary<string,string>();

        public static string cifrado(string cadena)
        {

            byte[] asciiBytes = Encoding.Unicode.GetBytes(cadena);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                asciiBytes[i]++;
            }

            return Encoding.Unicode.GetString(asciiBytes);
        }

        public static string descifrado(string cadena)
        {

            byte[] asciiBytes = Encoding.Unicode.GetBytes(cadena);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                asciiBytes[i]--;
            }

            return Encoding.Unicode.GetString(asciiBytes);
        }
    }
}
