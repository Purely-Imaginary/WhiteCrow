using WhiteCrow.Models;

namespace WhiteCrow.Interfaces
{
    public interface ILendProcess
    {
        Student LendBook(Student student, Book book);
        Student ReturnBook(Student student, Book book);



        
    }
}
