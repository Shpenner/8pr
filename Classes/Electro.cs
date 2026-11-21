using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr.Classes
{
    public class Electro : Shop
    {
        public int batteryCapacity { get; set; }
        public int speed { get; set; }
        public Electro(string Name, int Price, int batteryCapacity, int speed) : base(Name, Price)
        {
            this.batteryCapacity = batteryCapacity;
            this.speed = speed;
        }
    }
}
