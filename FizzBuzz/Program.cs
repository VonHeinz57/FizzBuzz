using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Define an integer to begin FizzBuzz!");
            string start = Console.ReadLine();
            
            Console.WriteLine("How many numbers do you want to increment?");
            string number = Console.ReadLine();

            int iStart;
            int.TryParse(start, out iStart);

            int iNumber;
            int.TryParse(number, out iNumber);

            int increment;

            if(iStart >= 0)
            {
                increment = iNumber + iStart;
            }
            else
            {
                increment = iNumber - Math.Abs(iStart);
            }
            

            for (int i = iStart; i <= increment; i++)
            {
                if(i % 3 == 0 && i % 5 ==0 && i !=0)
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else 
                {
                    Console.WriteLine($"{i}");
                }

            }
        }
    }
}
