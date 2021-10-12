using System.Collections.Generic;

namespace S03_Ex5Server
{
    public class Pool
    {
        private List<ServerHandler> connections;

        public Pool()
        {
            connections = new List<ServerHandler>();
        }

        public  void Broadcast(string msg)
        {
            foreach (var conn in connections)
            {
                conn.SendMessage(msg);
            }
        }

        public void AddConnection(ServerHandler serverHandler)
        {
            connections.Add(serverHandler);
        }
        public void RemoveConnection(ServerHandler serverHandler)
        {
            connections.Remove(serverHandler);
        }
    }
}