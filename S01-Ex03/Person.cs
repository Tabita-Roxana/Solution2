using System;

namespace S01_Ex02
{
    public class Person
    {
        private string name;
        
        public string Name { get; set; }

        public string Introduce()
        { 
            System.Console.WriteLine($"Hi, my name is {Name} !") ;
            return "";
        }
    }
}