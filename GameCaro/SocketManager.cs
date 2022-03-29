using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameCaro
{
    class SocketManager
    {
        #region client
        Socket client;

        public bool ConnectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(iep);
                return true;
            }
            catch 
            {
                return false;
            }

        }

        #endregion

        #region server
        Socket server;

        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(iep);
            server.Listen(10);

            Thread acceptClient = new Thread(() =>
                {
                    client = server.Accept();
                }
            );
            acceptClient.IsBackground = true;//Chương trình tắt thì thread này cũng tắt theo
            acceptClient.Start();      
        }

        #endregion

        #region both
        public string IP = "127.0.0.1";
        public int PORT = 9999;
        public const int BUFFER = 1024;
        //public bool isServer = true;

        public void Send(object data)
        {
            byte[] sendData = SerializeData(data);         
            SendData(client, sendData);      
        }

        public object Receive()
        {   
            byte[] receiveData = new byte[BUFFER];
            bool isOk = ReceiveData(client, receiveData);
            return DeserializeData(receiveData);
        }


        public void SendData(Socket target, byte[] data)
        {
            try
            {
                target.Send(data);
            }
            catch
            {
                
            }
        }

        public bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }

        //Nén 1 đối tượng thành 1 mảnh byte[]
        public byte[] SerializeData(Object o) {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        //Giải nén 1 mảng byte[] thành 1 đối tượng(object)
        public object DeserializeData(byte[] theByteArray) {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        #endregion
    }
}
