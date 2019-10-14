using selectionGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPI
{
   public class SelectionFileWriterReader
    {

         public void writeSelectionToFile(Selection sel) {
            try
            {
                string[] lines = sel.ToStringArray();

                using (StreamWriter stream =File.AppendText("Selections.txt")) {

                    if (sel.GetType() == typeof(EquableSelection)) {
                        stream.WriteLine("EquableSelection");
                        foreach (var line in lines)
                            stream.WriteLine(line);
                        stream.WriteLine("end");
                    }

                    if (sel.GetType() == typeof(ExponentialSelection)) {
                        stream.WriteLine("ExponentialSelection");
                        foreach (var line in lines)
                            stream.WriteLine(line);
                        stream.WriteLine("end");
                    }

                    if (sel.GetType() == typeof(NormalSelection)) {
                        stream.WriteLine("NormalSelection");
                        foreach (var line in lines)
                            stream.WriteLine(line);
                        stream.WriteLine("end");
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
            int cnt = 0;

            try {
                using (StreamReader reader = new StreamReader("Selections.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                            if (sel.GetType() == typeof(EquableSelection) && line == "EquableSelection")
                            {

                                line = reader.ReadLine();
                                while (line != "end")
                                {
                                    array[cnt] = line;
                                    cnt++;
                                line = reader.ReadLine();
                                }

                            array = array.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                            isRight = true;

                            break;
                            }

                            if (sel.GetType() == typeof(ExponentialSelection) && line == "ExponentialSelection")
                            {
                                line = reader.ReadLine();
                                while (line != "end") {
                                
                                array[cnt] = line;
                                cnt++;
                                line = reader.ReadLine();
                               }

                            array = array.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                            isRight = true;

                            break;
                            }

                            if (sel.GetType() == typeof(NormalSelection) && line == "NormalSelection")
                            {
                               
                            line = reader.ReadLine();
                            while (line != "end")
                            {
                                array[cnt] = line;
                                cnt++;
                                line = reader.ReadLine();
                            }

                            array = array.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                            isRight = true;

                            break;
                            }
                    }

                    if (isRight)
                    {
                        sel.AddFromStringArray(array);
                        reader.Close();
                        return;
                    }

                    Console.WriteLine("This type of selection in file dont exsits");
                    reader.Close();
                }
            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
