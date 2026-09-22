namespace DecanatPRO.WinForms
{
    partial class HistogramForm
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
            pnlChart = new Panel();
            SuspendLayout();
            // 
            // pnlChart
            // 
            pnlChart.Location = new Point(1, 1);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(800, 450);
            pnlChart.TabIndex = 0;
            pnlChart.Paint += pnlChart_Paint;
            // 
            // HistogramForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlChart);
            Name = "HistogramForm";
            Text = "HistogramForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChart;
    }
}