using System.Collections.Generic;
using WhiteCrow.Interfaces;

namespace WhiteCrow.Models
{
    public class Database : IDatabase
    {
        public List<Student> StudentsList { get; set; }

        public List<Student> GetStudents()
        {
            return StudentsList;
        }
    }
}