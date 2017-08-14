using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace EinlesenAusDatei
{
    public class NummerEinlesen
    {
        private string path;

        public NummerEinlesen()
        {
            this.path = @"..\..\..\NumberParserExtended.txt";

        }
        NummerEinlesen(string Path)
        {
            this.path = Path;
        }

        //Class read text file and return a list of strings in Main Program
        public List<string> ReturnZeichnen()
        {
            int counter = 1; // Zähler von der Reihe
            string line;
            Regex erst = new Regex(@"\s+");

            try
            {
                List<string> zeichnenAusDatei = new List<string>();

                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(path))
                {
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                     if(!(string.IsNullOrWhiteSpace(line)||(line=="")))
                       {
                       // Es ist ausreichend nur zweite Reihe vom Nummer einlesen, weil zweite Reihe spezifisch
                       // für Nummern ab 1 bis 5 ist.
                       // Für Rest von Nummer, es ist ausreichend noch letzte Reihe prüfen und dann in ein List 
                       // zu verbinden
                            if((counter%4)==2)
                            {
                                string[] str2 = Regex.Split(line, erst.ToString());
                                zeichnenAusDatei.AddRange(str2);
                            }
                            counter++;
                        }  
                        
                    }
                }

                foreach (string item in zeichnenAusDatei.ToArray())
                {
                    if(item =="")
                    {
                        zeichnenAusDatei.Remove(item);
                    }
                }
                return zeichnenAusDatei;
            }

            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private bool IsMatch(Regex erst, string line)
        {
            // throw new NotImplementedException();
            return true;
        }
    }
}
