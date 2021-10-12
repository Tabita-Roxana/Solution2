using System;

namespace S02_Ex2
{
    public class BirdWatcher
    {
        public int Id { get; set; }
        private string result = "";

        public void React(string birdBehaviour)
        {
            switch (birdBehaviour)
            {
                case "Bird flaps wings":
                    result = "How nice!!!";
                    break;
                case "Bird sings": result = "Ohh!";
                    break;
                case "Bird does mating dance":
                    result = "Would you look at that!";
                    break;
            }
            Console.WriteLine(Id +" " +result);
        }
        
    }
}