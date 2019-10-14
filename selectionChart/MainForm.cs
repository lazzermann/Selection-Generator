using System;
using System.Linq;
using System.Windows.Forms;
using EMPI;
using selectionGenerator;

namespace selectionChart
{
    public partial class MainForm : Form
    {
        public Selection select;
        public MainForm()
        {
            InitializeComponent();
        }

        private void selecGenButton_Click(object sender, EventArgs e)
        {
            if (normSelecRadio.Checked)
            {

                select = new NormalSelection();
                NormalFillForm form = new NormalFillForm();

                if (form.ShowDialog() == DialogResult.Cancel)
                {
                    FillNormalSelect(form);
                }

                ClearAllCharts();
                for (int i = 0; i < select.selection.Count; i++) {
                    selectionChart.Series["NormalSelection"].Points.AddXY(i+1, select.selection.ElementAt(i));
                }
                selectionChart.Series["NormalSelection"].Points.AddXY(-1, select.mathWaiting());
            }

        
            if (equableSelecRadio.Checked)
            {
                select = new EquableSelection();
                EquableFillForm form = new EquableFillForm();
                if(form.ShowDialog() == DialogResult.Cancel)
                {
                    FillEquableSelect(form);
                }
                ClearAllCharts();
                for (int i = 0; i < select.selection.Count; i++)
                {
                    selectionChart.Series["EquableSelection"].Points.AddXY(i + 1, select.selection.ElementAt(i));
                }
                selectionChart.Series["EquableSelection"].Points.AddXY(-1, select.mathWaiting());
            }

            if (exponentSelecRadio.Checked)
            {
                select = new ExponentialSelection();
                ExponentialFillForm form = new ExponentialFillForm();
                if(form.ShowDialog() == DialogResult.Cancel)
                {
                    FillExponentialSelect(form);
                }

                ClearAllCharts();
                for (int i = 0; i < select.selection.Count; i++)
                {
                    selectionChart.Series["ExponentalSelection"].Points.AddXY(i + 1, select.selection.ElementAt(i));
                }
                selectionChart.Series["ExponentalSelection"].Points.AddXY(-1, select.mathWaiting());
            }
        }

        void FillNormalSelect(NormalFillForm form) {
            if (form.isNumbs)
            {
                double value = 1;
                Random rand = new Random();

                for (int i = 0; i < Convert.ToInt32(form.textBox1.Text); i++)
                {
                    value = Math.Cos(2 * Math.PI * rand.NextDouble()) * Math.Sqrt(-2 * Math.Log(rand.NextDouble()));
                    select.selection.Add(Math.Round((Convert.ToDouble(form.textBox2.Text) + Convert.ToDouble(form.textBox3.Text) * value), 2));
                }

                ShowSelection();
            }
        }

        void FillEquableSelect(EquableFillForm form)
        {
            if (form.isNumbs)
            {
                double value = 1;
                Random rand = new Random();

                for (int i = 0; i < Convert.ToInt32(form.textBox1.Text); i++)
                {
                    value = Convert.ToInt32(form.textBox2.Text) + (Convert.ToInt32(form.textBox3.Text) - Convert.ToInt32(form.textBox2.Text)) * rand.NextDouble();
                    select.selection.Add(Math.Round (value, 2));
                }

                ShowSelection();
            }
        }
        void FillExponentialSelect(ExponentialFillForm form)
        {
            if (form.isNumbs)
            {
                double value = 1;
                Random rand = new Random();

                for (int i = 0; i < Convert.ToInt32(form.textBox1.Text); i++)
                {
                    value = -1 * (Math.Log(rand.NextDouble()) / Convert.ToInt32(form.textBox2.Text));
                    select.selection.Add(Math.Round(value, 2));
                }
                ShowSelection();
            }
        }
        void ShowSelection()
        {
            elemBox.Text = "";

            string[] arr = new string[select.selection.Count];
            arr = select.ToStringArray();
            for (int i = 0; i < arr.Length; i++)
            {
                elemBox.Text += arr[i] + " ";
            }

            maxElemBox.Text = select.selection.Max().ToString();
            minElemBox.Text = select.selection.Min().ToString();
            selectCountBox.Text = select.selection.Count.ToString();
            matWaitingText.Text = select.mathWaiting().ToString();
            dispersionText.Text = select.dispersion().ToString();
            standartDeviationText.Text = select.sqrtDispesion().ToString();
        }
        void ClearAllCharts() {
            selectionChart.Series["ExponentalSelection"].Points.Clear();
            selectionChart.Series["EquableSelection"].Points.Clear();
            selectionChart.Series["NormalSelection"].Points.Clear();
        }
        private void findExsistButton_Click(object sender, EventArgs e)
        {
            SelectionFileWriterReader reader = new SelectionFileWriterReader();
            if (normSelecRadio.Checked)
            {
                select = new NormalSelection();
            }
            if (equableSelecRadio.Checked)
            {
                select = new EquableSelection();
            }
            if (exponentSelecRadio.Checked)
            {
                select = new ExponentialSelection();     
            }

            reader.readSelectionFromFile(select);
            if(select.selection.Count == 0)
            {
                MessageBox.Show("File does no contain this type of selection", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {

                if(select.GetType() == typeof(NormalSelection))
                {
                    ClearAllCharts();
                    for (int i = 0; i < select.selection.Count; i++)
                    {
                        selectionChart.Series["NormalSelection"].Points.AddXY(i + 1, select.selection.ElementAt(i));
                    }
                    selectionChart.Series["NormalSelection"].Points.AddXY(-1, select.mathWaiting());
                }

                if(select.GetType() == typeof(EquableSelection))
                {
                    ClearAllCharts();
                    for (int i = 0; i < select.selection.Count; i++)
                    {
                        selectionChart.Series["EquableSelection"].Points.AddXY(i + 1, select.selection.ElementAt(i));
                    }
                    selectionChart.Series["EquableSelection"].Points.AddXY(-1, select.mathWaiting());
                }

                if(select.GetType() == typeof(ExponentialSelection))
                {
                    ClearAllCharts();
                    for (int i = 0; i < select.selection.Count; i++)
                    {
                        selectionChart.Series["ExponentalSelection"].Points.AddXY(i + 1, select.selection.ElementAt(i));
                    }
                    selectionChart.Series["ExponentalSelection"].Points.AddXY(-1, select.mathWaiting());
                }
            }
            
            ShowSelection();
        }
        void FindMinMaxInChart()
        {
            if(select.GetType() == typeof(NormalSelection)) {
                selectionChart.ChartAreas.Min();
            }
        }
        void UpdateChart()
        {
            ClearAllCharts();
            ShowSelection();

            for (int i = 0; i < select.selection.Count; i++)
            {
                selectionChart.Series["NormalSelection"].Points.AddXY(i + 1, select.selection.ElementAt(i));
            }
            selectionChart.Series["NormalSelection"].Points.AddXY(-1, select.mathWaiting());
        }

        private void writeSelectionButton_Click(object sender, EventArgs e)
        {
            SelectionFileWriterReader reader = new SelectionFileWriterReader();
            reader.writeSelectionToFile(select);

            MessageBox.Show("Selection succesfull writen into file","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void seriesCriterionButton_Click(object sender, EventArgs e)
        {
            SeriesCriterionForm ser = new SeriesCriterionForm(select);
            ser.ShowDialog();
        }

        private void StudentCriterionButton_Click(object sender, EventArgs e)
        {
            double value = select.selection.Max() - select.mathWaiting() / select.sqrtDispesion();
            
            StudentCriterionMin.Text = value.ToString();
            value = select.mathWaiting() - select.selection.Min() / select.sqrtDispesion();
            StudentCriterionMax.Text = value.ToString();

            select.studentCriterion();
            UpdateChart();
        }
    }
}
