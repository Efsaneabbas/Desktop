using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task.Methods
{
    internal class Device
    {
        public bool isOpening = false;
        public decimal Width;
        public decimal Height;
        public decimal Weight;
        public Device(decimal width, decimal height, decimal weight)
        {
            Width = width;
            Height = height;
            Weight = weight;

        }
        public void OpenDevice()
        {
            if (!isOpening)
            {
                isOpening = true;
                Console.WriteLine("Device opening...");
            }
            else
            {
                Console.WriteLine("Device already opened.");
            }
        }


        public void CloseDevice()
        {
            if (isOpening)
            {
                Console.WriteLine("Device closing...");
                isOpening = false;
            }
            else
            {
                Console.WriteLine("Device already closed.");
            }
        }
    }
}
