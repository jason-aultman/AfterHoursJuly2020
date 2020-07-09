using System;

namespace HomeWork07082020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            string input = Console.ReadLine();
            if(!int.TryParse(input, out int InputAsInt))
            {
                Console.WriteLine("There was something wrong with your input.");
                return;
            }
            Console.WriteLine("Your input was "+InputAsInt);
            
        }
    }
}
