using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    class User
    {
        public string uName;
        public string uIPv4;
        public string uNachricht;
        private string Formatierteausgabe;


        public string GetFormatierteAusgabe
        {
            get { return Formatierteausgabe = uName + " "; }
        }
        // static void setName()
        //    {
        //name=sName;
        //return(name);
        //    }
    }
}
