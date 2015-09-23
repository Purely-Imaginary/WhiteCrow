using System;
using System.Windows.Forms;
using WhiteCrow.Logic;
using WhiteCrow.Models;

namespace WhiteCrow.Windows.Books
{
    public partial class AddBook : Form
    {
        private readonly Book editedBook;

        public AddBook()
        {
            InitializeComponent();
        }

        public AddBook(Book book)
        {
            InitializeComponent();
            addButton.Click -= addButton_Click;
            addButton.Click += editButton_Click;

            addButton.Text = "Edytuj";

            numberTextBox.Text = book.Id;
            titleTextBox.Text = book.Name;
            publisherTextBox.Text = book.Publisher;
            classTextBox.Text = book.Class;
            valueTextBox.Text = book.Value.ToString();
            noteRichTextBox.Text = book.Notes;


            editedBook = book;
        }
        

        private void addButton_Click(object sender, EventArgs e)
        {
            var book = GetBook();
            if (book == null) return;
            DBHandler.AddBook(book);
            Close();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            // TO DO CHECK FOR DUPLICATE

            var book = GetBook();
            if (book == null) return;
            DBHandler.EditBook(editedBook, book);
            Close();
        }

        private Book GetBook()
        {
            float bookValue;
            var valParse = float.TryParse(valueTextBox.Text, out bookValue);

            if (valParse)
                return new Book()
                {
                    Id = numberTextBox.Text,
                    Name = titleTextBox.Text,
                    Publisher = publisherTextBox.Text,
                    Class = classTextBox.Text,
                    Notes = noteRichTextBox.Text,
                    Value = bookValue,
                    TimeAdded = DateTime.Now
                };
            MessageBox.Show("Wartość książki nie jest liczbą!");
            return null;
        }
    }
}