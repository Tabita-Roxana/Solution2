using System;
using System.Threading;

namespace S02_Ex4
{
    public class WaitingRoom
    {
        public Action<int> NumberChange;
        private int currentNumber = 0;
        private int ticketCount = 0;

        public void RunWaitingRoom()
        {
            
                while (currentNumber < ticketCount)
                {
                    Console.WriteLine("Diing!!!");
                    NumberChange?.Invoke(currentNumber);
                    currentNumber++;
                    Thread.Sleep(1000);
                }
            
        }

        public int DrawNumber()
        {
            ticketCount++;
            return ticketCount;
        }
    }
}