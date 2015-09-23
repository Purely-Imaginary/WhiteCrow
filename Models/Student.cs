using System.Collections.Generic;

namespace WhiteCrow.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Class { get; set; }
        public List<string> BookId { get; set; }
    }
}