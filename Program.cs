using System;
using System.Dynamic;

namespace csharp_loops_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it?");
            string today = Console.ReadLine();
            Console.WriteLine("Yay, today is " + today.ToUpper());

            Console.WriteLine("Let's Count!");
            Console.WriteLine("I will count from 1 to the number you enter: ");
            int countingNumber = Convert.ToInt32(Console.ReadLine());

            // While Loop
            int count = 1;
            while (count <= countingNumber){
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();

            // Do-While Loop
            int count2 = 1;
            do
            {
                Console.Write(count2 + " ");
                count2++;
            } while (count2 <= countingNumber);
            Console.WriteLine();

            // For Loop
            for (int count3 = 1; count3 <= countingNumber; count3++)
            {
                Console.Write(count3 + " ");
            }

        }
    }
}
