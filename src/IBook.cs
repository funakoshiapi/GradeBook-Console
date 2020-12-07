using System;
namespace GradeBook
{
    public interface IBook 
    {
        void AddGrade(double grade);
        Statistics GetMaxMinGradeAvg();
        void DisplayStats();
        String Name{get;}
        
    }
}

