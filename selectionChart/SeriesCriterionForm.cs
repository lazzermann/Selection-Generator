using selectionGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selectionChart
{
    public partial class SeriesCriterionForm : Form
    {
        public SeriesCriterionForm(Selection select)
        {
            InitializeComponent();
            seriesCriterion(select);
        }

        public void seriesCriterion(Selection select)
        {
            String result = "";
            List<double> buffer = new List<double>();
            double mediana = 0;

            foreach (double item in select.selection) { buffer.Add(item); }
            buffer.Sort();

            if (buffer.Count % 2 == 0)
            {
                mediana = (buffer.ElementAt((buffer.Count / 2) - 1) + buffer.ElementAt(buffer.Count / 2)) / 2;
            }

            else { mediana = buffer.ElementAt((buffer.Count - 1) / 2); }

            for (int i = 0; i < select.selection.Count; i++)
            {
                if (mediana > select.selection.ElementAt(i))
                    result += "-";

                if (mediana < select.selection.ElementAt(i))
                    result += "+";
            }

            string[] arr = new string[select.selection.Count];
            arr = select.ToStringArray();

            medianaTextBox.Text = mediana.ToString();
            for(int i = 0; i < arr.Length; i++)
            {
                originTextBox.Text += arr[i] + " ";
            }

            foreach(double var in buffer)
            {
                sortTextBox.Text += var.ToString()+" ";
            }

            maxLenthTextBox.Text = select.getMaxSeriesLenth(result.ToCharArray()).ToString();
            seriesTextBox.Text = select.getSeriesCount(result.ToCharArray()).ToString();
            resultTextBox.Text = result.ToString();

            int res1 = select.getSeriesCount(result.ToCharArray());
            double res2 = Math.Round((select.selection.Count + 1 - (1.96 * Math.Sqrt(select.selection.Count - 1))) / 2);
            label8.Text = res1+ " > " + res2;

            res1 = select.getMaxSeriesLenth(result.ToCharArray());
            res2 = Math.Round(3.33 * Math.Log(select.selection.Count + 1));
            label10.Text = res1 + " < " + res2;
        }
    }
}
