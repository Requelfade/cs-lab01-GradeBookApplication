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

            int studentsStep = studentsCount / 5;



            return base.GetLetterGrade(averageGrade);
        }
    }
}
