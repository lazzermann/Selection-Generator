using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Selection selec = new EquableSelection();
            selec.generateSelection();
            Console.WriteLine(selec.seriesCriterion());
        }
    }
}
