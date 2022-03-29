using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            
            var result = 0.0;
            foreach(var number in grades) 
            {
                result += number;
            }

            Console.WriteLine($"The sum is {result}!");

            var average = 0.0;
            average = result / grades.Count;

            System.Console.WriteLine($"The Average Grade is {average:N1}");

            
        }
    }
}
