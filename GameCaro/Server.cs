using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Server
    {
        public Socket server;
        public Socket acceptClient;
        public DataStream dataStream;

        public Server(String ip,int port)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ip), port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);
            acceptClient = server.Accept();
            
        }

        public void SendData(Object obj)
        {
            byte[] data = new byte[1024];
            data = dataStream.SerializeData(obj);
            acceptClient.Send(data);
        }

        public Object ReceiveData()
        {
            byte[] data = new byte[1024];
            acceptClient.Receive(data);
            return dataStream.DeserializeData(data);
        }
    }
}
