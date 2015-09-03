using System.Collections.Generic;

namespace WhiteCrow.Interfaces
{
    public interface IDatabase
    {
        List<IPerson> GetStudents();

    }
}
