using selectionGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPI
{
    class SelectionFileWriterReader
    {

         public void writeSelection(Selection sel) {
            try
            {
                string[] lines = sel.ToStringArray();

                using (StreamWriter stream =File.AppendText("Selections.txt")) {

                    if (sel.GetType() == typeof(EquableSelection)) {
                        stream.WriteLine('1');
                        foreach (var line in lines)
                            stream.Write(line + " ");
                        stream.WriteLine();
                    }

                    if (sel.GetType() == typeof(ExponentialSelection)) {
                        stream.WriteLine('2');
                        foreach (var line in lines)
                            stream.Write(line + " ");
                        stream.WriteLine();
                    }

                    if (sel.GetType() == typeof(NormalSelection)) {
                        stream.WriteLine('3');
                        foreach (var line in lines)
                            stream.Write(line + " ");
                        stream.WriteLine();
                    }
                    stream.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
