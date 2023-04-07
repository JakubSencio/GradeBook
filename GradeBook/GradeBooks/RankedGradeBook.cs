using System;
using GradeBook.Enums;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int TOP20 = (int)Math.Ceiling(0.2 * Students.Count);
            List<double> averageGradesList = Students.OrderBy(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            if (averageGrade <= averageGradesList[0])
            {
                return 'F';
            }
            else if (averageGrade <= averageGradesList[TOP20])
            {
                return 'D';
            }
            else if (averageGrade <= averageGradesList[TOP20 * 2])
            {
                return 'C';
            }

            else if (averageGrade <= averageGradesList[TOP20 * 3])
            {
                return 'B';
            }
            else
            {
                return 'A';
            }
        }
        public override void CalculateStatistics()
        {
            if (Students == null || Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students == null || Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}
