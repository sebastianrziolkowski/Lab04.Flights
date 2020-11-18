using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dane.Baza;
using Dane.Model;
using Dane.System;

namespace Terminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            SystemKontroliLotow systemKontroliLotow = new SystemKontroliLotow();
            Repozytorium repozytorium = new Repozytorium();
            Samolot samolot = repozytorium.WezSamolot();
            samolot.setMiastoCel(repozytorium.WezMiasto());

            systemKontroliLotow.SetSamolot(samolot);
            systemKontroliLotow.EkranObecnegoStanu();
            Console.ReadLine();
            */

            SystemKontroliLotow systemKontroliLotow = new SystemKontroliLotow();
            Repozytorium repo = new Repozytorium();
            Miasto miasto = repo.WezMiasto("Krakow");
            Miasto miasto2 = repo.WezMiasto("Seattle");
            Samolot samolot = repo.WezSamolot(miasto);
            samolot.SetMiastoCel(miasto2);

            systemKontroliLotow.SetSamolot(samolot);
            systemKontroliLotow.EkranObecnegoStanu();
            Console.ReadLine();
        }
    }
}
