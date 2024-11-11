using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Socket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //tcp/ip

            // Socket Listener acts as a server and listens to the incoming
            // messages on the specified port and protocol.

            startServer();
            Console.ReadLine();


        }

        public static void startServer()
        {
            // Get Host IP Address that is used to establish a connection
            // In this case, we get one IP address of localhost that is IP : 127.0.0.1
            // If a host has multiple addresses, you will get a list of addresses


            IPHostEntry ip = Dns.GetHostEntry("localhost");
            IPAddress ia = ip.AddressList[0];
            IPEndPoint ie = new IPEndPoint(ia, 11000);

            try {
                // Create a Socket that will use Tcp protocol
        
                System.Net.Sockets.Socket s = new System.Net.Sockets.Socket(ia.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                
                // A Socket must be associated with an endpoint using the Bind method
                s.Bind(ie);

                // Specify how many requests a Socket can listen before it gives Server busy response.
                // We will listen 10 requests at a time
                s.Listen(10);

                Console.WriteLine("waiting for connection..");
                System.Net.Sockets.Socket handler = s.Accept();


                // Incoming data from the client.
                string data = null;
                byte[] bytes = null;
                while (true)
                {
                    bytes = new byte[1024];
                    int byterecived = handler.Receive(bytes);
                    data+= Encoding.ASCII.GetString(bytes, 0, byterecived);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }

                }
                Console.WriteLine("message recived: " + data);
                byte[] message = Encoding.ASCII.GetBytes(data);
                handler.Send(message);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
