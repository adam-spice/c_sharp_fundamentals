using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 34.1;
            var y = 17.2;
            var result = x + y;
            Console.WriteLine(result);

            var numbers = new [] { 12.7, 10.3, 6.11 };
            var numbersResult = 0.0;
            foreach (double number in numbers)
            {
                numbersResult += number;
            }
            System.Console.WriteLine(numbersResult);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var gradesResult = 0.0;
            foreach (double number in grades)
            {
                gradesResult += number;
            }
            gradesResult /= grades.Count;
            System.Console.WriteLine($"The average grade is {gradesResult:N1}");



            if(args.Length >0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
