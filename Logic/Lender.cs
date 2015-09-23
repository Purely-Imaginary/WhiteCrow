using System;
using System.Linq;
using WhiteCrow.Models;

namespace WhiteCrow.Logic
{
    public class Lender
    {
        public Student LendBook(Student student, Book book)
        {
            var newBook = book;
            //newBook.BorrowTime = DateTime.Now; 
            student.BookId.Add(book.Id);
            return student;
        }

        public Student ReturnBook(Student student, Book book)
        {
            // TO DO CHECK FOR VALID ID
            var lookupId = book.Id;
            student.BookId.Remove(student.BookId.First(x => x.Equals(lookupId)));
            return student;
        }
    }
}
