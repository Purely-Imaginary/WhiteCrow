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
    }
}