using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using WhiteCrow.Interfaces;

namespace WhiteCrow.Models
{
    
    public class Student : IPerson
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Class { get; set; }

        public List<Book> Books { get; set; } 

        public string GetName()
        {
            return Name;
        }

        public string GetSurname()
        {
            return Surname;
        }

        public List<Book> GetBooks()
        {
            return new List<Book>();
        }
    }
}
