using System;

namespace WhiteCrow.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Id { get; set; }
        public string Class { get; set; }
        public float Value { get; set; }
        //public DateTime BorrowTime { get; set; }
        public DateTime TimeAdded { get; set; }
        public string Notes { get; set; }
    }
}