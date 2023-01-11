using Client.MVVM.Core;
using Client.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Client.MVVM.ViewModel
{
    class MainViewModel
    {

        public RelayCommand ConnectToServerCommand{ get; set; } 

        private Server _server;
        public MainViewModel()
        {
        _server= new Server();
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer());
        }
    }
}
