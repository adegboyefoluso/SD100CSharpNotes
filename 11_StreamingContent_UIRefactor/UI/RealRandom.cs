using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor.UI
{
    public class RealRandom : IRandomizer
    {
        public int Next(int min, int max)
        {
            Random rando = new Random();
            Thread.Sleep(rando.Next(1,6));
            return rando.Next(min, max);
        }
    }
}
