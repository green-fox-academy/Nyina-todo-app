using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_App
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer();
            FileHandler fileHandler = new FileHandler();

            if (args.Length == 0)
            {
                printer.TextToPrint();
            }
            else if (args[0] == "-l")
            {
                fileHandler.FileReader();
            }

            else if (args.Contains("-al"))
            {
                fileHandler.ListAdd();
            }
            else if (args.Contains("-a"))
            {
                fileHandler.ErrorHandling();
            }

            //else if (args[0] == "-l" && args[1] == "-a")

                //Console.ReadLine();
        }
    }
}
