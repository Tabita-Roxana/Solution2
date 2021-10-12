using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex5Client
{
    public class ClientHandler
    {

        private NetworkStream stream;
        

        public ClientHandler(NetworkStream stream)
        {
            this.stream = stream;
        }

        public void Run()
        {
            
            while (true)
            {
                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
                
            }
        }
        
        
        
        
        
        
        
        
    }
}