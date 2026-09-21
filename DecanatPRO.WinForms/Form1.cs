using System;
using System.Windows.Forms;
using BusinessLogic;

namespace DecanatPRO.WinForms
{
    public partial class Form1 : Form
    {
        private readonly Logic logic = new Logic();

        public Form1()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = logic.GetAllStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddStudentForm(logic))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Выберите студента в таблице.");
                return;
            }

            var row = dgvStudents.CurrentRow.DataBoundItem as Model.Student;
            if (row != null)
            {
                logic.DeleteStudent(row.Name, row.Speciality, row.Group);
                RefreshGrid();
            }
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            using (var histogramForm = new HistogramForm(logic))
            {
                histogramForm.ShowDialog();
            }
        }
    }
}