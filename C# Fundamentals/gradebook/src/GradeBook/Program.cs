using System;
using System.Collections.Generic;

namespace GradeBook
{


    public class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scots's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The Highest grade is {stats.High}");
            Console.WriteLine($"The Average grade is {stats.Average:N1}");
        }
    }
}
