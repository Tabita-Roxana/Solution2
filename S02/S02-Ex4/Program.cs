using System;
using System.Threading;

namespace S02_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom waitingRoom = new WaitingRoom();
            
            for (int i = 0; i < 10; i++)
            {
                Patient patient = new Patient(i, waitingRoom);
            }
            
            waitingRoom.RunWaitingRoom();
            



        }
    }
}