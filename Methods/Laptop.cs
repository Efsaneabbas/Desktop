using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task.Methods
{
    internal class Laptop: Device
    {
        public int PortCount;
        public Laptop(decimal width, decimal height, decimal weight, int portcount):base(width, height, weight)
        {
            PortCount = portcount;
        }
    }
}
