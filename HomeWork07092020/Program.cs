using System;

namespace HomeWork07092020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age ");
            bool success = int.TryParse(Console.ReadLine(), out int userAge);
            if (!success)
            {
                Console.WriteLine("I don't think that was a number");
                return;

            }
            if (success && userAge>16)
            {
                Console.WriteLine("You are old enough to drive alone");
            } 
            else if (success && userAge >=14 && userAge <16)
            {
                Console.WriteLine("You can drive with an adult");
            }
            else
            {
                Console.WriteLine("You probably shouldn't be driving");
            }
        }
    }

}
