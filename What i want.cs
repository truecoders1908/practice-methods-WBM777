using System;
using System.Collections.Generic;

namespace Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] values = { 2, 7, 9, 10 };

            Console.WriteLine(ContainsAnEight(values));

            int[] sum = { 47, 58, 65, 42, 77 };

            Console.WriteLine(SumArray(sum));

            string AreYouABoy = YesOrNoQuestion("Are you a Boy?");
        }



        static bool ContainsAnEight(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number == 8)
                {
                    return true;
                }
            }

            return false;

        }
        static int SumArray(int[] num)
        {
            int total = 0;
            foreach (int number in num)
            {
                total = total + number;
            }
            return total;

        }

        static string YesOrNoQuestion(string choice)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(choice);
                response = Console.ReadLine();
                if (response.ToLower() == "yes")
                {
                    Console.WriteLine("Cool Story Bro!");
                }
                else if (response.ToLower() == "no")
                {
                    Console.WriteLine("But why man?");
                }
                else
                {
                    Console.WriteLine("Get it together!!");
                }

            }
            return response;

        }

    }
}
