using System;
using System.Threading;

namespace S02_Ex2
{
    public class Bird
    {
        public Action<string> Behavior;
        
        private string[] birdBehaviour = {"Bird flaps wings","Bird sings", "Bird does mating dance" };

        public void RunBird()
        {
            for (int i = 0; i < 15; i++)
            {
                int index = i % birdBehaviour.Length;
                
                Console.WriteLine(birdBehaviour[index]);
                
                Behavior?.Invoke(birdBehaviour[index]);
                Thread.Sleep(1000);
            }
        }
        
        

    }
}