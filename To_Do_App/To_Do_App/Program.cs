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

            else if (args.Contains("-a"))
            {   //ha nem adok meg 2. argumentumot, akkor dobjon hibaüzenetet
                if (args.Length == 1)
                {
                    fileHandler.ErrorHandling();
                }
                else
                {   //itt hivatkozom be, hogy a 2. argumentumként mit adjon hozzá a listához
                    fileHandler.ListAdd(args[1]);
                }
            }


            else if (args.Contains("-r"))
            {
                if (args.Length == 1)
                {
                    printer.ErrorEnableToRemove();
                }
                else
                {
                    fileHandler.RemoveLines(Int32.Parse(args[1]));
                }
            }

            //else if (args[0] == "-l" && args[1] == "-a")

            //Console.ReadLine();
        }
    }
}
