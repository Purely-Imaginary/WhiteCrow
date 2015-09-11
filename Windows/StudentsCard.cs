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
        public StudentsCard(Student student)
        {
            InitializeComponent();
            FillStudent(student);

        }
        public StudentsCard(int Id)
        {
            InitializeComponent();
            var db = XmlHandler.GetDB();
            var student = db.StudentsList.First(x => x.Id == Id);
            FillStudent(student);

        }

        private void StudentsCard_Load(object sender, EventArgs e)
        {

        }

        private void FillStudent(Student student)
        {
            surnameLabel.Text = student.Surname;
            nameLabel.Text = student.Name;
            classLabel.Text = student.Class.ToString();
            FillBooksList(student);
        }

        private void FillBooksList(Student student)
        {
           booksListBox.Items.Clear();
            if (student.Books.Count != 0)
            {
                foreach (var book in student.Books)
                {
                    booksListBox.Items.Add(book.Name);
                }
            }
            else booksListBox.Items.Add("Brak");
        }
    }
}
