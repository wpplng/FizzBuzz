using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vänligen skriv in tre heltal, separerade med mellanslag.");
            Console.WriteLine("Det första talet måste vara större än 1.");
            Console.WriteLine("Det andra talet måste vara större än det första.");
            Console.WriteLine("Det sista talet måste vara minst lika stort som det andra och inte högre än 100.");

            string[] userValue = Console.ReadLine().Split(" ");
            
            int x = Convert.ToInt32(userValue[0]);
            int y = Convert.ToInt32(userValue[1]);
            int n = Convert.ToInt32(userValue[2]);

            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}