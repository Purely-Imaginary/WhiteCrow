using System.Linq;
using System.Windows.Forms;
using WhiteCrow.Models;

namespace WhiteCrow.Displays
{
    public class BooksViewDisplay
    {
        public static DataGridView ShowBooksGrid(DataGridView dgv, Database db)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv = MakeColumns(dgv);
            foreach (var book in db.BookList)
            {
                dgv.Rows.Add(FillRow(book));
            }
            return dgv;
        }
        private static DataGridView MakeColumns(DataGridView dgv)
        {
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("Name", "Tytuł");
            dgv.Columns.Add("Publisher", "Wydawca");
            dgv.Columns.Add("Class", "Klasa");
            dgv.Columns.Add("Value", "Wartość");
            dgv.Columns.Add("TimeAdded", "Czas dodania");
            dgv.Columns.Add("DoesHaveNote", "Notka");
            
            return dgv;
        }
        private static DataGridViewRow FillRow(Book book)
        {
            var row = new DataGridViewRow();
            for (var i = 0; i < 7; i++)
            {
                row.Cells.Add(new DataGridViewTextBoxCell());
            }

            row.Cells[0].Value = book.Id;
            row.Cells[1].Value = book.Name;
            row.Cells[2].Value = book.Publisher;
            row.Cells[3].Value = book.Class;
            row.Cells[4].Value = book.Value;
            row.Cells[5].Value = book.TimeAdded.ToShortDateString();
            row.Cells[6].Value = book.Notes;
            return row;
        }

    }

}