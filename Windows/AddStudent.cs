using System;
using System.Windows.Forms;
using WhiteCrow.Logic;
using WhiteCrow.Models;

namespace WhiteCrow.Windows
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        

        private void addButton_Click(object sender, EventArgs e)
        { // TO DO CHECK FOR DUPLICATE
            var db = XmlHandler.GetDB();
            var stud = getStudent();
            stud.Id = db.StudentsList.Count + 1;
            db.StudentsList.Add(stud);
            XmlHandler.SaveDB(db);
            MessageBox.Show("Uczeń " + stud.Name + " " + stud.Surname + " z klasy " + stud.Class + " został dodany do bazy danych!");
            Close();
        }

        Student getStudent()
        { // TO DO CHECK FOR VALID DATA
            var stud = new Student
            {
                Surname = surnameTextbox.Text,
                Name = nameTextbox.Text,
                Class = int.Parse(classCombo.Text)
            };
            return stud;
        }
    }
}
