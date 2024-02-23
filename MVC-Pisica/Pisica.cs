using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pisica
{
    public class Pisica
    {
        public int varstaAni;
        public int inaltimeCm;
        public string rasaPisica;

        public string PisicaInfo()
        {
            string text = " ";
            text += "Varsta: " + varstaAni + "\n";
            text += "Inaltime: " + inaltimeCm + "\n";
            text += "Rasa: " + rasaPisica + "\n";
            return text;
        }
    }
}
