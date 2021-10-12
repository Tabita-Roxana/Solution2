using System;

namespace S02_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            
            BirdWatcher b1 = new BirdWatcher{Id = 1};
            BirdWatcher b2 = new BirdWatcher {Id = 2};
            BlindWatcher blind = new BlindWatcher();

            bird.Behavior += b1.React;
            bird.Behavior += b2.React;
            bird.Behavior += blind.React;
            
            bird.RunBird();
        }
    }
}