namespace DecanatPRO.WinForms
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            layout = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            lblSpeciality = new Label();
            txtSpeciality = new TextBox();
            lblGroup = new Label();
            txtGroup = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            layout.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            //
            // layout
            //
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowCount = 7;
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.Dock = DockStyle.Fill;
            layout.Padding = new Padding(16);
            layout.Controls.Add(lblName, 0, 0);
            layout.Controls.Add(txtName, 0, 1);
            layout.Controls.Add(lblSpeciality, 0, 2);
            layout.Controls.Add(txtSpeciality, 0, 3);
            layout.Controls.Add(lblGroup, 0, 4);
            layout.Controls.Add(txtGroup, 0, 5);
            layout.Controls.Add(pnlButtons, 0, 6);
            layout.Name = "layout";
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Margin = new Padding(0, 0, 0, 4);
            lblName.Name = "lblName";
            lblName.Text = "ФИО";
            //
            // txtName
            //
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Margin = new Padding(0, 0, 0, 12);
            txtName.Name = "txtName";
            //
            // lblSpeciality
            //
            lblSpeciality.AutoSize = true;
            lblSpeciality.Margin = new Padding(0, 0, 0, 4);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Text = "Направление";
            //
            // txtSpeciality
            //
            txtSpeciality.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSpeciality.Margin = new Padding(0, 0, 0, 12);
            txtSpeciality.Name = "txtSpeciality";
            //
            // lblGroup
            //
            lblGroup.AutoSize = true;
            lblGroup.Margin = new Padding(0, 0, 0, 4);
            lblGroup.Name = "lblGroup";
            lblGroup.Text = "Группа";
            //
            // txtGroup
            //
            txtGroup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGroup.Margin = new Padding(0, 0, 0, 16);
            txtGroup.Name = "txtGroup";
            //
            // pnlButtons
            //
            pnlButtons.AutoSize = true;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Name = "pnlButtons";
            //
            // btnSave
            //
            btnSave.AutoSize = true;
            btnSave.Margin = new Padding(8, 0, 0, 0);
            btnSave.MinimumSize = new Size(100, 32);
            btnSave.Name = "btnSave";
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            //
            // btnCancel
            //
            btnCancel.AutoSize = true;
            btnCancel.MinimumSize = new Size(100, 32);
            btnCancel.Name = "btnCancel";
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            //
            // AddStudentForm
            //
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 260);
            Controls.Add(layout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление студента";
            layout.ResumeLayout(false);
            layout.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layout;
        private Label lblName;
        private TextBox txtName;
        private Label lblSpeciality;
        private TextBox txtSpeciality;
        private Label lblGroup;
        private TextBox txtGroup;
        private FlowLayoutPanel pnlButtons;
        private Button btnSave;
        private Button btnCancel;
    }
}