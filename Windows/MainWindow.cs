
using System.Windows.Forms;
using WhiteCrow.Windows;

namespace WhiteCrow
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var studentsView = new StudentsView();
            studentsView.Show();
        }
    }
}
