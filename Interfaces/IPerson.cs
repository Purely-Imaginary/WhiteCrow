using System.Collections.Generic;
using WhiteCrow.Models;

namespace WhiteCrow.Interfaces
{
    public interface IPerson
    {
        string GetName();

        string GetSurname();

        List<Book> GetBooks();



    }
}
