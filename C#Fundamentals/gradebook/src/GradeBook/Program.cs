using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Branden's Grade Book");

            while(true)
            {
                Console.WriteLine("Please enter grade or 'q' to quit.");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // can be used to catch all exceptions. No specified error just general message.
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                finally
                {
                    Console.WriteLine($"{input} Was Entered");
                }
                
            }

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"the letter grade is {stats.Letter}");
        }
    }
}
