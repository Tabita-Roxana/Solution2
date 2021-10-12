using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex03Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client..");
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            NetworkStream stream = client.GetStream();

            
            while (true)
            {
                Console.WriteLine("Input->");
                string message = Console.ReadLine();
                byte[] dataToServer = Encoding.ASCII.GetBytes(message);
                stream.Write(dataToServer,0,dataToServer.Length);

                if (message.Equals("exit"))
                {
                    stream.Close();
                    client.Close();
                    return;
                }

                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
            }

            
            
            
        }
    }
}