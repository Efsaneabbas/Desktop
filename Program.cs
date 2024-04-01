using Inheritance_Task.Methods;

namespace Inheritance_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device(12m, 13m, 14m);

            
            Mobile mobile = new Mobile(4, 2, 5m, 6m, 2);

            device.OpenDevice();
            device.OpenDevice();
            device.OpenDevice();

            device.CloseDevice();
            device.CloseDevice();
            device.CloseDevice();
            device.OpenDevice();


            mobile.AddNumber("0552330409");
            mobile.AddNumber("0503530414");

            mobile.SimCards[0] = "Bakcell";
            mobile.SimCards[1] = "Azercell";

            Console.WriteLine("All phone numbers after addition::");
            string[] allNumbersAfterAddition = mobile.GetNumbers();
            foreach (string number in allNumbersAfterAddition)
            {
                Console.WriteLine(number);
            }


 

            bool removeAtIndex = mobile.RemoveNumberAt(1);
            if (removeAtIndex)
            {
                Console.WriteLine("Number at index 1 removed succesfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }

            
            Console.WriteLine("Phone numbers after removal:");
            string[] remainingNumbers = mobile.GetNumbers();
            foreach (string number in remainingNumbers)
            {
                Console.WriteLine(number);
            }

            mobile.AddNumber("0557895478");

            Console.WriteLine("All phone numbers after second addition:");
            string[] allNumWithSecAdd = mobile.GetNumbers();
            foreach (string number in allNumWithSecAdd)
            {
                Console.WriteLine(number);
            }


        }
    }
}