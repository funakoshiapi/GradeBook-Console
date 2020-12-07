using System;
using System.Collections.Generic;
using GradeBook;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new DiskBook("Pablo");

            EnterGrades(book);
            book.DisplayStats();

        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a a grade or 'q' to quit");

                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    book.AddGrade(double.Parse(input));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

    }
}
