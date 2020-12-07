using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class InMemoryBook : Book 
    {
        public List<double> lgrades;
        private Statistics result;

        public InMemoryBook(string name) : base(name)
        {
            lgrades = new List<double>();
            Name = name;
            result = new Statistics();
        }

               ~InMemoryBook()
        {

        }
        public override void AddGrade(double grade)
        {

            if (grade <= 100 && grade >= 0)
            {
                lgrades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");

            }
        }
        public override void DisplayStats()
        {
            GetMaxMinGradeAvg();
            Console.WriteLine($"The highest grade is {result.High:N1} .");
            Console.WriteLine($"The lowest grade is {result.Low:N1} .");
            Console.WriteLine($"Average grade is {result.Average} and it is a {result.Letter}");
        }

        public override Statistics GetMaxMinGradeAvg()
        {
            int index = 0;
            foreach (var grade in lgrades)
            {
                result.Add(lgrades[index]);
                index ++ ;
            }

        return result;

        }

    }
}

