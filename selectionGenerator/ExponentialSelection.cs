using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionGenerator
{
   public class ExponentialSelection : Selection
    {
        private int damping { get; set; }

        public ExponentialSelection() : base() { }
        
        public override void generateSelection()
        {
            Random nue = new Random();

            int n = 1;
            double value = 0;
            double[] primeSelection;

            Console.WriteLine("Input the count of numbers in selection");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the dumping value");
            damping = Convert.ToInt32(Console.ReadLine());

            primeSelection = GeneratePrimarySelection(n);

            for (int i = 0; i < n; i++) {
                value = -1 * (Math.Log(1 - primeSelection[i]) / damping);
                selection.Add(Math.Round(value, 2));
            }
        }
    }
}
