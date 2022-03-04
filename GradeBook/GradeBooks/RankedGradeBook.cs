using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int studentsCount = Students.Count;
            if (studentsCount < 5) throw new InvalidOperationException();

            double[] gradesList = new double[studentsCount];

            for (int i = 0; i < studentsCount; i++)
            {
                gradesList[i] = Students[i].AverageGrade;
            }

            Array.Sort(gradesList);
            string grades = "FDCBA";

            for (int i = 5; i > 0; i--)
            {
                double percentile = i * studentsCount / 5 - 1;
                if (gradesList[(int)Math.Ceiling(percentile)] <= averageGrade) return grades[i - 1];
            }


            return 'F';
        }
    }
}
