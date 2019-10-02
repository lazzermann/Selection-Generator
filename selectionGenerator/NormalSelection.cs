using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionGenerator
{
    class NormalSelection : Selection
    {
        private int a { get; set; }
        private int sigma { get; set; }
        public NormalSelection() : base() { }

        public override void generateSelection()
        {
            Random randa = new Random();
            double doubleSum = 0;

            int n = 1;

            Console.WriteLine("Input the cout of elements");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input left limit of interval");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input right limit of interval");
            sigma = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                doubleSum = 0;
                for (int j = 0; j <= 12; j++) {
                    doubleSum += randa.NextDouble();
                }
                selection.Add(Math.Round((a + Math.Pow(sigma, 2) * (doubleSum - 6)), 3)); //N(a,sigma^2)
            }

        }
    }
}
