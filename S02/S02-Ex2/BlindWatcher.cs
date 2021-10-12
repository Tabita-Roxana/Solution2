using System;

namespace S02_Ex2
{
    public class BlindWatcher
    {

        public void React(string birdBehaviour)
        {
            if (birdBehaviour.Equals("Bird sings"))
            {
                Console.WriteLine( "Blind says yeeeeeyyy!!!!!!");
            }
            
        }
        
    }
}