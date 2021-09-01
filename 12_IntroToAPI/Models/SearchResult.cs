using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntroToAPI.Models
{
    public class SearchResult<T>
    {
        public int Count { get; set; }
        public List<T> Results { get; set; }
    }
}
