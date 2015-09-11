using System;
using System.Collections.Generic;

namespace WhiteCrow.Models
{
    
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Class { get; set; }

        public List<Book> Books { get; set; } 

      
    }
}
