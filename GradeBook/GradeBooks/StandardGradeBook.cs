using System;
using System.Collections.Generic;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
        }
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
