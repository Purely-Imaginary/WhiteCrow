using WhiteCrow.Models;

namespace WhiteCrow.Interfaces
{
    public interface ILendProcess
    {
        Student LendBook(Student student, IBook book);
        Student ReturnBook(Student student, IBook book);



        
    }
}
