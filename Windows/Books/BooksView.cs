using System;
using System.Windows.Forms;
using WhiteCrow.Displays;
using WhiteCrow.Logic;
using WhiteCrow.Windows.Books;

namespace WhiteCrow.Windows
{
    public partial class BooksView : Form
    {
        public BooksView()
        {
            InitializeComponent();
        }

        private void BooksView_Load(object sender, EventArgs e)
        {
            booksDataView = BooksViewDisplay.ShowBooksGrid(booksDataView, XmlHandler.GetDB());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addBook = new AddBook();
            addBook.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            booksDataView = BooksViewDisplay.ShowBooksGrid(booksDataView, XmlHandler.GetDB());
        }

        private void BooksView_Activated(object sender, EventArgs e)
        {
            booksDataView = BooksViewDisplay.ShowBooksGrid(booksDataView, XmlHandler.GetDB());
        }
    }
}
