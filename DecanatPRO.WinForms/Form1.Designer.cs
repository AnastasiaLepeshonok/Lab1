namespace DecanatPRO.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            pnlButtons = new Panel();
            btnHistogram = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(0, 45);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(800, 405);
            dgvStudents.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnHistogram);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(800, 45);
            pnlButtons.TabIndex = 4;
            // 
            // btnHistogram
            // 
            btnHistogram.Location = new Point(671, 8);
            btnHistogram.Name = "btnHistogram";
            btnHistogram.Size = new Size(117, 29);
            btnHistogram.TabIndex = 3;
            btnHistogram.Text = "Гистограмма";
            btnHistogram.UseVisualStyleBackColor = true;
            btnHistogram.Click += btnHistogram_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(339, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(pnlButtons);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dgvStudents;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnHistogram;
        private Panel pnlButtons;
    }
}