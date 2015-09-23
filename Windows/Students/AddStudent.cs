using System;
using System.Windows.Forms;
using WhiteCrow.Logic;
using WhiteCrow.Models;

namespace WhiteCrow.Windows
{
    public partial class AddStudent : Form
    {
        private readonly Student editedStudent;

        public AddStudent()
        {
            InitializeComponent();
        }

        public AddStudent(Student student)
        {
            InitializeComponent();
            addButton.Click -= addButton_Click;
            addButton.Click += editButton_Click;

            addButton.Text = "Edytuj";

            nameTextbox.Text = student.Name;
            surnameTextbox.Text = student.Surname;
            classTextbox.Text = student.Class;

            editedStudent = student;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var stud = getStudent();
            DBHandler.AddStudent(stud);
            Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // TO DO CHECK FOR DUPLICATE

            var stud = getStudent();
            DBHandler.EditStudent(editedStudent, stud);
            Close();
        }

        private Student getStudent()
        {
            // TO DO CHECK FOR VALID DATA
            var stud = new Student
            {
                Surname = surnameTextbox.Text,
                Name = nameTextbox.Text,
                Class = classTextbox.Text
            };
            return stud;
        }
    }
}