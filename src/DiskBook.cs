using System.Collections.Generic;
using System;
using System.IO;

namespace GradeBook
{

    public class DiskBook : Book
    {
        private Statistics result;
        public DiskBook(string name) : base(name)
        {
            result = new Statistics();
        }

        ~DiskBook()
        {
            if (result != null)
            {
                result.Dispose();
            }
        }

        public override void AddGrade(double grade)
        {
            
            if (grade <= 100 && grade >= 0)
            {
                using ( var writer = File.AppendText($"{Name}.txt") )
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");

            }
        }

        public override Statistics GetMaxMinGradeAvg()
        {
          

            using ( var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            return result;
        }

        public override void DisplayStats()
        {
            GetMaxMinGradeAvg();
            Console.WriteLine($"The highest grade is {result.High:N1} .");
            Console.WriteLine($"The lowest grade is {result.Low:N1} .");
            Console.WriteLine($"Average grade is {result.Average} and it is a {result.Letter}");
        }
    }
}