using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionGenerator
{
    abstract class Selection
    {
        protected List<double> selection;

        public Selection() { selection = new List<double>(); }

        public abstract void generateSelection();

        public void showSelection(List<double> selec) {
            foreach (double val in selec) { Console.Write(val + " "); }
            Console.WriteLine();
        }

        public bool seriesCriterion() {
            String result = "";
            List<double> buffer = new List<double>();
            double buf = 0;

            foreach (double item in selection) { buffer.Add(item); }
            buffer.Sort();

            if (buffer.Count % 2 == 0) {
                buf = (buffer.ElementAt((buffer.Count / 2) - 1) + buffer.ElementAt(buffer.Count / 2)) / 2;
            }
           else { buf = buffer.ElementAt((buffer.Count - 1) / 2); }

            for(int i = 0; i < selection.Count; i++) {
                if (buf > selection.ElementAt(i))
                    result += "-";

                if (buf < selection.ElementAt(i))
                    result += "+";             
            }

            Console.WriteLine("Mediana - " + buf);

            Console.WriteLine();
            Console.WriteLine("Sorted selection");
            showSelection(buffer);

            Console.WriteLine();
            Console.WriteLine("Original selection");
            showSelection(selection);

            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine(getSeriesCount(result.ToCharArray()) + " > " + Math.Round((selection.Count + 1 - (1.96 * Math.Sqrt(selection.Count - 1))) / 2));
            Console.WriteLine(getMaxSeriesLenth(result.ToCharArray()) + " < " + Math.Round(3.33 * Math.Log(selection.Count + 1)));

            if (getSeriesCount(result.ToCharArray()) > Math.Round((selection.Count + 1 - (1.96 * Math.Sqrt(selection.Count - 1))) / 2))
            {
                if (getMaxSeriesLenth(result.ToCharArray()) < Math.Round(3.33*Math.Log(selection.Count + 1)))
                    return true;
            }

            return false;
        }

        private int getSeriesCount(char[] res) {
            char buf = res[0];
            int cnt = 1;
            for (int i = 0; i < res.Length; i++) {
                if(buf != res[i]) { cnt++; buf = res[i]; }
            }
            return cnt;
        }

        private int getMaxSeriesLenth(char[] res) {
            int max = 0, cnt = 0;
            char buf = res[0];
            for(int i = 0; i < res.Length; i++) {
                if (buf != res[i])
                {
                    buf = res[i];
                    if (cnt > max) { max = cnt; cnt = 1; }
                }
                else { cnt++; }
            }
            return max;
        }
    }
}
