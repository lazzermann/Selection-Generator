using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionGenerator
{
    class NormalSelection : Selection
    {
        private double a { get; set; }
        private double sigma { get; set; }
        public NormalSelection() : base() { }

        public override void generateSelection()
        {
            Random randa = new Random();
            //double[] arr;
            double value = 1;

            int n = 1;

            

            Console.WriteLine("Input the cout of elements");
            n = Convert.ToInt32(Console.ReadLine());

            //arr = GetNormalPrimarySelection(n);

            Console.WriteLine("Input math waiting");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input standart deviation");
            sigma = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                value = Math.Cos(2 * Math.PI * randa.NextDouble())*Math.Sqrt(-2*Math.Log(randa.NextDouble()));
                selection.Add(Math.Round((a + sigma * value), 3)); //N(a,sigma^2)
            }

        }

    }
}
