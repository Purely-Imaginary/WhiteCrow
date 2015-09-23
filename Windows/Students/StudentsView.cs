using System;
using System.Windows.Forms;
using WhiteCrow.Displays;
using WhiteCrow.Logic;

namespace WhiteCrow.Windows
{
    public partial class StudentsView : Form
    {
        public StudentsView()
        {
            InitializeComponent();
        }

        private void StudentsView_Load(object sender, EventArgs e)
        {
            DBHandler.CheckIntegrity();
            studentsDataView = StudentsViewDisplay.ShowStudentsGrid(studentsDataView, XmlHandler.GetDB());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudent();
            addStudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsDataView = StudentsViewDisplay.ShowStudentsGrid(studentsDataView, XmlHandler.GetDB());
        }

        private void studentsDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView) sender;

            var student = DBHandler.FindStudent(dgv);
            var studentCard = new StudentsCard(student);
            studentCard.Show();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            studentsDataView = StudentsViewDisplay.FilterView(studentsDataView, searchBar.Text);
        }

        private void StudentsView_Activated(object sender, EventArgs e)
        {
            studentsDataView = StudentsViewDisplay.ShowStudentsGrid(studentsDataView, XmlHandler.GetDB());
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            var student = DBHandler.FindStudent(studentsDataView);
            DBHandler.DeleteStudent(student, true);
        }

        private void deleteClassButton_Click(object sender, EventArgs e)
        {
            var student = DBHandler.FindStudent(studentsDataView);
            DBHandler.DeleteClass(student.Class,true);

        }


        private void switchStripMenu_Click(object sender, EventArgs e)
        {
            DBHandler.NameSurnameSwitch();
        }

        private void studentsDataView_Sorted(object sender, EventArgs e)
        {
            StudentsViewDisplay.RestoreRowHeaders(studentsDataView);
        }
    }
}