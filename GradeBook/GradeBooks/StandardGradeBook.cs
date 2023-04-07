using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook 
    {
        public StandardGradeBook(string name, bool isWeigthed, bool isCurved) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;
            IsCurved = isCurved;
        }
        public bool IsCurved { get; set; }
    }
}
