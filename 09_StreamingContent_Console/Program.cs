using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{
    class Program
    {
        // args = array of options or commands you can type after the name of the program
        static void Main(string[] args)
        {
            /*
            if (args[0] == "-v" || args[0] =="--version")
            {
                // Console.WriteLine([the app version number]);
            }
            */

            // This is where you set up the app, deal with input, etc
            ProgramUI ui = new ProgramUI();
            ui.Run();

            // Not static because we need to use a field
            // ProgramUI.Run();
        }
    }
}
