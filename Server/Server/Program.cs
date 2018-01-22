using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            IPAddress adresse = IPAddress.Parse("172.0.0.1");
            IPEndPoint ServerEndPoint = new IPEndPoint(adresse, 4200);

            Socket serverSock = new Socket(AddressFamily.InterNetwork,
                                     SocketType.Stream,
                                     ProtocolType.Tcp);

            serverSock.Bind(ServerEndPoint);

            serverSock.Listen(0);     //Der Server hört ob eine Anfrage kommt

            Socket clientSock = serverSock.Accept();  //Der Socket vom Client wird gespeichert

            NetworkStream netStream = new NetworkStream(clientSock);

        }
    }
}
