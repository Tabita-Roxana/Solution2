using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace S03_Ex5Client
{
    class Client
    {
        private ClientHandler clientHandler;
        
        

        public void Start()
        {
            Console.WriteLine("Starting client..");
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            NetworkStream stream = client.GetStream();

            clientHandler = new ClientHandler(stream);

            Thread thread = new Thread(() => clientHandler.Run());
            thread.Start();

            while (true)
            {
                Console.WriteLine("Input->");
                string message = Console.ReadLine();
                byte[] dataToServer = Encoding.ASCII.GetBytes(message);
                stream.Write(dataToServer,0,dataToServer.Length);

                if (message.Equals("exit"))
                {
                    stream.Close();
                    // client.Close();
                }
            }
            

        }


    }
}