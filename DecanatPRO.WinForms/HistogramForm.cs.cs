using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;

namespace DecanatPRO.WinForms
{
    public partial class HistogramForm : Form
    {
        private readonly Logic logic;

        public HistogramForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            var distribution = logic.GetSpecialityDistribution();

            if (distribution.Count == 0)
            {
                e.Graphics.DrawString("Нет данных для отображения.",
                    Font, Brushes.Black, 10, 10);
                return;
            }

            int margin = 40;
            int chartWidth = pnlChart.Width - margin * 2;
            int chartHeight = pnlChart.Height - margin * 2;
            int barCount = distribution.Count;
            int barWidth = chartWidth / barCount;
            int maxValue = 0;

            foreach (var pair in distribution)
                if (pair.Value > maxValue) maxValue = pair.Value;

            int i = 0;
            foreach (var pair in distribution)
            {
                int barHeight = (int)((double)pair.Value / maxValue * chartHeight);
                int x = margin + i * barWidth;
                int y = pnlChart.Height - margin - barHeight;

                e.Graphics.FillRectangle(Brushes.SteelBlue, x + 5, y, barWidth - 10, barHeight);
                e.Graphics.DrawString(pair.Value.ToString(), Font, Brushes.Black, x + barWidth / 2 - 5, y - 20);
                e.Graphics.DrawString(pair.Key, Font, Brushes.Black, x, pnlChart.Height - margin + 5);

                i++;
            }

            e.Graphics.DrawLine(Pens.Black, margin, margin, margin, pnlChart.Height - margin);
            e.Graphics.DrawLine(Pens.Black, margin, pnlChart.Height - margin, pnlChart.Width - margin, pnlChart.Height - margin);
        }
    }
}