using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task.Methods
{
    internal class Mobile : Device
    {
        public string[] SimCards;
        public string[] numbers;
        public int Count;


        public Mobile(int numberCapacity, decimal width, decimal height, decimal weight, int simCartCount) : base(width, height, weight)
        {
            if (simCartCount < 1 || simCartCount > 2)
            {
                throw new ArgumentException("SimCardCount must be 1 or 2.");
            }

            SimCards = new string[simCartCount];
            Count = 0;
            numbers = new string[numberCapacity];
        }

        public void AddNumber(string number)
        {
            if (Count < numbers.Length)
            {
                if (SimCards.Length == 1 || (SimCards.Length == 2 && Count < SimCards.Length))
                {
                    numbers[Count] = number;
                    Count++;
                    Console.WriteLine($"Numer {number} added succesfully.");
                }
                else
                { 
                    Console.WriteLine("Cannot add more numbers.");
                }
            }
            else
            {
                Console.WriteLine("Number capacity exceeded. Cannot add more numbers.");
            }
        }
        public bool RemoveNumberAt(int index)
        {
            if (index >= Count)
            {
                return false;
            }

            for (int i = index; i < Count - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[Count - 1] = null;
            Count--;
            return true;
        }


        public string[] GetNumbers()
        {
            string[] copy = new string[Count];
            Array.Copy(numbers, copy, Count);
            return copy;
        }

    }
}


