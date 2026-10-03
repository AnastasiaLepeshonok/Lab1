using BusinessLogic;
using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DecanatPRO.WinForms
{
    public partial class Form1 : Form
    {
        private readonly Logic logic;

        private readonly BindingSource studentsBindingSource = new BindingSource();

        public Form1(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;      

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
                if (dgvStudents.Columns["Id"] != null)
                    dgvStudents.Columns["Id"].Visible = false;

            }
        }
        private void RefreshGrid()
        {
            studentsBindingSource.DataSource = logic.GetAllStudents();
            studentsBindingSource.ResetBindings(false);

            if (dgvStudents.Columns["Number"] == null)
            {
                dgvStudents.Columns.Insert(0, new DataGridViewTextBoxColumn
                {
                    Name = "Number",
                    HeaderText = "№",
                    ReadOnly = true
                });
            }

            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                dgvStudents.Rows[i].Cells["Number"].Value = i + 1;
            }
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

            if (dgvStudents.CurrentRow.DataBoundItem is not Student student)
            {
                MessageBox.Show("Не удалось определить студента.");
                return;
            }

            var result = MessageBox.Show(
                $"Удалить студента {student.Name}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                logic.DeleteStudent(student);
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