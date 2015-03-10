using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatPOI
{
    
    class globals
    {
        static string _username;

        public static string sendedText;

        public static string receivedText;

        public static string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
    }
}
