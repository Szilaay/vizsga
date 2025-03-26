using System;
using System.Collections.Generic;
using System.IO;
using filmekCLI;
using static System.Net.Mime.MediaTypeNames;

namespace filmekCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Filmek> lista = new List<Filmek>();

            FileStream fs = new FileStream("filmekCLI_adatok.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                lista.Add(new Filmek(sr.ReadLine()));
            }

            sr.Close();
            fs.Close();

            // 3. feladat
            Console.WriteLine($"3. feladat: A tárhelyen {lista.Count} db film van.");

            // 4. feladat
            Console.WriteLine("4. feladat: Gyártónkénti filmek száma:");

            Dictionary<string, int> gyartok = new Dictionary<string, int>();

            foreach (Filmek film in lista)
            {
                if (gyartok.ContainsKey(film.Forgalmazo))
                {
                    gyartok[film.Forgalmazo]++;
                }
                else
                {
                    gyartok.Add(film.Forgalmazo, 1);
                }
            }

            foreach (var gyarto in gyartok)
            {
                Console.WriteLine($"\t{gyarto.Key}: {gyarto.Value} db");
            }

            // 5. feladat
            Console.Write("5. feladat: Adjon meg egy műfajt nevét: ");
            string mufaj = Console.ReadLine();

            // 6. feladat
            FileStream keres = new FileStream("keresettmufaj.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(keres);

            bool van = false;

            foreach (Filmek film in lista)
            {
                if (film.Mufaj == mufaj)
                {
                    sw.WriteLine($"{film.Cim}\t{film.Hossz}");
                    van = true;
                }
            }

            if(!van)
            {
                sw.WriteLine($"Nincs a tárhelyen {mufaj} műfajú film!");
            }

            Console.WriteLine("6. feladat: A keresettmufaj.txt elkészült!");

            sw.Close();
            keres.Close();

            // 7. feladat -  Határozza meg, hogy melyik filmet mutatták be a legkorábban és annak adatait írassa a képernyőre! Keresd meg az év alapján a legelső filmet és annak az adatait ird ki a képernyőre!

            Filmek legkorabbi = lista[0];

            foreach (Filmek film in lista)
            {
                if (film.BemutatasEve < legkorabbi.BemutatasEve)
                {
                    legkorabbi = film;
                }
            }

            Console.WriteLine($"7. feladat: A legkorábban bemutatott film a tárhályen:");
            Console.WriteLine($"\tCím: {legkorabbi.Cim}");
            Console.WriteLine($"\tBemutatás éve: {legkorabbi.BemutatasEve}.");
            Console.WriteLine($"\tMűfaj: {legkorabbi.Mufaj}");
            Console.WriteLine($"\tGyártó/forgalmazó: {legkorabbi.Forgalmazo}");
            Console.WriteLine($"\tHossza: {legkorabbi.Hossz} perc");










            Console.ReadKey(true);
        }

    }
}