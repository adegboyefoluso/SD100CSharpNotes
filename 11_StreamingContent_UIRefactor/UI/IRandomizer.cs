using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor.UI
{
    public interface IRandomizer
    {
        int Next(int min, int max);
    }
}
