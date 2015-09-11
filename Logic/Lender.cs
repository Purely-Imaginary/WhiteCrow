using System;
using System.Linq;
using WhiteCrow.Models;

namespace WhiteCrow.Logic
{
    public class Lender
    {
        public Student LendBook(Student student, Book book)
        {
            var newBook = (Book) book;
            newBook.BorrowTime = DateTime.Now; 
            student.Books.Add(book);
            return student;
        }

        public Student ReturnBook(Student student, Book book)
        {
            // TO DO CHECK FOR VALID ID
            var lookupId = book.Id;
            student.Books.Remove(student.Books.First(x => x.Id.Equals(lookupId)));
            return student;
        }
    }
}
