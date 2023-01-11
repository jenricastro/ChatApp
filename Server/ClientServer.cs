using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerClient
    {
        public string Username { get; set; }
        public Guid UID { get; set; }
        public TcpClient ClientSocket { get; set; }

        public ServerClient(TcpClient client)
        {
            ClientSocket= client;
            UID = Guid.NewGuid();

            Console.WriteLine($"[{DateTime.Now}]: Client is connected with friend: {Username}");
        }
    }
}
