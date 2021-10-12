using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace S03_Ex5Server
{
     public class Server
    {
        private Pool pool = new Pool();
        public void Start()
        {
            
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            Console.WriteLine("Server started..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client connected");
                NetworkStream stream = client.GetStream();

                ServerHandler serverHandler = new ServerHandler(stream, this);
                pool.AddConnection(serverHandler);
                
                Thread thread = new Thread(() => serverHandler.Run());
                thread.Start();
                

            }
        }
        
        public Pool GetPool()
        {
            return pool;
        }
    }
}