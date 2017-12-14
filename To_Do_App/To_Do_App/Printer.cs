using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_App
{
    public class Printer
    {
     
        public void TextToPrint()
        {
            Console.WriteLine(
                "Command Line Todo application\n" +
                "=============================\n" +
                "\n" +
                "Command line arguments:\n" +
                "- l   Lists all the tasks\n" +
                "- a   Adds a new task\n" +
                "- r   Removes an task\n" +
                "- c   Completes an task"
                );
        }
            








}
}
