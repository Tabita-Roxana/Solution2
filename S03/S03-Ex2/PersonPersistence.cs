using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using S03_Ex1;

namespace S03_Ex2
{
    public class PersonPersistence
    {
        public static void StoreObjects(List<Person> persons)
        {
            using StreamWriter sw = new("MyPeopleFile.txt");
            string objAsJson = JsonSerializer.Serialize(persons, new JsonSerializerOptions {WriteIndented = true});
            sw.WriteLine(objAsJson);
        }

        public static string ReadObjects()
        {
            StringBuilder sb = new StringBuilder();
            using StreamReader sr = new StreamReader("MyPeopleFile.txt");
            string line;
            while ((line = sr.ReadLine()) !=null)
            {
                sb.AppendLine(line);
            }
            
            List<Person> persons = JsonSerializer.Deserialize<List<Person>>(sb.ToString());

            return sb.ToString();
        }
        
    }
}