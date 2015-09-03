using System;
using System.Windows.Forms;
using WhiteCrow.Interfaces;

namespace WhiteCrow.Models
{
    public class Book : IBook
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Class { get; set; }

        public DateTime BorrowTime { get; set; }
        public string GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public DateTime GetBorrowTime()
        {
            return BorrowTime;
        }
    }
}
