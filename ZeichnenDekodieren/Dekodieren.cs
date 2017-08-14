using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeichnenDekodieren
{
    public class Dekodieren
    {
       private List<int> returnNummer;

        public Dekodieren()
        {
            this.returnNummer=new List<int>();
        }
        public List<int> ReturnNummer(List<string> zeichnenInDat)
        {
           // List<int> returnNummer = new List<int>();

            foreach (string item in zeichnenInDat)
            {
                switch(item)
                {
                    case "/":
                        returnNummer.Add(3);
                        break;

                    case "|":
                        returnNummer.Add(1);
                        break;

                    case "|___|":
                        returnNummer.Add(4);
                        break;

                    case "|___":
                        returnNummer.Add(5);
                        break;

                    case "_|":
                        returnNummer.Add(2);
                        break;

                    default:
                        break;
                }
            }

            return returnNummer;
        }
    }
}
