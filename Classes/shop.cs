using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr.Classes
{
    public class shop
    {
        public string Name { get; set; }
        public int Price {  get; set; }

        public shop(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        
    }
}
