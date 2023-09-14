using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string Capital { get; set; }
        public string Language { get; set; }
        public List<string> Attractions { get; set; }
    }
}
