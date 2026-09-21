using System;
using System.Windows.Forms;
using BusinessLogic;

namespace DecanatPRO.WinForms
{
    public partial class AddStudentForm : Form
    {
        private readonly Logic logic;

        public AddStudentForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSpeciality.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            logic.AddStudent(txtName.Text.Trim(), txtSpeciality.Text.Trim(), txtGroup.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}