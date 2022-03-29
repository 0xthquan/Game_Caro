using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Client
    {
        public Socket client;
        public DataStream dataStream;

        public Client(String ip, int port)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ip),port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            while (client.Connected != true)
            {
                try
                {
                    client.Connect(iep);
                }
                catch (Exception ex) { }       
            }
        }

        public void SendData(Object obj)
        {
            byte[] data = new byte[1024];
            data = dataStream.SerializeData(obj);
            client.Send(data);
        }

        public Object ReceiveData()
        {
            byte[] data = new byte[1024];
            client.Receive(data);
            return dataStream.DeserializeData(data);
        }
    }
}
