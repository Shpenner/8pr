using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr.Classes
{
    public class Electro : Shop
    {
        public string batteryCapacity { get; set; }
        public string speed { get; set; }
        public Electro(string Name, int Price, string batteryCapacity, string speed) : base(Name, Price)
        {
            this.batteryCapacity = batteryCapacity;
            this.speed = speed;
        }
    }
}
