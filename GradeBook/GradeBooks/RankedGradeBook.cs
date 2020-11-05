using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            double Average = 0;
            
            foreach(var student in Students)
            {
                Average += student.AverageGrade;
            }

            if (averageGrade >= Average * 0.8) return 'A'; else return 'F';
        }
    }
}
