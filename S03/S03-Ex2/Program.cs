using System;
using System.Collections.Generic;
using S03_Ex1;

namespace S03_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hobbies1 = {"volleyball", "football"};
            string[] hobbies2 = {"volleyball", "tennis"};
            string[] hobbies3 = {"walking", "reading"};
            
            Person p1 = new Person("Anna", "Vilma", 29, 170, true, 'F',hobbies1);
            Person p2 = new Person("Mathias", "Jensen", 24, 182, false, 'M', hobbies2);
            Person p3 = new Person("Alice", "Varlan", 15, 160, false, 'F', hobbies3);

            List<Person> persons = new List<Person>();
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            
            //PersonPersistence.StoreObjects(persons);
            Console.WriteLine( PersonPersistence.ReadObjects());
        }
    }
}