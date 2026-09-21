using System;
using System.Windows.Forms;
using BusinessLogic;

namespace DecanatPRO.WinForms
{
    public partial class Form1 : Form
    {
        private readonly Logic logic = new Logic();
        private readonly BindingSource studentsBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            Text = "DecanatPRO";
            MinimumSize = new Size(500, 300);

            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dgvStudents.DataSource = studentsBindingSource;
            RefreshGrid();
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvStudents.Columns["Name"] != null)
            {
                dgvStudents.Columns["Name"].HeaderText = "ФИО";
                dgvStudents.Columns["Speciality"].HeaderText = "Направление";
                dgvStudents.Columns["Group"].HeaderText = "Группа";
            }
        }

        private void RefreshGrid()
        {
            studentsBindingSource.DataSource = logic.GetAllStudents();
            studentsBindingSource.ResetBindings(false);
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

            var name = dgvStudents.CurrentRow.Cells["Name"].Value?.ToString();
            var speciality = dgvStudents.CurrentRow.Cells["Speciality"].Value?.ToString();
            var group = dgvStudents.CurrentRow.Cells["Group"].Value?.ToString();

            if (name != null && speciality != null && group != null)
            {
                logic.DeleteStudent(name, speciality, group);
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