using EMPI;
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
            SelectionFileWriterReader reader = new SelectionFileWriterReader();
            Selection selec = new NormalSelection();
            selec.generateSelection();

            //selec.seriesCriterion();
            //selec.ascendingDescendingSeriesCriterion();

            reader.writeSelectionToFile(selec);
            //reader.readSelectionFromFile(selec);

            selec.showSelection();
            selec.studentCriterion();
            selec.showSelection();
            selec.showCount();
            selec.studentCriterion();
            selec.showCount();
            selec.showSelection();
        }
    }
}
