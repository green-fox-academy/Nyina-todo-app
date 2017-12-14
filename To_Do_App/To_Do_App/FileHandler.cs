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


        public void ListAdd()
        {
            StreamWriter sw = new StreamWriter("TasksInText.txt", true);
            string line = "Feed the monkey";
            sw.WriteLine(line);
            sw.Close();
        }

        public void ErrorHandling()
        {
            Console.WriteLine("Unable to add: no task provided");
        }

    }
}
