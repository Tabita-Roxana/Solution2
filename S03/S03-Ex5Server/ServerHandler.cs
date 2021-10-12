using System;
using System.Net.Sockets;
using System.Text;

namespace S03_Ex5Server
{
    public class ServerHandler
    {
        private NetworkStream stream;
        private Server server;
        
        public ServerHandler (NetworkStream stream, Server server)
        {
            this.stream = stream;
            this.server = server;
        }

        //read message from client
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
                
                //broadcasting mess
                server.GetPool().Broadcast(s);
                
                
            } 
        }

        public void SendMessage(string mess)
        {
            //respond
            byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {mess}");
            stream.Write(dataToClient,0,dataToClient.Length); 
            
        }
        

    }
}