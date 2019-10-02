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

        private const int firstLimitationOfAscendingDescendingCriterionFormula = 5;
        private const int secondLimitationOfAscendingDescendingCriterionFormula = 6;
        private const int thirdLimitationOfAscendingDescendingCriterionFormula = 7;

        public Selection() { selection = new List<double>(); }

        public abstract void generateSelection();

        public void showSelection(List<double> selec) {
            foreach (double val in selec) { Console.Write(val + " "); }
            Console.WriteLine();
        }

        public bool seriesCriterion() {
            String result = "";
            List<double> buffer = new List<double>();
            double mediana = 0;

            foreach (double item in selection) { buffer.Add(item); }
            buffer.Sort();

            if (buffer.Count % 2 == 0) {
                mediana = (buffer.ElementAt((buffer.Count / 2) - 1) + buffer.ElementAt(buffer.Count / 2)) / 2;
            }

           else { mediana = buffer.ElementAt((buffer.Count - 1) / 2); }

            for(int i = 0; i < selection.Count; i++) {
                if (mediana > selection.ElementAt(i))
                    result += "-";

                if (mediana < selection.ElementAt(i))
                    result += "+";             
            }

            Console.WriteLine("Mediana - " + mediana);

            Console.WriteLine();
            Console.WriteLine("Sorted selection");
            showSelection(buffer);

            Console.WriteLine();
            Console.WriteLine("Original selection");
            showSelection(selection);

            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Series quantity : " + getSeriesCount(result.ToCharArray()));
            Console.WriteLine("Max series lenth : " + getMaxSeriesLenth(result.ToCharArray()));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("V(n) > 1/2 * (n + 1 - 1,96 * √(n -1)) : ");
            Console.ResetColor();
            Console.WriteLine(getSeriesCount(result.ToCharArray()) + " > " + Math.Round((selection.Count + 1 - (1.96 * Math.Sqrt(selection.Count - 1))) / 2));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("T(n) < ln(n+1) : ");
            Console.ResetColor();
            Console.WriteLine(getMaxSeriesLenth(result.ToCharArray()) + " < " + Math.Round(Math.Log(selection.Count + 1)));

            if (getSeriesCount(result.ToCharArray()) > Math.Round((selection.Count + 1 - (1.96 * Math.Sqrt(selection.Count - 1))) / 2))
            {
                if (getMaxSeriesLenth(result.ToCharArray()) < Math.Round(Math.Log(selection.Count + 1)))
                    return true;
            }

            return false;
        }


        public bool ascendingDescendingSeriesCriterion() {
            String result = "";

            for (int i = 1; i < selection.Count; i++) {
                if (selection.ElementAt(i - 1) < selection.ElementAt(i))
                    result += "+"; //x(i + 1) > x(i)

                if (selection.ElementAt(i - 1) > selection.ElementAt(i))
                    result += "-"; //x(i + 1) < x(i) 
            }

            Console.WriteLine(result);

            Console.Write("Series quantity : ");
            Console.WriteLine(getSeriesCount(result.ToCharArray()));

            Console.Write("Max series lenth : ");
            Console.WriteLine(getMaxSeriesLenth(result.ToCharArray()));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("V(n) > 1/3 * (2n + 1) - 1,96 * √((16n -20)/90) : ");
            Console.ResetColor();

            Console.WriteLine(getSeriesCount(result.ToCharArray())+ ">"+ Math.Round( (((2 * selection.Count + 1) / 3) - (1.96 * Math.Sqrt((16 * selection.Count - 20) / 90)))) );

            if(getSeriesCount(result.ToCharArray()) > Math.Round( ((2*selection.Count + 1)/3) - (1.96 * Math.Sqrt((16*selection.Count - 20)/90) ))) {  //V(n) > 1/3 * (2n + 1) - 1,96 * √(16*n-20)/90 

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("T(n) <= {5 (n <= 26), 6 (n > 26, n <= 153), 7 (n > 153)} : ");
                Console.ResetColor();

                if (selection.Count <= 26) {
                    Console.WriteLine(getMaxSeriesLenth(result.ToCharArray()) + "<=" + firstLimitationOfAscendingDescendingCriterionFormula);
                    if (getMaxSeriesLenth(result.ToCharArray()) <= firstLimitationOfAscendingDescendingCriterionFormula)
                        return true;
                }
                
                if (selection.Count > 26 && selection.Count <= 153) {
                    Console.WriteLine(getMaxSeriesLenth(result.ToCharArray()) + "<=" + secondLimitationOfAscendingDescendingCriterionFormula);
                    if (getMaxSeriesLenth(result.ToCharArray()) <= secondLimitationOfAscendingDescendingCriterionFormula)
                        return true;
                }

                if (selection.Count > 153) {
                    Console.WriteLine(getMaxSeriesLenth(result.ToCharArray()) + "<=" + thirdLimitationOfAscendingDescendingCriterionFormula);
                    if (getMaxSeriesLenth(result.ToCharArray()) <= thirdLimitationOfAscendingDescendingCriterionFormula)
                        return true;
                }

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
                    if (cnt > max) { max = cnt;}
                    cnt = 1;
                }
                else { cnt++; }
            }
            return max;
        }
    }
}
