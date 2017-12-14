using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_App
{
    public class FileHandler
    {

        public void FileReader()
        {
            if (("TasksInText").Length <= 0)
            {
                string[] lines = File.ReadAllLines("TasksInText.txt");

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No todos for today! :)");
            }
            
        }


        public void ListAdd(string listElement)
        {
            StreamWriter sw = new StreamWriter("TasksInText.txt", true);
            sw.WriteLine(listElement);
            sw.Close();
        }

        public void ErrorHandling()
        {
            Console.WriteLine("Unable to add: no task provided");
        }

        public void RemoveLines(int number)
        {
            var file = new List<string>(System.IO.File.ReadAllLines("TasksInText.txt"));
            file.RemoveAt(number);
            File.WriteAllLines("TasksInText.txt", file.ToArray());
        }

    }
}
