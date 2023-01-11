using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
        class Program
        {
        static List<ServerClient> _users;
            static TcpListener _listener;
        static void Main(string[] args)
        {
            _users= new List<ServerClient>();
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 3000);
            _listener.Start();

            while(true)
            {
                var client = new ServerClient (_listener.AcceptTcpClient());
                _users.Add(client);

                /*Send message - connected with everyone on server*/

            }

            
        }
    }
}