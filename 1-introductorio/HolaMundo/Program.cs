using System;
using Microsoft.VisualBasic.CompilerServices;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your last name?");
            string lastName = Console.ReadLine();
            string fecha = DateTime.Now.ToString();
            Console.WriteLine($"Your last name is {lastName} and the actual date is: {fecha}");
            
            
            Console.Write("Give me a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give me another number:");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"The sum is {num1+num2}");
        }
    }
}