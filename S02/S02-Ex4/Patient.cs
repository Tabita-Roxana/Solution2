using System;

namespace S02_Ex4
{
    public class Patient
    {
        private int numberInQueue;
        private WaitingRoom waitingRoom;

        public Patient(int numberInQueue, WaitingRoom waitingRoom)
        {
            this.waitingRoom = waitingRoom;
            this.numberInQueue = numberInQueue;
            waitingRoom.DrawNumber();
            waitingRoom.NumberChange += ReactToNumber;
        }

        public void ReactToNumber(int ticketNumber)
        {
            Console.WriteLine("Patient " + numberInQueue + " looks up");
            
            if (numberInQueue == ticketNumber)
            {
                Console.WriteLine("Patient " + numberInQueue + " goes to the doctor's room");
                waitingRoom.NumberChange -= ReactToNumber;
            }
            else
            {
                Console.WriteLine("Patient " + numberInQueue + "looks into his phone");
            }
            
        }
    }
}