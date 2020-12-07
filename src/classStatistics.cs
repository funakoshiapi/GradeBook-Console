using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch(Average)
                {
                    case var num when num >= 90:
                        return 'A';
                    case var num when num  >= 80:
                        return'B';
                    case var num when num  >= 70:
                        return'C';
                    case var num when num  >= 60:
                        return'D';
                    default:
                        return'F';        
                }
            }
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        public double Sum;
        public int Count;

        public Statistics()
        {
            High = 0.0;
            Low = 0.0;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;

            if (number > High)
            {
                High = number;
            }

            if (number < High || Low > number )
            {
                Low = number;
            }
        }
    }
}