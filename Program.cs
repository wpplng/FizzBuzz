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
            int x;
            int y;
            int n;

            // validation for correct number of numbers
            if (userValue.Length != 3) {
                Console.WriteLine("Du måste skriva in 3 heltal, separerade med mellanslag.");
                return;
            }

            // validation for numbers entered, not chars
            try
            {
                x = Convert.ToInt32(userValue[0]);
                y = Convert.ToInt32(userValue[1]);
                n = Convert.ToInt32(userValue[2]);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Vänligen skriv in heltal med siffror.");
                return;
            }

            // validation for correct logic entered
            if (x < 1 || x >= y || y > n || n > 100)
            {
                Console.WriteLine("Vänligen uppfyll reglerna för vilka värden talen får ha, beskrivna ovan.");
                return;
            }

            // logic for fizzbuzz
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