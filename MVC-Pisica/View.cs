using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pisica
{
    public class View
    {
        private PisicaService _pisicaService;

        public View()
        {
            _pisicaService = new PisicaService();
        }
        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate pisicile");
            Console.WriteLine("Apsasati tasta 2 ca sa adaugati o pisica in lista"); 
            Console.WriteLine("Apasati tasta 3 si introduceti o pisica pe care o doriti");
            Console.WriteLine("Apasati tasta 4 pentru a sterge o pisica din lista");
            Console.WriteLine("Apasati tasta 5 pentru a edita varsta pisicii");
            Console.WriteLine("Apasati tasta 6 pentru a edita inaltimea pisicii");
            Console.WriteLine("apasati tasta 7 pentru a afisa toate pisicile de o anumita varsta");
            Console.WriteLine("Apasatit asta 8 pentru e afisa toate pisicile de o anumita inaltie");
            Console.WriteLine("Apasati tasta 9 pentru a afisa toate pisicile de o anumita rasa");
        }

        public void Play()
        {
            bool running = true;

            _pisicaService.LoadData();
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        _pisicaService.AfisarePisica();
                        break;

                    case "2":
                        AdaugareaUneiPisici();
                        break;

                    case "3":
                        AdoptareaUneiPisici();
                        break;

                    case "4":
                        StergereaUneiPisici();
                        break;

                    case "5":
                        EditVarstaAnimal();
                        break;

                    case "6":
                        EditInaltimePisica();
                        break;
                }
            }
        }

        public void AdaugareaUneiPisici()
        {
            Console.WriteLine("Inaltimea pisicii");
            int inaltimeNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tipul de pisica");
            string animalNou = Console.ReadLine();            

            Console.WriteLine("Varsta");
            int varstaNou = Int32.Parse(Console.ReadLine());

            Pisica pisica6 = new Pisica();
            pisica6.inaltimeCm = inaltimeNou;
            pisica6.rasaPisica = animalNou;
            pisica6.varstaAni = varstaNou;

            Console.WriteLine("Animalul a fost adaugat cu succes");
        }

        public void AdoptareaUneiPisici()
        {
            Console.WriteLine("Introduceti pisica dorit din lista de mai jos in text");
            string animalDorit = Console.ReadLine();

            _pisicaService.AdoptareaUneiPisici(animalDorit);

        }

        public void StergereaUneiPisici()
        {
            Console.WriteLine("Din lista de mai jos ce pisica dorita sa stergeti");
            _pisicaService.AfisarePisica();
            string PisicaDorite = Console.ReadLine();

            if (_pisicaService.FindPisicaByRasa(PisicaDorite) != -1)
            {
                _pisicaService.RemovePisicaByRasa(PisicaDorite);
                Console.WriteLine("Pisica a fost sters!");
            }
            else
            {
                Console.WriteLine("Pisica nu exista");

            }
        }

        public void EditVarstaAnimal()
        {
            Console.WriteLine("Ce pisica doriti sa modificati");
            string wantedAnimal = Console.ReadLine();

            Console.WriteLine("Cu ce varsta doriti sa modificati la pisica");
            int newVarsta = Int32.Parse(Console.ReadLine());

            if (_pisicaService.EditAnimalVarsta(wantedAnimal, newVarsta))
            {
                Console.WriteLine("Modificarea a reusit");
            }
            else
            {
                Console.WriteLine("Modificarea nu a reusit");
            }
        }

        public void EditInaltimePisica()
        {
            Console.WriteLine("Ce pisica doriti sa editati");
            string wantedAnimal = Console.ReadLine();

            Console.WriteLine("Cu ce inaltime doriti sa modificati pisica");
            int pisicaNewHigh = Int32.Parse(Console.ReadLine());

            if (_pisicaService.EditAnimalHigh(pisicaNewHigh, wantedAnimal))
            {
                Console.WriteLine("Pisica a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Pisica nu a putut fi editat");
            }
        }
    }
}
