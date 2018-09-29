using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name) //call the base constructor upon completion
        {
            Type = GradeBookType.Standard;
        }
    }
}
