using System;
using System.Linq;
using System.Windows.Forms;
using WhiteCrow.Models;

namespace WhiteCrow.Logic
{
    public static class DBHandler
    {
        public static Student FindStudent(int Id)
        {
            var db = XmlHandler.GetDB();
            var student = db.StudentsList.First(x => x.Id == Id);
            return student;
        }

        public static Student FindStudent(DataGridView dgv)
        {
            var db = XmlHandler.GetDB();

            var cell = dgv.SelectedCells[0];
            var row = cell.OwningRow;
            var id = int.Parse(row.Cells[0].Value.ToString());
            var student = db.StudentsList.First(x => x.Id == id);
            return student;
        }

        public static Book FindBook(string Id)
        {
            var db = XmlHandler.GetDB();
            return (db.BookList.First(x => x.Id == Id));
        }

        public static void CheckIntegrity()
        {
            var db = XmlHandler.GetDB();

            for (var i = 1; i <= db.StudentsList.Count; i++)
            {
                var idSearch = db.StudentsList.Where(x => x.Id == i);

                if (idSearch.Count() > 1)
                {
                    MessageBox.Show(
                        "Struktura bazy danych została naruszona, następuje próba odratowania struktury danych!");
                    RestoreIntegrity();
                    return;
                }
            }
        }

        private static void RestoreIntegrity()
        {
            var db = XmlHandler.GetDB();

            var i = 1;
            foreach (var student in db.StudentsList)
            {
                student.Id = i;
                i++;
            }
            XmlHandler.SaveDB(db);

            MessageBox.Show(
                "Struktura bazy danych została pomyślnie odnowiona!");
        }

        public static bool DeleteStudent(Student student, bool prompt)
        {
            if (prompt)
            {
                var confirmResult = MessageBox.Show("Czy na pewno skasować tego ucznia?", "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo);


                if (confirmResult != DialogResult.Yes) return false;
            }
            var db = XmlHandler.GetDB();

            db.StudentsList.RemoveAll(x => x.Id == student.Id);
            XmlHandler.SaveDB(db);

            if (prompt)
                MessageBox.Show("Uczeń " + student.Name + " " + student.Surname + " z klasy " + student.Class +
                                " został skasowany z bazy danych!");
            return true;
        }

        public static void AddStudent(Student student)
        {
            // TO DO CHECK FOR DUPLICATE
            var db = XmlHandler.GetDB();

            student.Id = db.StudentsList.OrderByDescending(x => x.Id).First().Id + 1;
            //Sorting by Id, getting highest and adding 1
            db.StudentsList.Add(student);

            XmlHandler.SaveDB(db);

            MessageBox.Show("Uczeń " + student.Name + " " + student.Surname + " z klasy " + student.Class +
                            " został dodany do bazy danych!");
        }

        public static void EditStudent(Student original, Student edited)
        {
            var db = XmlHandler.GetDB();
            // edited.id = original.id; remove original; add edited?
            original.Surname = edited.Surname;
            original.Name = edited.Name;
            original.Class = edited.Class;
            db.StudentsList.RemoveAll(x => x.Id == original.Id);
            db.StudentsList.Add(original);

            XmlHandler.SaveDB(db);

            MessageBox.Show("Uczeń " + edited.Name + " " + edited.Surname + " z klasy " + edited.Class +
                            " został wyedytowany!");
        }

        public static void DeleteClass(string classId, bool prompt)
        {
            var db = XmlHandler.GetDB();
            var studentList = db.StudentsList.Where(x => x.Class == classId);

            var message = "Czy na pewno chcesz skasować tych uczniów?\n\n";
            foreach (var student in studentList)
            {
                message += student.Name + " " + student.Surname + "\n";
            }

            var confirmResult = MessageBox.Show(message, "Potwierdź usunięcie",
                MessageBoxButtons.YesNo);

            if (prompt && confirmResult != DialogResult.Yes) return;
            foreach (var student in studentList)
            {
                DeleteStudent(student, false);
            }
        }

        public static void AddBook(Book book)
        {
            var db = XmlHandler.GetDB();

            
            //Sorting by Id, getting highest and adding 1
            db.BookList.Add(book);

            XmlHandler.SaveDB(db);

            MessageBox.Show("Książka " + book.Name + " " + " została dodana do bazy danych!");
        }

        public static void EditBook(Book oldBook, Book newBook)
        {
            var db = XmlHandler.GetDB();
            db.BookList.RemoveAll(x => x.Id == oldBook.Id);
            db.BookList.Add(newBook);
            MessageBox.Show("Książka " + newBook.Name +" została wyedytowana!");
        }

        public static void DeleteBook(Book book, bool prompt)
        {
            if (prompt)
            {
                var confirmResult = MessageBox.Show("Czy na pewno skasować tę książkę?", "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo);


                if (confirmResult != DialogResult.Yes) return;
            }
            var db = XmlHandler.GetDB();

            db.BookList.RemoveAll(x => x.Id == book.Id);
            XmlHandler.SaveDB(db);

            if (prompt)
                MessageBox.Show("Książka " + book.Name + " została skasowana z bazy danych!");
            
        }

        public static void NameSurnameSwitch()
        {
            var db = XmlHandler.GetDB();
            foreach (var student in db.StudentsList)
            {
                var bufor = student.Name;
                student.Name = student.Surname;
                student.Surname = bufor;
            }
            XmlHandler.SaveDB(db);
        }
    }
}