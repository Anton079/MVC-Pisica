using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pisica
{
    public class PisicaService
    {
        public List <Pisica> PisicaList = new List <Pisica> ();

        public void LoadData()
        {
            Pisica pisica1 = new Pisica();
            pisica1.varstaAni = 5;
            pisica1.inaltimeCm = 30;
            pisica1.rasaPisica = "Sfinx";

            Pisica pisica2 = new Pisica();
            pisica2.varstaAni = 3;
            pisica2.inaltimeCm = 25;
            pisica2.rasaPisica = "Persana";

            Pisica pisica3 = new Pisica();
            pisica3.varstaAni = 7;
            pisica3.inaltimeCm = 20;
            pisica3.rasaPisica = "Maine Coon";

            Pisica pisica4 = new Pisica();
            pisica4.varstaAni = 2;
            pisica4.inaltimeCm = 22;
            pisica4.rasaPisica = "Siameza";

            Pisica pisica5 = new Pisica();
            pisica5.varstaAni = 4;
            pisica5.inaltimeCm = 18;
            pisica5.rasaPisica = "Birmaneza";

            this.PisicaList.Add(pisica5);
            this.PisicaList.Add(pisica4);
            this.PisicaList.Add(pisica3);
            this.PisicaList.Add(pisica2);
            this.PisicaList.Add(pisica1);
        }

        public void AfisarePisica()
        {
            foreach(Pisica x in PisicaList)
            {
                Console.Write(x.PisicaInfo());
            }
        }

        //functie ce afiseaza o lista cu toate pisicile intre 3 si 7 ani
        public List <Pisica> FilterCatsByAge()
        {

            int nr3 = 3;
            int nr7 = 7;
            List <Pisica> pisicasList = new List <Pisica>();

            foreach(Pisica x in PisicaList)
            {
                if(x.varstaAni >= nr3)
                {
                    if (x.varstaAni <= nr7)
                    {
                        pisicasList.Add(x);
                    }
                }
            }
            return pisicasList;
        } 

        //functie ce aduna varsta tuturor pisicilor inafara de pirma si ultima
        public Pisica TotalAge()
        {
            int suma = 0;
            for (int i = 1; i < PisicaList.Count - 1; i++)
            {
                suma += PisicaList[i].varstaAni;
            }
            return suma;
        }

        //CRUD
        public bool EditCatBreed(string nrPisica, string Breed)
        {
            foreach (Pisica x in PisicaList)
            {
                if (x.rasaPisica == nrPisica)
                {
                    x.rasaPisica = Breed;
                    return true;
                }
            }
            return false;
        }
       
    }
}
