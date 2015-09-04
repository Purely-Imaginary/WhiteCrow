using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhiteCrow.Interfaces;
using WhiteCrow.Models;

namespace WhiteCrow.Logic
{
    public class Lender : ILendProcess
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
            var lookupId = book.GetId();
            student.Books.Remove(student.Books.First(x => x.GetId().Equals(lookupId)));
            return student;
        }
    }
}
