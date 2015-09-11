using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WhiteCrow.Logic;
using WhiteCrow.Models;

namespace WhiteCrow.Displays
{
    public static class StudentsViewDisplay
    {
        public static DataGridView ShowStudentsGrid(DataGridView dgv, Database db)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv = MakeColumns(dgv);
            foreach (var student in db.StudentsList)
            {
                dgv.Rows.Add(FillRow(student));
            }
            return dgv;

        }

        static DataGridView MakeColumns(DataGridView dgv)
        {
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("Surname", "Nazwisko");
            dgv.Columns.Add("Name", "Imię");
            dgv.Columns.Add("Class", "Klasa");
            dgv.Columns.Add("BookCount", "Ilość książek");
            return dgv;
        }
        static DataGridViewRow FillRow(Student student)
        {
            var row = new DataGridViewRow();
            for (int i = 0; i < 5; i++)
            {
                 row.Cells.Add(new DataGridViewTextBoxCell());
            }

            row.Cells[0].Value = student.Id;
            row.Cells[1].Value = student.Surname;
            row.Cells[2].Value = student.Name;
            row.Cells[3].Value = student.Class;
            row.Cells[4].Value = student.Books.Count;
            return row;

        }

        public static Student GetStudent(DataGridViewCell cell)
        {
            return null;
        }

        public static DataGridView FilterView(DataGridView dgv, string input)
        {
            input = input.ToLower();
            var db = XmlHandler.GetDB();

            var validStudentsList =
                db.StudentsList.Where(
                    x => x.Id.ToString().Contains(input) 
                        || x.Name.ToLower().Contains(input) 
                        || x.Surname.ToLower().Contains(input));

            dgv.Rows.Clear();
           
            foreach (var student in validStudentsList)
            {
                dgv.Rows.Add(FillRow(student));
            }
            return dgv;
        }

    }
}