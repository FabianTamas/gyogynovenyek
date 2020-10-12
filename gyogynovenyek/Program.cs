using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyogynovenyek
{
    class Program
    {
        static List<Novenyek> noveny = new List<Novenyek>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                noveny.Add(new Novenyek(file.ReadLine()));
            }
            file.Close();
        }

        static void f1()
        {
            Console.Write("1. feladat: Növények száma: ");
            Console.WriteLine(noveny.Count);
        }

        static void f2()
        {
            Console.WriteLine("2. feladat: Gyűjthető részek: ");
            foreach (var n in noveny)
            {
                if (!reszek.ContainsKey(n.Resz))
                {
                    reszek.Add(n.Resz, 0);
                }
            }

            foreach (var n in noveny)
            {
                reszek[n.Resz]++;
            }

            foreach (var r in reszek)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }
        }

        static void f3()
        {
            Console.Write("3. feladat: A legtöbb idő amíg gyüjthető: ");
            int max = 0;
            foreach (var n in noveny)
            {
                if (n.Idotartam > max)
                {
                    max = n.Idotartam;
                }
            }

            foreach (var n in noveny)
            {
                if (max == n.Idotartam)
                {
                    Console.WriteLine("\nA legtöbb idő amíg gyüjthető: {0}, {1}",max,n.Nev);
                }
            }
        }

        static void f4()
        {
            double db = 0;
            int osszeg = 0;
            foreach (var n in noveny)
            {
                osszeg += n.Idotartam;
                db++;
            }
            Console.WriteLine("Átlagos gyűjthető időtartam: {0}", osszeg/db);
        }

        static void Main(string[] args)
        {
            Beolvas();
            f1();
            f2();
            f3();
            f4();

            Console.ReadKey();
        }
    }
}
