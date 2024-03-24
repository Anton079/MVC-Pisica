using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pisica
{
    public class Pisica
    {
        public int _varstaAni;
        public int _inaltimeCm;
        public string _rasaPisica;

        public int varstaAni
        {
            get { return _varstaAni; }
            set { _varstaAni = value; }
        }

        public int inaltimeCm
        {
            get { return _inaltimeCm; }
            set { _inaltimeCm = value; }
        }

        public string rasaPisica
        {
            get { return _rasaPisica; }
            set { _rasaPisica = value; }
        }

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
