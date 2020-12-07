using System.Collections.Generic;
using System;
namespace GradeBook
{
    public abstract class Book : NameObject , IBook 
    {
        public Book (string name) : base(name)
        {

        }
        public abstract void AddGrade(double grade);
        public abstract Statistics GetMaxMinGradeAvg();

         public abstract void DisplayStats();
    }
}

