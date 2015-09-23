using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WhiteCrow.Logic;
using WhiteCrow.Models;

namespace WhiteCrow.Windows
{
    public partial class StudentsCard : Form
    {
        private readonly Student presentedStudent;
        public StudentsCard(Student student)
        {
            InitializeComponent();
            presentedStudent = student;
            FillStudent();
        }
        public StudentsCard(int Id)
        {
            InitializeComponent();
            var db = XmlHandler.GetDB();
            presentedStudent = db.StudentsList.First(x => x.Id == Id);
            FillStudent();

        }

        private void StudentsCard_Load(object sender, EventArgs e)
        {
            Text = presentedStudent.Name + " " + presentedStudent.Surname + " klasa " + presentedStudent.Class;
        }

        private void FillStudent()
        {
            surnameLabel.Text = presentedStudent.Surname;
            nameLabel.Text = presentedStudent.Name;
            classLabel.Text = presentedStudent.Class.ToString();
            FillBooksList();
        }

        private void FillBooksList()
        {
           booksListBox.Items.Clear();
           if (presentedStudent.BookId.Count != 0)
            {
                foreach (var bookId in presentedStudent.BookId)
                {
                    var book = DBHandler.FindBook(bookId);
                    booksListBox.Items.Add(book.Name);
                }
            }
            else booksListBox.Items.Add("Brak");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editStudent = new AddStudent(presentedStudent);
            editStudent.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DBHandler.DeleteStudent(presentedStudent,true)) Close();
        }
    }
}
