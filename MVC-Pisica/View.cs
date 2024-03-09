using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pisica
{
    public class View
    {
        PisicaService pisicaService = new PisicaService();
        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate pisicile");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate pisicile de aceasi rasa");
            Console.WriteLine("Apasati tasta 3 si introduceti o pisica pe care o doriti");
        }

        public void Play()
        {
            bool running = true;

            pisicaService.LoadData();
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        pisicaService.AfisarePisica();
                        break;
                }
            }
        }
    }
}
