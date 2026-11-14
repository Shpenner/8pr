using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr.Classes
{
    public class Children : Shop
    {
        public int Age { get; set; }
        public Children(string Name, int Price, int Age) :base(Name, Price)
        {
            this.Age = Age;
        }
    }
}
