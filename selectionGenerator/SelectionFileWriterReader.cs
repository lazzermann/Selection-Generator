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

         public void writeSelectionToFile(Selection sel) {
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
        public void readSelectionFromFile(Selection sel)
        {
            string line;
            string[] array = new string[10000];
            bool isRight = false;

            try {
                using (StreamReader reader = new StreamReader("Selections.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {

                        if (line.Length == 1) {

                            if (sel.GetType() == typeof(EquableSelection) && line == "1")
                            {
                                line = reader.ReadLine();
                                array = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                                isRight = true;

                                break;
                            }

                            if (sel.GetType() == typeof(ExponentialSelection) && line == "2")
                            {
                                line = reader.ReadLine();
                                array = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                                isRight = true;

                                break;
                            }
                            if (sel.GetType() == typeof(NormalSelection) && line == "3")
                            {
                                line = reader.ReadLine();
                                array = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                                isRight = true;

                                break;
                            }
                        }
                    }

                    if (isRight)
                    {
                        sel.AddFromStringArray(array);
                        return;
                    }

                    Console.WriteLine("This type of selection in file dont exsits");
                    
                }
            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
