using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool weighted) : base(name, weighted) //call the base constructor upon completion
        {
            Type = GradeBookType.Standard;
        }
    }
}
