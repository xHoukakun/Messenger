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
            IPEndPoint myIPE;
            Socket mySock = null;
            int myPort;
            IPAddress myIP;

            myIP = GetIP();
            myPort = 8887;
            myIPE = new IPEndPoint(myIP, myPort);       //IPEndPoint des Servers

            Console.Write("Server-IP: " + myIP + "     Server-Port: " + myPort);        //Serverdaten werden in der Console ausgegeben

            try
            {
                mySock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                mySock.Bind(myIPE);
                mySock.Listen(1);
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.ErrorCode + ": " + se.Message);        //Ausgabe einer Fehlermeldung bei der Socket erstellung
                Environment.Exit(se.ErrorCode);
            }


            byte[] empfangeneBytes = new byte[32];
            int anzahlBytes;


            while (true)     //Endlosschleife des Servers
            {
                Socket client = null;       //Grungerüst für den Client

                try
                {
                    client = mySock.Accept();          //Die Clientdaten werden in einem Socket gespeichert

                    int echoedBytes = 0;        //Anzahl der Bytes die zurückgesendet wurden

                    ///
                    ///Was geschit mit den empfangenen Daten des Clients
                    ///                 ^ 
                    ///                 |
                    ///                 |
                    /// 


                    while ((anzahlBytes = client.Receive(empfangeneBytes, 0, empfangeneBytes.Length,            //Die Empfangenen Bytes werden gespeichert
                                                       SocketFlags.None)) > 0)
                    {
                        client.Send(empfangeneBytes, 0, anzahlBytes, SocketFlags.None);         //Die Bytes werden an den Client zurückgesendet
                        echoedBytes += anzahlBytes;

                        Console.SetCursorPosition(0, 3);
                        Console.WriteLine("Received {0} bytes from server: {1}", echoedBytes,
                                  Encoding.ASCII.GetString(empfangeneBytes, 0, echoedBytes));
                        Console.ReadKey();

                    }

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();

                }
                catch (Exception)
                {
                    client.Close();
                }

            }
        }





        /// <summary>
        /// Methode zur Bestimmung der IP-Adresse des Servers
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetIP()
        {
            foreach (var item in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (item.AddressFamily == AddressFamily.InterNetwork)
                    return item;
            }
            return null;

        }
    }
}
