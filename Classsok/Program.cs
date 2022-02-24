using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classsok
{
    class Program
    {

        class Tanulo
        {
            public string kod;
            public string nev;
            public string matcsop;
            public string angcsop;
            public string mnyelv;
            public string nem;
            public int egyuttlakok;
            public int testverszam;
        }

        static void Main(string[] args)
        {
            
            


            List<Tanulo> tanulok = new List<Tanulo>();

            string[] sorok = File.ReadAllLines("input.txt");

            for (int i = 0; i < sorok.Length; i++)
            {

                string[] sortomb = sorok[i].Split(';');

                Tanulo t = new Tanulo();

                t.kod = sortomb[0];
                t.nev = sortomb[1];
                t.matcsop = sortomb[2];
                t.angcsop = sortomb[3];
                t.mnyelv = sortomb[4];
                t.nem = sortomb[5];
                t.egyuttlakok = int.Parse(sortomb[6]);
                t.testverszam = int.Parse(sortomb[7]);

                tanulok.Add(t);
            }

            
            Console.WriteLine($"1: Ennyi diák van: {tanulok.Count}");

            Console.Write("2: Hány fiú tanul az osztályban? ");
            {


                int db = 0;

                for (int i = 0; i < tanulok.Count; i++)
                {
                    if (tanulok[i].nem == "F")
                    {
                        db++;
                    }
                }


                Console.Write(db);
                Console.WriteLine();
            }
        }
    }
}
