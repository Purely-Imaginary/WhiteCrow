using System;

namespace WhiteCrow.Models
{
    public class Book
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Class { get; set; }

        public DateTime BorrowTime { get; set; }
        
    }
}
