using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EinlesenAusDatei;
using ZeichnenDekodieren;

namespace RZviracTestAufgabe
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> zeichnenInDatei = new List<string>();
            NummerEinlesen einlasenDatei = new NummerEinlesen();

            zeichnenInDatei =einlasenDatei.ReturnZeichnen();

            //foreach (string item in zeichnenInDatei)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            List<int> nummerInDatei = new List<int>();
            Dekodieren ausZeichnenNachNummer = new Dekodieren();
            nummerInDatei= ausZeichnenNachNummer.ReturnNummer(zeichnenInDatei);
            Console.WriteLine("**************************************\n");
            Console.WriteLine("Die Nummern in Datei sind:\n");
            Console.WriteLine("**************************************\n");
            foreach (int item in nummerInDatei)
            {
                Console.WriteLine("\t{0}", item);
            }
            Console.WriteLine("\n**************************************\n\n");
        }
    }
}
