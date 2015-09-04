using System.Collections.Generic;
using WhiteCrow.Models;

namespace WhiteCrow.Interfaces
{
    public interface IDatabase
    {
        List<Student> GetStudents();

    }
}
