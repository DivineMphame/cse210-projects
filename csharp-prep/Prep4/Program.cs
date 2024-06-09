using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int choiceNumber = -1;
        while (choiceNumber != 0)
        {
            Console.Write("Enter a list of numbers,enter 0 to when you are finished. ");

            string userResponse = Console.ReadLine();
            choiceNumber = int.Parse(userResponse);

            if (choiceNumber != 0)
            {
                numbers.Add(choiceNumber);
            }
        }
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is : {sum}");
         float Average = ((float)sum) / numbers.Count;
         Console.WriteLine($"The average is : {Average}");

         int max = numbers[0];

         foreach (int number in numbers)
         {
            if (number > max)
            {
                max = number;
            }
         }
         Console.WriteLine($"The max is : {max}");
    }
}