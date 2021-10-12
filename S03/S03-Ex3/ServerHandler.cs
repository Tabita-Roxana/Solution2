using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex3
{
    public class ServerHandler
    {
        private NetworkStream stream;
        
        public ServerHandler (NetworkStream stream)
        {
            this.stream = stream;
        }

        public void Run()
        {
            while (true)
            {
                //read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);

                if (s.Equals("exit"))
                {
                    //close connection
                    break;
                }
                
                //respond
                byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                stream.Write(dataToClient,0,dataToClient.Length); 
            }
        }
        

    }
}