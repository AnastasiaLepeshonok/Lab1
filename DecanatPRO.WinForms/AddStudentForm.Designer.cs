namespace DecanatPRO.WinForms
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtSpeciality = new TextBox();
            txtGroup = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Направление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(730, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Группа";
            // 
            // txtName
            // 
            txtName.Location = new Point(0, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(343, 23);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(100, 27);
            txtSpeciality.TabIndex = 6;
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(663, 23);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(125, 27);
            txtGroup.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(241, 146);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(442, 146);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtGroup);
            Controls.Add(txtSpeciality);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSpeciality;
        private TextBox txtGroup;
        private Button btnSave;
        private Button btnCancel;
    }
}