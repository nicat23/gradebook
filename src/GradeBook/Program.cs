using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Justin's Grade Book");
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // ..
                }
            }
            var stats = book.GetStatistics();

            Console.WriteLine($"For the grade book named {book.Name}");
            Console.WriteLine($"Lowest grade: {stats.Low}");
            Console.WriteLine($"Highest grade: {stats.High}");
            Console.WriteLine($"Average: {stats.Average:N2}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            //List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
        }
    }
}
