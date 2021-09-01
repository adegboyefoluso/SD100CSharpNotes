using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor.UI
{
    public class SlowConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            foreach (char letter in s)
            {
                Thread.Sleep(50);
                Console.Write(letter);
            }
            Console.Write("\n");
            Thread.Sleep(1000);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
